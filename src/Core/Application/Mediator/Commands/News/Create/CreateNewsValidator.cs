using FluentValidation;

namespace Application.Mediator.Commands.News.Create
{
    public class CreateNewsValidator : AbstractValidator<CreateNewsCommand>
    {
        public CreateNewsValidator()
        {
            RuleFor(e => e.UserId)
            .NotEmpty().WithMessage("{PropertyName} boş olamaz")
            .NotNull().WithMessage("{PropertyName} boş olamaz")
            .WithName("Yazar");

            RuleFor(e => e.Description)
            .NotEmpty().WithMessage("{PropertyName} boş olamaz")
            .NotNull().WithMessage("{PropertyName} boş olamaz")
            .MaximumLength(500).WithMessage("{PropertyName} maksimum {MaxLength} olabilir")
            .WithName("Özet");

            RuleFor(e => e.Title)
            .NotEmpty().WithMessage("{PropertyName} boş olamaz")
            .NotNull().WithMessage("{PropertyName} boş olamaz")
            .MaximumLength(200).WithMessage("{PropertyName} maksimum {MaxLength} olabilir")
            .WithName("Başlık");

            RuleFor(e => e.Content)
            .NotEmpty().WithMessage("{PropertyName} boş olamaz")
            .NotNull().WithMessage("{PropertyName} boş olamaz")
            .WithName("İçerik");

            RuleFor(e => e.Cover)
            .NotEmpty().WithMessage("{PropertyName} boş olamaz")
            .NotNull().WithMessage("{PropertyName} boş olamaz")
            .WithName("Resim");
        }
    }
}