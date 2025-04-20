using Quanlybanhang.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlybanhang.GUI.UC;

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

        
            private void LoadFormToPanel(System.Windows.Forms.UserControl userControl)
        {
            
            panelMain.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panelMain.Controls.Add(userControl);
            userControl.BringToFront();
        }

        
        private void MoveIndicator(Control button)
        {
            pnlIndicator.Top = button.Top;
            pnlIndicator.Height = button.Height;
        }


        private void btn_HangHoaQL_Click(object sender, EventArgs e)
        {
            MoveIndicator(btn_HangHoaQL);
            LoadFormToPanel(new UserHangHoa_QL());    
        }

        private void btn_NhanVienQL_Click(object sender, EventArgs e)
        {
            MoveIndicator(btn_NhanVienQL);
            LoadFormToPanel(new UserNhanVien());
        }

        private void btn_KhachHangQL_Click(object sender, EventArgs e)
        {
            MoveIndicator(btn_KhachHangQL);
            //LoadFormToPanel(new FormKhachHang_QL());
        }

        private void btn_NhaCungCapQL_Click(object sender, EventArgs e)
        {
            MoveIndicator(btn_NhaCungCapQL);
            LoadFormToPanel(new UserNhaCungCap());
        }

        private void btn_BanHangQL_Click(object sender, EventArgs e)
        {
            MoveIndicator(btn_BanHangQL);
            //LoadFormToPanel(new FormChiTietBanHang_QL());
        }

        private void box_out_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void box_out_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(box_out, "Nhấn để thoát");
        }
    }
}
