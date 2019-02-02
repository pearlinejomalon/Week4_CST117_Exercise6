using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise6
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonRollDice_Click(object sender, EventArgs e)
        {
            //create new dice objects
            Dice redDie = new Dice(12);
            Dice blueDie = new Dice(6);
            bool snakeEyes = false;

            //Set random dice rolls
            int redDigit = 0;
            int blueDigit = 0;

            //set number of sides for red die
            while (!snakeEyes)
            {
                textDie1.Text = "";
                textDie2.Text = "";

                //Get random dice rolls
                redDigit = redDie.rollDie();
                blueDigit = blueDie.rollDie();

                //Add dice rolls
                textDie1.Text = Convert.ToString(redDigit);
                textDie2.Text = Convert.ToString(blueDigit);

                if ((redDigit == blueDigit) && (redDigit == 1))
                {
                    snakeEyes = true;
                    MessageBox.Show(string.Format("You got snake eyes in {0} tries.", redDie.NumberOfRolls));
                }
            }

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
