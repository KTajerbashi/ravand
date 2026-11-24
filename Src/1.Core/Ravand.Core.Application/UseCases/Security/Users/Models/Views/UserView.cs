using Ravand.Core.Domain.Entities.Security.User;

namespace Ravand.Core.Application.UseCases.Security.Users.Models.Views;

public class UserView : BaseView<UserEntity>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string DisplayName { get; set; }

    public override void Mapping(Profile profile)
    {
    }
}
