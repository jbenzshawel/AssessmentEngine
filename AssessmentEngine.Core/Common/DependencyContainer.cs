using AssessmentEngine.Core.Mapping.Abstraction;
using AssessmentEngine.Core.Mapping.Implementation;
using AssessmentEngine.Core.Mapping.Profiles;
using AssessmentEngine.Core.Services.Abstraction;
using AssessmentEngine.Core.Services.Implementation;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace AssessmentEngine.Core.Common
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
            services.AddSingleton<IMapperAdapter, MapperAdapter>(x => BuildMapper());
        }

        private static MapperAdapter BuildMapper()
        {
            var mapper = new MapperAdapter(new Profile[] {new AssessmentProfile(),});
            mapper.AssertConfigurationIsValid();
            return mapper;
        }

        private static void ConfigureCoreServices(IServiceCollection services)
        {
            services.AddTransient<IAssessmentService, AssessmentService>();
            services.AddTransient<IUserService, UserService>();
        }
    }
}