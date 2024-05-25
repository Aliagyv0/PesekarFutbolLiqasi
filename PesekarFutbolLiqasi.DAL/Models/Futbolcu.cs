using PesekarFutbolLiqasi.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeşəkarFutbolLiqası.DAL.Models
{
    public class Futbolcu:BaseEntity
    {
        public int FormaNomresi { get; set; }
        public string AdSoyad { get; set; }      
        public int AtdigiQolSayi { get; set; }
        public int KomandaId { get; set; }
        public  Komanda Komanda { get; set; }
    }

}
