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
    public partial class Login : Form
    {
        private Signup signup;

        public Login()
        {
            InitializeComponent();
        }
        public Login(Signup sign)
        {
            InitializeComponent();
            signup = sign;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = user;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }

        private void user_Enter(object sender, EventArgs e)
        {
            if (user.Text == "Email hoặc số điện thoại")
            {
                user.Text = "";
                user.ForeColor = Color.Black;
            }
        }

        private void user_Leave(object sender, EventArgs e)
        {
            if (user.Text == "")
            {
                user.Text = "Email hoặc số điện thoại";
                user.ForeColor = Color.Gray;
            }
        }
        private void Pass_Enter(object sender, EventArgs e)
        {
            if (Pass.Text == "Mật khẩu")
            {
                Pass.Text = "";
                Pass.ForeColor = Color.Black;
            }
        }

        private void Pass_Leave(object sender, EventArgs e)
        {
            if (Pass.Text == "")
            {
                Pass.Text = "Mật khẩu";
                Pass.ForeColor = Color.Gray;
                Pass.UseSystemPasswordChar = false;
            }
        }

        private void Pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void llbsignin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Signup().Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Forgotpass().Show();
            this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
