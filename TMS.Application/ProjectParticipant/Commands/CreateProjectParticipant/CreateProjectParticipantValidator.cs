using FluentValidation;

namespace TMS.Application.ProjectParticipant.Commands.CreateProjectParticipant
{
    public class CreateProjectParticipantValidator : AbstractValidator<CreateProjectParticipantCommand>
    {
        public CreateProjectParticipantValidator()
        {
            RuleFor(CreateProjectParticipantCommand => 
                CreateProjectParticipantCommand.ProjectId).NotEmpty();

            RuleFor(CreateProjectParticipantCommand =>
                CreateProjectParticipantCommand.UserId).NotEmpty();

            RuleFor(CreateProjectParticipantCommand =>
                CreateProjectParticipantCommand.ProjectRoleId).NotEmpty();
        }
    }
}