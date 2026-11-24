using Ravand.Core.Application.Providers.ScrutorDI;
using Ravand.Core.Domain.Entities.Security.Role;
using Ravand.Core.Domain.Entities.Security.User;
using Ravand.EndPoint.WebApi.Models;

namespace Ravand.EndPoint.WebApi.Providers.Identity.Interfaces;

public interface IIdentityService : IScopeLifeTime
{

    Task<IdentityResponse> LoginByUsernameAsync(string username, string password, CancellationToken cancellation);
    Task<IdentityResponse> LoginByEmailAsync(string email, string password, CancellationToken cancellation);
    Task<IdentityResponse> LoginAsync(UserEntity user, CancellationToken cancellation);
    Task<IdentityResponse> LoginAsSessionAsync(string username, string password, CancellationToken cancellation);

    Task<IdentityResponse> LogoutAsync(CancellationToken cancellation);


    Task<IdentityResponse> AddUserClaimsAsync(UserEntity user, CancellationToken cancellation);
    Task<IdentityResponse> RemoveUserClaimsAsync(UserEntity user, CancellationToken cancellation);

    Task<IdentityResponse> AddUserTokenAsync(UserEntity user, CancellationToken cancellation);
    Task<IdentityResponse> RemoveUserTokenAsync(UserEntity user, CancellationToken cancellation);

    Task<IdentityResponse> AddUserLoginAsync(UserEntity user, CancellationToken cancellation);
    Task<IdentityResponse> RemoveUserLoginAsync(UserEntity user, CancellationToken cancellation);

    Task<IdentityResponse> AddRoleClaimAsync(RoleEntity role, CancellationToken cancellation);
    Task<IdentityResponse> RemoveRoleClaimAsync(UserEntity user, CancellationToken cancellation);

    Task<IdentityResponse> AddRoleToUserAsync(UserEntity user, string roleName, CancellationToken cancellation);

}
