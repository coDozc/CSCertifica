using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string conString = "Data Source = (localdb)\\MSSQLLocalDB; initial " +
                "Catalog = ornekRestoranDb; integrated security = true ";
            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("-----------------------------------");
            #region Kategori ekleme
            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //string conString = "Data Source = (localdb)\\MSSQLLocalDB; initial " +
            //    "Catalog = ornekRestoranDb; integrated security = true ";
            //SqlConnection conn = new SqlConnection(conString);

            //conn.Open();
            //SqlCommand cmd = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", conn);
            //cmd.Parameters.AddWithValue("@p1", categoryName);
            //cmd.ExecuteNonQuery();
            //conn.Close();

            //Console.Write("Kategori başarıyla eklendi!");
            #endregion

            #region ürün ekleme
            //string productName;
            //decimal productPrice;
            //bool productStatus;

            //Console.Write("Ürün adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection conn = new SqlConnection(conString);
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values " +
            //    "(@productName,@productPrice,@productStatus)", conn);
            //cmd.Parameters.AddWithValue("@productName", productName);
            //cmd.Parameters.AddWithValue("@productPrice", productPrice);
            //cmd.Parameters.AddWithValue("@productStatus", true);
            //cmd.ExecuteNonQuery();
            //conn.Close();
            //Console.Write("Ürün eklemesi başarılı!");

            #endregion

            #region ürün listeleme
            //SqlConnection conn = new SqlConnection(conString);
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("Select * From TblProduct", conn);
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);

            //foreach (DataRow dr in dt.Rows)
            //{
            //    foreach (var item in dr.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //conn.Close();
            #endregion

            #region ürün silme
            //Console.Write("Silinecek ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());
            //SqlConnection con = new SqlConnection(conString);
            //con.Open();

            //SqlCommand cmd = new SqlCommand("Delete From TblProduct Where ProductId=@productId", con);
            //cmd.Parameters.AddWithValue("@productId", productId);
            //cmd.ExecuteNonQuery();

            //con.Close();

            //Console.WriteLine("Silme işlemi yapıldı!");
            #endregion

            #region ürün güncelleme
            //Console.Write("Güncellenecek ürün ID: ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek ürün adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellenecek ürün fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection con = new SqlConnection(conString);
            //con.Open();
            //SqlCommand com = new SqlCommand("Update TblProduct Set ProductName=@productName, ProductPrice=@productPrice " +
            //    "where ProductId=@productId", con);
            //com.Parameters.AddWithValue("@productName", productName);
            //com.Parameters.AddWithValue("@productPrice", productPrice);
            //com.Parameters.AddWithValue("@productId", productId);
            //com.ExecuteNonQuery();
            //con.Close();

            //Console.WriteLine("Güncelleme başarılı!");
            #endregion
            Console.Read();
        }
    }
}
