using Autofac;
using Common.Interfaces;
using Common.Mapping;

namespace Infrastructure.Modules
{
    public class CommonModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MappingService>().As<IMappingService>();
        }
    }
}
