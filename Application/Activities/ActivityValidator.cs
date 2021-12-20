using Domain;
using FluentValidation;

namespace Application.Activities
{
    public class ActivityValidator : AbstractValidator<Activity>
    {
        public ActivityValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Body).NotEmpty();
        }
    }
}