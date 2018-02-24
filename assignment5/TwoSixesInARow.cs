using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    class TwoSixesInARow
    {
        private static int number;
        static TwoSixesInARow()
        {
            number = 0;
        }

        static public void F()
        {
            Console.WriteLine("TwoSixesInARow");
            number++;
        }

        static public void PrintNumber()
        {
            Console.WriteLine(number);
            Reset();
        }

        static public void Reset()
        {
            number = 0;
        }
    }
}
