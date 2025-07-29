using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace loginform
{
    public partial class Signup : Form
    {
        private Login login;
        private ThongBaoTaoTaiKhoanThanhCong thongBaoTaoTaiKhoanThanhCong;
        public Signup()
        {
            InitializeComponent();
        }

        public Signup(Login log)
        {
            InitializeComponent();
            login = log;
        }
        public Signup(ThongBaoTaoTaiKhoanThanhCong tbttktc)
        {
            InitializeComponent();
            thongBaoTaoTaiKhoanThanhCong = tbttktc;
        }
        private void signup_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Tuser_TextChanged(object sender, EventArgs e)
        {

        }
        private void Tuser_Enter(object sender, EventArgs e)
        {
            if (Tuser.Text == "Email hoặc số điện thoại")
            {
                Tuser.Text = "";
                Tuser.ForeColor = Color.Black;
            }
        }

        private void Tuser_Leave(object sender, EventArgs e)
        {
            if (Tuser.Text == "")
            {
                Tuser.Text = "Email hoặc số điện thoại";
                Tuser.ForeColor = Color.Gray;
            }
        }
        private void Tpass_TextChanged(object sender, EventArgs e)
        {

        }
        private void Tpass_Enter(object sender, EventArgs e)
        {
            if (Tpass.Text == "Mật khẩu")
            {
                Tpass.Text = "";
                Tpass.ForeColor = Color.Black;
                Tpass.UseSystemPasswordChar = true;
            }
        }

        private void Tpass_Leave(object sender, EventArgs e)
        {
            if (Tpass.Text == "")
            {
                Tpass.UseSystemPasswordChar = false;
                Tpass.Text = "Mật khẩu";
                Tpass.ForeColor = Color.Gray;
            }
        }
        private void btHienPass_Click(object sender, EventArgs e)
        {
            Tpass.UseSystemPasswordChar = !Tpass.UseSystemPasswordChar;
            if (Tpass.UseSystemPasswordChar)
                btHienPass.Text = "👁";
            else
                btHienPass.Text = "🔒";
        }


        private void Tpass2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tpass2_Enter(object sender, EventArgs e)
        {
            if (Tpass2.Text == "Nhập lại mật khẩu")
            {
                Tpass2.Text = "";
                Tpass2.ForeColor = Color.Black;
                Tpass2.UseSystemPasswordChar = true;
            }
        }

        private void Tpass2_Leave(object sender, EventArgs e)
        {
            if (Tpass2.Text == "")
            {
                Tpass2.UseSystemPasswordChar = false;
                Tpass2.Text = "Nhập lại mật khẩu";
                Tpass2.ForeColor = Color.Gray;
            }
        }
        private void btHienPass2_Click(object sender, EventArgs e)
        {
            Tpass2.UseSystemPasswordChar = !Tpass2.UseSystemPasswordChar;
            if (Tpass2.UseSystemPasswordChar)
                btHienPass2.Text = "👁";
            else
                btHienPass2.Text = "🔒";
        }

        private void btsignup_Click(object sender, EventArgs e)
        {
            //if() tạo đc
            //{
                this.Hide();
                new Login().Show();
                new ThongBaoTaoTaiKhoanThanhCong().Show();
                this.Close();
            //}
            //else ko tạo đc
                
            
        }

        private void llbreturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
            this.Close();
        }

        private void Tmanv_TextChanged(object sender, EventArgs e)
        {

        }
        private void Tmanv_Enter(object sender, EventArgs e)
        {
            if (Tmanv.Text == "Mã nhân viên")
            {
                Tmanv.Text = "";
                Tmanv.ForeColor = Color.Black;
            }
        }

        private void Tmanv_Leave(object sender, EventArgs e)
        {
            if (Tmanv.Text == "")
            {
                Tmanv.Text = "Mã nhân viên";
                Tmanv.ForeColor = Color.Gray;
            }
        }
    }
}
