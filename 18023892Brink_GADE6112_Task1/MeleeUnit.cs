using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18023892Brink_GADE6112_Task1
{
    class MeleeUnit : Unit
    {
        //random to be used throughout the class
        Random rnd = new Random();

        //using a base constructor to access Unit's variables (properties must be accessed from MeleeUnit which is why base is used)
        //health, speed, attackrange and symbol changed to fit the MeleeUnit
        public MeleeUnit(int xPos, int yPos, int health, int speed, int attack, int attackRange, int team, string symbol, bool isAttack) : base(xPos, yPos, 120, 1, attack, 1, team, "O", isAttack)
        {
            //this. to refer to the instance of the variable in this class
            this.xPos = xPos;
            this.yPos = yPos;
            this.health = health;
            this.speed = speed;
            this.attack = attack;
            this.attackRange = attackRange;
            this.team = team;
            this.symbol = symbol;
            this.isAttack = isAttack;
        }

        //overrides the Unit class method Move() ... same for all the methods
        public override void Move(ref Unit closestUnit)
        {
        }
        public override void Combat()
        {

        }
        public override bool AttRange()
        {
            return false;
        }
        public override void ClosestUnitPos()
        {

        }
        public override void UnitDeath()
        {
            
        }
        //a string showing all the unit information
        public override string ToString()
        {
            //showing the unit symbol, position, health points and attack
            return symbol + ": [" + X + "," + Y + "] " + Health + "HP " + Attack;
        }

        //creating the properties for this class using the variables from Unit and using getters / setters
        //set = when the value needs to be set to something (can be changed)
        //get = when a value needs to be gotten from the variable
        public int X { get { return xPos; } set { xPos = value; } }

        public int Y { get { return yPos; } set { yPos = value; } }

        public int maxHP { get { return health; } }

        public int Health { get { return health; } }

        public int Attack { get { return attack; } set { attack = value; } }

        //didnt use set since the value has been set and wont change (see constructor base at the top)
        public int Speed { get { return speed; } }

        public int Range { get { return attackRange; } }

        public int Team { get { return team; } set { team = value; } }

        public string Symbol { get { return symbol; } }

        public bool isAttacking { get { return isAttack; } set { isAttack = value; } }
    }
}
