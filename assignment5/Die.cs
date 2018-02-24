using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace assignment5
{
    class Die
    {
        /// <summary>
        /// The delegate type for handling event.
        /// </summary>
        public delegate void TwoSixesInARow();

        /// <summary>
        /// Event
        /// </summary>
        public TwoSixesInARow twoSixesInARow;

        public delegate void EndOfProgram();

        public EndOfProgram endOfProgram;

        public delegate void SumIsGreater(List<int> randomNumbers);

        public SumIsGreater sumIsGreater;


        /// <summary>
        /// How many times Die should be rolled.
        /// </summary>
        public int numberOfRolls;

        /// <summary>
        /// The rundom number generator
        /// </summary>
        private readonly Random random;


        public Die(int numberOfRolls)
        {
            this.numberOfRolls = numberOfRolls;
            this.random = new Random(100);

        }

        public void Run()
        {
            int previousNumber = 0;
            List<int> randomNumbers = new List<int>(); 

            for (int i = 0; i < this.numberOfRolls; i++)
            {
                
                int nextNumber = this.random.Next(1, 7);
                randomNumbers.Add(nextNumber);
                randomNumbers.Last();
                //Console.WriteLine(nextNumber);

                if (randomNumbers.Count() == 5)
                {
                    if(randomNumbers.Sum() > 19)
                    {
                        if (this.sumIsGreater != null)
                        {
                            this.sumIsGreater.Invoke(randomNumbers);
                        }
                    }
                    randomNumbers.RemoveAt(0);
                }

                
                if (nextNumber == previousNumber && nextNumber == 6)
                {
                    if (this.twoSixesInARow != null)
                    {
                        this.twoSixesInARow.Invoke();
                    }
                }

               
                previousNumber = nextNumber;
            }
            
            if (this.endOfProgram != null)
            {
                endOfProgram.Invoke();
            }
        } 
    }
}
