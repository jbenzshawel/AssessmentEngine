using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AssessmentEngine.Core.Abstraction;
using AssessmentEngine.Core.Utilities;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;

namespace AssessmentEngine.Infrastructure.Providers
{
    public class CacheProvider : ICacheProvider
    {
        private readonly IMemoryCache _cache;
        private readonly ILogger<CacheProvider> _logger;

        // TODO: Move to config
        private const int SlidingExpirationMinutes = 15;
        private const int MaxExpirationMinutes = 120;

        private static IList<string> CacheKeys { get; } = new List<string>();

        public CacheProvider(IMemoryCache cache, ILogger<CacheProvider> logger)
        {
            _cache = cache;
            _logger = logger;
        }

        public void ClearCache()
        {
            foreach (var key in CacheKeys)
            {
                _cache.Remove(key);
            }

            _logger.LogInformation("Cache cleared");

        }

        public TObject Set<TObject>(string key, TObject item)
        {
            var cacheEntryOptions = new MemoryCacheEntryOptions()
                .SetSlidingExpiration(TimeSpan.FromMinutes(SlidingExpirationMinutes))
                .SetAbsoluteExpiration(TimeSpan.FromMinutes(MaxExpirationMinutes));

            _cache.Set(key, item, cacheEntryOptions);

            AddCacheKey(key);

            _logger.LogInformation($"Cached item with key {key} created");

            return item;
        }

        public bool TryGetValue<TObject>(string key, out TObject cacheValue)
        {
            if (_cache.TryGetValue(key, out TObject cacheEntry))
            {
                cacheValue = cacheEntry;

                return true;
            }

            cacheValue = default(TObject);

            return false;
        }

        public TObject Get<TObject>(string key)
            => _cache.TryGetValue(key, out TObject cacheEntry)
             ? cacheEntry
             : default(TObject);

        public async Task<TObject> GetCachedItem<TObject>(string cacheKey, Func<Task<TObject>> getMethod)
        {
            Guard.NotNull(getMethod, nameof(getMethod));

            if (_cache.TryGetValue(cacheKey, out TObject cacheEntry))
            {
                return cacheEntry;
            }

            TObject item = await getMethod();

            Set(cacheKey, item);

            return item;
        }

        private void AddCacheKey(string key)
        {
            if (CacheKeys.Contains(key))
            {
                return;
            }

            CacheKeys.Add(key);
        }

        private void RemoveCacheKey(string key)
        {
            if (CacheKeys.Contains(key))
            {
                return;
            }

            CacheKeys.Add(key);
        }
    }
}