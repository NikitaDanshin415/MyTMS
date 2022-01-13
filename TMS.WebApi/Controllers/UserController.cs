using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using TMS.Application.Project.Queries.GetProjectList;
using TMS.Application.Users.Queries.GetUsersList;

namespace TMS.WebApi.Controllers
{
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    [Authorize]
    [Produces("application/json")]
    [Route("api/{version:apiVersion}/[controller]")]
    public class UserController : BaseController
    {
        private readonly IMapper _mapper;

        public UserController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<UserListVm>> Get(string userName)
        {

            var query = new GetUserListQuery()
            {
                UserId = UserId,
                UserName = userName
                
            };
            var vm = await Mediator.Send(query);

            return Ok(vm);
        }
    }
}
