namespace WinFormsApp1
{
    partial class Play
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
            pictureBox1 = new PictureBox();
            button0 = new Button();
            button1 = new Button();
            button2 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            lblStatus = new Label();
            lblPlayerScore = new Label();
            lblCpuScore = new Label();
            lblDraws = new Label();
            btnNextRound = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ticgrid;
            pictureBox1.Location = new Point(0, 141);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(394, 308);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button0
            // 
            button0.BackgroundImageLayout = ImageLayout.Zoom;
            button0.Location = new Point(50, 150);
            button0.Name = "button0";
            button0.Size = new Size(93, 91);
            button0.TabIndex = 1;
            button0.Text = "button0";
            button0.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(149, 150);
            button1.Name = "button1";
            button1.Size = new Size(93, 91);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(250, 150);
            button2.Name = "button2";
            button2.Size = new Size(93, 91);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.Location = new Point(250, 249);
            button5.Name = "button5";
            button5.Size = new Size(93, 91);
            button5.TabIndex = 1;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Location = new Point(149, 247);
            button4.Name = "button4";
            button4.Size = new Size(93, 91);
            button4.TabIndex = 1;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Location = new Point(50, 247);
            button3.Name = "button3";
            button3.Size = new Size(93, 91);
            button3.TabIndex = 1;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.BackgroundImageLayout = ImageLayout.Zoom;
            button6.Location = new Point(50, 348);
            button6.Name = "button6";
            button6.Size = new Size(93, 91);
            button6.TabIndex = 1;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.BackgroundImageLayout = ImageLayout.Zoom;
            button7.Location = new Point(149, 348);
            button7.Name = "button7";
            button7.Size = new Size(93, 91);
            button7.TabIndex = 1;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.BackgroundImageLayout = ImageLayout.Zoom;
            button8.Location = new Point(250, 348);
            button8.Name = "button8";
            button8.Size = new Size(93, 91);
            button8.TabIndex = 1;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = SystemColors.ActiveCaption;
            lblStatus.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(130, 57);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(44, 16);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "status";
            lblStatus.Click += lblStatus_Click;
            // 
            // lblPlayerScore
            // 
            lblPlayerScore.AutoSize = true;
            lblPlayerScore.BackColor = SystemColors.ActiveCaption;
            lblPlayerScore.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlayerScore.Location = new Point(34, 27);
            lblPlayerScore.Name = "lblPlayerScore";
            lblPlayerScore.Size = new Size(50, 16);
            lblPlayerScore.TabIndex = 2;
            lblPlayerScore.Text = "player";
            // 
            // lblCpuScore
            // 
            lblCpuScore.AutoSize = true;
            lblCpuScore.BackColor = SystemColors.ActiveCaption;
            lblCpuScore.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCpuScore.Location = new Point(305, 27);
            lblCpuScore.Name = "lblCpuScore";
            lblCpuScore.Size = new Size(32, 16);
            lblCpuScore.TabIndex = 2;
            lblCpuScore.Text = "cpu";
            // 
            // lblDraws
            // 
            lblDraws.AutoSize = true;
            lblDraws.BackColor = SystemColors.ActiveCaption;
            lblDraws.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDraws.Location = new Point(130, 99);
            lblDraws.Name = "lblDraws";
            lblDraws.Size = new Size(61, 16);
            lblDraws.TabIndex = 2;
            lblDraws.Text = "Draws: 0";
            lblDraws.Click += lblStatus_Click;
            // 
            // btnNextRound
            // 
            btnNextRound.BackColor = SystemColors.Control;
            btnNextRound.Location = new Point(305, 112);
            btnNextRound.Name = "btnNextRound";
            btnNextRound.Size = new Size(85, 23);
            btnNextRound.TabIndex = 3;
            btnNextRound.Text = "Next Round";
            btnNextRound.UseVisualStyleBackColor = false;
            btnNextRound.Click += btnNextRound_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaption;
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(391, 144);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // Play
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 450);
            Controls.Add(btnNextRound);
            Controls.Add(lblCpuScore);
            Controls.Add(lblPlayerScore);
            Controls.Add(lblDraws);
            Controls.Add(lblStatus);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button0);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "Play";
            Text = "Play";
            Load += Play_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button0;
        private Button button1;
        private Button button2;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button6;
        private Button button7;
        private Button button8;
        private Label lblStatus;
        private Label lblPlayerScore;
        private Label lblCpuScore;
        private Label lblDraws;
        private Button btnNextRound;
        private PictureBox pictureBox2;
    }
}