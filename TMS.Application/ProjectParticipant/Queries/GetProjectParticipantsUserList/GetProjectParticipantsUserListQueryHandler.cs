using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TMS.Application.Interfaces;

namespace TMS.Application.ProjectParticipant.Queries.GetProjectParticipantsUserList
{
    public class GetProjectParticipantsUserListQueryHandler : IRequestHandler<GetProjectParticipantsUserListQuery, ProjectParticipantsUserListVm>
    {
        private readonly ITmsDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetProjectParticipantsUserListQueryHandler(ITmsDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<ProjectParticipantsUserListVm> Handle(GetProjectParticipantsUserListQuery request, CancellationToken cancellationToken)
        {
            var projectParticipant = await _dbContext.ProjectParticipants
                .Where(p => p.ProjectId == request.ProjectId)
                .ProjectTo<GetProjectParticipantsUserListLookupDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);


            return new ProjectParticipantsUserListVm {ProjectParticipantsUserList = projectParticipant};
        }
    }
}