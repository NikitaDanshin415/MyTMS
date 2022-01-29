using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TMS.Application.Project.Commands.CreateProject;
using TMS.Application.Project.Queries.GetProjectDetails;
using TMS.Application.Project.Queries.GetProjectList;
using TMS.Application.TestCase.Commands.CreateTestCase;
using TMS.Application.TestCase.Queries.GetTestCaseDetails;
using TMS.Application.TestCase.Queries.GetTestCaseList;
using TMS.WebApi.Models.TestCase;

namespace TMS.WebApi.Controllers
{
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    [Produces("application/json")]
    [Route("api/{version:apiVersion}/[controller]")]
    public class TestCaseController : BaseController
    {

        private readonly IMapper _mapper;

        public TestCaseController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<TestCaseListVm>> GetTestCaseList(int projectId)
        {
            var query = new GetTestCaseListQuery()
            {
                UserId = UserId,
                ProjectId = projectId
            };
            var vm = await Mediator.Send(query);

            return Ok(vm);
        }

        [HttpGet("{id}")]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<TestCaseDetailsVm>> Get(int id)
        {
            var query = new GetTestCaseDetailsQuery()
            {
                UserId = UserId,
                TestCaseId = id
            };

            try
            {
                var vm = await Mediator.Send(query);
                return Ok(vm);
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }


        [ApiVersion("1.0")]
        [ApiVersion("2.0")]
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<int>> Create([FromBody] CreateTestCaseDto createTestCaseDto)
        {
            var command = _mapper.Map<CreateTestCaseCommand>(createTestCaseDto);
            command.UserId = UserId;
            var projectId = await Mediator.Send(command);

            return Ok(projectId);
        }

    }
}