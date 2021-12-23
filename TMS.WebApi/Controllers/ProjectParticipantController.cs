using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TMS.Application.Project.Queries.GetProjectList;
using TMS.Application.ProjectParticipant.Queries.GetProjectParticipantsList;

namespace TMS.WebApi.Controllers
{
    public class ProjectParticipantController : BaseController
    {
        private readonly IMapper _mapper;

        public ProjectParticipantController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<ProjectParticipantListVm>> GetAll()
        {

            var query = new GetProjectParticipantListQuery
            {
                UserId = UserId
            };
            var vm = await Mediator.Send(query);

            return Ok(vm);
        }

    }
}