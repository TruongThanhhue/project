namespace loginform
{
    partial class Recoverpass
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
            this.Npass2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Npass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btsend = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.llbreturn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 426);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 82);
            this.panel3.TabIndex = 37;
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
            // Npass2
            // 
            this.Npass2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Npass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Npass2.ForeColor = System.Drawing.Color.Gray;
            this.Npass2.Location = new System.Drawing.Point(134, 228);
            this.Npass2.Name = "Npass2";
            this.Npass2.Size = new System.Drawing.Size(529, 34);
            this.Npass2.TabIndex = 42;
            this.Npass2.TextChanged += new System.EventHandler(this.Npass2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(132, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "Nhập lại mật khẩu:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Mật khẩu mới:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(130, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Nhập mật khẩu mới cho tài khoản.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Npass
            // 
            this.Npass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Npass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Npass.ForeColor = System.Drawing.Color.Gray;
            this.Npass.Location = new System.Drawing.Point(135, 155);
            this.Npass.Name = "Npass";
            this.Npass.Size = new System.Drawing.Size(529, 34);
            this.Npass.TabIndex = 35;
            this.Npass.TextChanged += new System.EventHandler(this.Npass_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(129, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 33);
            this.label2.TabIndex = 38;
            this.label2.Text = "Đặt Lại Mật Khẩu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btsend
            // 
            this.btsend.AutoSize = true;
            this.btsend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.btsend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btsend.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btsend.Location = new System.Drawing.Point(134, 311);
            this.btsend.Name = "btsend";
            this.btsend.Size = new System.Drawing.Size(129, 61);
            this.btsend.TabIndex = 36;
            this.btsend.Text = "Gửi";
            this.btsend.UseVisualStyleBackColor = false;
            this.btsend.Click += new System.EventHandler(this.btsend_Click);
            // 
            // Recoverpass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Npass2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Npass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btsend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Recoverpass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recoverpass";
            this.Load += new System.EventHandler(this.Recoverpass_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label llbreturn;
        private System.Windows.Forms.TextBox Npass2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Npass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btsend;
    }
}