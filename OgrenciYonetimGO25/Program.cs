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
            Menu();
            
            while(true)
            {
                string secim = SecimAl();
                switch (secim)
                {
                    case "1":
                    case "E":
                        OgrenciEkle();
                        break;

                    case "2":
                    case "L":
                        OgrenciListele();
                        break;

                    case "3":
                    case "S":
                        OgrenciSil();
                        break;

                    case "4":
                    case "X":
                        Console.WriteLine("Cikis yaptiniz");
                        break;
                    default:
                        Console.WriteLine("Gecerli bir deger girin");
                        break;
                }
                if(secim == "X" || secim == "4")
                {
                    break;
                }
            }

        }
        static string SecimAl()
        {
            Console.Write("Seciminiz: ");
            string giris = Console.ReadLine().ToUpper();
            return giris;
        }
        static void Menu()
        {
            Console.WriteLine("ogrenci Yonetim uygulamasi" +
                "\n1- Ogrenci Ekle (E)" +
                "\n2- Ogrenci Listele (L)" +
                "\n3- Ogrenci Sil (S)" +
                "\n4- Cikis (X)");
            
        }
        static void OgrenciSil()
        {
            
            Console.WriteLine("3- Ogrenci sil ----------" +
                "\nSilmek istediginiz Ogrencinin");
            Console.Write("No: ");
            int no = int.Parse(Console.ReadLine());
            foreach (Ogrenci item in Ogrenciler)
            {
                if(item.No == no)
                {
                    Console.WriteLine("Adi: "+item.Ad
                        +"\nSoyadi: "+item.Soyad
                        +"\nSubesi: "+item.Sube);
                    Console.WriteLine("Ogrenciyi silmek istediginize emin misiniz (E/H)");
                    string secim;
                    while (true)
                    {
                        secim = Console.ReadLine().ToUpper();
                        if (secim == "E")
                        {
                            Ogrenciler.Remove(item);
                            Console.WriteLine("Ogrenci Silindi");
                            break;
                        }
                        else if(secim == "H")
                        {
                            Console.WriteLine("Ogrenci Silinmedi");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Gecerli bir deger girin");
                        }
                    }
                    break;
                }
            }
            

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
