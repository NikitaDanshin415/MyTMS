using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TMS.Application.Project.Queries.GetProjectDetails;
using TMS.Application.Project.Queries.GetProjectList;
using TMS.Application.ProjectRole.Queries.GetProjectRoleDetails;
using TMS.Application.ProjectRole.Queries.GetProjectRolesList;

namespace TMS.WebApi.Controllers
{
    public class ProjectRoleController : BaseController
    {
        private readonly IMapper _mapper;

        public ProjectRoleController(IMapper mapper)
        {
            _mapper = mapper;
        }

  
        [HttpGet]
        [Authorize]
        [ApiVersion("1.0")]
        [ApiVersion("2.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<ProjectRoleListVm>> GetAll()
        {

            var query = new GetProjectRoleListQuery
            {
                UserId = UserId
            };
            var vm = await Mediator.Send(query);

            return Ok(vm);
        }

        [ApiVersion("1.0")]
        [ApiVersion("2.0")]
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<ProjectRoleListVm>> Get(int id)
        {
            var query = new GetProjectRoleDetailsQuery()
            {
                Id = id
            };
            var vm = await Mediator.Send(query);

            return Ok(vm);
        }

    }
}