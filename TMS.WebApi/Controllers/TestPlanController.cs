using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using TMS.Application.Project.Commands.CreateProject;
using TMS.Application.TestPlan.Commands.CreateTestPlan;
using TMS.Application.TestPlan.Queries.GetTestPlanList;
using TMS.WebApi.Models;
using TMS.WebApi.Models.TestPlan;

namespace TMS.WebApi.Controllers
{
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    [Produces("application/json")]
    [Route("api/{version:apiVersion}/[controller]")]
    public class TestPlanController : BaseController
    {
        private readonly IMapper _mapper;

        public TestPlanController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [ApiVersion("1.0")]
        [ApiVersion("2.0")]
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<int>> Create([FromBody] CreateTestPlanDto createTestPlanDto)
        {
            var command = _mapper.Map<CreateTestPlanCommand>(createTestPlanDto);
            var projectId = await Mediator.Send(command);

            return Ok(projectId);
        }

        [ApiVersion("1.0")]
        [ApiVersion("2.0")]
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<int>> GetAll(Guid Projectid)
        {
            var query = new GetTestPlanListQuery()
            {
                UserId = UserId,
                ProjectId = Projectid
            };
            var vm = await Mediator.Send(query);

            return Ok(vm);
        }
    }
}
