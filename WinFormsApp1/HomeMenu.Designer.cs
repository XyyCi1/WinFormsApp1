namespace WinFormsApp1
{
    partial class HomeMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeMenu));
            labelUsername = new Label();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox6 = new PictureBox();
            label1 = new Label();
            button2 = new Button();
            ButtonChange = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.BackColor = SystemColors.ActiveCaption;
            labelUsername.Font = new Font("Century Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(206, 20);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(186, 41);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "username";
            labelUsername.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(265, 283);
            button1.Name = "button1";
            button1.Size = new Size(267, 47);
            button1.TabIndex = 1;
            button1.Text = "View Match History";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(301, 345);
            button3.Name = "button3";
            button3.Size = new Size(196, 49);
            button3.TabIndex = 3;
            button3.Text = "LeaderBoard";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(237, 180);
            button4.Name = "button4";
            button4.Size = new Size(316, 85);
            button4.TabIndex = 4;
            button4.Text = "PLAY";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 107);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaption;
            pictureBox2.Dock = DockStyle.Bottom;
            pictureBox2.Location = new Point(0, 466);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(800, 94);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = SystemColors.ActiveCaption;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(637, 5);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(120, 96);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 10;
            pictureBox6.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Century Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(188, 41);
            label1.TabIndex = 0;
            label1.Text = "Welcome,";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button2
            // 
            button2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(447, 424);
            button2.Name = "button2";
            button2.Size = new Size(124, 23);
            button2.TabIndex = 11;
            button2.Text = "Delete Account";
            button2.UseVisualStyleBackColor = true;
            // 
            // ButtonChange
            // 
            ButtonChange.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonChange.Location = new Point(230, 424);
            ButtonChange.Name = "ButtonChange";
            ButtonChange.Size = new Size(124, 23);
            ButtonChange.TabIndex = 11;
            ButtonChange.Text = "Change Details";
            ButtonChange.UseVisualStyleBackColor = true;
            // 
            // HomeMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 560);
            Controls.Add(ButtonChange);
            Controls.Add(button2);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(labelUsername);
            Controls.Add(pictureBox1);
            Name = "HomeMenu";
            Text = "UserProfile";
            Load += HomeMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUsername;
        private Button button1;
        private Button button3;
        private Button button4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox6;
        private Label label1;
        private Button button2;
        private Button ButtonChange;
    }
}