using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MFulopSjANApeerProgrammingClasses
{
    class Monster
    {
        private string type;
        private double health; // hp
        private double mana;
        private bool isAlive;
        // constructor
        public Monster(string nType, double nHealth, double nMana)
        {
            type = nType;
            health = nHealth;
            mana = nMana;
            isAlive = true;
        }
        Random rand = new Random();
        // attack method
        public double attack(double playerHealth)
        {
            if (mana < 3)
            {
                mana++;
                // monsterAttack is the amount of hp taken from the player
                double monsterAttack = rand.Next(20, 50);
                return playerHealth - monsterAttack;
            }
            else
            {
                mana = mana - 3;
                // mana spell
                double choice = rand.Next(0, 2);
                if (choice == 0)
                {
                    // heal
                    health = health + 40;
                    return playerHealth - 0;
                }
                else
                {
                    // special attack
                    double monsterAttack = rand.Next(10, 60);
                    return playerHealth - monsterAttack;
                }
            }
        }

        // get set
        public bool IsAlive
        {
            get
            {
                if (health < 1)
                {
                    isAlive = false;
                }
                return isAlive;
            }
            set
            {
                isAlive = value;
            }
        }
        // health
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
        // get set
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

    }
}
