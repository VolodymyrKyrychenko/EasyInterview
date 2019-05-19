using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Reflection;

namespace Web.Infrastructure.StartupExtension
{
    public static class AutoMapperExtensionscs
    {
        public static void AddAutoMapperProfiles(this IServiceCollection service)
        {
            var assembliesToScan = System.AppDomain.CurrentDomain.GetAssemblies().Where(p => !p.IsDynamic).ToList();
            assembliesToScan.Add(Assembly.Load("Infrastructure"));

            var allTypes = assembliesToScan.SelectMany(a => a.ExportedTypes);

            var profiles =
                allTypes
                    .Where(t => typeof(Profile).GetTypeInfo().IsAssignableFrom(t.GetTypeInfo()))
                    .Where(t => !t.GetTypeInfo().IsAbstract).ToList();

            service.AddAutoMapper(profiles.Select(profile => profile.Assembly));
        }
    }
}
