using FluentValidation;
using GestaoCursos.Application.Dtos.Requests;

namespace GestaoCursos.Application.Validators
{
    public class CreateCourseRequestValidator: AbstractValidator<CreateCourseRequest>
    {
        public CreateCourseRequestValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("O título é obrigatório.")
                .MinimumLength(3).WithMessage("O título deve conter ao menos 3 caracteres.");
            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("A descrição é obrigatória.")
                .MinimumLength(10).WithMessage("A descrição deve conter ao menos 10 caracteres.");
            RuleFor(x => x.DurationInHours)
                .GreaterThan(0).WithMessage("A duração deve ser maior que zero.");
            RuleFor(x => x.Price)
                .GreaterThan(0).WithMessage("O preço deve ser maior que zero.");
        }
    }
}
