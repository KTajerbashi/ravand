using Ravand.Core.Domain.Entities.Security.User;

namespace Ravand.Core.Application.UseCases.Security.Users.Models.DTOs;

public class UserDTO : BaseDTO<UserEntity>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string DisplayName { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public bool IsOnline { get; set; }
    public override void Mapping(Profile profile)
    {
        profile.CreateMap<UserEntity, UserDTO>();
    }
    //public void Mapping(Profile profile)
    //{
    //    profile.CreateMap<CreateUserCommand, User>()
    //        .ConstructUsing(cmd => new User(cmd.Email));
    //}
}
