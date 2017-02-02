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
            
        }

        private void imageTimer_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            UI_DiceBox1.Image = imageList1.Images[rand.Next(6)];
            UI_DiceBox2.Image = imageList1.Images[rand.Next(6)];
            UI_DiceBox3.Image = imageList1.Images[rand.Next(6)];
            UI_DiceBox4.Image = imageList1.Images[rand.Next(6)];
            UI_DiceBox5.Image = imageList1.Images[rand.Next(6)];
            UI_DiceBox6.Image = imageList1.Images[rand.Next(6)];
        }

        private void rollTimer_Tick(object sender, EventArgs e)
        {
            imageTimer.Enabled = false;
            rollTimer.Enabled = false;
        }
    }
}
