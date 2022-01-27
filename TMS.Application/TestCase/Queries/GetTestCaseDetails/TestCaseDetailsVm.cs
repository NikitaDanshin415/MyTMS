using System.Collections.Generic;
using AutoMapper;
using TMS.Application.Common.Mapping;
using TMS.Application.Project.Queries.GetProjectDetails;
using TMS.Domain;

namespace TMS.Application.TestCase.Queries.GetTestCaseDetails
{
    public class TestCaseDetailsVm : IMapWith<Domain.TestCase>
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public int ProjectId { get; set; }

        public string UserId { get; set; }

        public List<TestCaseStep> Steps { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.TestCase, TestCaseDetailsVm>()
                .ForMember(projectVm => projectVm.Description,
                    opt =>
                        opt.MapFrom(project => project.Description))
                .ForMember(projectVm => projectVm.Date,
                    opt =>
                        opt.MapFrom(project => project.Date))
                .ForMember(projectVm => projectVm.Id,
                    opt =>
                        opt.MapFrom(project => project.Id))
                .ForMember(projectVm => projectVm.Steps,
                    opt =>
                        opt.MapFrom(project => project.Steps))
                .ForMember(projectVm => projectVm.Name,
                    opt =>
                        opt.MapFrom(project => project.Name))
                .ForMember(projectVm => projectVm.UserId,
                    opt =>
                        opt.MapFrom(project => project.UserId));
        }
    }
}