using AutoMapper;

namespace EasyInterview.WEB.AutoMapper
{
    public static class AutoMapperConfiguration
    {
        public static void Config()
        {
            Mapper.Initialize(cfg => cfg.AddProfile(new WebMappingProfile()));
        }
    }
}