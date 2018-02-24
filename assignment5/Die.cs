using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            this.random = new Random(1);
        }

        public void Run()
        {
            for (int i = 0; i < this.rollingDie; i++)
            {
                int nextNumber = this.random.Next(1, 7);
                Console.WriteLine(nextNumber);
                if (this.twoSixesInARow != null)
                {
                    this.twoSixesInARow.Invoke();
                }
            }
        }
    }
}
