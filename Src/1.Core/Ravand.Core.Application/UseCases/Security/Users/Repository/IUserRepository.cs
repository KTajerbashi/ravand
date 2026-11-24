using Ravand.Core.Application.Common;
using Ravand.Core.Domain.Entities.Security.User;

namespace Ravand.Core.Application.UseCases.Security.Users.Repository;

public interface IUserRepository : IBaseRepository<UserEntity, long>
{
}

