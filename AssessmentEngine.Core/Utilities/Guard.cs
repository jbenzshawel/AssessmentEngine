using System;

namespace AssessmentEngine.Core.Utilities
{
    // Due to bug in roslyn-analyzer: https://github.com/dotnet/roslyn-analyzers/issues/3451 
    [AttributeUsage(AttributeTargets.Parameter)]
    internal sealed class ValidatedNotNullAttribute : Attribute { }

    public static class Guard
    {
        /// <summary>
        /// Throws an <see cref="ArgumentNullException" /> if <paramref name="input" /> is null.
        /// </summary>
        /// <typeparam name="TClass"></typeparam>
        /// <param name="input"></param>
        /// <param name="parameterName"></param>
        /// <returns><paramref name="input" /> if the value is not null.</returns>
        public static TClass NotNull<TClass>([ValidatedNotNull] TClass input, string parameterName) where TClass : class
        {
            if (input is null)
            {
                throw new ArgumentNullException(parameterName);
            }

            return input;
        }

        /// <summary>
        /// Throws an <see cref="ArgumentNullException" /> if <paramref name="input" /> is null or empty.
        /// </summary>
        /// <typeparam name="TString"></typeparam>
        /// <param name="input"></param>
        /// <param name="parameterName"></param>
        /// <returns><paramref name="input" /> if the value is not null.</returns>
        public static TString NotNullOrEmpty<TString>([ValidatedNotNull] TString input, string parameterName) where TString : class
        {
            if (input is null || string.IsNullOrEmpty(input as string))
            {
                throw new ArgumentNullException(parameterName);
            }

            return input;
        }
    }
}