using AssessmentEngine.Core.Abstraction;
using AssessmentEngine.Core.BlockVersions.Abstraction;
using AssessmentEngine.Core.BlockVersions.Implementation;
using AssessmentEngine.Core.Services.Abstraction;
using AssessmentEngine.Core.Services.Implementation;
using AssessmentEngine.Infrastructure.Database;
using AssessmentEngine.Infrastructure.Mapping.Implementation;
using AssessmentEngine.Infrastructure.Mapping.Profiles;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace AssessmentEngine.Infrastructure.Configuration
{
    public static class DependencyContainer
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddScoped<IApplicationDbContext, ApplicationDbContext>();
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
            services.AddScoped<ILookupService, LookupService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRandomService, RandomService>();
            services.AddScoped<IBlockVersionGenerator, EFTBlockVersionGenerator>();
            services.AddScoped<IBlockVersionGenerator, VetFlexIIBlockVersionGenerator>();
            services.AddScoped<IBlockVersionGenerator, VetFlexIIIBlockVersionGenerator>();
            services.AddScoped<IBlockVersionGeneratorFactory, BlockVersionGeneratorFactory>();
            services.AddScoped<IAssessmentService, AssessmentService>();
        }
    }
}