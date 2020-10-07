using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiedostoJaPoikkeukset
{
    class Program
    {
        static void Main(string[] args)
        {
            string tiedostoNimi = @"C:\Academy\Kotka\Git\CodeAcademyKymenlaakso2020\DotNet\Lukuja.txt";
            string[] rivit = File.ReadAllLines(tiedostoNimi);

            List<int> luvut = new List<int>();
            foreach (string rivi in rivit)
            {
                int luku = int.Parse(rivi);
                luvut.Add(luku);
            }

            double keskiarvo = luvut.Average();
            Console.WriteLine("Keskiarvo on: " + keskiarvo);
        }
    }
}
