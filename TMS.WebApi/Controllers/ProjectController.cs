using System;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TMS.Application.Project.Commands.CreateProject;
using TMS.Application.Project.Commands.DeleteProject;
using TMS.Application.Project.Commands.UpdateProject;
using TMS.Application.Project.Queries.GetProjectDetails;
using TMS.Application.Project.Queries.GetProjectList;
using TMS.WebApi.Models;

namespace TMS.WebApi.Controllers
{
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    [Produces("application/json")]
    [Route("api/{version:apiVersion}/[controller]")]
    public class ProjectController : BaseController
    {
        private readonly IMapper _mapper;

        public ProjectController(IMapper mapper)
        {
            _mapper = mapper;
        }


        [HttpGet]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<ProjectListVm>> GetAll()
        {

            var query = new GetProjectListQuery
            {
                UserId = UserId
            };
            var vm = await Mediator.Send(query);

            return Ok(vm);
        }


        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<ProjectListVm>> Get(int id)
        {
            var query = new GetProjectDetailsQuery()
            {
                UserId = UserId,
                ProjectId = id
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
        public async Task<ActionResult<int>> Create([FromBody] CreateProjectDto createProjectDto)
        {
            var command = _mapper.Map<CreateProjectCommand>(createProjectDto);
            command.UserId = UserId;
            var projectId = await Mediator.Send(command);

            return Ok(projectId);
        }

        [HttpPut("{ProjectId}")]
        [Authorize]
        public async Task<ActionResult<int>> Update([FromBody] UpdateProjectDto updateProjectDto, int ProjectId)
        {
            var command = _mapper.Map<UpdateProjectCommand>(updateProjectDto);
            command.UserId = UserId;
            command.ProjectId = ProjectId;
            await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [Authorize]
        public async Task<ActionResult<int>> Delete(int id)
        {
            var command = new DeleteProjectCommand
            {
                Id = id,
                UserId = UserId
            };

            await Mediator.Send(command);
            return NoContent();
        }

    }
}