using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler_Baslangic
{
    class Program
    {
        static void Main(string[] args)
        {

            // Tekrar Ettirme

            //Console.WriteLine("Lütfen adınızı giriniz.");

            //string ad;

            //ad = Console.ReadLine();

            //Console.WriteLine("Lütfen Kaç kere tekrar etmeniz gerektiğini yazın");

            //int uzunluk;

            //uzunluk = int.Parse(Console.ReadLine());

            //Console.Clear();


            //for (int i = 0; i < uzunluk; i++)
            //{
            //    Console.WriteLine(ad);
            //}

            //


            // Kullanıcıdan girilen sayının 0 a kadar olan sayıların toplamı 
            //int input;

            //Console.WriteLine("Lütfen bir sayı giriniz");

            //input = int.Parse(Console.ReadLine());
            //int toplam=0;


            //for (int i = 0; i <= input; i++)
            //{


            //    toplam += i;
            //}

            //Console.WriteLine(toplam);


            // Faktöriyel

            //Console.WriteLine("Sayıyı Girin:");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int faktoriyel = 1;

            //for (int i = 1; i <= sayi; i++)
            //{
            //    faktoriyel = faktoriyel * i;
            //}

            //Console.WriteLine(faktoriyel);



            //Çarpım Tablosu 



            //for (int i = 0; i <= 10; i++)
            //{


            //    for (int j = 0; j <= 10; j++)
            //    {
            //        Console.Write("{0}*{1}={2}\t", i, j, (i * j));
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();


            //Yıldızlardan Piramit
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = i; j < 10; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}



            //0la 100 arasında 9 a bölünenleri listelere

            //int liste = 0;
            //Console.WriteLine("9'a tam bölünen liste:");
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 9 == 0)
            //    {
            //        Console.WriteLine(i);
            //        liste++;
            //    }
            //}



            //Bilinen sayının asal mı değil mi onu öğrenme

            //int check = 0; // Kontrol değeri
            //Console.Write("Sayı Girin : ");
            //int num = Convert.ToInt32(Console.ReadLine()); // parse

            //for (int i = 2; i < num; i++)
            //{
            //    if (num % i == 0) // 2 ye ve sıfıra bölünebilme
            //        check++; 
            //}

            //if (check != 0)
            //    Console.WriteLine("Girdiğiniz sayı asal değildir.");
            //else
            //    Console.WriteLine("Girdiğiniz sayı asaldır.");
            //Console.ReadKey();







            //While denemesi

            //int i = 1;

            //while (i < 11)
            //{
            //    Console.WriteLine("Merhaba");

            //    i++;
            //}



            //int sayı;
            //Console.WriteLine("Lütfen sayı giriniz.");
            //sayı = int.Parse(Console.ReadLine());

            //while (sayı % 2 == 0)
            //{


            //    Console.WriteLine("Devam et");

            //    sayı = int.Parse(Console.ReadLine());


            //}

            //Console.WriteLine("Dur");


            //Kullanıcı bir sayı girecek , girdiği sayıdan geriye doğru gidilecek


            //int input;

            //Console.WriteLine("giriş");
            //input = int.Parse(Console.ReadLine());


            //for (int i = input; i >= 0; i--)
            //{
            //    Console.WriteLine(i);
            //    System.Threading.Thread.Sleep(1000);
            //}

            //Console.WriteLine("Azaldı");

            //saniye belirleyerek belirli yerden başlama durma
           
            int deger;

            Console.WriteLine("Başlangıç saniyesi");

            deger = int.Parse(Console.ReadLine());

            int durma;

            Console.WriteLine("Durma saniyesi");

            durma = int.Parse(Console.ReadLine());

            for (int i = deger; i <= durma; i--)
            {
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(1000);
            }

            Console.ReadKey();
        }
    }
}

