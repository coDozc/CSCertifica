using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü
            //string[] fruits = { "elma", "armut", "çilek", "karpuz", "mandalina" };

            //foreach (string fruit in fruits)
            //{
            //    Console.WriteLine(fruit);
            //}
            //int sum = 1;
            //int[] numbers = { 1, 2123, 3334, 777, 333, 666, 1123, 423 };

            //foreach (int i in numbers) 
            //{
            //    if (i % 2 == 0)
            //        sum += i;
            //}
            //Console.WriteLine(sum);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,6,7
            //};

            //foreach (int num in numbers)
            //{
            //    Console.WriteLine(num);
            //}

            //string word = "selam";

            //foreach (char s in word)
            //{
            //    Console.WriteLine(s);
            //}


            #endregion

            #region sınav sistemi uygulaması
            Console.Write("***** Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("--------------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------");
            Console.WriteLine();
            Console.WriteLine("Öğrencilerin Adları: ");
            Console.WriteLine();

            string[] students = new string[studentCount];
            double[] resultsAvg = new double[studentCount];
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{i + 1}. öğrencinin ismini giriniz");
                students[i] = Console.ReadLine();

                double totalExamRes = 0;

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{students[i]} adlı öğrencinin {j+1}. sınavdan aldığı puan: ");
                    double marks = double.Parse(Console.ReadLine());
                    totalExamRes += marks;
                }
                resultsAvg[i] = totalExamRes / 3;
            }

            Console.WriteLine("--------------------------------");
            Console.WriteLine();
            Console.WriteLine("Öğrenciler ve Not Ortalamaları");

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{students[i]}: {resultsAvg[i]}");

                if (resultsAvg[i] >= 50)
                    Console.WriteLine($"{students[i]} dersi geçti");
                else
                    Console.WriteLine($"{students[i]} dersten kaldı");
            }

            Console.WriteLine("--------------------------------");
            Console.WriteLine();
            Console.WriteLine("Sınıf Ortalaması");
            int average = 0;

            foreach (int mark in resultsAvg)
            {
                average+=mark;
            }

            average = average / students.Length;
            Console.WriteLine(average.ToString());
            #endregion
            Console.Read();
        }
    }
}