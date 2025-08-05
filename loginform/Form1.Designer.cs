namespace loginform
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            user = new TextBox();
            panel1 = new Panel();
            line1 = new Panel();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            line2 = new Panel();
            Pass = new TextBox();
            pictureBox3 = new PictureBox();
            btlogin = new Button();
            llbsignin = new LinkLabel();
            linkLabel1 = new LinkLabel();
            panel3 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // user
            // 
            user.BorderStyle = BorderStyle.None;
            user.Cursor = Cursors.IBeam;
            user.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            user.ForeColor = Color.Gray;
            user.Location = new Point(45, 14);
            user.Name = "user";
            user.Size = new Size(378, 32);
            user.TabIndex = 2;
            user.Text = "Email hoặc số điện thoại";
            user.TextChanged += user_TextChanged;
            user.Enter += user_Enter;
            user.Leave += user_Leave;
            // 
            // panel1
            // 
            panel1.Controls.Add(line1);
            panel1.Controls.Add(user);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(25, 244);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 55);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // line1
            // 
            line1.BackColor = Color.FromArgb(255, 195, 77);
            line1.Location = new Point(45, 40);
            line1.Name = "line1";
            line1.Size = new Size(378, 1);
            line1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user__1_;
            pictureBox2.Location = new Point(4, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(line2);
            panel2.Controls.Add(Pass);
            panel2.Controls.Add(pictureBox3);
            panel2.Location = new Point(25, 307);
            panel2.Name = "panel2";
            panel2.Size = new Size(444, 52);
            panel2.TabIndex = 3;
            // 
            // line2
            // 
            line2.BackColor = Color.FromArgb(255, 195, 77);
            line2.Location = new Point(45, 40);
            line2.Name = "line2";
            line2.Size = new Size(378, 1);
            line2.TabIndex = 3;
            // 
            // Pass
            // 
            Pass.BorderStyle = BorderStyle.None;
            Pass.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Pass.ForeColor = Color.Gray;
            Pass.Location = new Point(45, 14);
            Pass.Name = "Pass";
            Pass.Size = new Size(378, 32);
            Pass.TabIndex = 2;
            Pass.Text = "Mật khẩu";
            Pass.TextChanged += Pass_TextChanged;
            Pass.Enter += Pass_Enter;
            Pass.Leave += Pass_Leave;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.padlock__2_;
            pictureBox3.Location = new Point(4, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // btlogin
            // 
            btlogin.AutoSize = true;
            btlogin.BackColor = Color.FromArgb(57, 73, 171);
            btlogin.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btlogin.ForeColor = SystemColors.ButtonFace;
            btlogin.Location = new Point(25, 420);
            btlogin.Name = "btlogin";
            btlogin.Size = new Size(444, 58);
            btlogin.TabIndex = 4;
            btlogin.Text = "ĐĂNG NHẬP";
            btlogin.UseVisualStyleBackColor = false;
            btlogin.Click += button1_Click;
            // 
            // llbsignin
            // 
            llbsignin.AutoSize = true;
            llbsignin.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llbsignin.Location = new Point(362, 481);
            llbsignin.Name = "llbsignin";
            llbsignin.Size = new Size(156, 40);
            llbsignin.TabIndex = 5;
            llbsignin.TabStop = true;
            llbsignin.Text = "Đăng ký";
            llbsignin.TextAlign = ContentAlignment.MiddleCenter;
            llbsignin.LinkClicked += llbsignin_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(30, 359);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(159, 25);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Quên mật khẩu";
            linkLabel1.TextAlign = ContentAlignment.MiddleLeft;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 525);
            panel3.Name = "panel3";
            panel3.Size = new Size(481, 82);
            panel3.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(189, 9);
            label1.Name = "label1";
            label1.Size = new Size(103, 37);
            label1.TabIndex = 0;
            label1.Text = "Close";
            label1.Click += label1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(162, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(481, 607);
            Controls.Add(panel3);
            Controls.Add(linkLabel1);
            Controls.Add(llbsignin);
            Controls.Add(btlogin);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Salary calculation";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.Panel line2;
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.LinkLabel llbsignin;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
    }
}

