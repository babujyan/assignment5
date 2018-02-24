using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    class SumIsGreater
    {
        static SumIsGreater()
        {

        }

        static public void S(List<int> randomNumbers)
        {
            
            for (int i = 0; i < randomNumbers.Count(); i++)
            {
                Console.Write(randomNumbers[i] +" ");


            }
            Console.WriteLine();
        }
    }
}
