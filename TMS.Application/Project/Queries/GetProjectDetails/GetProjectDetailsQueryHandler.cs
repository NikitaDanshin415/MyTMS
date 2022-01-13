using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TMS.Application.Common.Exceptions;
using TMS.Application.Interfaces;

namespace TMS.Application.Project.Queries.GetProjectDetails
{
    public class GetProjectDetailsQueryHandler : IRequestHandler<GetProjectDetailsQuery, ProjectDetailsVm>
    {
        private readonly ITmsDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetProjectDetailsQueryHandler(ITmsDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<ProjectDetailsVm> Handle(GetProjectDetailsQuery request, CancellationToken cancellationToken)
        {
            var projectParticipant = await _dbContext.ProjectParticipants
                .FirstOrDefaultAsync(e =>
                    e.UserId == request.UserId && e.ProjectId == request.ProjectId, cancellationToken);

            if (projectParticipant == null)
            {
                throw new NotFoundException(nameof(Domain.Project), request.ProjectId);
            }


            var entity = await _dbContext.Projects
                .FirstOrDefaultAsync(project => project.Id == projectParticipant.ProjectId, cancellationToken);

            if (entity == null || projectParticipant == null)
            {
                throw new NotFoundException(nameof(Domain.Project), request.ProjectId);
            }

            return _mapper.Map<ProjectDetailsVm>(entity);
        }
     
    }
}