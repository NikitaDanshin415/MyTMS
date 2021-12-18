using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TMS.Application.Common.Exceptions;
using TMS.Application.Interfaces;
using TMS.Application.Project.Queries.GetProjectDetails;

namespace TMS.Application.ProjectRole.Queries.GetProjectRoleDetails
{
    public class GetProjectRoleDetailsQueryHandler : IRequestHandler<GetProjectRoleDetailsQuery, ProjectRoleDetailsVm>
    {
        private readonly ITmsDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetProjectRoleDetailsQueryHandler(ITmsDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<ProjectRoleDetailsVm> Handle(GetProjectRoleDetailsQuery request, CancellationToken cancellationToken)
        {
            var entity = await _dbContext.ProjectRoles
                .FirstOrDefaultAsync(projectRole => projectRole.Id == request.Id, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Domain.ProjectRole), request.Id);
            }
            
            return _mapper.Map<ProjectRoleDetailsVm>(entity);
        }
    }
}