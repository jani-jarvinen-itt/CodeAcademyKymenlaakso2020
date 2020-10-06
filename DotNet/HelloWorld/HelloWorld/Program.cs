using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moi Code Academy Kymenlaakso!");

            Random random = new Random();
            int maxValue = random.Next(10, 20);

            for (int i = 0; i < maxValue; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine($"Luku {i} on kolmella jaollinen.");
                }
            }
        }
    }
}
