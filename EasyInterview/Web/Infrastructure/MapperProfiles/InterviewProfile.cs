using AutoMapper;
using Domain.Entities;
using Web.Models.Interview;

namespace Web.Infrastructure.MapperProfiles
{
    public class InterviewProfile : Profile
    {
        public InterviewProfile()
        {
            CreateMap<Interview, InterviewViewModel>()
                .ForMember(destination => destination.Name,
                           member => member.MapFrom(source => source.Candidate.Name))
                .ForMember(destination => destination.StartTime,
                           member => member.MapFrom(source => source.Candidate.Name))
                .ForMember(destination => destination.Duration,
                           member => member.MapFrom(source => (source.Finish - source.Start).ToString()));
        }
    }
}
