using System;
using System.Collections.Generic;
using System.Linq;
using AssessmentEngine.Core.Abstraction;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace AssessmentEngine.Core.UnitTests.Builders
{
    public class MockDbContextBuilder
    {
        private readonly Dictionary<Type, object> _mockDbSets = new Dictionary<Type, object>();

        private readonly Mock<IApplicationDbContext> _mockDbContext;

        public MockDbContextBuilder()
        {
            _mockDbContext = new Mock<IApplicationDbContext>();
        }

        public Mock<DbSet<TEntity>> GetMockDbSet<TEntity>() where TEntity : class
        {
            if (_mockDbSets.ContainsKey(typeof(TEntity)))
            {
                return _mockDbSets[typeof(TEntity)] as Mock<DbSet<TEntity>>;
            }

            throw new Exception("TEntity does not have a mock DbSet");
        }


        public Mock<IApplicationDbContext> Build()
            => _mockDbContext;

        private DbSet<TEntity> BuildMockDbSet<TEntity>(IEnumerable<TEntity> sourceList) where TEntity : class
        {
            var queryable = sourceList.AsQueryable();

            var dbSet = new Mock<DbSet<TEntity>>();
            dbSet.As<IQueryable<TEntity>>().Setup(m => m.Provider).Returns(queryable.Provider);
            dbSet.As<IQueryable<TEntity>>().Setup(m => m.Expression).Returns(queryable.Expression);
            dbSet.As<IQueryable<TEntity>>().Setup(m => m.ElementType).Returns(queryable.ElementType);
            dbSet.As<IQueryable<TEntity>>().Setup(m => m.GetEnumerator()).Returns(() => queryable.GetEnumerator());
            dbSet.Setup(d => d.Add(It.IsAny<TEntity>())).Callback<TEntity>((s) => sourceList.Append(s));

            _mockDbSets.Add(typeof(TEntity), dbSet);

            return dbSet.Object;
        }
    }
}