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

        Monster myMonster = new Monster("big", 150, 0);

        public void resetButtons()
        {
            groupBox2.Visible = false;
            fireBallButton.Visible = false;
            healButton.Visible = false;
        }

        double playerHealth = 100;
        double playerAttack;
        double playerMana = 3;
        Random randy = new Random();
        private void attack_Click(object sender, EventArgs e)
        {
            /*
            myMonster.Health = 0;
            MessageBox.Show(myMonster.IsAlive.ToString());
             */
            // xp for mana points
            playerMana++;
            playerAttack = randy.Next(10, 30);
            // let the player attack first
            myMonster.Health = myMonster.Health - playerAttack;
            // check if the monster is dead
            if (myMonster.IsAlive == false)
            {
                MessageBox.Show("You are winner!");
            }
            else
            {
                // let monster attack player
                playerHealth = myMonster.attack(playerHealth);
                if (playerHealth < 1)
                {
                    MessageBox.Show("You are loser!");
                    this.Close();
                }
            }
            // update labels
            // monster statzxs
            mHealth.Text = myMonster.Health.ToString();
            mMana.Text = myMonster.Mana.ToString();
            // player stasz
            pHealth.Text = playerHealth.ToString();
            pMana.Text = playerMana.ToString();
        }

        private void spellButton_Click(object sender, EventArgs e)
        {
            if (playerMana < 3)
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
            // player stasz
            pHealth.Text = playerHealth.ToString();
            pMana.Text = playerMana.ToString();
        }

        private void healButton_Click(object sender, EventArgs e)
        {
            playerHealth = playerHealth + 60;
            playerMana = playerMana - 3;
            resetButtons();
            if (myMonster.IsAlive == false)
            {
                MessageBox.Show("You are winner!");
            }
            else
            {
                // let monster attack player
                playerHealth = myMonster.attack(playerHealth);
                if (playerHealth < 1)
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
            playerMana = playerMana - 3;
            /// reset everything
            resetButtons();
            if (myMonster.IsAlive == false)
            {
                MessageBox.Show("You are winner!");
            }
            else
            {
                // let monster attack player
                playerHealth = myMonster.attack(playerHealth);
                if (playerHealth < 1)
                {
                    MessageBox.Show("You are loser!");
                    this.Close();
                }
            }
        }

        private void updateStats_Tick(object sender, EventArgs e)
        {
            // monster statzxs
            mHealth.Text = myMonster.Health.ToString();
            mMana.Text = myMonster.Mana.ToString();
            // player stasz
            pHealth.Text = playerHealth.ToString();
            pMana.Text = playerMana.ToString();
        }

    }
}
