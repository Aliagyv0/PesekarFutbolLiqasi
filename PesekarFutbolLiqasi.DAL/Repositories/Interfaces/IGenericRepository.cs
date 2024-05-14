using PesekarFutbolLiqasi.DAL.Models;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesekarFutbolLiqasi.DAL.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T  : BaseEntity
    {
        public T Add(T entity);
        public void Update(T entity);
        public void Delete(int id);
        public IList<T> GetAll();
        public T GetById(int id);
    }
}
