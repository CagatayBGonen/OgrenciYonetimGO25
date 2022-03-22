using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciYonetimGO25
{
    //sablon
    class Ogrenci
    {
        public int No;
        public string Ad;
        public string Soyad;
        public string Sube;
        //classlara ayit verileri gunceleyebilecegimiz ve
        //classlara ayit verilerden yeni veri tureyebilecegimiz metodlar kullanicaz.

        public int DogumYili;
        public int Yas()
        {
            return DateTime.Now.Year - DogumYili;
        }
    }
}
