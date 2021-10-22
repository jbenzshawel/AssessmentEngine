using System;
using System.Collections.Generic;
using System.Linq;
using AssessmentEngine.Core.Abstraction;
using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace AssessmentEngine.Infrastructure.Mapping.Implementation
{
    public class MapperAdapter : IMapperAdapter
    {
        private readonly MapperConfiguration _configuration;
        private readonly IMapper _mapper;

        public MapperAdapter(IEnumerable<Profile> profiles)
        {
            _configuration = new MapperConfiguration(cfg =>
            {
                foreach (var profile in profiles)
                {
                    cfg.AddProfile(profile);
                }
            });

            _mapper = _configuration.CreateMapper();
        }

        public void AssertConfigurationIsValid()
        {
            _mapper.ConfigurationProvider.AssertConfigurationIsValid();
        }

        public IQueryable<TDest> Map<TSource, TDest>(IQueryable<TSource> query)
            => query.ProjectTo<TDest>(_configuration);

        public TDest Map<TSource, TDest>(TSource source)
            =>  _mapper.Map<TSource, TDest>(source);

        public TDest Map<TSource, TDest>(TSource source, TDest destination)
            => _mapper.Map(source, destination);
        
        public TDest Map<TSource, TDest>(Func<TSource> func) 
            where TDest : new() where TSource : new()
            => _mapper.Map<TSource, TDest>(func());

        public void Map<TSource, TDest>(Action<TSource> action, TDest model)
            where TDest : new() where TSource : new()
        {
            var dto = _mapper.Map<TDest, TSource>(model);
            action(dto);
            _mapper.Map(dto, model);
        }
    }
}
