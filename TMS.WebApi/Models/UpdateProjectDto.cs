using System;
using AutoMapper;
using TMS.Application.Common.Mapping;
using TMS.Application.Project.Commands.UpdateProject;

namespace TMS.WebApi.Models
{
    public class UpdateProjectDto : IMapWith<UpdateProjectDto>
    {
 public string ProjectName { get; set; }
        public string ProjectStatusId { get; set; }
        public string Id { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<UpdateProjectDto, UpdateProjectCommand>()
                .ForMember(projectDto => projectDto.Id,
                    opt => opt.MapFrom(noteDto => noteDto.Id))
                .ForMember(projectDto => projectDto.ProjectName,
                    opt => opt.MapFrom(noteDto => noteDto.ProjectName))
                .ForMember(projectDto => projectDto.ProjectStatusId,
                    opt => opt.MapFrom(noteDto => noteDto.ProjectStatusId));
        }
    }
}