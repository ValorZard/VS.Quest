using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MFulopSjANApeerProgrammingClasses
{
    public class Player
    {
        private double health;
        private double mana;
        private double attackDamage;// the damage that the player deals
        private int level;
        private double healthDamage;// the damage the monster does to you
        public Player()
        {
            health = 100;
            mana = 3;
            level = 1;
        }
        public Player(double health, double mana, int level)
        {
            this.health = health;
            this.mana = mana;
            this.level = level;
        }

        public double Health
        {
            get
            {
                return health;
            }
            set
            {
                health = value;
            }
        }

        public double Mana
        {
            get
            {
                return mana;
            }
            set
            {
                mana = value;
            }
        }

        public double Attack
        {
            get
            {
                return attackDamage;
            }
            set
            {
                attackDamage = value;
            }
        }

        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                level = value;
            }
        }
    }
}
