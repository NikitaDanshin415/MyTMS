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

        public async Task<TestPlanListVm> Handle(GetTestPlanListQuery request, CancellationToken cancellationToken)
        {
            var testPlans = await _dbContext.TestPlans
                .Where(e => e.ProjectId == request.ProjectId)
                .ProjectTo<TestPlanListDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
            

            return new TestPlanListVm { TestPlans = testPlans };
        }


    }
}