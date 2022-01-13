using System;
using AutoMapper;
using TMS.Application.Common.Mapping;

namespace TMS.Application.Project.Queries.GetProjectDetails
{
    public class ProjectDetailsVm : IMapWith<Domain.Project>
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public DateTime AdditionDate { get; set; }
        public int ProjectStatusId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Project, ProjectDetailsVm>()
                .ForMember(projectVm => projectVm.ProjectName,
                    opt =>
                        opt.MapFrom(project => project.ProjectName))
                .ForMember(projectVm => projectVm.ProjectStatusId,
                    opt =>
                        opt.MapFrom(project => project.ProjectStatusId))
                .ForMember(projectVm => projectVm.AdditionDate,
                    opt =>
                        opt.MapFrom(project => project.AdditionDate))
                .ForMember(projectVm => projectVm.Id,
                    opt =>
                        opt.MapFrom(project => project.Id));
        }


    }
}