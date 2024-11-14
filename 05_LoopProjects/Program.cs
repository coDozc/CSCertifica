using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region alt alta 10 yıldız
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("*");
            //}
            #endregion

            #region yan yana 10 yıldız
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("*");
            //}
            #endregion

            #region alt alta 10 yıldız her satırda 10 yıldız
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region dik üçgen
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region ters dik üçgen
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 5-i; j >= 0; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();    
            //}
            #endregion

            #region sağa yatık ikizkenar üçgen
            //int count = 5;
            //for (int i = 1; i < count * 2 ; i++)
            //{
            //    int starCount = i <= count ? i : count * 2 - i;

            //    for (int j = 0; j < starCount; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region piramit
            //int n = 5;
            //for (int = 1; i<=n; i++)
            //{
            //    for (int j = n-i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2*i-1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region ters piramit
            int n = 5;
            for (int i = n; i >= n; i--)
            {
                for (int j = n - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion
            Console.ReadKey();
        }
    }
}
