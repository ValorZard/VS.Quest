namespace MFulopSjANApeerProgrammingClasses
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.healButton = new System.Windows.Forms.Button();
            this.fireBallButton = new System.Windows.Forms.Button();
            this.pMana = new System.Windows.Forms.Label();
            this.pHealth = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.spellButton = new System.Windows.Forms.Button();
            this.attack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mHealth = new System.Windows.Forms.Label();
            this.mMana = new System.Windows.Forms.Label();
            this.updateStats = new System.Windows.Forms.Timer(this.components);
            this.knifeButton = new System.Windows.Forms.RadioButton();
            this.crowbarButton = new System.Windows.Forms.RadioButton();
            this.swordButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.swordButton);
            this.groupBox1.Controls.Add(this.crowbarButton);
            this.groupBox1.Controls.Add(this.knifeButton);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.pMana);
            this.groupBox1.Controls.Add(this.pHealth);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.spellButton);
            this.groupBox1.Controls.Add(this.attack);
            this.groupBox1.Location = new System.Drawing.Point(15, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(774, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.healButton);
            this.groupBox2.Controls.Add(this.fireBallButton);
            this.groupBox2.Location = new System.Drawing.Point(255, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 110);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            this.groupBox2.Visible = false;
            // 
            // healButton
            // 
            this.healButton.Location = new System.Drawing.Point(6, 70);
            this.healButton.Name = "healButton";
            this.healButton.Size = new System.Drawing.Size(187, 23);
            this.healButton.TabIndex = 1;
            this.healButton.Text = "Heal";
            this.healButton.UseVisualStyleBackColor = true;
            this.healButton.Visible = false;
            this.healButton.Click += new System.EventHandler(this.healButton_Click);
            // 
            // fireBallButton
            // 
            this.fireBallButton.Location = new System.Drawing.Point(6, 29);
            this.fireBallButton.Name = "fireBallButton";
            this.fireBallButton.Size = new System.Drawing.Size(187, 23);
            this.fireBallButton.TabIndex = 0;
            this.fireBallButton.Text = "Fire Ball!";
            this.fireBallButton.UseVisualStyleBackColor = true;
            this.fireBallButton.Visible = false;
            this.fireBallButton.Click += new System.EventHandler(this.fireBallButton_Click);
            // 
            // pMana
            // 
            this.pMana.AutoSize = true;
            this.pMana.Location = new System.Drawing.Point(6, 51);
            this.pMana.Name = "pMana";
            this.pMana.Size = new System.Drawing.Size(35, 13);
            this.pMana.TabIndex = 4;
            this.pMana.Text = "label3";
            // 
            // pHealth
            // 
            this.pHealth.AutoSize = true;
            this.pHealth.Location = new System.Drawing.Point(6, 27);
            this.pHealth.Name = "pHealth";
            this.pHealth.Size = new System.Drawing.Size(35, 13);
            this.pHealth.TabIndex = 5;
            this.pHealth.Text = "label4";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(560, 112);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(208, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Change Weapons";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // spellButton
            // 
            this.spellButton.Location = new System.Drawing.Point(127, 46);
            this.spellButton.Name = "spellButton";
            this.spellButton.Size = new System.Drawing.Size(75, 23);
            this.spellButton.TabIndex = 1;
            this.spellButton.Text = "Spell";
            this.spellButton.UseVisualStyleBackColor = true;
            this.spellButton.Click += new System.EventHandler(this.spellButton_Click);
            // 
            // attack
            // 
            this.attack.Location = new System.Drawing.Point(127, 17);
            this.attack.Name = "attack";
            this.attack.Size = new System.Drawing.Size(75, 23);
            this.attack.TabIndex = 0;
            this.attack.Text = "Attack";
            this.attack.UseVisualStyleBackColor = true;
            this.attack.Click += new System.EventHandler(this.attack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MFulopSjANApeerProgrammingClasses.Properties.Resources.ranMonster;
            this.pictureBox1.Location = new System.Drawing.Point(231, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // mHealth
            // 
            this.mHealth.AutoSize = true;
            this.mHealth.Location = new System.Drawing.Point(12, 13);
            this.mHealth.Name = "mHealth";
            this.mHealth.Size = new System.Drawing.Size(35, 13);
            this.mHealth.TabIndex = 2;
            this.mHealth.Text = "label1";
            // 
            // mMana
            // 
            this.mMana.AutoSize = true;
            this.mMana.Location = new System.Drawing.Point(12, 40);
            this.mMana.Name = "mMana";
            this.mMana.Size = new System.Drawing.Size(35, 13);
            this.mMana.TabIndex = 3;
            this.mMana.Text = "label2";
            // 
            // updateStats
            // 
            this.updateStats.Enabled = true;
            this.updateStats.Tick += new System.EventHandler(this.updateStats_Tick);
            // 
            // knifeButton
            // 
            this.knifeButton.AutoSize = true;
            this.knifeButton.Location = new System.Drawing.Point(560, 17);
            this.knifeButton.Name = "knifeButton";
            this.knifeButton.Size = new System.Drawing.Size(83, 17);
            this.knifeButton.TabIndex = 7;
            this.knifeButton.TabStop = true;
            this.knifeButton.Text = "Knife of Day";
            this.knifeButton.UseVisualStyleBackColor = true;
            // 
            // crowbarButton
            // 
            this.crowbarButton.AutoSize = true;
            this.crowbarButton.Location = new System.Drawing.Point(560, 46);
            this.crowbarButton.Name = "crowbarButton";
            this.crowbarButton.Size = new System.Drawing.Size(137, 17);
            this.crowbarButton.TabIndex = 8;
            this.crowbarButton.TabStop = true;
            this.crowbarButton.Text = "The Freeman\'s Crowbar";
            this.crowbarButton.UseVisualStyleBackColor = true;
            // 
            // swordButton
            // 
            this.swordButton.AutoSize = true;
            this.swordButton.Location = new System.Drawing.Point(560, 78);
            this.swordButton.Name = "swordButton";
            this.swordButton.Size = new System.Drawing.Size(132, 17);
            this.swordButton.TabIndex = 9;
            this.swordButton.TabStop = true;
            this.swordButton.Text = "Sword of Nostradamus";
            this.swordButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.swordButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 398);
            this.Controls.Add(this.mMana);
            this.Controls.Add(this.mHealth);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button spellButton;
        private System.Windows.Forms.Button attack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label pMana;
        private System.Windows.Forms.Label pHealth;
        private System.Windows.Forms.Label mHealth;
        private System.Windows.Forms.Label mMana;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button healButton;
        private System.Windows.Forms.Button fireBallButton;
        private System.Windows.Forms.Timer updateStats;
        private System.Windows.Forms.RadioButton swordButton;
        private System.Windows.Forms.RadioButton crowbarButton;
        private System.Windows.Forms.RadioButton knifeButton;
    }
}

