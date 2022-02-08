using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listeler
{
    class Program
    {
        static void Main(string[] args)
        {

            //************************************
            //List<string> liste = new List<string>();




            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Öğrenci Adını Giriniz");

            //    liste.Add(Console.ReadLine());

            //}


            //foreach (var item in liste)
            //{
            //    Console.WriteLine(item);
            //}


            //liste.Sort();

            //***********************************************



            //int delete;
            //List<int> yaslar = new List<int>();
            //yaslar.Add(15);
            //yaslar.Add(20);
            //yaslar.Add(25);
            //yaslar.Add(24);

            //for (int i = 0; i < yaslar.Count; i++)
            //{
            //    Console.WriteLine(yaslar[i]);
            //}

            //Console.Write("Lütfen silinecek elemanı yazın: ");
            //delete = int.Parse(Console.ReadLine());
            //yaslar.Remove(delete);



            //Console.WriteLine("Güncel Liste");
            //for (int i = 0; i < yaslar.Count; i++)
            //{
            //    Console.WriteLine(yaslar[i]);
            //}

            //***************************

            // Bir listenin içinden arama yapılsın ve aranan eleman varsa var desin yoksa yok desin.

            //int search;
            //int searchofIndex;


            //List<int> sayı_listesi = new List<int>();

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("Sayı Giriniz : ");
            //    sayı_listesi.Add(int.Parse(Console.ReadLine()));

            //}

            //List<int> yeni_liste = new List<int>(sayı_listesi);

            //for (int i = 0; i < yeni_liste.Count; i++)
            //{
            //    Console.WriteLine(yeni_liste[i]);
            //}


            //Console.WriteLine("\nAranacak sayıyı giriniz : ");
            //search = int.Parse(Console.ReadLine());

            //if (yeni_liste.Contains(search))
            //{
            //    searchofIndex = yeni_liste.IndexOf(search);
            //    Console.WriteLine(search + "Sayısı Listede vardır. Index no : " + searchofIndex);
            //}
            //else
            //{
            //    Console.WriteLine("Boyle bir sayı listede yok.");
            //}

            //********************************************************

            //int removeIndexNo;

            //string choose;

            //List<string> animals = new List<string>();

            //for (int i = 0; i < 6; i++)
            //{
            //    Console.Write("Please enter the animals: ");
            //    animals.Add(Console.ReadLine());
            //}
            //Console.Clear();

            //Console.WriteLine("---Animals---\n");

            //for (int i = 0; i < animals.Count; i++)
            //{
            //    Console.WriteLine((i+1) + ". number of index for animal : " + animals[i]);
            //}


            //Console.WriteLine("\nPlease entered the index number which you  want the remove");
            //removeIndexNo = int.Parse(Console.ReadLine());
            //animals.RemoveAt(removeIndexNo);

            //Console.WriteLine("\nIf you want to delete please push the e or E ; if you want to exit please hit the enter two times");
            //choose = Console.ReadLine();

            //Console.Clear();

            //while (choose == "E" || choose == "e")
            //{
            //    Console.WriteLine("---New Animal list (updated)---\n");
            //    for (int i = 0; i < animals.Count; i++)
            //    {
            //        Console.WriteLine((i+1) + ". number of index for animal : " + animals[i]);
            //    }

            //    Console.WriteLine("\nPlease write the index number of animal which you would delete in list");
            //    removeIndexNo = int.Parse(Console.ReadLine());
            //    animals.RemoveAt(removeIndexNo);

            //    Console.WriteLine("\nIf you want to delete please push the e or E ; if you want to exit please hit the enter two times");
            //    choose = Console.ReadLine();
            //    Console.Clear();
            //}
            //Console.Clear();

            //Console.WriteLine("---Take Care---\nMade By AK-47");


            //**********************************

            string silme;

            string aranacak;

            string[] yeni_dizi = new string[3];

            yeni_dizi[0] = "Alp";
            yeni_dizi[1] = "Kutay";
            yeni_dizi[2] = "Atasever";

            List<string> diziyi_listeye_cevirme = new List<string>(yeni_dizi);

            foreach (var item in diziyi_listeye_cevirme)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("Lütfen silmek istediğiniz veriyi girin:");

                silme = Console.ReadLine();

                diziyi_listeye_cevirme.Remove(silme);

            Console.WriteLine("Son hali:" );

            foreach (var item in diziyi_listeye_cevirme)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Aranacak kelime");

            aranacak = Console.ReadLine();

            if (diziyi_listeye_cevirme.Contains(aranacak))
            {
                Console.WriteLine("aranacak kelime:" + aranacak);
            }
            else
            {
                Console.WriteLine("aranacak kelime yok");
            }

            Console.ReadKey();

        }
    }

}




