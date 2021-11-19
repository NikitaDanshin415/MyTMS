using System;
using System.Threading.Tasks;
using AutoMapper;
using IdentityServer4.Extensions;
using IdentityServer4.Services;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TMS.Application.Project.Commands.CreateProject;
using TMS.Application.Project.Commands.DeleteProject;
using TMS.Application.Project.Commands.UpdateProject;
using TMS.Application.Project.Queries.GetProjectDetails;
using TMS.Application.Project.Queries.GetProjectList;
using TMS.Domain;
using TMS.WebApi.Models;

namespace TMS.WebApi.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class ProjectController : BaseController
    {
        private readonly IMapper _mapper;

        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly IIdentityServerInteractionService _interactionService;

        public ProjectController(SignInManager<User> signInManager, UserManager<User> userManager,
            IIdentityServerInteractionService interactionService, IMapper mapper)
        {
            (_signInManager, _userManager, _interactionService) =
                (signInManager, userManager, interactionService);
            _mapper = mapper;
        }
 


        [HttpGet]
        [Authorize]
        public async Task<ActionResult<ProjectListVm>> GetAll()
        {
            var query = new GetProjectListQuery
            {
                UserId = _signInManager.Context.User.Identity.GetSubjectId()
            };
            var vm = await Mediator.Send(query);

            return Ok(vm);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProjectListVm>> Get(Guid id)
        {
            var query = new GetProjectDetailsQuery()
            {
                UserId = _signInManager.Context.User.Identity.GetSubjectId(),
                Id = id
            };
            var vm = await Mediator.Send(query);

            return Ok(vm);
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateProjectDto createProjectDto)
        {
            var command = _mapper.Map<CreateProjectCommand>(createProjectDto);
            command.UserId = _signInManager.Context.User.Identity.GetSubjectId();
            var projectId = await Mediator.Send(command);

            return Ok(projectId);
        }

        [HttpPut("{id}")]
        [Authorize]
        public async Task<ActionResult<Guid>> Create([FromBody] UpdateProjectDto updateProjectDto)
        {
            var command = _mapper.Map<UpdateProjectCommand>(updateProjectDto);
            command.UserId = _signInManager.Context.User.Identity.GetSubjectId();
            await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [Authorize]
        public async Task<ActionResult<Guid>> Delete(Guid id)
        {
            var command = new DeleteProjectCommand
            {
                Id = id,
                UserId = _signInManager.Context.User.Identity.GetSubjectId()
            };

            await Mediator.Send(command);
            return NoContent();
        }

    }
}