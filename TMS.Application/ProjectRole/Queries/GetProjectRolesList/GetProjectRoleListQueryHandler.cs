using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TMS.Application.Interfaces;
using TMS.Application.Project.Queries.GetProjectList;

namespace TMS.Application.ProjectRole.Queries.GetProjectRolesList
{

    public class GetProjectRoleListQueryHandler : IRequestHandler<GetProjectRoleListQuery, ProjectRoleListVm>
    {
        private readonly ITmsDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetProjectRoleListQueryHandler(ITmsDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<ProjectRoleListVm> Handle(GetProjectRoleListQuery request, CancellationToken cancellationToken)
        {

            var projectRoleQuery = await _dbContext.ProjectRoles
                .ProjectTo<ProjectRoleLookupDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);


            return new ProjectRoleListVm() { ProjectRoles = projectRoleQuery };

        }
    }
}