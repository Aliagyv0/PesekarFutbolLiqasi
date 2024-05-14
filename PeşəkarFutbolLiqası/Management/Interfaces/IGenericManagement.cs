using PeşəkarFutbolLiqası.DAL.Models;
using PesekarFutbolLiqasi.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeşəkarFutbolLiqası.Management.Interfaces
{
    public interface IGenericManagement<T>
    {
        public void Add();
        public void Update();
        public void Delete();
        public void GetAll(Func<T, int>? expression);
        public void GetById();
    }
}
