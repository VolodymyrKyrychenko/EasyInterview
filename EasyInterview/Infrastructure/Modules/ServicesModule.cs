using Autofac;
using Domain.Entities;
using Services.Interfaces;
using Services.Services;

namespace Infrastructure.Modules
{
    public class ServicesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<LibraryService>().As<IService<Library>>();
            builder.RegisterType<InterviewService>().As<IInterviewService>();
        }
    }
}
