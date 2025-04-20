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
    public partial class FormHangHoa_QL : Form
    {
        public FormHangHoa_QL()
        {
            InitializeComponent();
        }

        private void FormHangHoa_Load(object sender, EventArgs e)
        {

        }

        private void btn_GiamGia_HH_Click(object sender, EventArgs e)
        {
            FormGiamGia_HH formGiamGia = new FormGiamGia_HH();
            formGiamGia.ShowDialog();
        }

        private void btn_ChitietHH_Click(object sender, EventArgs e)
        {
            FormChitietHH formChitietHH = new FormChitietHH();
            formChitietHH.ShowDialog();
        }
    }
}
