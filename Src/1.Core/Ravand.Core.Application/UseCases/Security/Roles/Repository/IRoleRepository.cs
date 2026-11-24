using Ravand.Core.Application.Common;
using Ravand.Core.Domain.Entities.Security.Role;

namespace Ravand.Core.Application.UseCases.Security.Roles.Repository;

public interface IRoleRepository : IBaseRepository<RoleEntity, long>
{
}

