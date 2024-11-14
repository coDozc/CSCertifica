using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region temel dizi
            //string[] cities = new string[4];

            //cities[0] = "İstanbul";
            //cities[1] = "Paris";
            //cities[2] = "Roma";
            //cities[3] = "Londra";

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //string[] cities = { "İstanbul", "Paris", "Roma", "Londra" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}
            //Console.WriteLine(cities.Length);
            #endregion

            #region dizi elemanlarıyla pratikler
            //int[] numbers = { 3, 43, 234, 745, 234, 32523, 63, 2345234, 4345 };

            //foreach (int number in numbers) 
            //{
            //    if(number %7 == 0)
            //        Console.WriteLine(number); 
            //}

            //int temp = numbers[0];

            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if(temp > numbers[i])
            //        temp = numbers[i];
            //}

            //Console.WriteLine($"dizideki en küçük sayı: {temp}");
            //Array.Sort(numbers);

            //foreach (int i in numbers) Console.WriteLine(i);
            //Console.WriteLine();
            //Array.Reverse(numbers);
            //foreach (int i in numbers) Console.WriteLine(i);    
            #endregion

            #region metotlar
            //string[] customers = { "ali", "ayşe", "merve", "bayram" };

            //int index = Array.IndexOf(customers, "ayşe");
            //Console.WriteLine(index);
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //Console.WriteLine(numbers.Max());
            #endregion

            #region klavyeden giriş

            //int gameCount;
            //Console.WriteLine("kaç oyun gireceksiniz");
            //gameCount = int.Parse(Console.ReadLine());
            //string[] games = new string[gameCount];

            //for (int i = 0; i < gameCount; i++)
            //{
            //    Console.WriteLine($"{i + 1}. oyunu giriniz: ");
            //    games[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("------------------");

            //foreach (string s in games)
            //{
            //    Console.WriteLine(s);
            //}

            int[] numbers = { 3, 43, 234, 745, 234, 32523, 63, 2345234, 4345 };

            Console.WriteLine("çift sayılar");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0) 
                {
                    Console.WriteLine(numbers[i]);
                }
               
            }
            Console.WriteLine();
            Console.WriteLine("tek sayılar");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                    Console.WriteLine(numbers[i]);
            }   

            #endregion

            Console.Read();
        }
    }
}
