using System;
using AssessmentEngine.Infrastructure.Mapping.Implementation;
using AssessmentEngine.Infrastructure.Mapping.Profiles;
using AutoMapper;
using Xunit;

namespace AssessmentEngine.Infrastructure.UnitTests
{
    public class MapperAdapterTests
    {
        [Fact]
        public void Mapper_HasValidMappingConfiguration()
        {
            var mapper = new MapperAdapter(new Profile[] { new AssessmentProfile(), });

            mapper.AssertConfigurationIsValid();
        }
    }
}