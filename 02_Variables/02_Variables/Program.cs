using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  C# Basics
            double num, num2, result;
            Console.WriteLine("sayı giriniz");
            num = double.Parse(Console.ReadLine());
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("sayi 1: "+ num + " " +"sayi 2: " + num2);

            result = num + num2;
            Console.WriteLine("sonuç: " + result);

            Console.Read();
            #endregion


        }
    }
}
