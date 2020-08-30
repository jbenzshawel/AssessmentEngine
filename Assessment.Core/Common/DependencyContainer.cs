using Assessment.Core.Mapping.Abstraction;
using Assessment.Core.Mapping.Implementation;
using Assessment.Core.Mapping.Profiles;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace Assessment.Core.Common
{
    public static class DependencyContainer
    {
        public static void Configure(IServiceCollection services)
        {
            ConfigureMapper(services);
            ConfigureCoreServices(services);
        }

        private static void ConfigureMapper(IServiceCollection services)
        {
            var appProfile = new Profile[] {new AssessmentProfile(),};
            services.AddSingleton<IMapperAdapter, MapperAdapter>(x => new MapperAdapter(appProfile));
        }

        private static void ConfigureCoreServices(IServiceCollection services)
        {
           
        }
    }
}