using System.Data.SqlClient;
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
using System.Configuration;

namespace loginform
{
    public partial class Login : Form
    {
        private string connectionString;
        private SqlConnection conn;
        private Signup signup;

        public Login()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            conn = new SqlConnection(connectionString);
        }
        public Login(Signup sign)
        {
            InitializeComponent();
            signup = sign;
            connectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            conn = new SqlConnection(connectionString);
        }
        private void Login_Load(object sender, EventArgs e)
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
            string username = user.Text.Trim();
            string password = Pass.Text.Trim();

            if (username == "" || password == "" || username == "Email hoặc số điện thoại" || password == "Mật khẩu")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM TAIKHOAN WHERE TENDN = @username AND MK = @password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Mở form chính ở đây nếu có
                    // this.Hide();
                    // new MainForm().Show();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
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
