using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace CMPE1600_ICA6
{
    public partial class Form1 : Form
    {
        int dice1 = 0;  //
        int dice2 = 0;  //
        int dice3 = 0;  //
        int dice4 = 0;  //  These store the value of the dice
        int dice5 = 0;  //
        int dice6 = 0;  //
        bool dice1Hold = false; //
        bool dice2Hold = false; //
        bool dice3Hold = false; //
        bool dice4Hold = false; //  These check if the dice should be held or not
        bool dice5Hold = false; //
        bool dice6Hold = false; //
        int rollCount = 0;      //  Counts how many times roll has been clocked
        SoundPlayer mPlayer = new SoundPlayer(CMPE1600_ICA6.Properties.Resources.diceboard);    //preps sound file
        public Form1()
        {
            InitializeComponent();
        }

        //Preps the labels to have images
        private void Form1_Load(object sender, EventArgs e)
        {                        
            UI_DiceBox1.Image = null;
            UI_DiceBox2.Image = null;
            UI_DiceBox3.Image = null;
            UI_DiceBox4.Image = null;
            UI_DiceBox5.Image = null;
            UI_DiceBox6.Image = null;
        }

        //Starts the dice roll timers, and increments rolls
        //updates the roll label
        private void UI_RollButton_Click(object sender, EventArgs e)
        {
            imageTimer.Enabled = true;
            rollTimer.Enabled = true;
            mPlayer.Play();
            rollCount++;
            UI_RollValue.Text = rollCount.ToString();
        }

        //On each tick, stores a random number in each die value
        //unless there has been a hold placed on that die.
        //Each label then accesses an image according to
        //value stored at last tick
        private void imageTimer_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            DiceRandomizer(rand);
            DiceRolling();
        }

        //Controls length of time that dice roll
        //On tick, stops itself and image timer
        //Gets total of dice values
        //Disables roll button on 3rd roll, enabled play again
        private void rollTimer_Tick(object sender, EventArgs e)
        {
            imageTimer.Enabled = false;
            rollTimer.Enabled = false;
            UI_ScoreValue.Text = (((dice1 + 1) + (dice2 + 1) + (dice3 + 1) + (dice4 + 1) + (dice5 + 1) + (dice6 + 1)).ToString());
            if (rollCount > 2)
            {
                UI_ScoreLabel.Text = "Final Score: ";
                UI_PlayAgainButton.Enabled = true;
                UI_RollButton.Enabled = false;
            }
        }

        //Resets everything to base case
        private void UI_PlayAgainButton_Click(object sender, EventArgs e)
        {
            GameReset();

        }

        //      All events below detect click on die, and change
        //      border color based on previous state, as well as
        //      either puts a hold on die or not depending on
        //      previous state
        private void UI_DiceBox1_MouseClick(object sender, MouseEventArgs e)
        {            
            if (rollCount != 0)
            {
                
                if ((UI_DiceBox1.BackColor == Color.White) || (UI_DiceBox1.BackColor == Color.Green))
                {
                    UI_DiceBox1.BackColor = Color.Red;
                    dice1Hold = true;
                }
                else if (UI_DiceBox1.BackColor == Color.Red)
                {
                    UI_DiceBox1.BackColor = Color.Green;
                    dice1Hold = false;
                }
            }
        }
        private void UI_DiceBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (rollCount != 0)
            {

                if ((UI_DiceBox2.BackColor == Color.White) || (UI_DiceBox2.BackColor == Color.Green))
                {
                    UI_DiceBox2.BackColor = Color.Red;
                    dice2Hold = true;
                }
                else if (UI_DiceBox2.BackColor == Color.Red)
                {
                    UI_DiceBox2.BackColor = Color.Green;
                    dice2Hold = false;
                }
            }
        }
        private void UI_DiceBox3_MouseClick(object sender, MouseEventArgs e)
        {
            if (rollCount != 0)
            {

                if ((UI_DiceBox3.BackColor == Color.White) || (UI_DiceBox3.BackColor == Color.Green))
                {
                    UI_DiceBox3.BackColor = Color.Red;
                    dice3Hold = true;
                }
                else if (UI_DiceBox3.BackColor == Color.Red)
                {
                    UI_DiceBox3.BackColor = Color.Green;
                    dice3Hold = false;
                }
            }
        }
        private void UI_DiceBox4_MouseClick(object sender, MouseEventArgs e)
        {
            if (rollCount != 0)
            {

                if ((UI_DiceBox4.BackColor == Color.White) || (UI_DiceBox4.BackColor == Color.Green))
                {
                    UI_DiceBox4.BackColor = Color.Red;
                    dice4Hold = true;
                }
                else if (UI_DiceBox4.BackColor == Color.Red)
                {
                    UI_DiceBox4.BackColor = Color.Green;
                    dice4Hold = false;
                }
            }
        }

        private void UI_DiceBox5_MouseClick(object sender, MouseEventArgs e)
        {
            if (rollCount != 0)
            {

                if ((UI_DiceBox5.BackColor == Color.White) || (UI_DiceBox5.BackColor == Color.Green))
                {
                    UI_DiceBox5.BackColor = Color.Red;
                    dice5Hold = true;
                }
                else if (UI_DiceBox5.BackColor == Color.Red)
                {
                    UI_DiceBox5.BackColor = Color.Green;
                    dice5Hold = false;
                }
            }
        }

        private void UI_DiceBox6_MouseClick(object sender, MouseEventArgs e)
        {
            if (rollCount != 0)
            {

                if ((UI_DiceBox6.BackColor == Color.White) || (UI_DiceBox6.BackColor == Color.Green))
                {
                    UI_DiceBox6.BackColor = Color.Red;
                    dice6Hold = true;
                }
                else if (UI_DiceBox6.BackColor == Color.Red)
                {
                    UI_DiceBox6.BackColor = Color.Green;
                    dice6Hold = false;
                }
            }
        }
        //
        // End of Dice Hold and click methods
        //

        //Resets most objects to their initial state
        private void GameReset()
        {
            UI_RollButton.Enabled = true;
            rollCount = 0;
            UI_RollValue.Text = 0.ToString();
            UI_ScoreLabel.Text = "Score:";
            UI_ScoreValue.Text = 0.ToString();
            DiceReset();
        }
        //Resets all the dice and dice boxes
        private void DiceReset()
        {
            UI_DiceBox1.BackColor = Color.White;
            dice1Hold = false;
            UI_DiceBox2.BackColor = Color.White;
            dice2Hold = false;
            UI_DiceBox3.BackColor = Color.White;
            dice3Hold = false;
            UI_DiceBox4.BackColor = Color.White;
            dice4Hold = false;
            UI_DiceBox5.BackColor = Color.White;
            dice5Hold = false;
            UI_DiceBox6.BackColor = Color.White;
            dice6Hold = false;
            UI_DiceBox1.Image = null;
            UI_DiceBox2.Image = null;
            UI_DiceBox3.Image = null;
            UI_DiceBox4.Image = null;
            UI_DiceBox5.Image = null;
            UI_DiceBox6.Image = null;
        }
        //Randomizes dice value, but
        //does not actually change
        //the image shown -- see DiceRolling
        private void DiceRandomizer(Random rand)
        {
            if (dice1Hold == false)
                dice1 = rand.Next(6);
            if (dice2Hold == false)
                dice2 = rand.Next(6);
            if (dice3Hold == false)
                dice3 = rand.Next(6);
            if (dice4Hold == false)
                dice4 = rand.Next(6);
            if (dice5Hold == false)
                dice5 = rand.Next(6);
            if (dice6Hold == false)
                dice6 = rand.Next(6);
        }
        //Changes the dice image shown
        //based on the randomized value
        //at each timer tick
        private void DiceRolling()
        {
            UI_DiceBox1.Image = imageList1.Images[dice1];
            UI_DiceBox2.Image = imageList1.Images[dice2];
            UI_DiceBox3.Image = imageList1.Images[dice3];
            UI_DiceBox4.Image = imageList1.Images[dice4];
            UI_DiceBox5.Image = imageList1.Images[dice5];
            UI_DiceBox6.Image = imageList1.Images[dice6];
        }
    }
}
