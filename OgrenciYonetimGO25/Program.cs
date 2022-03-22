using System;
using System.Collections.Generic;

namespace OgrenciYonetimGO25
{
    class Program
    {
        //Cagatay B Gonen
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
                        return;                   
                }
                                
            }

        }
        static string SecimAl()
        {
            string giris;
            int hataliGirisSayisi = 0;
            while (true)
            {
                Console.Write("Seciminiz: ");
                giris = Console.ReadLine().ToUpper();
                if (giris != "1" && giris != "E" && giris != "2" && giris != "L" && giris != "3" && giris != "S" && giris != "4" && giris != "X")
                {
                    
                    Console.WriteLine("Hatali giris yapildi.");
                    hataliGirisSayisi++;
                    if(hataliGirisSayisi >= 10)
                    {
                        Console.WriteLine("Uzgunum sizi anlayamiyorum. Program sonlandiriliyor.");
                        giris = "X";
                        break;
                    }

                }
                else
                {
                    break;
                }
            }           
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

            Console.WriteLine("3- Öğrenci Sil-----------");
            bool ogrenciVarMi = Ogrenciler.Count != 0;
            if (ogrenciVarMi)
            {
                Console.WriteLine("Silmek istediğiniz öğrencinin");
                Console.Write("No: ");
                int no = int.Parse(Console.ReadLine());

                Ogrenci o = null;

                foreach (Ogrenci x in Ogrenciler)
                {
                    if (x.No == no)
                    {
                        o = x;
                        break;
                    }
                }

                if (o != null)
                {
                    Console.WriteLine("Adı: " + o.Ad);
                    Console.WriteLine("Soyadı: " + o.Soyad);
                    Console.WriteLine("Şubesi: " + o.Sube);
                    Console.WriteLine();
                    Console.WriteLine("Öğrenciyi silmek istediğinize emin misiniz? (E/H)");
                    string secim = Console.ReadLine().ToUpper();

                    if (secim == "E")
                    {
                        Ogrenciler.Remove(o);
                        Console.WriteLine("Öğrenci silindi.");
                    }
                    else
                    {
                        Console.WriteLine("Öğrenci silinmedi.");
                    }
                }
                else
                {
                    Console.WriteLine("Bu numarada bir öğrenci bulunamadı.");
                }
            }
            else
            {
                Console.WriteLine("Listede silinecek ogrenci yok.");
            }
            


        }
        static void OgrenciEkle()
        {
            Ogrenci o = new Ogrenci();
            Console.WriteLine("ogrenci Ekle ----------" +
                "\n"+ (Ogrenciler.Count+1) +". Ogrencinin");
            while (true)
            {
                bool noVarMi = false;
                Console.Write("No: ");
                int no = int.Parse(Console.ReadLine());
                foreach (Ogrenci item in Ogrenciler)
                {
                    if(item.No == no)
                    {
                        Console.WriteLine("No zaten var. Baska bir No girin.");
                        noVarMi = true;
                        break;
                    }                    
                    
                }
                if(!noVarMi)
                {
                    o.No = no;
                    break;
                }                               
            }
            
            Console.Write("Adi: ");
            string ad = Console.ReadLine().ToLower();
            o.Ad = ad.Substring(0,1).ToUpper()+ad.Substring(1);
            Console.Write("Soyadi: ");
            string soyad = Console.ReadLine().ToLower();
            o.Soyad = soyad.Substring(0, 1).ToUpper() + soyad.Substring(1);
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
            bool ogrenciVarMi = Ogrenciler.Count != 0;
            if (ogrenciVarMi)
            {
                Console.WriteLine("Ogrenci Listele----------" + "\n"
                + "\nSube".PadRight(10) + "No".PadRight(10) + "Ad Soyad" + "\n----------------------------");
                foreach (Ogrenci item in Ogrenciler)
                {
                    Console.WriteLine(item.Sube.PadRight(9) + item.No.ToString().PadRight(10) + item.Ad + " " + item.Soyad);
                }
            }
            else
            {
                Console.WriteLine("Gosterilecek ogrenci yok.");
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
