using Ravand.Core.Application.UseCases.Security.Users.Handlers.Add;
using Ravand.Core.Application.UseCases.Security.Users.Handlers.ReadDataGrid;
using Ravand.Core.Application.UseCases.Security.Users.Handlers.Update;
using Ravand.Core.Domain.Entities.Security.User;
using Ravand.Core.Domain.Entities.Security.User.Parameters;

namespace Ravand.Core.Application.UseCases.Security.Users.MapProfile;

public class UserAggregateProfile : Profile
{
    public UserAggregateProfile()
    {
        CreateMap<UserEntity, ReadDataGridView>().ReverseMap();
        CreateMap<AddCommand, UserCreateParameter>().ReverseMap();
        CreateMap<UpdateCommand, UserUpdateParameter>().ReverseMap();
    }
}