using Ravand.Core.Application.UseCases.Security.Roles.Repository;
using Ravand.Core.Domain.Entities.Security.Role;
using Ravand.Infra.Data.Common;
using Ravand.Infra.Data.DataContext;

namespace Ravand.Infra.Data.Repositories;

public class RoleRepository : BaseRepository<RoleEntity, long>, IRoleRepository
{
    public RoleRepository(DatabaseContext context) : base(context)
    {
    }
}
