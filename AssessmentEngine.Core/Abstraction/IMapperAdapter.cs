using System;
using System.Linq;

namespace AssessmentEngine.Core.Abstraction
{
    public interface IMapperAdapter
    {
        void AssertConfigurationIsValid();
        IQueryable<TDest> Map<TSource, TDest>(IQueryable<TSource> query);
        TDest Map<TSource, TDest>(TSource source);
        TDest Map<TSource, TDest>(TSource source, TDest destination);
        TDest Map<TSource, TDest>(Func<TSource> func) where TDest : new() where TSource : new();
        void  Map<TSource, TDest>(Action<TSource> action, TDest model) where TDest : new() where TSource : new();
    }
}