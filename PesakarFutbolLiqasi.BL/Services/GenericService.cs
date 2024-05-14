using PesakarFutbolLiqasi.BL.Services.Interfaces;
using PesekarFutbolLiqasi.DAL.Models;
using PesekarFutbolLiqasi.DAL.Repositories.Implentations;
using PesekarFutbolLiqasi.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesakarFutbolLiqasi.BL.Services
{
    public class GenericService<T> : IGenericService<T> where T : BaseEntity
    {
        private readonly IGenericRepository<T> _repository;
        public GenericService() 
        {
            _repository = new GenericRepository<T>();
        }
        public T Add(T entity)
        {
            return _repository.Add(entity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public IList<T> GetAll()
        {
            return _repository.GetAll();
        }

        public T GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Update(T entity)
        {
            _repository.Update(entity);
        }
    }
}
