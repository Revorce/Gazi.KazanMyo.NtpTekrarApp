using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciLib
{
    public class Ogrenci
    {
        public string ad;
        public string soyad;
        public string telno;
        public byte yas;
        string basaridurum;//Field
        double ortalama;//Field

        public string Basaridurum { get => basaridurum; }//(Readonly) Property
        public double Ortalama//Property
        {
            get
            {
                return Ortalama;
            }
            set
            {
                ortalama = value;
                if (value > 2)
                {
                    basaridurum = "Başarılı";
                }
                else
                {
                    basaridurum = "Başarısız";
                }
            }
        }
    }
}
