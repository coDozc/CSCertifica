using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine($"{i}. sayı"+ " "+ $"{i}");
            //}

            //            for (int i = 0; i <= 1000; i++)
            //            {
            //                Console.WriteLine($"{i} sayısının 5 ile bölümden kalan: {i % 5}");
            //;           }
            //           
            //int count = 0;
            //for (int i = 1; i < 50; i++)
            //{
            //    if(i % 7 == 0)
            //        count++;
            //}
            //Console.WriteLine(count);


            #endregion

            #region While
            //char space;
            //bool isSpace = false;
            //space = char.Parse(Console.ReadLine());
            //while (!isSpace)
            //{
            //    space = char.Parse(Console.ReadLine());
            //    if (space == ' ')
            //        isSpace = true;

            //    Console.WriteLine("Boşluğa basmadın!");
            //}
            //int i = 0;
            //while (i <= 30) 
            //{
            //    if (i % 3 == 0)
            //        Console.WriteLine(i);

            //    i++;
            //}
            #endregion

            #region 3 basamak sorusu
            int sayi, sum=0;
            
            Console.WriteLine("sayı giriniz");
            sayi = int.Parse(Console.ReadLine());
  
            while (sayi > 0)
            {
                int basamak = sayi % 10;
                sum += basamak;
                sayi /= 10;
            }

            Console.WriteLine(sum);
            #endregion
            Console.Read();


        }
    }
}
