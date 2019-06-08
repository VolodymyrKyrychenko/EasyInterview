using AutoMapper;
using Domain.Entities;
using Web.Models.LibraryModels;

namespace Web.Infrastructure.MapperProfiles
{
    public class LibraryProfile : Profile
    {
        public LibraryProfile()
        {
            CreateMap<Library, LibraryViewModel>();
        }
    }
}
