using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginform
{
    public partial class ThongBaoTaoTaiKhoanThanhCong : Form
    {
        private Signup signup;
        public ThongBaoTaoTaiKhoanThanhCong()
        {
            InitializeComponent();
        }
        public ThongBaoTaoTaiKhoanThanhCong(Signup sign)
        {
            InitializeComponent();
            signup = sign;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ThongBaoTaoTaiKhoanThanhCong_Load(object sender, EventArgs e)
        {

        }
    }
}
