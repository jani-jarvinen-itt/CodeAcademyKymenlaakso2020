using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStreamDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string tiedostoNimi = @"C:\Academy\Kotka\Git\CodeAcademyKymenlaakso2020\DotNet\Lukuja.txt";
            FileStream stream = new FileStream(tiedostoNimi, FileMode.Open, FileAccess.Read);

            byte[] tavut = new byte[stream.Length];
            stream.Read(tavut, 0, (int)stream.Length);
            string teksti = Encoding.ASCII.GetString(tavut);
            string[] rivit = teksti.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            List<int> luvut = new List<int>();
            foreach (string rivi in rivit)
            {
                int luku = int.Parse(rivi);
                luvut.Add(luku);
            }

            double keskiarvo = luvut.Average();
            Console.WriteLine("Keskiarvo on: " + keskiarvo);
            */

            Console.WriteLine("Aloitetaan tiedostoon kirjoittaminen.");

            string tiedostoNimi = @"C:\Temp\Testi.txt";
            FileStream stream = new FileStream(tiedostoNimi, FileMode.Create, FileAccess.ReadWrite);
            string teksti = "Moi Code Academy!\r\n";
            byte[] tavut = Encoding.UTF8.GetBytes(teksti);

            for (int i = 0; i < 10; i++)
            {
                stream.Write(tavut, 0, tavut.Length);
            }

            // throw new Exception("Virhe!");
            // stream.Close();

            Console.WriteLine("Kirjoitus (10 kertaa) tehty!");
            // Console.ReadLine();
        }
    }
}
