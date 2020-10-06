using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtsTestApp
{
    public class SuperLaskin : CommonTypeSystemDemo.Laskin
    {
        public int Tulo(int a, int b)
        {
            return a + b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aloitetaan CTS-testaus.");

            CommonTypeSystemDemo.Laskin laskin = new CommonTypeSystemDemo.Laskin();
            int summa = laskin.Summa(123, 456);

            Console.WriteLine("Summa on: " + summa);
        }
    }
}
