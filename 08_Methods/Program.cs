using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region void metotlar
            //void customerList()
            //{
            //    Console.WriteLine("bayram");
            //    Console.WriteLine("ayşe");
            //    Console.WriteLine("can");
            //}
            //customerList();
            //customerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();
            #endregion

            #region Geriye değer döndürmeyen string parametreli metotlar
            //void WriteMethod(string name)
            //{
            //    Console.WriteLine(name);
            //}
            //WriteMethod("can ozan");

            //void customerCard(string name, string surName)
            //{
            //    Console.WriteLine($"Müşteri: {name} {surName}");
            //}
            //customerCard("bayram","özcan");
            #endregion

            #region Geriye değer döndürmeyen int parametreli metotlar
            //void Multiply(int x, int y, int z)
            //{
            //    int result = x * y * z;
            //    Console.WriteLine(result);
            //}
            //Multiply(7, 3 ,5);
            #endregion

            #region geriye değer döndüren metotlar
            //string CustomerName()
            //{
            //    return "mehmet yıldız";
            //}
            //var name = CustomerName();
            //Console.WriteLine(name);
            #endregion

            #region #region geriye değer döndüren string parametreli metotlar
            //string countryCard(string countryName, string capital, double population)
            //{
            //    string card = "Ülke: "+ countryName+ "- Başkent: "+ capital + "- Nüfus: "+ 
            //        population;
            //    return card;
            //}

            //string x, y;
            //int z;
            //Console.WriteLine("Ülke adını giriniz: ");
            //x = Console.ReadLine();
            //Console.WriteLine("Başkentini giriniz: ");
            //y = Console.ReadLine();
            //Console.WriteLine("Nüfusunu giriniz: ");
            //z = int.Parse(Console.ReadLine());

            //Console.WriteLine(countryCard(x, y, z));
            #endregion

            #region geriye değer döndüren int parametreli metotlar
            //int Sum(int x, int y)
            //{
            //    return x + y;
            //}
            //Console.WriteLine("toplanacak sayıları giriniz: ");
            //int num = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine()); 

            //Console.WriteLine(Sum(num, num2));

            
            #endregion

            Console.ReadKey();
        }
    }
}
