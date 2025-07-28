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
    public partial class ThongBaoDatLaiMatKhauThanhCong : Form
    {
        private Recoverpass recoverpass;
        public ThongBaoDatLaiMatKhauThanhCong()
        {
            InitializeComponent();
        }
        public ThongBaoDatLaiMatKhauThanhCong(Recoverpass rcvp)
        {
            InitializeComponent();
            recoverpass = rcvp;
        }

        private void ThongBaoDatLaiMatKhauThanhCong_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
