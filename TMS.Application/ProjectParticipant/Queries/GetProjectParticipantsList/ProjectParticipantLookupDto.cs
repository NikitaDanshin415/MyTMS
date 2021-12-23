using System;
using AutoMapper;
using TMS.Application.Common.Mapping;
using TMS.Domain;

namespace TMS.Application.ProjectParticipant.Queries.GetProjectParticipantsList
{
    public class ProjectParticipantLookupDto : IMapWith<Domain.ProjectParticipants>
    {
        public DateTime AdditionToProject { get; set; }
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public Guid ProjectId { get; set; }
        public Guid ProjectRoleId { get; set; }
        public Domain.Project Project { get; set; }
        public Domain.ProjectRole ProjectRole { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.ProjectParticipants, ProjectParticipantLookupDto>()
                .ForMember(projectParticipant => projectParticipant.Id,
                    opt => opt.MapFrom(pp => pp.Id))
                .ForMember(projectParticipant => projectParticipant.AdditionToProject,
                    opt => opt.MapFrom(pp => pp.AdditionToProject))
                .ForMember(projectParticipant => projectParticipant.UserId,
                    opt => opt.MapFrom(pp => pp.UserId))
                .ForMember(projectParticipant => projectParticipant.ProjectId,
                    opt => opt.MapFrom(pp => pp.ProjectId))
                .ForMember(projectParticipant => projectParticipant.ProjectRoleId,
                    opt => opt.MapFrom(pp => pp.ProjectRoleId));
        }
    }
}