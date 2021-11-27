using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentEngine.Core.BlockVersions.Implementation;
using AssessmentEngine.Core.DTO;
using AssessmentEngine.Core.Services.Abstraction;
using AssessmentEngine.Domain.Enums;
using Moq;
using Xunit;

namespace AssessmentEngine.Core.UnitTests.BlockVersions
{
    public class VetFlexIIBlockVersionStrategyTests
    {
        [Fact]
        public async Task Generate_ShouldNotSetCognitiveLoadForBlockTypes()
        {
            // arrange
            var lookupService = BuildLookupService();
            var vetFlexBlockVersionStrategy = new VetFlexIIBlockVersionStrategy(lookupService.Object);

            // act
            var blockTypes = await vetFlexBlockVersionStrategy.Generate();
            
            // assert
            Assert.True(blockTypes.All(x => !x.CognitiveLoad && string.IsNullOrEmpty(x.Series)));
        }

        [Fact]
        public async Task Generate_ShouldSetUidForAllBlockTypes()
        {
            // arrange
            var lookupService = BuildLookupService();
            var vetFlexBlockVersionStrategy = new VetFlexIIBlockVersionStrategy(lookupService.Object);

            // act
            var blockTypes = await vetFlexBlockVersionStrategy.Generate();
            
            // assert
            Assert.True(blockTypes.All(x => x.Uid != Guid.Empty));
        }
        
        [Fact]
        public async Task Generate_ShouldOnlyHaveVersionOneInFirstSixBlocks()
        {
            // arrange
            var lookupService = BuildLookupService();
            var vetFlexBlockVersionStrategy = new VetFlexIIBlockVersionStrategy(lookupService.Object);

            // act
            var blockTypes = await vetFlexBlockVersionStrategy.Generate();
            
            // assert
            Assert.True(blockTypes.Take(6).All(x =>
                GetBlockVersionNumber((BlockTypes)x.BlockTypeId) == '1'));
        }
        
        [Fact]
        public async Task Generate_ShouldOnlyHaveVersionTwoInLastSixBlocks()
        {
            // arrange
            var lookupService = BuildLookupService();
            var vetFlexBlockVersionStrategy = new VetFlexIIBlockVersionStrategy(lookupService.Object);

            // act
            var blockTypes = await vetFlexBlockVersionStrategy.Generate();
            
            // assert
            Assert.True(blockTypes.Skip(6).Take(6).All(x =>
                GetBlockVersionNumber((BlockTypes)x.BlockTypeId) == '2'));
        }

        private Char GetBlockVersionNumber(BlockTypes blockType)
            => blockType.ToString().Last();
        private Mock<ILookupService> BuildLookupService()
        {
            var lookupService = new Mock<ILookupService>();

            lookupService.Setup(m => 
                    m.BlockTypes(It.Is<AssessmentTypes>(p => p == AssessmentTypes.VetFlexII)))
                .Returns(GetStubBlockTypes());

            return lookupService;
        }

        private Task<IEnumerable<LookupTypeDTO>> GetStubBlockTypes()
        {
            var stubBlockTypes = new[]
            {
                new LookupTypeDTO { Id = (int)BlockTypes.EP1, Name = "EN1", SortOrder = 1 },
                new LookupTypeDTO { Id = (int)BlockTypes.EP2, Name = "EP2", SortOrder = 2 },
                new LookupTypeDTO { Id = (int)BlockTypes.EN1, Name = "EN1", SortOrder = 3 },
                new LookupTypeDTO { Id = (int)BlockTypes.EN2, Name = "EN2", SortOrder = 4 },
                new LookupTypeDTO { Id = (int)BlockTypes.SP1, Name = "SP1", SortOrder = 5 },
                new LookupTypeDTO { Id = (int)BlockTypes.SP2, Name = "SP2", SortOrder = 6 },
                new LookupTypeDTO { Id = (int)BlockTypes.SN1, Name = "SN1", SortOrder = 7 },
                new LookupTypeDTO { Id = (int)BlockTypes.SN2, Name = "SN2", SortOrder = 8 },
                new LookupTypeDTO { Id = (int)BlockTypes.VP1, Name = "VP1", SortOrder = 9 },
                new LookupTypeDTO { Id = (int)BlockTypes.VP2, Name = "VP2", SortOrder = 10 },
                new LookupTypeDTO { Id = (int)BlockTypes.VN1, Name = "VN1", SortOrder = 11 },
                new LookupTypeDTO { Id = (int)BlockTypes.VN2, Name = "VN2", SortOrder = 12 },
            };

            return Task.FromResult(stubBlockTypes.AsEnumerable());
        }
    }
}