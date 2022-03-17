using System;
using System.Collections.Generic;

namespace OgrenciYonetimGO25
{
    class Program
    {

        static List<Ogrenci> Ogrenciler = new List<Ogrenci>(); // metod disinda olan her isimlendirme buyuk harfle baslar

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void Ogrenciyazdir()
        {




        }
        static void SahteVeriGir()
        {
            Ogrenci o1 = new Ogrenci();
            o1.Ad = "Cagatay";
            o1.Soyad = "Yilmaz";
            o1.Sube = "A";
            o1.No = 10;

            Ogrenci o2 = new Ogrenci();
            o2.Ad = "Sude";
            o2.Soyad = "korkmaz";
            o2.Sube = "B";
            o2.No = 23;


            Ogrenciler.Add(o1);
            Ogrenciler.Add(o2);
        }
    }
}
