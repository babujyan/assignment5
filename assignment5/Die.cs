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
        public delegate void VoidToVoid();

        /// <summary>
        /// Event-Two sixes in a row.
        /// </summary>
        public event VoidToVoid TwoSixesInARow;

        /// <summary>
        /// Event - End of program.
        /// </summary>
        public event VoidToVoid EndOfProgram;

        /// <summary>
        /// The delegate type for handling event.
        /// </summary>
        /// <param name="randomNumbers">Rolled dice.</param>
        public delegate void LinstIntToVoid(List<int> randomNumbers);

        /// <summary>
        /// Event -the sum is greater than or equal to 20.
        /// </summary>
        public event LinstIntToVoid SumIsGreater;


        /// <summary>
        /// How many times Die should be rolled.
        /// </summary>
        public int numberOfRolls;

        /// <summary>
        /// The rundom number generator
        /// </summary>
        private readonly Random random;

        /// <summary>
        /// Seting how many times die gonna be rolled.
        /// </summary>
        /// <param name="numberOfRolls"> Number of rolls.</param>
        public Die(int numberOfRolls)
        {
            this.numberOfRolls = numberOfRolls;
            this.random = new Random(100);

        }

        /// <summary>
        /// Simulation of rolling dice.
        /// </summary>
        public void Run()
        {
            //Init some local vars.
            int previousNumber = 0;
            List<int> randomNumbers = new List<int>(); 

            //
            for (int i = 0; i < this.numberOfRolls; i++)
            {
                //gets random number from 1 to 6.
                int nextNumber = this.random.Next(1, 7);
                
                //Adds to list.
                randomNumbers.Add(nextNumber);

                //If there are two sixes in a row call the event.
                if (nextNumber == previousNumber && nextNumber == 6)
                {
                    if (this.TwoSixesInARow != null)
                    {
                        this.TwoSixesInARow.Invoke();
                    }
                }

                //If ther are 5 nubers in a list count sum.
                if (randomNumbers.Count() == 5)
                {
                    if(randomNumbers.Sum() > 19)
                    {
                        //If the sum is greater than or equal to 20 call the event.
                        if (this.SumIsGreater != null)
                        {        
                            this.SumIsGreater.Invoke(randomNumbers);
                        }
                    }
                    
                    //Clear the list.
                    randomNumbers.Clear();
                }

                
                //Make mext nuber to previous number.            
                previousNumber = nextNumber;
            }

            //When all dices have rolled call end of program event.
            if (this.EndOfProgram != null)
            {
                this.EndOfProgram.Invoke();
            }
        } 
    }
}