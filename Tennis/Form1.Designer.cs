namespace Tennis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            GameBall = new PictureBox();
            panel3 = new Panel();
            player2 = new PictureBox();
            player1 = new PictureBox();
            leftBall1 = new PictureBox();
            rightBall1 = new PictureBox();
            rightBall2 = new PictureBox();
            leftBall2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            timer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GameBall).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftBall1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightBall1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightBall2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftBall2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(GameBall);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(player2);
            panel1.Controls.Add(player1);
            panel1.Controls.Add(leftBall1);
            panel1.Controls.Add(rightBall1);
            panel1.Controls.Add(rightBall2);
            panel1.Controls.Add(leftBall2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(52, 114);
            panel1.Name = "panel1";
            panel1.Size = new Size(773, 401);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // GameBall
            // 
            GameBall.BackColor = Color.Transparent;
            GameBall.BackgroundImageLayout = ImageLayout.None;
            GameBall.Image = (Image)resources.GetObject("GameBall.Image");
            GameBall.Location = new Point(368, 187);
            GameBall.Name = "GameBall";
            GameBall.Size = new Size(30, 30);
            GameBall.SizeMode = PictureBoxSizeMode.StretchImage;
            GameBall.TabIndex = 7;
            GameBall.TabStop = false;
            // 
            // panel3
            // 
            panel3.ForeColor = SystemColors.Control;
            panel3.Location = new Point(398, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(0, 400);
            panel3.TabIndex = 6;
            // 
            // player2
            // 
            player2.BackColor = Color.OliveDrab;
            player2.Image = (Image)resources.GetObject("player2.Image");
            player2.Location = new Point(620, 156);
            player2.Name = "player2";
            player2.Size = new Size(49, 81);
            player2.SizeMode = PictureBoxSizeMode.StretchImage;
            player2.TabIndex = 5;
            player2.TabStop = false;
            // 
            // player1
            // 
            player1.BackColor = Color.OliveDrab;
            player1.Image = (Image)resources.GetObject("player1.Image");
            player1.Location = new Point(109, 156);
            player1.Name = "player1";
            player1.Size = new Size(49, 81);
            player1.SizeMode = PictureBoxSizeMode.StretchImage;
            player1.TabIndex = 4;
            player1.TabStop = false;
            // 
            // leftBall1
            // 
            leftBall1.BackColor = SystemColors.Control;
            leftBall1.Image = (Image)resources.GetObject("leftBall1.Image");
            leftBall1.Location = new Point(59, 229);
            leftBall1.Name = "leftBall1";
            leftBall1.Size = new Size(30, 30);
            leftBall1.SizeMode = PictureBoxSizeMode.StretchImage;
            leftBall1.TabIndex = 3;
            leftBall1.TabStop = false;
            // 
            // rightBall1
            // 
            rightBall1.BackColor = SystemColors.ControlLight;
            rightBall1.Image = (Image)resources.GetObject("rightBall1.Image");
            rightBall1.Location = new Point(681, 77);
            rightBall1.Name = "rightBall1";
            rightBall1.Size = new Size(30, 30);
            rightBall1.SizeMode = PictureBoxSizeMode.StretchImage;
            rightBall1.TabIndex = 2;
            rightBall1.TabStop = false;
            // 
            // rightBall2
            // 
            rightBall2.BackColor = SystemColors.Control;
            rightBall2.Image = (Image)resources.GetObject("rightBall2.Image");
            rightBall2.Location = new Point(738, 77);
            rightBall2.Name = "rightBall2";
            rightBall2.Size = new Size(30, 30);
            rightBall2.SizeMode = PictureBoxSizeMode.StretchImage;
            rightBall2.TabIndex = 1;
            rightBall2.TabStop = false;
            // 
            // leftBall2
            // 
            leftBall2.BackColor = SystemColors.Control;
            leftBall2.Image = (Image)resources.GetObject("leftBall2.Image");
            leftBall2.Location = new Point(3, 282);
            leftBall2.Name = "leftBall2";
            leftBall2.Size = new Size(30, 30);
            leftBall2.SizeMode = PictureBoxSizeMode.StretchImage;
            leftBall2.TabIndex = 0;
            leftBall2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-28, -29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(830, 460);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Location = new Point(326, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(231, 72);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 20;
            timer.Tick += GameTimer;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 548);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Tournois de tennis";
            Load += Form1_Load;
            KeyDown += KeyListener;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GameBall).EndInit();
            ((System.ComponentModel.ISupportInitialize)player2).EndInit();
            ((System.ComponentModel.ISupportInitialize)player1).EndInit();
            ((System.ComponentModel.ISupportInitialize)leftBall1).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightBall1).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightBall2).EndInit();
            ((System.ComponentModel.ISupportInitialize)leftBall2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox leftBall2;
        private System.Windows.Forms.Timer timer;
        private PictureBox leftBall1;
        private PictureBox rightBall1;
        private PictureBox rightBall2;
        private PictureBox player2;
        private PictureBox player1;
        private Panel panel3;
        private PictureBox GameBall;
        private PictureBox pictureBox1;
    }
}
