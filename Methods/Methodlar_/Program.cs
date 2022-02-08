using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodlar_
{
    class Program
    {
        public static void HesapMakinesi()
        {

            Console.WriteLine("Welcome Sir!!!");
            string symbol;

            double sayı;
            double sayı2;

           

            Console.WriteLine("Please enter the symbol for which you would like the expression");

            symbol = Console.ReadLine();

            if (symbol == "+")
            {
                Console.WriteLine("Type the numbers");

                sayı = int.Parse(Console.ReadLine());
                sayı2 = int.Parse(Console.ReadLine());

                Console.WriteLine(sayı + sayı2 );
            }

            else if (symbol == "-")
            {
                Console.WriteLine("Type the numbers");

                sayı = int.Parse(Console.ReadLine());
                sayı2 = int.Parse(Console.ReadLine());

                Console.WriteLine(sayı - sayı2 );
            }

            else if (symbol == "*")
            {
                Console.WriteLine("Type the numbers");

                sayı = int.Parse(Console.ReadLine());
                sayı2 = int.Parse(Console.ReadLine());

                Console.WriteLine(sayı * sayı2 );
            }

            else if (symbol == "/")
            {
                Console.WriteLine("Type the numbers");

                sayı = int.Parse(Console.ReadLine());
                sayı2 = int.Parse(Console.ReadLine());

                Console.WriteLine(sayı / sayı2);
            }

            else
            {
                Console.WriteLine("Wrong input");
            }

        }
        public static void HelloWorld()
        {
            Console.WriteLine("Yarabbi Şükür");
        }

        public static void SayıHesaplama()
        {
            int[] sayılar = new int[5];


            for (int i = 0; i < sayılar.Length; i++)
            {
                Console.WriteLine("Lütfen bir sayı giriniz:");

                sayılar[i] = int.Parse(Console.ReadLine());


            }

            foreach (var item in sayılar)
            {
                Console.WriteLine(item);
            }

            

        }

        public static void AlanHesaplama()
        {
            int a;
            int b;
            int alan;

            Console.WriteLine("Lütfen kısa kenarı girin:");

            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen uzun kenarı girin:");

            b = Convert.ToInt32(Console.ReadLine());

            alan = a * b;

            Console.WriteLine(alan);
        }


        static void Main(string[] args)
        {
            //AlanHesaplama();

            // SayıHesaplama();

            HesapMakinesi();

            Console.Read();
        }
    }
}
