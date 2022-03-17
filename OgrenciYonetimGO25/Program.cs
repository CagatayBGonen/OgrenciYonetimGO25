using System;
using System.Collections.Generic;

namespace OgrenciYonetimGO25
{
    class Program
    {

        static List<Ogrenci> Ogrenciler = new List<Ogrenci>(); // metod disinda olan her isimlendirme buyuk harfle baslar

        static void Main(string[] args)
        {
            OgrenciListele();
        }

        static void OgrenciListele()
        {
            SahteVeriGir();
            Console.WriteLine("Ogrenci Listele----------"+"\n"
                +"\nSube    No    Ad Soyad"+"\n----------------------------");
            foreach (Ogrenci item in Ogrenciler)
            {
                Console.WriteLine(item.Sube+"    "+item.No+"    "+item.Ad+" "+item.Soyad);
            }
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

            Ogrenci o3 = new Ogrenci();
            o3.Ad = "Ahmet";
            o3.Soyad = "Soluk";
            o3.Sube = "C";
            o3.No = 46;

            Ogrenciler.Add(o1);
            Ogrenciler.Add(o2);
            Ogrenciler.Add(o3);
        }
    }
}
