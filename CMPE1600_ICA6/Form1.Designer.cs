namespace CMPE1600_ICA6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.UI_DiceBox1 = new System.Windows.Forms.Label();
            this.UI_RollButton = new System.Windows.Forms.Button();
            this.UI_PlayAgainButton = new System.Windows.Forms.Button();
            this.UI_DiceBox2 = new System.Windows.Forms.Label();
            this.UI_DiceBox3 = new System.Windows.Forms.Label();
            this.UI_DiceBox4 = new System.Windows.Forms.Label();
            this.UI_DiceBox5 = new System.Windows.Forms.Label();
            this.UI_DiceBox6 = new System.Windows.Forms.Label();
            this.UI_RollLabel = new System.Windows.Forms.Label();
            this.UI_ScoreLabel = new System.Windows.Forms.Label();
            this.imageTimer = new System.Windows.Forms.Timer(this.components);
            this.rollTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Dice1.png");
            this.imageList1.Images.SetKeyName(1, "Dice2.png");
            this.imageList1.Images.SetKeyName(2, "Dice3.png");
            this.imageList1.Images.SetKeyName(3, "Dice4.png");
            this.imageList1.Images.SetKeyName(4, "Dice5.png");
            this.imageList1.Images.SetKeyName(5, "Dice6.png");
            // 
            // UI_DiceBox1
            // 
            this.UI_DiceBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UI_DiceBox1.Location = new System.Drawing.Point(12, 35);
            this.UI_DiceBox1.Name = "UI_DiceBox1";
            this.UI_DiceBox1.Size = new System.Drawing.Size(45, 45);
            this.UI_DiceBox1.TabIndex = 0;
            // 
            // UI_RollButton
            // 
            this.UI_RollButton.Location = new System.Drawing.Point(124, 102);
            this.UI_RollButton.Name = "UI_RollButton";
            this.UI_RollButton.Size = new System.Drawing.Size(75, 23);
            this.UI_RollButton.TabIndex = 1;
            this.UI_RollButton.Text = "Roll";
            this.UI_RollButton.UseVisualStyleBackColor = true;
            this.UI_RollButton.Click += new System.EventHandler(this.UI_RollButton_Click);
            // 
            // UI_PlayAgainButton
            // 
            this.UI_PlayAgainButton.Location = new System.Drawing.Point(124, 194);
            this.UI_PlayAgainButton.Name = "UI_PlayAgainButton";
            this.UI_PlayAgainButton.Size = new System.Drawing.Size(75, 23);
            this.UI_PlayAgainButton.TabIndex = 2;
            this.UI_PlayAgainButton.Text = "Play Again";
            this.UI_PlayAgainButton.UseVisualStyleBackColor = true;
            // 
            // UI_DiceBox2
            // 
            this.UI_DiceBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UI_DiceBox2.Location = new System.Drawing.Point(63, 35);
            this.UI_DiceBox2.Name = "UI_DiceBox2";
            this.UI_DiceBox2.Size = new System.Drawing.Size(45, 45);
            this.UI_DiceBox2.TabIndex = 3;
            // 
            // UI_DiceBox3
            // 
            this.UI_DiceBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UI_DiceBox3.Location = new System.Drawing.Point(114, 35);
            this.UI_DiceBox3.Name = "UI_DiceBox3";
            this.UI_DiceBox3.Size = new System.Drawing.Size(45, 45);
            this.UI_DiceBox3.TabIndex = 4;
            // 
            // UI_DiceBox4
            // 
            this.UI_DiceBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UI_DiceBox4.Location = new System.Drawing.Point(165, 35);
            this.UI_DiceBox4.Name = "UI_DiceBox4";
            this.UI_DiceBox4.Size = new System.Drawing.Size(45, 45);
            this.UI_DiceBox4.TabIndex = 5;
            // 
            // UI_DiceBox5
            // 
            this.UI_DiceBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UI_DiceBox5.Location = new System.Drawing.Point(216, 35);
            this.UI_DiceBox5.Name = "UI_DiceBox5";
            this.UI_DiceBox5.Size = new System.Drawing.Size(45, 45);
            this.UI_DiceBox5.TabIndex = 6;
            // 
            // UI_DiceBox6
            // 
            this.UI_DiceBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UI_DiceBox6.Location = new System.Drawing.Point(267, 35);
            this.UI_DiceBox6.Name = "UI_DiceBox6";
            this.UI_DiceBox6.Size = new System.Drawing.Size(45, 45);
            this.UI_DiceBox6.TabIndex = 7;
            // 
            // UI_RollLabel
            // 
            this.UI_RollLabel.AutoSize = true;
            this.UI_RollLabel.Location = new System.Drawing.Point(121, 138);
            this.UI_RollLabel.Name = "UI_RollLabel";
            this.UI_RollLabel.Size = new System.Drawing.Size(25, 13);
            this.UI_RollLabel.TabIndex = 8;
            this.UI_RollLabel.Text = "Roll";
            // 
            // UI_ScoreLabel
            // 
            this.UI_ScoreLabel.AutoSize = true;
            this.UI_ScoreLabel.Location = new System.Drawing.Point(121, 168);
            this.UI_ScoreLabel.Name = "UI_ScoreLabel";
            this.UI_ScoreLabel.Size = new System.Drawing.Size(35, 13);
            this.UI_ScoreLabel.TabIndex = 9;
            this.UI_ScoreLabel.Text = "Score";
            // 
            // imageTimer
            // 
            this.imageTimer.Tick += new System.EventHandler(this.imageTimer_Tick);
            // 
            // rollTimer
            // 
            this.rollTimer.Interval = 1000;
            this.rollTimer.Tick += new System.EventHandler(this.rollTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 261);
            this.Controls.Add(this.UI_ScoreLabel);
            this.Controls.Add(this.UI_RollLabel);
            this.Controls.Add(this.UI_DiceBox6);
            this.Controls.Add(this.UI_DiceBox5);
            this.Controls.Add(this.UI_DiceBox4);
            this.Controls.Add(this.UI_DiceBox3);
            this.Controls.Add(this.UI_DiceBox2);
            this.Controls.Add(this.UI_PlayAgainButton);
            this.Controls.Add(this.UI_RollButton);
            this.Controls.Add(this.UI_DiceBox1);
            this.Name = "Form1";
            this.Text = "Roll\'em";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label UI_DiceBox1;
        private System.Windows.Forms.Button UI_RollButton;
        private System.Windows.Forms.Button UI_PlayAgainButton;
        private System.Windows.Forms.Label UI_DiceBox2;
        private System.Windows.Forms.Label UI_DiceBox3;
        private System.Windows.Forms.Label UI_DiceBox4;
        private System.Windows.Forms.Label UI_DiceBox5;
        private System.Windows.Forms.Label UI_DiceBox6;
        private System.Windows.Forms.Label UI_RollLabel;
        private System.Windows.Forms.Label UI_ScoreLabel;
        private System.Windows.Forms.Timer imageTimer;
        private System.Windows.Forms.Timer rollTimer;
    }
}

