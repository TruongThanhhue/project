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
    public partial class Recoverpass : Form
    {
        private Forgotpass forgotpass;
        private ThongBaoDatLaiMatKhauThanhCong thongBaoDatLaiMatKhauThanhCong;
        public Recoverpass()
        {
            InitializeComponent();
        }
        public Recoverpass(Forgotpass fgp)
        {
            InitializeComponent();
            forgotpass = fgp;
        }
        public Recoverpass(ThongBaoDatLaiMatKhauThanhCong tbdlmktc)
        {
            InitializeComponent();
            thongBaoDatLaiMatKhauThanhCong = tbdlmktc;
        }
        private void Recoverpass_Load(object sender, EventArgs e)
        {

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

        private void Npass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Npass2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btsend_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
            new ThongBaoDatLaiMatKhauThanhCong().Show();
            this.Close();
        }

        private void llbreturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Forgotpass().Show();
            this.Close();
        }
    }
}
