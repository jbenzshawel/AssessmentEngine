using System;
using System.Threading.Tasks;

namespace AssessmentEngine.Core.Abstraction
{
    public interface ICacheProvider
    {
        void ClearCache();
        TObject Set<TObject>(string key, TObject item);
        TObject Get<TObject>(string key);
        Task<TObject> GetCachedItem<TObject>(string cacheKey, Func<Task<TObject>> getMethod);
        bool TryGetValue<TObject>(string key, out TObject cacheValue);
    }
}