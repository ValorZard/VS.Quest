using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MFulopSjANApeerProgrammingClasses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Monster myMonster = new Monster("Biggy Axeball", 127, 0);

        public void resetButtons()
        {
            groupBox2.Visible = false;
            fireBallButton.Visible = false;
            healButton.Visible = false;
        }
        
        Player p = new Player();
        Random randy = new Random();
        private void attack_Click(object sender, EventArgs e)
        {
            /*
            myMonster.Health = 0;
            MessageBox.Show(myMonster.IsAlive.ToString());
             */
            // xp for mana points
            p.Mana = p.Mana + 1 + currentWeapon.ManaRegen;
            // weapon1.minDamage, weapon1.minDamage
            // weapon2.minDamage, ...
            // myWeapon.min, myWeapon.max
            p.Attack = randy.Next( (int)currentWeapon.MinDamage, (int)currentWeapon.MaxDamage) + (p.Level*5);
            // let the player attack first
            myMonster.Health = myMonster.Health - p.Attack;
            // check if the monster is dead
            if (myMonster.IsAlive == false)
            {
                MessageBox.Show("You are winner!");
                // reset player health
                p.Health = 100;
                p.Level++;
                p.Mana = 2+p.Level;

                // level++
                /// myMonster = new stats]
                myMonster = new Monster("Bingo Jackass",125+(p.Level*4), 1);
                /// // update the labels
            }
            else
            {
                // let monster attack player
                p.Health = myMonster.attack(p.Health);
                if (p.Health < 1)
                {
                    MessageBox.Show("You are loser!");
                    this.Close();
                }
            }
            // update labels
            // monster statzxs
            mHealth.Text = myMonster.Health.ToString();
            mMana.Text = myMonster.Mana.ToString();
            enemyDamage.Text = "You've taken: " + myMonster.MonsterAttack;
            // player stasz
            pHealth.Text = p.Health.ToString();
            pMana.Text = p.Mana.ToString();
            playerDamage.Text = "You dealt: " + p.Attack.ToString();
        }

        private void spellButton_Click(object sender, EventArgs e)
        {
            if (p.Mana < 3)
            {
                MessageBox.Show("Not Enough Mana");
            }
            else
            {
                groupBox2.Visible = true;
                fireBallButton.Visible = true;
                healButton.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // monster statzxs
            mHealth.Text = myMonster.Health.ToString();
            mMana.Text = myMonster.Mana.ToString();
            monsterName.Text = myMonster.MonsterType;
            // player stasz
            pHealth.Text = p.Health.ToString();
            pMana.Text = p.Mana.ToString();
            // check button
            crowbarButton.Checked = true;
            playerDamage.Text = "You dealt: 0";
            enemyDamage.Text = "You dealt: 0";
        }

        private void healButton_Click(object sender, EventArgs e)
        {
            p.Health = p.Health + 60;
            p.Mana = p.Mana - 3;
            resetButtons();
            if (myMonster.IsAlive == false)
            {
                MessageBox.Show("You are winner!");
            }
            else
            {
                // let monster attack player
                p.Health = myMonster.attack(p.Health);
                playerDamage.Text = "You dealt: 0";
                enemyDamage.Text = "You've taken: " + myMonster.MonsterAttack;
                if (p.Health < 1)
                {
                    MessageBox.Show("You are loser!");
                    this.Close();
                }
            }
        }

        private void fireBallButton_Click(object sender, EventArgs e)
        {
            double fireBallDamage = randy.Next(1, 100);
            myMonster.Health = myMonster.Health - fireBallDamage;
            // remove mana
            p.Mana = p.Mana - 3;
            /// reset everything
            resetButtons(); 
            if (myMonster.IsAlive == false)
            {
                MessageBox.Show("You are winner!");
            }
            else
            {
                // player
                enemyDamage.Text = "You've taken: " + myMonster.MonsterAttack;
                playerDamage.Text = "You dealt: " + fireBallDamage.ToString();
                // let monster attack player
                p.Health = myMonster.attack(p.Health);
                if (p.Health < 1)
                {
                    MessageBox.Show("You are loser!");
                    this.Close();
                }
            }
        }
        Weapon currentWeapon;
        private void updateStats_Tick(object sender, EventArgs e)
        {
            if (knifeButton.Checked == true)
            {
                currentWeapon = new Weapon(9, 30, 0, 1);
            }
            if (crowbarButton.Checked == true)
            {
                currentWeapon = new Weapon(12, 40, 0, 0);
            }
            if (swordButton.Checked == true)
            {
                currentWeapon = new Weapon(10, 35, 8, 0);
            }
            // monster statzxs
            mHealth.Text = myMonster.Health.ToString();
            mMana.Text = myMonster.Mana.ToString();
            // player stasz
            pHealth.Text = p.Health.ToString();
            pMana.Text = p.Mana.ToString();

        }

        

    }
}
