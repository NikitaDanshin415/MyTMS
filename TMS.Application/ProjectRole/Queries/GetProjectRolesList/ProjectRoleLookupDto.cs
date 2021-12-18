using System;
using AutoMapper;
using TMS.Application.Common.Mapping;

namespace TMS.Application.ProjectRole.Queries.GetProjectRolesList
{
    public class ProjectRoleLookupDto : IMapWith<Domain.ProjectRole>
    {
        public Guid Id { get; set; }
        public string RoleName { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.ProjectRole, ProjectRoleLookupDto>()
                .ForMember(projectDto => projectDto.Id,
                    opt => opt.MapFrom(project => project.Id))
                .ForMember(projectDto => projectDto.RoleName,
                    opt => opt.MapFrom(project => project.RoleName));
        }
    }
}