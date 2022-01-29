using System.Collections.Generic;
using AutoMapper;
using TMS.Application.Common.Mapping;
using TMS.Application.TestCase.Commands.CreateTestCase;
using TMS.Application.TestPlan.Commands.CreateTestPlan;
using TMS.Domain;
using TMS.WebApi.Models.TestPlan;

namespace TMS.WebApi.Models.TestCase
{
    public class CreateTestCaseDto : IMapWith<CreateTestCaseCommand>
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
        public int ProjectId { get; set; }
        public string UserId { get; set; }
        public List<TestCaseStep> Steps { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateTestCaseDto, CreateTestCaseCommand>()
                .ForMember(testCaseCommand => testCaseCommand.UserId,
                    opt => opt.MapFrom(testCaseDto => testCaseDto.UserId))
                .ForMember(testCaseCommand => testCaseCommand.Description,
                    opt => opt.MapFrom(testCaseDto => testCaseDto.Description))
                .ForMember(testCaseCommand => testCaseCommand.Name,
                    opt => opt.MapFrom(testCaseDto => testCaseDto.Name))
                .ForMember(testCaseCommand => testCaseCommand.Description,
                    opt => opt.MapFrom(testCaseDto => testCaseDto.Description))
                .ForMember(testCaseCommand => testCaseCommand.ProjectId,
                    opt => opt.MapFrom(testCaseDto => testCaseDto.ProjectId));
        }

    }
}