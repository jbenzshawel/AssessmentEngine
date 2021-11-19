using AssessmentEngine.Core.Common;
using Microsoft.Extensions.Options;
using Moq;

namespace AssessmentEngine.Core.UnitTests.Stubs
{
    public class StubEFTSettings
    {
        private static EFTSettings EFTSettings
            => new EFTSettings
            {
                SeriesSize = 7
            };

        public static IOptions<EFTSettings> Build()
        {
            var mockEftSettings = new Mock<IOptions<EFTSettings>>();
            mockEftSettings.Setup(x => x.Value).Returns(EFTSettings);

            return mockEftSettings.Object;
        }
    }
}