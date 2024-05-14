using PesekarFutbolLiqasi.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesakarFutbolLiqasi.BL.Services.Interfaces
{
    public interface IGenericService <T> where T : BaseEntity
    {
        public T Add(T entity);
        public void Update(T entity);
        public void Delete(int id);
        public IList<T> GetAll();
        public T GetById(int id);
    }
}
