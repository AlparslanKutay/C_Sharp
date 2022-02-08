using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodlar_devam
{
    class Program
    {
        // bir şirketin default olarak 5 tane ürünü olsun, bu ürünlerin kontrolünü sağlayabilecekleri bir console uygulaması yazmalısın
        // ürünlerin silinebilmesi, kaç ürün olduğunu görebilmeliler, ürün arayabilme, ürün ekleme

        //ürün ekle , sil, sayı göster, ürünleri ismiyle arayabilme 


        public static void dManage()
        {



            
            

            //Bu bir gıda şirketidir
            string pro_1 = "Rice";
            string pro_2 = "Bean";
            string pro_3 = "Corn";
            string pro_4 = "Eggplant";
            string pro_5 = "Chickpea";

            List<String> products = new List<string>();

            products.Add(pro_1);
            products.Add(pro_2);
            products.Add(pro_3);
            products.Add(pro_4);
            products.Add(pro_5);




            Console.WriteLine("Welcome Sir-------What you wanna do today?");

            foreach (var item in products)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------");

            Console.WriteLine("Wanna Add new product? Press A");

            Console.WriteLine("Wanna Remove product? Press D");

            Console.WriteLine("Wanna Show the Products? Press S" );

            Console.WriteLine("Wanna  search any product? Press F");



            string symbol;

            symbol = Console.ReadLine();

            

            


            if (symbol == "A")
            {
                Console.WriteLine("What you wanna to add our product list");

                products.Add(Console.ReadLine());

                foreach (var item in products)
                {
                    Console.WriteLine(item);
                }

            }

            else if (symbol == "D")
            {
                string delete;
                products.Count();

                

                Console.WriteLine("Which product wanna remove from our list?");

                delete = Console.ReadLine();

                products.Remove(delete);

                foreach (var item in products)
                {
                    Console.WriteLine(item);
                }
            }

            else if (symbol == "S")
            {
                Console.WriteLine("Here to our list");

                products.Count();

                foreach (var item in products)
                {
                    Console.WriteLine(item);
                }

            }

            else if (symbol == "F")
            {
                Console.WriteLine("Which product wanna find");

                string arama;
                arama = Console.ReadLine();

                products.Contains(arama);

                foreach (var item in products)
                {
                    Console.WriteLine(item);
                }

            }

            foreach (var item in products)
            {
                Console.WriteLine(item);
            }


        }


        static void Main(string[] args)
        {

            dManage();

            Console.ReadKey();
        }
    }
}
