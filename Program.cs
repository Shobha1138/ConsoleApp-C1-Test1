using System;

namespace ConsoleApp_C1_Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string[] Products = new string[10];
            // comment

            Console.WriteLine("Add Products: ");
            string[] Products = new string[20];

            int index = 0;


            while (true)
            {
                Console.WriteLine("Enter Product Name: ");
                string data = Console.ReadLine();
                if (data == "exit")

                {
                    break;
                }



                Products[index] = data;
                index++;
            }
            Array.Resize(ref Products, index);
            //Products[index] = data;
            Console.WriteLine();
            Console.WriteLine("My Products List: ");




            for (int i = 0; i < Products.Length; i++)
            {
                Console.WriteLine(Products[i]);

            }

           // Array.Sort(Products);
            //Products[index] = data;
           // Console.WriteLine();
            //Console.WriteLine("My Products with foreach List: ");

           // foreach (int product in Products)
           // {

               // Console.WriteLine(product);

         //   }



            //for (int i = 0; i < Products.Length; i++)
            //;
            //Console.WriteLine("My Products Names");
           // Console.ReadLine();
            //foreach (string product in Products)

            {
               // Console.WriteLine(Products[i]);
                    }
            
           // Console.ReadLine();

        }
    }
}
