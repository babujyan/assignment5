using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    static class TwoSixesInARow
    {
        /// <summary>
        /// Field for counting how many times the event has occurred.
        /// </summary>
        private static int number;

        /// <summary>
        ///Static constructor for initialization static fields.
        /// </summary>
        static TwoSixesInARow()
        {
            number = 0;
        }

        /// <summary>
        /// Event handler for event two sixes in a row.
        /// </summary>
        static public void EvantHandler()
        {
            Console.WriteLine("TwoSixesInARow");
            number++;
        }

        /// <summary>
        /// Event handler for event end of program.
        /// </summary>
        static public void PrintNumber()
        {
            Console.WriteLine("Two Sixes in a row event has accurred " +number +" times.");
            Reset();
        }

        /// <summary>
        /// Reset fields.
        /// </summary>
        static public void Reset()
        {
            number = 0;
        }
    }
}
