using PesekarFutbolLiqasi.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeşəkarFutbolLiqası.DAL.Models
{
    public class Komanda:BaseEntity
    {
        public string KomandaAdi { get; set; }
        public int QaliblikSayi { get; set; }
        public int BeraberlikSayi { get; set; }
        public int MeglubiyyetSayi { get; set; }
        public int AtdigiQolSayi { get; set; }
        public int YediyiQolSayi { get; set; }
        public virtual List <Futbolcu> Futbolcular {  get; set; }
       
    }
}
