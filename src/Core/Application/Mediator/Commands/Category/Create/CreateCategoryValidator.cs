using FluentValidation;

namespace Application.Mediator.Commands.Category.Create
{
    public class CreateCategoryValidator : AbstractValidator<CreateCategoryCommand>
    {
        public CreateCategoryValidator()
        {
            RuleFor(e => e.Title)
           .NotEmpty().WithMessage("{PropertyName} boş olamaz")
           .NotNull().WithMessage("{PropertyName} boş olamaz")
           .MaximumLength(200).WithMessage("{PropertyName} maksimum {MaxLength} olabilir")
           .WithName("Başlık");
        }
    }
}