using Ravand.Core.Application.UseCases.Security.Users.Repository;
using Ravand.Core.Domain.Entities.Security.User;
using Ravand.Infra.Data.Common;
using Ravand.Infra.Data.DataContext;
using Microsoft.EntityFrameworkCore;

namespace Ravand.Infra.Data.Repositories;

public class UserRepository : BaseRepository<UserEntity, long>, IUserRepository
{
    public UserRepository(DatabaseContext context) : base(context)
    {
    }
    protected override IQueryable<UserEntity> IncludeGraph(IQueryable<UserEntity> query)
       => query
           .Include(x => x.UserRoles)
           .ThenInclude(x => x.Role);
}
