using Ravand.Core.Application.Providers.ScrutorDI;
using Ravand.Core.Application.UseCases.Security.Roles.Repository;
using Ravand.Core.Application.UseCases.Security.Users.Repository;
using Ravand.Core.Domain.Entities.Security.Role;
using Ravand.Core.Domain.Entities.Security.User;
using Microsoft.AspNetCore.Identity;

namespace Ravand.EndPoint.WebApi.Providers.Identity.Interfaces;

public interface IIdentityFacade : IScopeLifeTime
{
    UserManager<UserEntity> UserManager { get; }
    SignInManager<UserEntity> SignInManager { get; }
    RoleManager<RoleEntity> RoleManager { get; }
    ITokenService TokenService { get; }
    IUserRepository UserRepository { get; }
    IRoleRepository RoleRepository { get; }

}
