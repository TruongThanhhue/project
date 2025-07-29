namespace loginform
{
    partial class Signup
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
            this.btsignup = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Tuser = new System.Windows.Forms.TextBox();
            this.btHienPass2 = new System.Windows.Forms.Button();
            this.btHienPass = new System.Windows.Forms.Button();
            this.Tpass2 = new System.Windows.Forms.TextBox();
            this.Tpass = new System.Windows.Forms.TextBox();
            this.Tmanv = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.llbreturn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 494);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 82);
            this.panel3.TabIndex = 13;
            // 
            // llbreturn
            // 
            this.llbreturn.AutoSize = true;
            this.llbreturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbreturn.ForeColor = System.Drawing.Color.Red;
            this.llbreturn.Location = new System.Drawing.Point(332, 31);
            this.llbreturn.Name = "llbreturn";
            this.llbreturn.Size = new System.Drawing.Size(130, 31);
            this.llbreturn.TabIndex = 0;
            this.llbreturn.Text = "Quay Lại";
            this.llbreturn.Click += new System.EventHandler(this.llbreturn_Click);
            // 
            // btsignup
            // 
            this.btsignup.AutoSize = true;
            this.btsignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.btsignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsignup.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btsignup.Location = new System.Drawing.Point(134, 362);
            this.btsignup.Name = "btsignup";
            this.btsignup.Size = new System.Drawing.Size(529, 58);
            this.btsignup.TabIndex = 10;
            this.btsignup.Text = "ĐĂNG KÝ";
            this.btsignup.UseVisualStyleBackColor = false;
            this.btsignup.Click += new System.EventHandler(this.btsignup_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(175, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(447, 58);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tạo Tài Khoản Mới";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Tuser
            // 
            this.Tuser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Tuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tuser.ForeColor = System.Drawing.Color.Gray;
            this.Tuser.Location = new System.Drawing.Point(134, 168);
            this.Tuser.Name = "Tuser";
            this.Tuser.Size = new System.Drawing.Size(529, 34);
            this.Tuser.TabIndex = 4;
            this.Tuser.Text = "Email hoặc số điện thoại";
            this.Tuser.TextChanged += new System.EventHandler(this.Tuser_TextChanged);
            this.Tuser.Enter += new System.EventHandler(this.Tuser_Enter);
            this.Tuser.Leave += new System.EventHandler(this.Tuser_Leave);
            // 
            // btHienPass2
            // 
            this.btHienPass2.Location = new System.Drawing.Point(639, 283);
            this.btHienPass2.Name = "btHienPass2";
            this.btHienPass2.Size = new System.Drawing.Size(24, 24);
            this.btHienPass2.TabIndex = 22;
            this.btHienPass2.Text = "👁";
            this.btHienPass2.UseVisualStyleBackColor = true;
            this.btHienPass2.Click += new System.EventHandler(this.btHienPass2_Click);
            // 
            // btHienPass
            // 
            this.btHienPass.Location = new System.Drawing.Point(370, 284);
            this.btHienPass.Name = "btHienPass";
            this.btHienPass.Size = new System.Drawing.Size(24, 24);
            this.btHienPass.TabIndex = 23;
            this.btHienPass.Text = "👁";
            this.btHienPass.UseVisualStyleBackColor = true;
            this.btHienPass.Click += new System.EventHandler(this.btHienPass_Click);
            // 
            // Tpass2
            // 
            this.Tpass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tpass2.ForeColor = System.Drawing.Color.Gray;
            this.Tpass2.Location = new System.Drawing.Point(403, 278);
            this.Tpass2.Name = "Tpass2";
            this.Tpass2.Size = new System.Drawing.Size(260, 34);
            this.Tpass2.TabIndex = 19;
            this.Tpass2.Text = "Nhập lại mật khẩu";
            this.Tpass2.TextChanged += new System.EventHandler(this.Tpass2_TextChanged);
            this.Tpass2.Enter += new System.EventHandler(this.Tpass2_Enter);
            this.Tpass2.Leave += new System.EventHandler(this.Tpass2_Leave);
            // 
            // Tpass
            // 
            this.Tpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.Tpass.ForeColor = System.Drawing.Color.Gray;
            this.Tpass.Location = new System.Drawing.Point(134, 279);
            this.Tpass.Name = "Tpass";
            this.Tpass.Size = new System.Drawing.Size(260, 34);
            this.Tpass.TabIndex = 2;
            this.Tpass.Text = "Mật khẩu";
            this.Tpass.TextChanged += new System.EventHandler(this.Tpass_TextChanged);
            this.Tpass.Enter += new System.EventHandler(this.Tpass_Enter);
            this.Tpass.Leave += new System.EventHandler(this.Tpass_Leave);
            // 
            // Tmanv
            // 
            this.Tmanv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Tmanv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tmanv.ForeColor = System.Drawing.Color.Gray;
            this.Tmanv.Location = new System.Drawing.Point(134, 218);
            this.Tmanv.Name = "Tmanv";
            this.Tmanv.Size = new System.Drawing.Size(529, 34);
            this.Tmanv.TabIndex = 24;
            this.Tmanv.Text = "Mã nhân viên";
            this.Tmanv.TextChanged += new System.EventHandler(this.Tmanv_TextChanged);
            this.Tmanv.Enter += new System.EventHandler(this.Tmanv_Enter);
            this.Tmanv.Leave += new System.EventHandler(this.Tmanv_Leave);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 576);
            this.Controls.Add(this.Tmanv);
            this.Controls.Add(this.btHienPass);
            this.Controls.Add(this.btHienPass2);
            this.Controls.Add(this.Tpass2);
            this.Controls.Add(this.Tuser);
            this.Controls.Add(this.Tpass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btsignup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "signup";
            this.Load += new System.EventHandler(this.signup_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label llbreturn;
        private System.Windows.Forms.Button btsignup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tuser;
        private System.Windows.Forms.Button btHienPass2;
        private System.Windows.Forms.Button btHienPass;
        private System.Windows.Forms.TextBox Tpass2;
        private System.Windows.Forms.TextBox Tpass;
        private System.Windows.Forms.TextBox Tmanv;
    }
}