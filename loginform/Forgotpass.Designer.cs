namespace loginform
{
    partial class Forgotpass
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.llbreturn = new System.Windows.Forms.Label();
            this.Quser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btsend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCaptcha = new System.Windows.Forms.TextBox();
            this.btTaiLai = new System.Windows.Forms.Button();
            this.pbCaptcha = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptcha)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.llbreturn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 431);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 82);
            this.panel3.TabIndex = 27;
            // 
            // llbreturn
            // 
            this.llbreturn.AutoSize = true;
            this.llbreturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbreturn.ForeColor = System.Drawing.Color.Red;
            this.llbreturn.Location = new System.Drawing.Point(324, 31);
            this.llbreturn.Name = "llbreturn";
            this.llbreturn.Size = new System.Drawing.Size(130, 31);
            this.llbreturn.TabIndex = 0;
            this.llbreturn.Text = "Quay Lại";
            this.llbreturn.Click += new System.EventHandler(this.llbreturn_Click);
            // 
            // Quser
            // 
            this.Quser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Quser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quser.ForeColor = System.Drawing.Color.Gray;
            this.Quser.Location = new System.Drawing.Point(134, 173);
            this.Quser.Name = "Quser";
            this.Quser.Size = new System.Drawing.Size(529, 34);
            this.Quser.TabIndex = 25;
            this.Quser.TextChanged += new System.EventHandler(this.Quser_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(129, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "Quên Mật Khẩu?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btsend
            // 
            this.btsend.AutoSize = true;
            this.btsend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.btsend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btsend.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btsend.Location = new System.Drawing.Point(134, 300);
            this.btsend.Name = "btsend";
            this.btsend.Size = new System.Drawing.Size(129, 37);
            this.btsend.TabIndex = 26;
            this.btsend.Text = "Gửi";
            this.btsend.UseVisualStyleBackColor = false;
            this.btsend.Click += new System.EventHandler(this.btsend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(131, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nhập địa chỉ email hoặc số điện thoại đăng ký để đặt lại mật khẩu.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Email hoặc số điện thoại:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(131, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Nhập mã captcha:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtCaptcha
            // 
            this.txtCaptcha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCaptcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaptcha.ForeColor = System.Drawing.Color.Gray;
            this.txtCaptcha.Location = new System.Drawing.Point(134, 246);
            this.txtCaptcha.Name = "txtCaptcha";
            this.txtCaptcha.Size = new System.Drawing.Size(253, 34);
            this.txtCaptcha.TabIndex = 32;
            this.txtCaptcha.TextChanged += new System.EventHandler(this.txtCaptcha_TextChanged);
            // 
            // btTaiLai
            // 
            this.btTaiLai.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btTaiLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.btTaiLai.Location = new System.Drawing.Point(602, 236);
            this.btTaiLai.Name = "btTaiLai";
            this.btTaiLai.Size = new System.Drawing.Size(61, 53);
            this.btTaiLai.TabIndex = 34;
            this.btTaiLai.Text = "⟳";
            this.btTaiLai.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btTaiLai.UseVisualStyleBackColor = false;
            this.btTaiLai.Click += new System.EventHandler(this.btTaiLai_Click);
            // 
            // pbCaptcha
            // 
            this.pbCaptcha.Location = new System.Drawing.Point(459, 236);
            this.pbCaptcha.Name = "pbCaptcha";
            this.pbCaptcha.Size = new System.Drawing.Size(137, 53);
            this.pbCaptcha.TabIndex = 33;
            this.pbCaptcha.TabStop = false;
            this.pbCaptcha.Click += new System.EventHandler(this.pbCaptcha_Click);
            // 
            // Forgotpass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.btTaiLai);
            this.Controls.Add(this.pbCaptcha);
            this.Controls.Add(this.txtCaptcha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Quser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btsend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Forgotpass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgotpass";
            this.Load += new System.EventHandler(this.Forgotpass_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptcha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label llbreturn;
        private System.Windows.Forms.TextBox Quser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btsend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCaptcha;
        private System.Windows.Forms.PictureBox pbCaptcha;
        private System.Windows.Forms.Button btTaiLai;
    }
}