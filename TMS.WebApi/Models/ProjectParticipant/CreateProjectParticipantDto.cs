using System.ComponentModel.DataAnnotations;
using AutoMapper;
using TMS.Application.Common.Mapping;
using TMS.Application.ProjectParticipant.Commands.CreateProjectParticipant;

namespace TMS.WebApi.Models.ProjectParticipant
{
    public class CreateProjectParticipantDto : IMapWith<CreateProjectParticipantCommand>
    {
        [Required]
        public int ProjectId { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public int ProjectRoleId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateProjectParticipantDto, CreateProjectParticipantCommand>()
                .ForMember(projectParticipant => projectParticipant.ProjectId,
                    opt => opt.MapFrom(projectPart => projectPart.ProjectId));
        }
    }
}