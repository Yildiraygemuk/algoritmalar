using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Bir sayı giriniz");
            //int sayi = Convert.ToInt32( Console.ReadLine());
            //for (int i = 0; i <= sayi; i++)
            //{
            //    Console.Write("* ");



            //    for (int j = 1; j <= sayi; j++)
            //    {
            //        Console.Write("* ");
            //    }

            //    Console.WriteLine(" ");
            //}

            //Console.ReadLine();






            //Console.WriteLine("Bir sayı giriniz");
            //int yukseklik = Convert.ToInt32(Console.ReadLine());
            //int genislik = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= yukseklik; i++)
            //{

            //    for (int j = 1; j <= genislik; j++)
            //    {
            //        if (i == genislik || i == 1)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            if (j == yukseklik || j == 1)
            //            {
            //                Console.Write("*");
            //            }
            //            else
            //            {
            //                Console.Write(" ");
            //            };
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();





            //Console.WriteLine("Bir sayı giriniz");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < sayi1; i++)
            //{

            //    for (int k =i; k < sayi1; k++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int s = 0; s < i; s++)
            //    {
            //        Console.Write("*");
            //        Console.Write(" ");
            //    }


            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            Console.WriteLine("Bir sayı giriniz");
            int sayi12 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < sayi12; i++)
            {
                for (int k = i; k < sayi12; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("~");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}





// ******
// *    *