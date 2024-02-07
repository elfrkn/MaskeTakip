using System;

namespace WorkAround
{
    class Program
    {
        static void Main(string[] args)
        {
            Selamver();
            Selamver();
            Selamver();
            int sonuc=Topla();
            Console.ReadLine();

        }

        static void Selamver()
        {
            Console.WriteLine("Merhaba");
        }

        static int Topla()
        {
            return 5;
        }
    }
}


