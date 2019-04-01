using AutoMapper;
using EasyInterview.Core.Entities;
using EasyInterview.WEB.Models.ModelViewEntities;

namespace EasyInterview.WEB.AutoMapper
{
    public class WebMappingProfile : Profile
    {
        public WebMappingProfile()
        {
            CreateMap<Exercise, TaskModelView>();

            CreateMap<TaskModelView, Exercise>();
        }
    }
}