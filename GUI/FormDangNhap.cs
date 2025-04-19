using Quanlybanhang.BLL;
using Quanlybanhang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlybanhang.GUI
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();

        }

        private void pictureBoxminimize_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxminimize, "Nhấp để thu nhỏ");
        }

        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxClose, "Nhấp để thoát");
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormDangNhap_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pbShow, "Show Password");
        }

        private void pbHide_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pbHide, "Hide Password");
        }

        private void pbShow_Click(object sender, EventArgs e)
        {
            pbShow.Hide();
            txtMK.UseSystemPasswordChar = false;
            pbHide.Show();
        }

        private void pbHide_Click(object sender, EventArgs e)
        {
            pbHide.Hide();
            txtMK.UseSystemPasswordChar = true;
            pbShow.Show();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            BLL_TaiKhoan bll = new BLL_TaiKhoan();
            DTO_TaiKhoan taiKhoan = bll.DangNhap(txtTK.Text, txtMK.Text);

            if (taiKhoan != null)
            {
                MessageBox.Show("Đăng nhập thành công!");

                // Truyền thông tin tài khoản qua FormMain
                FormMain formMain = new FormMain(taiKhoan);
                formMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }
        }

        private void ckBoxadmin_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBoxadmin.Checked)
                ckBoxNhanvien.Checked = false;
        }

        private void ckBoxNhanvien_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBoxNhanvien.Checked)
                ckBoxadmin.Checked = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}