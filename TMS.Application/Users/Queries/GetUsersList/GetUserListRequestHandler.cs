using System.Linq;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using TMS.Application.Interfaces;

namespace TMS.Application.Users.Queries.GetUsersList
{
    public class GetUserListRequestHandler : IRequestHandler<GetUserListQuery, UserListVm>
    {
        private readonly ITmsDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetUserListRequestHandler(ITmsDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<UserListVm> Handle(GetUserListQuery request, CancellationToken cancellationToken)
        {
            var users = await _dbContext.Users
                .Where(e => e.UserName.Contains(request.UserName))
                .ProjectTo<UserListDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new UserListVm {UserList = users};
        }
    }
}