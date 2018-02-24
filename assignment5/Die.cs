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


        /// <summary>
        /// How many times Die should be rolled.
        /// </summary>
        public int rollingDie;

        /// <summary>
        /// The rundom number generator
        /// </summary>
        private readonly Random random;


        public Die(int rollingDie)
        {
            this.rollingDie = rollingDie;
            this.random = new Random(100);

        }

        public void Run()
        {
            int previousNumber = 0;
            for (int i = 0; i < this.rollingDie; i++)
            {
                int nextNumber = this.random.Next(1, 7);

                Console.WriteLine(nextNumber);
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
