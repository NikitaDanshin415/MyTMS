using System.Linq;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using TMS.Application.Interfaces;

namespace TMS.Application.TestPlan.Queries.GetTestPlanList
{
    public class GetTestPlanListQueryHandler : IRequestHandler<GetTestPlanListQuery, TestPlanListVm>
    {
        private readonly ITmsDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetTestPlanListQueryHandler(ITmsDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        //public async Task<TestPlanListVm> Handle(GetTestPlanListQuery request, CancellationToken cancellationToken)
        //{

        //    var projectParticipant = await _dbContext.ProjectParticipants
        //        .FirstOrDefaultAsync(e => e.ProjectId == request.ProjectId && e.UserId == request.UserId, cancellationToken: cancellationToken);


        //    var testPlans = await _dbContext.TestPlans
        //        .Where(e => e.ProjectParticipantId == projectParticipant.Id)
        //        .ProjectTo<TestPlanListDto>(_mapper.ConfigurationProvider)
        //        .ToListAsync(cancellationToken);

        //    return new TestPlanListVm { TestPlans = testPlans };


        //}
        public Task<TestPlanListVm> Handle(GetTestPlanListQuery request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}