using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using AutoMapper;
using AutoMapper.Configuration.Annotations;
using TMS.Application.Common.Mapping;

namespace TMS.Application.Project.Queries.GetProjectList
{
    public class ProjectLookupDto : IMapWith<Domain.Project>
    {
        public Guid Id { get; set; }
        public string ProjectName { get; set; }
        public int ProjectStatusId { get; set; }
        [IgnoreDataMember]
        [IgnoreMap]
        [Ignore]
        [JsonIgnore]
        public string UserId { get; set; }
        public DateTime Date { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Project, ProjectLookupDto>()
                .ForMember(projectDto => projectDto.Id,
                    opt => opt.MapFrom(project => project.Id))
                .ForMember(projectDto => projectDto.ProjectName,
                    opt => opt.MapFrom(project => project.ProjectName))
                .ForMember(projectDto => projectDto.ProjectStatusId,
                    opt => opt.MapFrom(project => project.ProjectStatusId))
                .ForMember(projectDto => projectDto.Date,
                    opt => opt.MapFrom(project => project.AdditionDate))
                .ForMember(projectDto => projectDto.UserId,
                    x => x.Ignore());
        }
    }
}