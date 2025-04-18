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
    public partial class FormMain : Form
    {
        private DTO_TaiKhoan taiKhoan;

        public FormMain(DTO_TaiKhoan taiKhoan)
        {
            InitializeComponent();
            this.taiKhoan = taiKhoan;

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Loại tài khoản: " + taiKhoan.LoaiTaiKhoan);

        }
    }
}
