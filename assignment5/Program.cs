using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    class Program
    {

        static void Main(string[] args)
        {
            
            Die a = new Die(50);

            //Subsribing to the events.
            a.TwoSixesInARow += TwoSixesInARow.EvantHandler;
            a.EndOfProgram += TwoSixesInARow.PrintNumber;
            a.SumIsGreater += SumIsGreater.EvantHandler;

            //Run the simulation.
            a.Run();
        }
    }
}
