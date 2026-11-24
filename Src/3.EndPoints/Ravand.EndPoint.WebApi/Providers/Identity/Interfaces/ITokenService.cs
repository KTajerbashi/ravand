using Ravand.Core.Application.Providers.ScrutorDI;
using Ravand.EndPoint.WebApi.Models;

namespace Ravand.EndPoint.WebApi.Providers.Identity.Interfaces;

public interface ITokenService : IScopeLifeTime
{
    Task<TokenResponse> GenerateTokenAsync(TokenRequest parameter, CancellationToken cancellation);
    Task<TokenResponse> GenerateRefreshTokenAsync(string token, string refreshToken, CancellationToken cancellation);
    Task<TokenResponse> ValidateTokenAsync(string token, CancellationToken cancellation);
}
