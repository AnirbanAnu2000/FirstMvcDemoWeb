using FirstDemo.Base.DbContexts;
using FirstDemo.Base.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.Base.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly BaseDbContext _dbContext;
        protected DbSet<T> _dbSet;

        public Repository(BaseDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }
        public IList<T> GetAll(T tEntity)
        {
            return _dbSet.ToList();
        }

        public T GetById(int entityId)
        {
            return _dbSet.Find(entityId);
        }

        public void Insert(T tEntity)
        {
            _dbSet.Add(tEntity);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}