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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.user = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.line1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.line2 = new System.Windows.Forms.Panel();
            this.Pass = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btlogin = new System.Windows.Forms.Button();
            this.llbsignin = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.Color.Gray;
            this.user.Location = new System.Drawing.Point(45, 14);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(378, 27);
            this.user.TabIndex = 2;
            this.user.Text = "Email hoặc số điện thoại";
            this.user.TextChanged += new System.EventHandler(this.user_TextChanged);
            this.user.Enter += new System.EventHandler(this.user_Enter);
            this.user.Leave += new System.EventHandler(this.user_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.line1);
            this.panel1.Controls.Add(this.user);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(25, 244);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 55);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(77)))));
            this.line1.Location = new System.Drawing.Point(45, 40);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(378, 1);
            this.line1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::loginform.Properties.Resources.user__1_;
            this.pictureBox2.Location = new System.Drawing.Point(4, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.line2);
            this.panel2.Controls.Add(this.Pass);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Location = new System.Drawing.Point(25, 307);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 52);
            this.panel2.TabIndex = 3;
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(77)))));
            this.line2.Location = new System.Drawing.Point(45, 40);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(378, 1);
            this.line2.TabIndex = 3;
            // 
            // Pass
            // 
            this.Pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass.ForeColor = System.Drawing.Color.Gray;
            this.Pass.Location = new System.Drawing.Point(45, 14);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(378, 27);
            this.Pass.TabIndex = 2;
            this.Pass.Text = "Mật khẩu";
            this.Pass.TextChanged += new System.EventHandler(this.Pass_TextChanged);
            this.Pass.Enter += new System.EventHandler(this.Pass_Enter);
            this.Pass.Leave += new System.EventHandler(this.Pass_Leave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::loginform.Properties.Resources.padlock__2_;
            this.pictureBox3.Location = new System.Drawing.Point(4, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // btlogin
            // 
            this.btlogin.AutoSize = true;
            this.btlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.btlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btlogin.Location = new System.Drawing.Point(25, 420);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(444, 58);
            this.btlogin.TabIndex = 4;
            this.btlogin.Text = "ĐĂNG NHẬP";
            this.btlogin.UseVisualStyleBackColor = false;
            this.btlogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // llbsignin
            // 
            this.llbsignin.AutoSize = true;
            this.llbsignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbsignin.Location = new System.Drawing.Point(362, 481);
            this.llbsignin.Name = "llbsignin";
            this.llbsignin.Size = new System.Drawing.Size(131, 36);
            this.llbsignin.TabIndex = 5;
            this.llbsignin.TabStop = true;
            this.llbsignin.Text = "Đăng ký";
            this.llbsignin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llbsignin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbsignin_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(30, 359);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(135, 20);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Quên mật khẩu";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 525);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(481, 82);
            this.panel3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(189, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Close";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::loginform.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(162, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(481, 607);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.llbsignin);
            this.Controls.Add(this.btlogin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Salary calculation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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

