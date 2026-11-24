var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Ravand_EndPoint_WebApi>("Ravand-endpoint-webapi");

builder.AddProject<Projects.Ravand_EndPoint_WebApp>("Ravand-endpoint-webapp");

builder.Build().Run();
