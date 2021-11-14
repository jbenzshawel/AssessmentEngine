using System;
using System.Text;
using AssessmentEngine.Core.Common;
using AssessmentEngine.Core.Services.Abstraction;
using Microsoft.Extensions.Options;

namespace AssessmentEngine.Core.Services.Implementation
{
    public class RandomService : IRandomService
    {
        private readonly EFTSettings _eftSettings;

        public RandomService(IOptions<EFTSettings> eftSettings)
        {
            _eftSettings = eftSettings.Value;
        }

        public string GetRandomSeries()
        {
            var stringBuilder = new StringBuilder();

            for (var i = 1; i <= _eftSettings.SeriesSize; i++)
            {
                stringBuilder.Append(new Random().Next(1, 10));
            }

            return stringBuilder.ToString();
        }
    }
}