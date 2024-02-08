using System;

namespace WorkAround
{
    class Program
    {
        static void Main(string[] args)
        {
            Selamver(isim:"Elif");
            Selamver(isim:"Furkan");
            Selamver(isim:"Selim");
            Selamver(isim:"Hamza");
            Selamver();
            Topla(3,5);

            //Array-Diziler

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Elif";
            ogrenciler[1] = "Furkan";
            ogrenciler[2] = "Selim";
            ogrenciler = new string[4];
            ogrenciler[3] = "Hamza";
            for(int i=0; i<ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "Istanbul", "Izmir" };
            string[] sehirler2 = new[] { "Bursa", "Bolu", "Sakarya" };
            foreach(string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            List<string> yenisehirler1=new List<string> { "Adana", "Urfa", "Manisa" };
            yenisehirler1.Add("Gaziantep");
            foreach(string sehir in yenisehirler1)
            {
                Console.WriteLine(sehir);
            }


            Console.ReadLine();

        }

        static void Selamver(string isim="isimsiz")
        {
            Console.WriteLine("Merhaba" + isim);
        }

        static int Topla(int sayi1,int sayi2)
        {
            int sonuc= sayi1 + sayi2;
            Console.WriteLine("toplam= " + sonuc);
            return sonuc;
        }
    }
}


