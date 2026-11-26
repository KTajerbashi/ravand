using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Ravand.EndPoint.WebApi;
using Ravand.EndPoint.WebApi.Configurations.Identity;
using Ravand.EndPoint.WebApi.Configurations.Swagger;
using Ravand.EndPoint.WebApi.Extensions;
using Ravand.EndPoint.WebApi.Middlewares.ExceptionsHandling;
using Ravand.ServiceDefaults;

namespace Ravand.EndPoint.WebApp;

public static class DependencyInjections
{
    public static WebApplicationBuilder AddWebApp(this WebApplicationBuilder builder)
    {
        IConfiguration configuration = builder.Configuration;

        builder.AddServiceDefaults();

        builder.Services.AddHttpContextAccessor();
        builder.Services.AddControllers();

        builder.Services.AddRazorPages(options =>
        {
            options.Conventions.AddFolderRouteModelConvention("/", model =>
            {
                foreach (var selector in model.Selectors)
                {
                    var template = selector.AttributeRouteModel!.Template;

                    selector.AttributeRouteModel.Template =
                        AttributeRouteModel.CombineTemplates("app", template);
                }
            });
        });

        builder.Services.AddOpenApi();
        builder.Services.AddSwaggerApi();

        builder.Services.AddIdentityServices(configuration, IdentityType.SessionBase);
        builder.Services.AddWebApi(configuration);

        return builder;
    }

    public static async Task<WebApplication> UseWebApp(this WebApplication app)
    {
        // ---------- Infrastructure ----------
        app.MapDefaultEndpoints();
        app.UseExceptionsHandling();

        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
        }
        else
        {
            app.UseHsts();
        }

        app.UseHttpsRedirection();

        // ---------- Static files (wwwroot + Angular build) ----------
        app.MapStaticAssets();

        // ---------- Routing / Auth ----------
        app.UseRouting();

        // باید شامل UseAuthentication و UseSession (در صورت نیاز) باشد
        // و حتماً قبل از UseAuthorization اجرا شود
        app.UseIdentityServices(IdentityType.SessionBase);
        app.UseAuthorization();

        app.UseSwaggerApi();

        // ---------- Endpoints (اولویت بالا) ----------
        app.MapControllers();                     // API
        app.MapRazorPages().WithStaticAssets();   // Razor Pages (مثلاً /counter)

        // ---------- Angular fallback (کمترین اولویت) ----------
        // هر آدرسی که Razor یا Controller نشناخت → آنگولار (مثلاً /dashboard)
        app.MapFallback(async context =>
        {
            var path = context.Request.Path;

            // مسیرهای /api و /app که پیدا نشدند باید 404 واقعی بدهند
            if (path.StartsWithSegments("/api") ||
                path.StartsWithSegments("/app") ||
                Path.HasExtension(path.Value))
            {
                context.Response.StatusCode = StatusCodes.Status404NotFound;
                return;
            }

            context.Response.ContentType = "text/html; charset=utf-8";
            await context.Response.SendFileAsync(
                Path.Combine(app.Environment.WebRootPath, "index.html"));
        });

        if (app.Environment.IsDevelopment())
        {
            await app.InitialDatabaseWithSeedDataAsync();
        }

        app.MapGet("/debug/routes", (IEnumerable<EndpointDataSource> sources) =>
        string.Join("\n", sources.SelectMany(s => s.Endpoints).Select(e => e.DisplayName + " => " + (e as RouteEndpoint)?.RoutePattern.RawText)));

        return app;
    }
}