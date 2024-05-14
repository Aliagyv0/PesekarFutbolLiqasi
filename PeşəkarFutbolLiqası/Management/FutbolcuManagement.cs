using PesakarFutbolLiqasi.BL.Services;
using PesakarFutbolLiqasi.BL.Services.Interfaces;
using PeşəkarFutbolLiqası.DAL.Models;
using PeşəkarFutbolLiqası.Management.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PeşəkarFutbolLiqası.Management
{
    internal class FutbolcuManagement : IGenericManagement <Futbolcu>
    {

        //public int FormaNomresi { get; set; }
        //public string AdSoyad { get; set; }
        //public int AtdigiQolSayi { get; set; }
        //public int KomandaId { get; set; }
        //public Komanda Komanda { get; set; }
        private readonly IGenericService<Futbolcu> _service;
        public FutbolcuManagement()
        {
            _service =new GenericService<Futbolcu>();
        }
        public void Add()
        {

            Console.WriteLine("Forma nomresini daxil edin");
            int.TryParse(Console.ReadLine(), out int formaNumber);
            if (formaNumber>100|| formaNumber<1)
            {
                Console.WriteLine("bu futbolcu nomresi sisteme daxil edile bilmez");
                return;
            }
            
            Console.WriteLine("Ad ve Soyadi daxil edin");
          string NameSurname = Console.ReadLine();
            Console.WriteLine("AtdigiQolSayini daxil edin");
            int AtdigiQolSay = int.Parse(Console.ReadLine());
            Console.WriteLine("KomandaId ni daxil edin");
            int KomandaId = int.Parse(Console.ReadLine());
            Futbolcu futbolcu = new Futbolcu()

            {
                FormaNomresi = formaNumber,
                AdSoyad = NameSurname,              
                AtdigiQolSayi = AtdigiQolSay,
                KomandaId=KomandaId,
                CreateDate = DateTime.Now,
            };
            _service.Add(futbolcu);
            Console.WriteLine("Futbolcu Ugurla sisteme daxil edildi ");
        }

        public void Delete()
        {
            Console.WriteLine("Id ni daxil edin");
            int.TryParse(Console.ReadLine(), out int Id);
            _service.Delete(Id);
            Console.WriteLine("Ugurlu silinme");
        }

        public void GetAll(Func<Futbolcu, int>? expression)
        {
            var items = _service.GetAll();
            foreach (var item in items.OrderBy(expression))
            {
                Console.WriteLine($"{item.Komanda.KomandaAdi}             " +
                    $"{item.FormaNomresi}              {item.AdSoyad}" +
                    $"  {item.AtdigiQolSayi}");
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
                   $"{item.FormaNomresi}+{item.AdSoyad}" +
                   $" {item.AtdigiQolSayi}");
            }
            else
            {
                Console.WriteLine("bele bir futbolcu sistemde yoxdur");
            }
        }

        public void Update()
        {
            Console.WriteLine("Id ni daxil edin");
            int.TryParse(Console.ReadLine(), out int Id);
            var futbolcu = _service.GetById(Id);
            if (futbolcu is not null)
            {
                Console.WriteLine("Forma nomresini daxil edin");
                int.TryParse(Console.ReadLine(), out int formaNumber);
                if (formaNumber > 100 || formaNumber < 1)
                {
                    Console.WriteLine("bu futbolcu nomresi sisteme daxil edile bilmez");
                    return;
                }

                Console.WriteLine("Ad ve Soyadi daxil edin");
                string NameSurname = Console.ReadLine();
                Console.WriteLine("AtdigiQolSayini daxil edin");
                int AtdigiQolSay = int.Parse(Console.ReadLine());
                Console.WriteLine("KomandaId ni daxil edin");
                int KomandaId = int.Parse(Console.ReadLine());
              
                futbolcu.AdSoyad = NameSurname;
                futbolcu.FormaNomresi = formaNumber;
                futbolcu.AtdigiQolSayi = AtdigiQolSay;
                futbolcu.KomandaId = KomandaId; 
                futbolcu.UpdateDate = DateTime.Now;

                _service.Update(futbolcu);
                Console.WriteLine("Futbolcu Ugurla update olundu ");
            }
            else
            {
                Console.WriteLine("bele Futbolcu sistemde yoxdur");
            }
        }
    }
}
