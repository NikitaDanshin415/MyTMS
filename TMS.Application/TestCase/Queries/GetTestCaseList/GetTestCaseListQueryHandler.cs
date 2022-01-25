using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TMS.Application.Interfaces;

namespace TMS.Application.TestCase.Queries.GetTestCaseList
{
    public class GetTestCaseListQueryHandler : IRequestHandler<GetTestCaseListQuery, TestCaseListVm>
    {

        private readonly ITmsDbContext _dbContext;
        private readonly IMapper _mapper;
        public GetTestCaseListQueryHandler(ITmsDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<TestCaseListVm> Handle(GetTestCaseListQuery request, CancellationToken cancellationToken)
        {
            var testCases = await _dbContext.TestCases
                .Where(e => request.ProjectId == e.ProjectId)
                .ProjectTo<TestCaseListDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new TestCaseListVm {TestCases = testCases};
        }
    }
}