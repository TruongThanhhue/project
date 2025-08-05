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
using System.Data.SqlClient;

namespace loginform
{
    public partial class Signup : Form
    {
        private Login login;
        private ThongBaoTaoTaiKhoanThanhCong thongBaoTaoTaiKhoanThanhCong;
        private string connectionString = "DB";
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
            string tenDN = Tuser.Text;
            string matKhau = Tpass.Text;
            string nhapLaiMK = Tpass2.Text;
            string maNV = Tmanv.Text;

            // Kiểm tra các trường nhập liệu
            if (string.IsNullOrEmpty(tenDN) || string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(nhapLaiMK) || string.IsNullOrEmpty(maNV) ||
                tenDN == "Email hoặc số điện thoại" || matKhau == "Mật khẩu" || nhapLaiMK == "Nhập lại mật khẩu" || maNV == "Mã nhân viên")
            {
                MessageBox.Show("Vui lòng điền đầy đủ tất cả các thông tin.", "Lỗi đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (matKhau != nhapLaiMK)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp.", "Lỗi đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra các ràng buộc khác (ví dụ: độ dài mật khẩu, định dạng email,...)
            if (matKhau.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự.", "Lỗi đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Bước 1: Kiểm tra xem Mã nhân viên (MANV) có tồn tại trong bảng NHANVIEN không
                    string checkMaNVQuery = "SELECT COUNT(*) FROM NHANVIEN WHERE MANV = @MaNV";
                    using (SqlCommand checkMaNVCommand = new SqlCommand(checkMaNVQuery, connection))
                    {
                        checkMaNVCommand.Parameters.AddWithValue("@MaNV", maNV);
                        int count = (int)checkMaNVCommand.ExecuteScalar();
                        if (count == 0)
                        {
                            MessageBox.Show("Mã nhân viên không tồn tại trong hệ thống.", "Lỗi đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Bước 2: Kiểm tra xem Tên đăng nhập (TENDN) đã tồn tại trong bảng TAIKHOAN chưa
                    string checkTenDNQuery = "SELECT COUNT(*) FROM TAIKHOAN WHERE TENDN = @TenDN";
                    using (SqlCommand checkTenDNCommand = new SqlCommand(checkTenDNQuery, connection))
                    {
                        checkTenDNCommand.Parameters.AddWithValue("@TenDN", tenDN);
                        int count = (int)checkTenDNCommand.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Tên đăng nhập này đã tồn tại. Vui lòng chọn tên khác.", "Lỗi đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Bước 3: Nếu mọi thứ hợp lệ, tiến hành thêm tài khoản mới
                    // Lưu ý: Nên mã hóa mật khẩu trước khi lưu vào database
                    string insertQuery = "INSERT INTO TAIKHOAN (TENDN, MK, MANV) VALUES (@TenDN, @MatKhau, @MaNV)";
                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@TenDN", tenDN);
                        insertCommand.Parameters.AddWithValue("@MatKhau", matKhau);
                        insertCommand.Parameters.AddWithValue("@MaNV", maNV);
                        int rowsAffected = insertCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            this.Hide();
                            new Login().Show();
                            new ThongBaoTaoTaiKhoanThanhCong().Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Đã xảy ra lỗi khi tạo tài khoản. Vui lòng thử lại.", "Lỗi đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi Database: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
