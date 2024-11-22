using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNum;
            string conString = "Data Source = (localdb)\\MSSQLLocalDB; initial Catalog = ornekRestoranDb; integrated security = true ";

            Console.WriteLine("------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.WriteLine("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNum = Console.ReadLine();
            Console.WriteLine("------------------------------");

            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                foreach (var row in item.ItemArray)
                {
                    Console.Write(" " + row.ToString());
                }
                Console.WriteLine();
            }
            connection.Close();




            Console.Read();
        }
    }
}
