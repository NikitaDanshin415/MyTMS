using System;
using AutoMapper;
using TMS.Application.Common.Mapping;
using TMS.Application.Project.Queries.GetProjectDetails;

namespace TMS.Application.ProjectRole.Queries.GetProjectRoleDetails
{
    public class ProjectRoleDetailsVm : IMapWith<Domain.ProjectRole>
    {
        public Guid Id { get; set; }
        public string RoleName { get; set; }


        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.ProjectRole, ProjectRoleDetailsVm>()
                .ForMember(projectRoleVm => projectRoleVm.RoleName,
                    opt =>
                        opt.MapFrom(projectRole => projectRole.RoleName))
                .ForMember(projectRoleVm => projectRoleVm.Id,
                    opt =>
                        opt.MapFrom(projectRole => projectRole.Id));
        }
    }
}