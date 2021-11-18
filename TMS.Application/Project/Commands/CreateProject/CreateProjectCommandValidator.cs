using FluentValidation;

namespace TMS.Application.Project.Commands.CreateProject
{
    public class CreateProjectCommandValidator : AbstractValidator<CreateProjectCommand>
    {
        public CreateProjectCommandValidator()
        {
            RuleFor(createProjectCommand =>
                createProjectCommand.ProjectName).NotEmpty();
        }
    }
}