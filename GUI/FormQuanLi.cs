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
    public partial class FormQuanLi: Form
    {
        public FormQuanLi()
        {
            InitializeComponent();
        }

        private void FormQuanLi_Load(object sender, EventArgs e)
        {

        }

        private void LoadFormToPanel(object form)
        {
            if (this.panelMain.Controls.Count > 0)
                this.panelMain.Controls.RemoveAt(0);

            Form f = form as Form;
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(f);
            this.panelMain.Tag = f;
            f.Show();
        }

        private void btn_HangHoaQL_Click(object sender, EventArgs e)
        {
            LoadFormToPanel(new FormHangHoa_QL());
        }

        private void btn_NhanVienQL_Click(object sender, EventArgs e)
        {
            LoadFormToPanel(new FormNhanVien_QL());
        }

        private void btn_KhachHangQL_Click(object sender, EventArgs e)
        {
            LoadFormToPanel(new FormKhachHang_QL());
        }

        private void btn_NhaCungCapQL_Click(object sender, EventArgs e)
        {
            LoadFormToPanel(new FormNhaCungCap_QL());
        }

        private void btn_BanHangQL_Click(object sender, EventArgs e)
        {
            LoadFormToPanel(new FormChiTietBanHang_QL());
        }
    }
}
