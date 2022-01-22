using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TMS.Application.Project.Commands.CreateProject;
using TMS.Application.Project.Queries.GetProjectList;
using TMS.Application.ProjectParticipant.Commands.CreateProjectParticipant;
using TMS.Application.ProjectParticipant.Commands.DeleteProjectParticipant;
using TMS.Application.ProjectParticipant.Queries.GetProjectParticipantDetails;
using TMS.Application.ProjectParticipant.Queries.GetProjectParticipantsList;
using TMS.Application.ProjectParticipant.Queries.GetProjectParticipantsUserList;
using TMS.WebApi.Models.ProjectParticipant;

namespace TMS.WebApi.Controllers
{
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    [Produces("application/json")]
    [Route("api/{version:apiVersion}/[controller]")]
    public class ProjectParticipantController : BaseController
    {
        private readonly IMapper _mapper;

        public ProjectParticipantController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<ProjectParticipantListVm>> GetAll()
        {

            var query = new GetProjectParticipantListQuery
            {
                UserId = UserId
            };
            var vm = await Mediator.Send(query);

            return Ok(vm);
        }

        /**
         * Все проекты пользвоателя
         */
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<ProjectParticipantDetailsVm>> Get(int id)
        {
            var query = new GetProjectParticipantDetailsQuery()
            {
                UserId = UserId,
                Id = id
            };
            var vm = await Mediator.Send(query);

            return Ok(vm);
        }

        /**
          * Все пользователи проекта.
          */
        [HttpGet("{id}/users")]
        [Authorize]
        public async Task<ActionResult<ProjectParticipantsUserListVm>> GetProjectUsers(int id)
        {
            var query = new GetProjectParticipantsUserListQuery()
            {
                UserId = UserId,
                ProjectId = id
            };
            var vm = await Mediator.Send(query);

            return Ok(vm);
        }


        [ApiVersion("1.0")]
        [ApiVersion("2.0")]
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<int>> Create([FromBody] CreateProjectParticipantDto createProjectParticipantDto)
        {
            var command = _mapper.Map<CreateProjectParticipantCommand>(createProjectParticipantDto);
            var projectId = await Mediator.Send(command);

            return Ok(projectId);
        }

        [HttpDelete("{id}")]
        [Authorize]
        public async Task<ActionResult<int>> Delete(int id)
        {
            var command = new DeleteProjectParticipantCommand()
            {
                Id = id,
                UserId = UserId
            };

            await Mediator.Send(command);
            return NoContent();
        }


    }
}