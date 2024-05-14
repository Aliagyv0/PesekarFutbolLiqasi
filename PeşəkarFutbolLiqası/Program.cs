using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using PeşəkarFutbolLiqası.Management;

namespace PeşəkarFutbolLiqası
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool opration = true;
            FutbolcuManagement futbolcuManagement = new();
            KomandaManagement komandaManagement = new();
            OyunManagement oyunManagement = new();
            
            
            while (true)
            {
                Console.WriteLine("Menyu:");
                Console.WriteLine("1.Bitmis oyunun neticeleri");
                Console.WriteLine("2. Bir komandanın cari veziyyetinin ve futbolçularının siyahılanması");
                Console.WriteLine("3. Puan cedvelinin sıralanması");
                Console.WriteLine("4. En çox qol atan ve en çox qol yiyen komandaların sıralanması");
                Console.WriteLine("5. Liqde en çox qol atan futbolçunun sıralanması");
                Console.WriteLine("0. Çıxış");
                Console.WriteLine("Seçiminizi daxil edin:");

                int secim = int.Parse(Console.ReadLine());
               
                switch (secim)
                {
                    case 1:
                        // Bitmiş oyuna dair nəticələrin daxil edilməsi funksiyası
                  
                        break;
                    case 2:
                        // Bir komandanın cari vəziyyətinin və futbolçularının siyahılanması funksiyası
                        
                        break;
                    case 3:
                        // Puan cədvəlinin sıralanması funksiyası
                        
                        break;
                    case 4:
                        // Ən çox qol atan və ən çox qol yiyən komandaların sıralanması funksiyası
                       
                        break;
                    case 5:
                        // Liqdə ən çox qol atan futbolçunun sıralanması funksiyası
                        Console.WriteLine("Komanda Adı      Forma No        Ad Soyad       AQ");
                        Console.WriteLine("------------------------------------------------------");
                        futbolcuManagement.GetAll(f=>-f.AtdigiQolSayi);

                        break;
                    case 6:
                       
                        break;
                    default:
                        Console.WriteLine("Yanlış seçim!");
                        break;
                }
            }
        }
    }
}

