using PesakarFutbolLiqasi.BL.Services;
using PesakarFutbolLiqasi.BL.Services.Interfaces;
using PeşəkarFutbolLiqası.DAL.Models;
using PeşəkarFutbolLiqası.Management.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeşəkarFutbolLiqası.Management
{
    internal class KomandaManagement : IGenericManagement<Komanda>
    {
        

        private readonly IGenericService<Komanda> _service;
        public KomandaManagement()
        {
                _service=new GenericService <Komanda>();
        }
        public void Add()
        {
            Console.WriteLine("Komanda adini daxil edin");
            string komandaAdi = Console.ReadLine();
            Console.WriteLine("QaliblikSayini daxil edin");
            int QaliblikSay = int.Parse(Console.ReadLine());
            Console.WriteLine(" BeraberlikSayini daxil edin");
            int BeraberlikSay = int.Parse(Console.ReadLine());
            Console.WriteLine("MeglubiyyetSayini daxil edin");
            int MeglubiyyetSay = int.Parse(Console.ReadLine());
            Console.WriteLine("AtdigiQolSayini daxil edin");
            int AtdigiQolSay = int.Parse(Console.ReadLine());
            Console.WriteLine("YediyiQolSayini daxil edin");
            int YediyiQolSay = int.Parse(Console.ReadLine());
            Komanda komanda = new Komanda()
            {
                KomandaAdi = komandaAdi,
                QaliblikSayi = QaliblikSay,
                BeraberlikSayi = BeraberlikSay,
                MeglubiyyetSayi = MeglubiyyetSay,
                AtdigiQolSayi = AtdigiQolSay,
                YediyiQolSayi = YediyiQolSay,
                CreateDate = DateTime.Now,
            };
            _service.Add(komanda);
            Console.WriteLine("Komanda Ugurla sisteme daxil edildi ");
        }

        public void Delete()
        {
            Console.WriteLine("Id ni daxil edin");
            int.TryParse(Console.ReadLine(), out int Id);
            _service.Delete(Id);
            Console.WriteLine("Ugurlu silinme");
        }

        public void GetAll(Func<Komanda, int>? expression)
        {
           var items= _service.GetAll();
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Id} " +
                    $"{item.KomandaAdi}+{item.QaliblikSayi}" +
                    $" {item.BeraberlikSayi} {item.MeglubiyyetSayi} " +
                    $"{item.AtdigiQolSayi} {item.YediyiQolSayi} ");
            }
        }

        public void GetById()
        {
            Console.WriteLine("Id ni daxil edin");
            int.TryParse(Console.ReadLine(), out int Id);
           var item = _service.GetById(Id);
            if (item is not null)
            {
                Console.WriteLine($"{item.Id} " +
                   $"{item.KomandaAdi}+{item.QaliblikSayi}" +
                   $" {item.BeraberlikSayi} {item.MeglubiyyetSayi} " +
                   $"{item.AtdigiQolSayi} {item.YediyiQolSayi} ");
            }
            else
            {
                Console.WriteLine("bele bir komanda sistemde yoxdur");
            }
            
        }

        public void Update()
        {
            Console.WriteLine("Id ni daxil edin");
            int.TryParse(Console.ReadLine(), out int Id);
          var komanda=_service.GetById(Id);
            if (komanda is not null)
            {
                Console.WriteLine("Komanda adini daxil edin");
                string komandaAdi = Console.ReadLine();
                Console.WriteLine("QaliblikSayini daxil edin");
                int QaliblikSay = int.Parse(Console.ReadLine());
                Console.WriteLine(" BeraberlikSayini daxil edin");
                int BeraberlikSay = int.Parse(Console.ReadLine());
                Console.WriteLine("MeglubiyyetSayini daxil edin");
                int MeglubiyyetSay = int.Parse(Console.ReadLine());
                Console.WriteLine("AtdigiQolSayini daxil edin");
                int AtdigiQolSay = int.Parse(Console.ReadLine());
                Console.WriteLine("YediyiQolSayini daxil edin");
                int YediyiQolSay = int.Parse(Console.ReadLine());
                komanda.KomandaAdi = komandaAdi;
                komanda.QaliblikSayi = QaliblikSay;
                komanda.BeraberlikSayi = BeraberlikSay;
                komanda.MeglubiyyetSayi = MeglubiyyetSay;
                komanda.AtdigiQolSayi = AtdigiQolSay;
                komanda.YediyiQolSayi = YediyiQolSay;
                komanda.UpdateDate = DateTime.Now;

                _service.Update(komanda);
                Console.WriteLine("Komanda Ugurla update olundu ");
            }
            else
            {
                Console.WriteLine("bele komanda sistemde yoxdur");
            }
        }
    }
}
