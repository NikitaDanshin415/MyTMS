using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TMS.Application.Interfaces;
using TMS.Domain;

namespace TMS.Application.ProjectParticipant.Commands.CreateProjectParticipant
{
    public class CreateProjectParticipantCommandHandler : IRequestHandler<CreateProjectParticipantCommand, Domain.ProjectParticipants>
    {
        private readonly ITmsDbContext _dbContext;

        public CreateProjectParticipantCommandHandler(ITmsDbContext context)
        {
            _dbContext = context;
        }


        public async Task<ProjectParticipants> Handle(CreateProjectParticipantCommand request, CancellationToken cancellationToken)
        {
            var projectParticipant = new ProjectParticipants
            {
                ProjectId = request.ProjectId,
                ProjectRoleId = request.ProjectRoleId,
                UserId = request.UserId,
                AdditionToProject = DateTime.Now
            };

            await _dbContext.ProjectParticipants.AddAsync(projectParticipant, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return projectParticipant;
        }
    }
}