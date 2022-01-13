using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using TMS.Application.Common.Mapping;
using TMS.Application.TestPlan.Commands.CreateTestPlan;

namespace TMS.WebApi.Models.TestPlan
{
    public class CreateTestPlanDto : IMapWith<CreateTestPlanCommand>
    {
        [Required]
        public string TestPlanName { get; set; }
        [Required]
        public string Description { get; set; }

        public string UserId { get; set; }
        [Required]
        public int ProjectId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateTestPlanDto, CreateTestPlanCommand>()
                .ForMember(testPlanCommand => testPlanCommand.TestPlanName,
                    opt => opt.MapFrom(testPlanDto => testPlanDto.TestPlanName))
                .ForMember(testPlanCommand => testPlanCommand.Description,
                opt => opt.MapFrom(testPlanDto => testPlanDto.Description))
                .ForMember(testPlanCommand => testPlanCommand.ProjectId,
                    opt => opt.MapFrom(testPlanDto => testPlanDto.ProjectId));
        }
    }
}
