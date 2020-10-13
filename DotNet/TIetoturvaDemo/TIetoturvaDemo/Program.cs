using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIetoturvaDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] luvut = new int[3];
            luvut[0] = 1;
            luvut[1] = 2;
            luvut[2] = 3;
            luvut[3] = 4;
            */

            Console.WriteLine("Syötä maan nimi:");
            string maa = Console.ReadLine();

            if (maa.Length > 20)
            {
                Console.WriteLine("Virhe: maa on liia pitkä!");
                return;
            }

            // parametroitu kysely (parameterized query)
            string sql = "SELECT CompanyName FROM Customers " +
                "WHERE Country = @maa";

            Console.WriteLine(sql);
            Console.WriteLine();

            string yhteys = "Data Source=localhost;Database=Northwind;Integrated Security=SSPI;";
            SqlConnection connection = new SqlConnection(yhteys);
            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@maa", maa);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[0]);
            }
            connection.Close();
            Console.WriteLine("---- loppu ----");

            Console.ReadLine();
        }
    }
}
