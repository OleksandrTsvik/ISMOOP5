using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDelegate
{
    public class TabulationFunctions
    {
        public static void Tabulate(double a, double b, double h, MathematicalFunctions func)
        {
            for (double x = a; x <= b; x += h)
                Console.WriteLine($"y({x, 0:f4}) = {func(x), 0:f4}");
        }
    }
}
