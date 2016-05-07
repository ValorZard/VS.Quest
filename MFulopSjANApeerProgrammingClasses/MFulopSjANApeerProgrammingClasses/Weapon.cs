using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MFulopSjANApeerProgrammingClasses
{
    class Weapon
    {
        private double minDamage;
        private double maxDamage;
        private double healthRegen;
        private double manaRegen;
        public Weapon(double nMinDamage, double nMaxDamage, double healthRegen1, double manaRege1n)
        {
          minDamage = nMinDamage;
          maxDamage = nMaxDamage;
          healthRegen = healthRegen1;
          manaRegen = manaRege1n;
        }
        // get set
        public double MaxDamage
        {
            get
            {
                return maxDamage;
            }
            set
            {
                maxDamage = value;
            }
        }
        // get set
        public double MinDamage
        {
            get
            {
                return minDamage;
            }
            set
            {
                minDamage = value;
            }
        }
        // 
        public double ManaRegen
        {
            get
            {
                return manaRegen;
            }
            set
            {
                manaRegen = value;
            }
        }
        public double HealthRegen
        {
            get
            {
                return healthRegen;
            }
            set
            {
                healthRegen = value;
            }
        }
    }
}
