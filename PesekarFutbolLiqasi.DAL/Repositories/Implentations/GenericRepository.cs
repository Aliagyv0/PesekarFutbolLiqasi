using Microsoft.EntityFrameworkCore;
using PesekarFutbolLiqasi.DAL.Context;
using PesekarFutbolLiqasi.DAL.Models;
using PesekarFutbolLiqasi.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesekarFutbolLiqasi.DAL.Repositories.Implentations
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly FutbolDbContext _dbContext;
        private readonly DbSet<T> _dbSet;
        public GenericRepository()
        {
            _dbContext = new FutbolDbContext();
            _dbSet = _dbContext.Set<T>();
        }

        public T Add(T entity)
        {
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public void Delete(int id)
        {
            var entity = GetById(id);

            if (entity != null)
            {
                _dbSet.Remove(entity);
                _dbContext.SaveChanges();
            }
        }

        public IList<T> GetAll()
        {
           return _dbSet.AsNoTracking().ToList();

        }

        public T GetById(int id)
        {
          return  _dbSet.Find(id);
           
        }

        public void Update(T entity)
        {        
            _dbContext.Update(entity);
            _dbContext.SaveChanges();
        }
    }
}
