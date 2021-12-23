using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TMS.Application.Interfaces;
using TMS.Application.Project.Queries.GetProjectList;

namespace TMS.Application.ProjectParticipant.Queries.GetProjectParticipantsList
{
    public class GetProjectParticipantListQueryHandler : IRequestHandler<GetProjectParticipantListQuery, ProjectParticipantListVm>
    {
        private readonly ITmsDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetProjectParticipantListQueryHandler(ITmsDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<ProjectParticipantListVm> Handle(GetProjectParticipantListQuery request,
            CancellationToken cancellationToken)
        {
            var projectParticipant = await _dbContext.ProjectParticipants
                .Where(p => p.UserId == request.UserId)
                .ProjectTo<ProjectParticipantLookupDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new ProjectParticipantListVm{ProjectParticipant = projectParticipant};
    }
    }
}