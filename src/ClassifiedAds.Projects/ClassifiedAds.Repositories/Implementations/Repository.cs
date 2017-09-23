using ClassifiedAds.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ClassifiedAds.Repositories.Implementations
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AdsDbContext _dbContext;

        public Repository(AdsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<T> DbSet => _dbContext.Set<T>();

        public IQueryable<T> GetAll()
        {
            return _dbContext.Set<T>();
        }
    }
}
