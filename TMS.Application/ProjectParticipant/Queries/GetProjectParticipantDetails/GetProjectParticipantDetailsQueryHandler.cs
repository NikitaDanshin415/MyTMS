using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TMS.Application.Common.Exceptions;
using TMS.Application.Interfaces;
using TMS.Application.Project.Queries.GetProjectDetails;
using TMS.Application.ProjectParticipant.Queries.GetProjectParticipantsList;

namespace TMS.Application.ProjectParticipant.Queries.GetProjectParticipantDetails
{
    public class GetProjectParticipantDetailsQueryHandler : IRequestHandler<GetProjectParticipantDetailsQuery, ProjectParticipantDetailsVm>
    {
        private readonly ITmsDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetProjectParticipantDetailsQueryHandler(ITmsDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<ProjectParticipantDetailsVm> Handle(GetProjectParticipantDetailsQuery request,
            CancellationToken cancellationToken)
        {
            var projectParticipant = await _dbContext.ProjectParticipants
                .Where(p => p.UserId == request.UserId
                            && p.ProjectId == request.Id)
                .ProjectTo<ProjectParticipantDetailsVm>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);


            return _mapper.Map<ProjectParticipantDetailsVm>(projectParticipant.First());
        }

    }
}