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
        int dice1 = 0;
        int dice2 = 0;
        int dice3 = 0;
        int dice4 = 0;
        int dice5 = 0;
        int dice6 = 0;
        int rollCount = 0;
        private SoundPlayer mPlayer = new SoundPlayer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UI_DiceBox1.Image = null;
            UI_DiceBox2.Image = null;
            UI_DiceBox3.Image = null;
            UI_DiceBox4.Image = null;
            UI_DiceBox5.Image = null;
            UI_DiceBox6.Image = null;
        }

        private void UI_RollButton_Click(object sender, EventArgs e)
        {
            imageTimer.Enabled = true;
            rollTimer.Enabled = true;
            rollCount++;
            
        }

        private void imageTimer_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            dice1 = rand.Next(6);
            dice2 = rand.Next(6);
            dice3 = rand.Next(6);
            dice4 = rand.Next(6);
            dice5 = rand.Next(6);
            dice6 = rand.Next(6);
            UI_DiceBox1.Image = imageList1.Images[dice1];
            UI_DiceBox2.Image = imageList1.Images[dice2];
            UI_DiceBox3.Image = imageList1.Images[dice3];
            UI_DiceBox4.Image = imageList1.Images[dice4];
            UI_DiceBox5.Image = imageList1.Images[dice5];
            UI_DiceBox6.Image = imageList1.Images[dice6];
        }

        private void rollTimer_Tick(object sender, EventArgs e)
        {
            imageTimer.Enabled = false;
            rollTimer.Enabled = false;
            UI_ScoreValue.Text = (((dice1 + 1) + (dice2 + 1) + (dice3 + 1) + (dice4 + 1) + (dice5 + 1) + (dice6 + 1)).ToString());


        }
    }
}
