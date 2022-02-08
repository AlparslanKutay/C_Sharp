using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] weekDays2 = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            //foreach (var item in weekDays2)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] sayilar = { 0, 1, 2, 3, 4, 5 };

            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(sayilar[2]);
            //}

            //string[] ogrenciler = { "Ali", "Ahmet", "Fatma", "Hayriye" };

            //foreach (var item in ogrenciler)
            //{
            //    Console.WriteLine("Bu grubuun 2. Öğrencisi " + ogrenciler[2] + "dır");
            //}



            //int mevcut = 0;

            //Console.WriteLine("Sınıf Mevcudu Giriniz");

            //mevcut = int.Parse(Console.ReadLine());

            //Console.WriteLine();

            //string [] ogrenci_sayisi = new string[mevcut];

            //for (int i = 0; i < mevcut; i++)
            //{
            //    Console.WriteLine("Öğrenci Adını Giriniz");

            //    ogrenci_sayisi[i] = Console.ReadLine();

            //}


            //for (int i = 0; i < ogrenci_sayisi.Length; i++)
            //{
            //    Console.WriteLine(i + 1 + ". Öğrenci" + ogrenci_sayisi[i]);


            // bu hatalı ben yaptım

            //int sınıf_mevcudu;

            //Console.WriteLine("Lütfen sınıf mevcudu girin");

            //sınıf_mevcudu = int.Parse(Console.ReadLine());

            //int[] mevcut = new int[sınıf_mevcudu];

            //int notlar;


            //for (int i = 0; i < mevcut.Length; i++)
            //{

            //    Console.WriteLine("Lütfen Öğrencilerin notlarını giriniz:");

            //    notlar = int.Parse(Console.ReadLine());
            //    if (notlar < 50)
            //    {
            //        Console.WriteLine("Sınıftan kaldınız.");
            //    }

            //   else if (notlar > 50)
            //    {
            //        Console.WriteLine("Sınıfı Geçtiniz.");
            //    }

            //    else
            //    {

            //        Console.WriteLine("Birşeyler hatalı");

            //    }


            //int [] notlar = new int[7];

            //int gecen=0;
            //int kalan=0;

            //for (int i = 0; i < notlar.Length; i++)
            //{
            //    Console.WriteLine(i + 1 + ".Notu giriniz:");
            //    notlar[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < notlar.Length; i++)
            //{
            //    if (notlar[i] >= 50)
            //    {
            //        gecen++;
            //    }

            //    else
            //    {
            //        kalan++;
            //    }


            //}



            //int[] yas = new int[5];

            //for (int i = 0; i < yas.Length; i++)
            //{
            //    Console.WriteLine("Lütfen yaş giriniz:");

            //    yas[i] = int.Parse(Console.ReadLine());
            //}

            //Console.Clear();


            //    double avg = Queryable.Average(yas.AsQueryable());

            //    double sum = Queryable.Sum(yas.AsQueryable());

            //    Console.WriteLine("Yas Ortalaması:" + avg);
            //    Console.WriteLine("Yas Toplamı:" + sum);



            //List<int> sayilar1 = new List<int>();

            //for (int i = 0; i < 10; i++) // burada sayılar listesini önceden tanımlayamadığımız için değeri önceden giriyorsun
            //{
            //    Console.WriteLine("Sayı Girin:");

            //    sayilar1.Add(int.Parse(Console.ReadLine()));
            //}

            //foreach (var item in sayilar1)
            //{
            //    Console.WriteLine(item);
            //}

            List<int> yaslar = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Yaş gir:");
                yaslar.Add(int.Parse(Console.ReadLine()));
            }

            foreach (var item in yaslar)
            {
                Console.WriteLine(item);
            }

           

            yaslar.Sort();


            double avg = Queryable.Average(yaslar.AsQueryable());

            double sum = Queryable.Sum(yaslar.AsQueryable());

            Console.WriteLine("Ortalama:" + avg + "Toplam:" + sum);







            Console.ReadKey();


        }
    }
}

