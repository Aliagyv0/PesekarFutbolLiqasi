using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeşəkarFutbolLiqası.Management.Interfaces
{
    public interface IGenericManagement
    {
        public void Add();
        public void Update();
        public void Delete();
        public void GetAll();
        public void GetById();
    }
}
