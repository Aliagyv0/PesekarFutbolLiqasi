using PesakarFutbolLiqasi.BL.Services.Interfaces;
using PesakarFutbolLiqasi.BL.Services;
using PeşəkarFutbolLiqası.DAL.Models;
using PeşəkarFutbolLiqası.Management.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeşəkarFutbolLiqası.Management
{
    internal class OyunManagement : IGenericManagement<Oyun>
    {
        private readonly IGenericService<Oyun> _service;
        public OyunManagement()
        {
            _service = new GenericService<Oyun>();
        }
        //public int HefteNomresi { get; set; }
        //public int EvSahibiId { get; set; }
        //public int QonaqId { get; set; }
        //public int EvSahibiQolSayı { get; set; }
        //public int QonaqQolSayı { get; set; }
        //public Komanda EvSahibi { get; set; }
        //public Komanda Qonaq { get; set; }
        public void Add()
        {
            Console.WriteLine("HefteNomresini daxil edin");
            int HefteNomresi = int.Parse(Console.ReadLine());
            Console.WriteLine("EvSahibiId ni daxil edin");
            int EvSahibiId = int.Parse(Console.ReadLine());
            Console.WriteLine(" QonaqId ni daxil edin");
            int QonaqId = int.Parse(Console.ReadLine());
            Console.WriteLine("EvSahibiQolSayıni daxil edin");
            int EvSahibiQolSayı = int.Parse(Console.ReadLine());
            Console.WriteLine("QonaqQolSayıni daxil edin");
            int QonaqQolSayı = int.Parse(Console.ReadLine());
            Oyun oyun = new Oyun()
            {
                HefteNomresi = HefteNomresi,
                EvSahibiId = EvSahibiId,
                QonaqId = QonaqId,
                EvSahibiQolSayı = EvSahibiQolSayı,
                QonaqQolSayı = QonaqQolSayı,
                CreateDate = DateTime.Now,
            };
            _service.Add(oyun);
            Console.WriteLine("oyun Ugurla sisteme daxil edildi ");
        }

        public void Delete()
        {
            Console.WriteLine("Id ni daxil edin");
            int.TryParse(Console.ReadLine(), out int Id);
            _service.Delete(Id);
            Console.WriteLine("Ugurlu silinme");
        }

        public void GetAll(Func<Oyun, int>? expression)
       
        {
            var items = _service.GetAll();
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Id} " +
                    $"{item.HefteNomresi}+{item.EvSahibiId}" +
                    $" {item.QonaqId} {item.EvSahibiQolSayı} " +
                    $"{item.QonaqQolSayı}");
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
                $"{item.HefteNomresi}+{item.EvSahibiId}" +
                $" {item.QonaqId} {item.EvSahibiQolSayı} " +
                $"{item.QonaqQolSayı}");
            }
            else
            {
                Console.WriteLine("bele bir oyun sistemde yoxdur");
            }
        }

        public void Update()
        {
            Console.WriteLine("Id ni daxil edin");
            int.TryParse(Console.ReadLine(), out int Id);
            var oyun = _service.GetById(Id);
            if (oyun is not null)
            {
                Console.WriteLine("HefteNomresini daxil edin");
                int HefteNomresi = int.Parse(Console.ReadLine());
                Console.WriteLine("EvSahibiId ni daxil edin");
                int EvSahibiId = int.Parse(Console.ReadLine());
                Console.WriteLine(" QonaqId ni daxil edin");
                int QonaqId = int.Parse(Console.ReadLine());
                Console.WriteLine("EvSahibiQolSayıni daxil edin");
                int EvSahibiQolSayı = int.Parse(Console.ReadLine());
                Console.WriteLine("QonaqQolSayıni daxil edin");
                int QonaqQolSayı = int.Parse(Console.ReadLine());
                oyun.HefteNomresi = HefteNomresi;
                oyun.EvSahibiId = EvSahibiId;
                oyun.QonaqId = QonaqId;
                oyun.EvSahibiQolSayı = EvSahibiQolSayı;
                oyun.QonaqQolSayı = QonaqQolSayı;
                oyun.UpdateDate = DateTime.Now;

                _service.Update(oyun);
                Console.WriteLine("Oyun Ugurla update olundu ");
            }
            else
            {
                Console.WriteLine("bele oyun sistemde yoxdur");
            }
        }
    }
}
