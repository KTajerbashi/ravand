using FluentValidation;

namespace Ravand.Core.Application.UseCases.Aggregate
{
    public class UserModelValidator : AbstractValidator<AddAggregateCommand>
    {
        public UserModelValidator()
        {
            RuleFor(x => x.UserInfo).SetValidator(new UserInfoValidator());
            RuleFor(x => x.UserEducation).SetValidator(new UserEducationValidator());
        }
    }
}