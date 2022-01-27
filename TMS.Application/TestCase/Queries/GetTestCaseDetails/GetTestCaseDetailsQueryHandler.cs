using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TMS.Application.Interfaces;

namespace TMS.Application.TestCase.Queries.GetTestCaseDetails
{
    public class GetTestCaseDetailsQueryHandler : IRequestHandler<GetTestCaseDetailsQuery, TestCaseDetailsVm>
    {
        private readonly ITmsDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetTestCaseDetailsQueryHandler(ITmsDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<TestCaseDetailsVm> Handle(GetTestCaseDetailsQuery request, CancellationToken cancellationToken)
        {
            var testCaseDetails = await _dbContext.TestCases
                .Include(e => e.Steps)
                .FirstOrDefaultAsync(e => e.Id == request.TestCaseId, cancellationToken);


            return _mapper.Map<TestCaseDetailsVm>(testCaseDetails);
            
        }
    }
}