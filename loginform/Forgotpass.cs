using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace loginform
{
    public partial class Forgotpass : Form
    {
        public string captchaCode;
        private Login login;
        private Recoverpass recoverpass;
        public Forgotpass()
        {
            InitializeComponent();
        }
        public Forgotpass(Login log)
        {
            InitializeComponent();
            login = log;
        }
        public Forgotpass(Recoverpass rcvp)
        {
            InitializeComponent();
            recoverpass = rcvp;
        }
        private void TaoCaptcha()
        {
            Random rand = new Random();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            captchaCode = new string(Enumerable.Repeat(chars, 6)
                                    .Select(s => s[rand.Next(s.Length)]).ToArray());

            Bitmap bmp = new Bitmap(150, 50);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);

            using (Font font = new Font("Arial", 15, FontStyle.Bold))
            {
                using (Brush brush = new LinearGradientBrush(
                    new Rectangle(0, 0, bmp.Width, bmp.Height),
                    Color.Blue, Color.DarkRed, 45f))
                {
                    g.DrawString(captchaCode, font, brush, new PointF(10, 10));
                }
            }

            pbCaptcha.Image = bmp;
        }
        private void Forgotpass_Load(object sender, EventArgs e)
        {
            TaoCaptcha();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Quser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtCaptcha_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbCaptcha_Click(object sender, EventArgs e)
        {

        }

        private void btTaiLai_Click(object sender, EventArgs e)
        {
            TaoCaptcha();
        }

        private void btsend_Click(object sender, EventArgs e)
        {
            if (txtCaptcha.Text.Trim().ToUpper() == captchaCode)
            {
                this.Hide();
                MessageBox.Show("Captcha đúng!");
                new Recoverpass().Show();
            }
            else
            {
                MessageBox.Show("Captcha sai! Vui lòng thử lại.");
                TaoCaptcha();
            }
        }

        private void llbreturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
            this.Close();
        }
    }
}
