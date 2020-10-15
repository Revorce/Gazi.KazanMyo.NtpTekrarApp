using OgrenciLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazi.KazanMyo.NtpTekrarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.ad = "Berkay";
            ogrenci.soyad = "Sezgin";
            ogrenci.telno = "05457345711";
            ogrenci.yas = 20;
            ogrenci.Ortalama = 3;
            //Ortalama 2'den büyükse, basşarılı değilse başarısız yazsın

            // ogrenci.Basaridurum = "basarili";//set
            Console.WriteLine(ogrenci.Basaridurum);//get
            Console.ReadKey();
        }
    }
    
   
}
