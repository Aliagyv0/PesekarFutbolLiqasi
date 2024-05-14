using PesekarFutbolLiqasi.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeşəkarFutbolLiqası.DAL.Models
{
    public class Oyun:BaseEntity
    {
        public int HefteNomresi { get; set; }
        public int EvSahibiId { get; set; }
        public int QonaqId{ get; set; }
        public int EvSahibiQolSayı { get; set; }
        public int QonaqQolSayı { get; set; }
        public virtual Komanda EvSahibi {  get; set; }
        public virtual Komanda Qonaq {  get; set; }


    }
}
