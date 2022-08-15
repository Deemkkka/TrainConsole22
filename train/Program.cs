using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0;

            string quadrant = x >= 0 ? y >= 0 ? "1" : "4" : y > 0 ? "2" : "3";

            Console.WriteLine(quadrant);

            Console.ReadKey();

        }
    }
}
