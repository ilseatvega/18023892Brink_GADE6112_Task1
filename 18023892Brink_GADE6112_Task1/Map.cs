using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18023892Brink_GADE6112_Task1
{
    class Map
    {
        //array to store the units
        public Unit[] units;
        //array to store the battlefield
        public char[,] battlefield = new char[20, 20];
        //random to be used throughout the class
        Random rnd = new Random();

        public Map(int unitNo)
        {
            units = new Unit[unitNo];
            unitGenerate(units.Length);
            updateMap();
        }

        //method to randomly generate battlefield with units
        public void unitGenerate (int unitNo)
        {
            for (int i = 0; i < unitNo; i++)
            {
                //random position for units (x value)
                int newX = rnd.Next(0, 20);
                //random position for units(x value)
                int newY = rnd.Next(0, 20);
                //mod function that checks if i is odd or even (to switch between teams)
                int team = i % 2;
                //declaring tempattack (attack strength)
                int tempAttack = 0;
                //switch to determine which attack strength will be used (using rnd to randomise the case)
                switch (rnd.Next(0,4))
                {
                    case 0: tempAttack = 5; break;
                    case 1: tempAttack = 10; break;
                    case 2: tempAttack = 15; break;
                    case 3: tempAttack = 20; break;
                }
                //switch to determine which unit type will spawn (using rnd)
                switch (rnd.Next(0, 2))
                {
                    case 0: units[i] = new MeleeUnit(newX, newY, 120, 1, tempAttack, 1, team, "O", false); break;
                    case 1: units[i] = new RangedUnit(newX, newY, 100, 1, tempAttack, 4, team, "X", false); break;
                }
            }
        }

        //updates the map with the visual symbols 
        public void updateMap()
        {
            //for loops to loop through both the x and y positions in the array and fill them with .
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    battlefield[i, j] = '.';
                }
            }
            //places all the units on their x and y pos
            for (int i = 0; i < units.Length; i++)
            {
                battlefield[units[i].X, units[i].Y] = Convert.ToChar(units[i].Symbol);
            }
        }
    }
}
