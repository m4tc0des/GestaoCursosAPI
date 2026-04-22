using FluentValidation;
using GestaoCursos.Application.Dtos;

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
        }
    }
}
