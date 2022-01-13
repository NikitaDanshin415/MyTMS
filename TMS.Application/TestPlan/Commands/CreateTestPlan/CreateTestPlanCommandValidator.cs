using FluentValidation;

namespace TMS.Application.TestPlan.Commands.CreateTestPlan
{
    public class CreateTestPlanCommandValidator : AbstractValidator<CreateTestPlanCommand>
    {
        public CreateTestPlanCommandValidator()
        {
            RuleFor(createTestPlanCommand =>
                createTestPlanCommand.TestPlanName).NotEmpty();

            RuleFor(createTestPlanCommand =>
                createTestPlanCommand.Description).NotEmpty();

            RuleFor(createTestPlanCommand =>
                createTestPlanCommand.ProjectId).NotEmpty();

        }
    }
}