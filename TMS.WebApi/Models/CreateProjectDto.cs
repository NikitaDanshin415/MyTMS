using AutoMapper;
using TMS.Application.Common.Mapping;
using TMS.Application.Project.Commands.CreateProject;

namespace TMS.WebApi.Models
{
    public class CreateProjectDto : IMapWith<CreateProjectCommand>
    {
        public string ProjectName { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateProjectDto, CreateProjectCommand>()
                .ForMember(projectCommand => projectCommand.ProjectName,
                    opt =>
                        opt.MapFrom(projectDto => projectDto.ProjectName));
        }
    }
}