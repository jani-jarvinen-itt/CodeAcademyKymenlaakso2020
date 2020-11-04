using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Valuuttakurssit
{
    class Program
    {
        static void Main(string[] args)
        {
            // kysy käyttäjältä euromäärä
            Console.WriteLine("Anna euromäärä:");
            string syöte = Console.ReadLine();
            double eurot = double.Parse(syöte);
            double usdKurssi = -1;

            // lue USD-valuuttakurssi
            string url = "http://www.ecb.europa.eu/stats/eurofxref/eurofxref-daily.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(url);
            XmlNodeList cubeNodes = doc.DocumentElement.ChildNodes[2].ChildNodes[0].ChildNodes;
            foreach (XmlNode cubeNode in cubeNodes)
            {
                string currency = cubeNode.Attributes["currency"].Value;
                string rate = cubeNode.Attributes["rate"].Value;
                // Console.WriteLine(currency + ": " + rate);

                if (currency == "USD")
                {
                    CultureInfo enUs = new CultureInfo("en-US");
                    usdKurssi = double.Parse(rate, enUs);
                }
            }

            // laske USD-määrä
            if (usdKurssi > 0)
            {
                double dollarit = eurot * usdKurssi;
                Console.WriteLine($"Tulos: {eurot} euroa = ${dollarit} USD.");
            }

            Console.ReadLine();
        }
    }
}
