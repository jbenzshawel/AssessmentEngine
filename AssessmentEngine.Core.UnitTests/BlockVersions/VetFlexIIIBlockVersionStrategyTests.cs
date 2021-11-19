using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentEngine.Core.BlockVersions.Implementation;
using AssessmentEngine.Core.DTO;
using AssessmentEngine.Core.Services.Abstraction;
using Moq;
using Xunit;

namespace AssessmentEngine.Core.UnitTests.BlockVersions
{
    public class VetFlexIIIBlockVersionStrategyTests
    {
        [Fact]
        public async Task Generate_ShouldNotSetCognitiveLoadForBlockTypes()
        {
            // arrange
            var lookupService = BuildLookupService();
            var eftBlockVersionStrategy = new VetFlexIIIBlockVersionStrategy(lookupService.Object);

            // act
            var blockTypes = await eftBlockVersionStrategy.Generate();
            
            // assert
            Assert.True(blockTypes.All(x => !x.CognitiveLoad && string.IsNullOrEmpty(x.Series)));
        }

        [Fact]
        public async Task Generate_ShouldSetUidForAllBlockTypes()
        {
            // arrange
            var lookupService = BuildLookupService();
            var eftBlockVersionStrategy = new VetFlexIIIBlockVersionStrategy(lookupService.Object);

            // act
            var blockTypes = await eftBlockVersionStrategy.Generate();
            
            // assert
            Assert.True(blockTypes.All(x => x.Uid != Guid.Empty));
        }

        private Mock<ILookupService> BuildLookupService()
        {
            var lookupService = new Mock<ILookupService>();

            lookupService.Setup(m => m.BlockTypes())
                .Returns(GetStubBlockTypes());

            return lookupService;
        }

        private Task<IEnumerable<LookupTypeDTO>> GetStubBlockTypes()
        {
            var stubBlockTypes = new[]
            {
                new LookupTypeDTO { Id = 1, Name = "Test 1", SortOrder = 1 },
                new LookupTypeDTO { Id = 2, Name = "Test 2", SortOrder = 2 },
                new LookupTypeDTO { Id = 3, Name = "Test 3", SortOrder = 3 },
                new LookupTypeDTO { Id = 4, Name = "Test 4", SortOrder = 4 },
                new LookupTypeDTO { Id = 5, Name = "Test 4", SortOrder = 5 },
                new LookupTypeDTO { Id = 6, Name = "Test 4", SortOrder = 6 },
            };

            return Task.FromResult(stubBlockTypes.AsEnumerable());
        }
    }
}