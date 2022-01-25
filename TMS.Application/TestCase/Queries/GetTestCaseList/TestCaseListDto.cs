using System.Text.Json.Serialization;
using AutoMapper;
using TMS.Application.Common.Mapping;
using TMS.Domain;

namespace TMS.Application.TestCase.Queries.GetTestCaseList
{
    public class TestCaseListDto : IMapWith<Domain.TestCase>
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
        public int ProjectId { get; set; }
        [JsonIgnore]
        public string UserId { get; set; }
        public User User { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.TestCase, TestCaseListDto>()
                .ForMember(testCaseDto => testCaseDto.Description,
                    opt => opt.MapFrom(tc => tc.Description))
                .ForMember(testCaseDto => testCaseDto.Date,
                    opt => opt.MapFrom(tc => tc.Date))
                .ForMember(testCaseDto => testCaseDto.ProjectId,
                    opt => opt.MapFrom(tc => tc.ProjectId))
                .ForMember(testCaseDto => testCaseDto.UserId,
                    opt => opt.MapFrom(tc => tc.UserId))
                .ForMember(testCaseDto => testCaseDto.Id,
                    opt => opt.MapFrom(tc => tc.Id));
        }
    }

    
}