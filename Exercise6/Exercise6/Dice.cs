using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Dice
    {
        //Declaring class properties
        private int numberOfSides;
        private int numberOfRolls;

        //Initialize random number object
        Random randomNumber = new Random();

        public int NumberOfSides
        {
            get
            {
                return numberOfSides;
            }
            set
            {
                numberOfSides = value;
            }
        }

        public int NumberOfRolls
        {
            get
            {
                return numberOfRolls;
            }
        }

        //rollDie method
        public int rollDie()
        {
            numberOfRolls++;
            return this.randomNumber.Next(1, this.numberOfSides + 1);
        }

        public Dice(int numberOfSides)
        {
            if (numberOfSides > 20)
            {
                this.numberOfSides = 20;
            }
            else if (numberOfSides < 4)
            {
                this.numberOfSides = 4;
            } else
            this.numberOfSides = numberOfSides;
        }

        public Dice()
        {
            this.numberOfSides = 6;
        }
    }
}