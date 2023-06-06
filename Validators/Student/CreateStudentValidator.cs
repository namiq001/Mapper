using FluentValidation;
using Project.DTOs.StudentDto;

namespace Project.Validators.Student;

public class CreateStudentValidator : AbstractValidator<CreateStudentDto>
{
    public CreateStudentValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .NotNull()
            .WithMessage("Zehmet olmasa Name hissesini doldurun")
            .MaximumLength(100)
            .MinimumLength(3)
            .WithMessage("Name-in uzulugu min 3 max 100 ola biler");

        RuleFor(x=>x.Surname)
            .NotEmpty()
            .NotNull()
            .WithMessage("Zehmet olmasa Surname hissesini doldurun")
            .MaximumLength(100)
            .MinimumLength(3)
            .WithMessage("Surname-in uzulugu min 3 max 100 ola biler");

        RuleFor(x => x.Age)
            .NotEmpty()
            .NotNull()
            .WithMessage("Zehmet olmasa Age hissesini doldurun")
            .Must(x => x > 18)
            .WithMessage("Zehmet olmasa Age hissesini 18 den cox olalidi");
    }
}
