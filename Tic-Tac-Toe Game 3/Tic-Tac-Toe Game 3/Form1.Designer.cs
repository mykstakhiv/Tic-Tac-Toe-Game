namespace Tic_Tac_Toe_Game_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            CPUTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 0;
            label1.Text = "Player Wins:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(192, 0, 0);
            label2.Location = new Point(358, 9);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 1;
            label2.Text = "CPU Wins:";
            // 
            // button1
            // 
            button1.BackColor = Color.Thistle;
            button1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(89, 64);
            button1.Name = "button1";
            button1.Size = new Size(96, 96);
            button1.TabIndex = 2;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = false;
            button1.Click += PlayerClickButton;
            // 
            // button2
            // 
            button2.BackColor = Color.Thistle;
            button2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(191, 64);
            button2.Name = "button2";
            button2.Size = new Size(96, 96);
            button2.TabIndex = 3;
            button2.Text = "?";
            button2.UseVisualStyleBackColor = false;
            button2.Click += PlayerClickButton;
            // 
            // button3
            // 
            button3.BackColor = Color.Thistle;
            button3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(293, 64);
            button3.Name = "button3";
            button3.Size = new Size(96, 96);
            button3.TabIndex = 4;
            button3.Text = "?";
            button3.UseVisualStyleBackColor = false;
            button3.Click += PlayerClickButton;
            // 
            // button4
            // 
            button4.BackColor = Color.Thistle;
            button4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(89, 166);
            button4.Name = "button4";
            button4.Size = new Size(96, 96);
            button4.TabIndex = 5;
            button4.Text = "?";
            button4.UseVisualStyleBackColor = false;
            button4.Click += PlayerClickButton;
            // 
            // button5
            // 
            button5.BackColor = Color.Thistle;
            button5.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(191, 166);
            button5.Name = "button5";
            button5.Size = new Size(96, 96);
            button5.TabIndex = 6;
            button5.Text = "?";
            button5.UseVisualStyleBackColor = false;
            button5.Click += PlayerClickButton;
            // 
            // button6
            // 
            button6.BackColor = Color.Thistle;
            button6.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(293, 166);
            button6.Name = "button6";
            button6.Size = new Size(96, 96);
            button6.TabIndex = 7;
            button6.Text = "?";
            button6.UseVisualStyleBackColor = false;
            button6.Click += PlayerClickButton;
            // 
            // button7
            // 
            button7.BackColor = Color.Thistle;
            button7.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(89, 268);
            button7.Name = "button7";
            button7.Size = new Size(96, 96);
            button7.TabIndex = 8;
            button7.Text = "?";
            button7.UseVisualStyleBackColor = false;
            button7.Click += PlayerClickButton;
            // 
            // button8
            // 
            button8.BackColor = Color.Thistle;
            button8.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(191, 268);
            button8.Name = "button8";
            button8.Size = new Size(96, 96);
            button8.TabIndex = 9;
            button8.Text = "?";
            button8.UseVisualStyleBackColor = false;
            button8.Click += PlayerClickButton;
            // 
            // button9
            // 
            button9.BackColor = Color.Thistle;
            button9.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(293, 268);
            button9.Name = "button9";
            button9.Size = new Size(96, 96);
            button9.TabIndex = 10;
            button9.Text = "?";
            button9.UseVisualStyleBackColor = false;
            button9.Click += PlayerClickButton;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(0, 192, 192);
            button10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button10.Location = new Point(176, 386);
            button10.Name = "button10";
            button10.Size = new Size(129, 41);
            button10.TabIndex = 11;
            button10.Text = "Restart Game";
            button10.UseVisualStyleBackColor = false;
            button10.Click += RestartGame;
            // 
            // CPUTimer
            // 
            CPUTimer.Interval = 1;
            CPUTimer.Tick += CPUmove;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 453);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Tic-Tac-Toe Game Win Forms MOO ICT";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private System.Windows.Forms.Timer CPUTimer;
    }
}