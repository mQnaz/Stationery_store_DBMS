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
    public partial class FormMain: Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        private DTO_TaiKhoan taiKhoan;

        public FormMain(DTO_TaiKhoan tk)
        {
            InitializeComponent();
            taiKhoan = tk;

            // Ví dụ: hiển thị tên tài khoản trên label nếu cần
            // lblTenNV.Text = taiKhoan.TenDangNhap;
        }
    }
}
