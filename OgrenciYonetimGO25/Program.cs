using System;
using System.Collections.Generic;

namespace OgrenciYonetimGO25
{
    class Program
    {

        static List<Ogrenci> Ogrenciler = new List<Ogrenci>(); // metod disinda olan her isimlendirme buyuk harfle baslar

        static void Main(string[] args)
        {
            SahteVeriGir();
            Uygulama();
        }
        static void Uygulama()
        {
            string secim;
            do
            {
                Console.WriteLine("ogrenci Yonetim uygulamasi" +
                "\n1- Ogrenci Ekle (E)" +
                "\n2- Ogrenci Listele (L)" +
                "\n3- Ogrenci Sil (S)" +
                "\n4- Cikis (X)");
                Console.Write("Seciminiz: ");
                secim = Console.ReadLine().ToUpper();

                switch (secim)
                {
                    case "E":
                        OgrenciEkle();
                        break;
                    case "L":
                        OgrenciListele();
                        break;
                    case "S":
                        OgrenciSil();
                        break;
                    case "X":
                        Console.WriteLine("Cikis yaptiniz");
                        break;                 
                    default:
                        Console.WriteLine("Gecerli bir deger girin");
                        break;
                }
            } while (secim != "X");            
        }
        static void OgrenciSil()
        {

        }
        static void OgrenciEkle()
        {
            Ogrenci o = new Ogrenci();
            Console.WriteLine("ogrenci Ekle ----------\nOgrencinin");
            Console.Write("No: ");
            o.No = int.Parse(Console.ReadLine());
            Console.Write("Adi: ");
            o.Ad = Console.ReadLine();
            Console.Write("Soyadi: ");
            o.Soyad = Console.ReadLine();
            Console.Write("Subesi: ");
            o.Sube = Console.ReadLine();
            
            Console.WriteLine("ogrenciyi katdetmek istediginize emin misiniz? (E/H)");

            string kaydediyimMi = Console.ReadLine().ToUpper();
            if (kaydediyimMi.Equals("E"))
            {
                Ogrenciler.Add(o);
                Console.WriteLine("Ogrenci Eklendi");
            }
            else if (kaydediyimMi.Equals("H"))
            {
                Console.WriteLine("Ogrenci Eklenmedi");
            }
            else
            {
                Console.WriteLine("Gecerli bir deger girin");
            }
        }
        static void OgrenciListele()
        {
            
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
