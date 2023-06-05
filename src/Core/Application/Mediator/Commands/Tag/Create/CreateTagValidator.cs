using FluentValidation;

namespace Application.Mediator.Commands.Tag.Create
{
    public class CreateTagValidator : AbstractValidator<CreateTagCommand>
    {
        public CreateTagValidator()
        {
            RuleFor(e => e.Title)
           .NotEmpty().WithMessage("{PropertyName} boş olamaz")
           .NotNull().WithMessage("{PropertyName} boş olamaz")
           .MaximumLength(200).WithMessage("{PropertyName} maksimum {MaxLength} olabilir")
           .WithName("Başlık");
        }
    }
}