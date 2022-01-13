using System;
using AutoMapper;
using TMS.Application.Common.Mapping;
using TMS.Domain;

namespace TMS.Application.TestPlan.Queries.GetTestPlanList
{
    public class TestPlanListDto : IMapWith<Domain.TestPlan>
    {
        public int Id { get; set; }
        public string TestPlanName { get; set; }
        public string Description { get; set; }
        public DateTime AdditionDateTime { get; set; }
        public int ProjectParticipantId { get; set; }
        public ProjectParticipants ProjectParticipant { get; set; }
        public User User { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.TestPlan, TestPlanListDto>()
                .ForMember(testPlanDto => testPlanDto.Id,
                    opt => opt.MapFrom(testPlan => testPlan.Id))
                .ForMember(testPlanDto => testPlanDto.TestPlanName,
                    opt => opt.MapFrom(testPlan => testPlan.TestPlanName))
                .ForMember(testPlanDto => testPlanDto.Description,
                    opt => opt.MapFrom(testPlan => testPlan.Description))
                .ForMember(testPlanDto => testPlanDto.AdditionDateTime,
                    opt => opt.MapFrom(testPlan => testPlan.AdditionDateTime));
        }
    }
}