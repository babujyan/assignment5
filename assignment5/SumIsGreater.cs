using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    static class SumIsGreater
    {
        /// <summary>
        /// In case we need to write something here. Current state empty.
        /// </summary>
        static SumIsGreater()
        {
        }

        /// <summary>
        /// Event handler for event the sum  is greater than or equal to 20.
        /// </summary>
        /// <param name="randomNumbers">Numbers which sum is greater than or equal to 20.</param>
        static public void EvantHandler(List<int> randomNumbers)
        {
            Console.Write("");

            for (int i = 0; i < randomNumbers.Count(); i++)
            {
                Console.Write(randomNumbers[i] + " ");
            }
            Console.WriteLine(" The sum of all these numbers is greater than or equal to 20");
        }
    }
}
