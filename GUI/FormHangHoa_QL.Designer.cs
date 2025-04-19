namespace Quanlybanhang.GUI
{
    partial class FormHangHoa_QL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHangHoa_QL));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_ThongTinHangHoa = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_ThemHH = new Guna.UI2.WinForms.Guna2Button();
            this.btn_SuaHH = new Guna.UI2.WinForms.Guna2Button();
            this.btn_XoaHH = new Guna.UI2.WinForms.Guna2Button();
            this.btn_TimKiemHH = new Guna.UI2.WinForms.Guna2Button();
            this.txtb_MaSPHH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtb_TenSPHH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtb_DonViTinhHH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtb_MotaHH = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongTinHangHoa)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(21, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 65);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hàng Hóa";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgv_ThongTinHangHoa
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgv_ThongTinHangHoa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ThongTinHangHoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_ThongTinHangHoa.ColumnHeadersHeight = 4;
            this.dgv_ThongTinHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ThongTinHangHoa.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_ThongTinHangHoa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_ThongTinHangHoa.Location = new System.Drawing.Point(211, 159);
            this.dgv_ThongTinHangHoa.Name = "dgv_ThongTinHangHoa";
            this.dgv_ThongTinHangHoa.RowHeadersVisible = false;
            this.dgv_ThongTinHangHoa.RowHeadersWidth = 51;
            this.dgv_ThongTinHangHoa.RowTemplate.Height = 24;
            this.dgv_ThongTinHangHoa.Size = new System.Drawing.Size(1038, 494);
            this.dgv_ThongTinHangHoa.TabIndex = 11;
            this.dgv_ThongTinHangHoa.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_ThongTinHangHoa.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_ThongTinHangHoa.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_ThongTinHangHoa.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_ThongTinHangHoa.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_ThongTinHangHoa.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_ThongTinHangHoa.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_ThongTinHangHoa.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_ThongTinHangHoa.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_ThongTinHangHoa.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_ThongTinHangHoa.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_ThongTinHangHoa.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_ThongTinHangHoa.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_ThongTinHangHoa.ThemeStyle.ReadOnly = false;
            this.dgv_ThongTinHangHoa.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_ThongTinHangHoa.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_ThongTinHangHoa.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_ThongTinHangHoa.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_ThongTinHangHoa.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_ThongTinHangHoa.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_ThongTinHangHoa.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btn_ThemHH
            // 
            this.btn_ThemHH.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_ThemHH.BorderColor = System.Drawing.Color.White;
            this.btn_ThemHH.BorderRadius = 5;
            this.btn_ThemHH.BorderThickness = 2;
            this.btn_ThemHH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThemHH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThemHH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ThemHH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ThemHH.FillColor = System.Drawing.Color.Transparent;
            this.btn_ThemHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemHH.ForeColor = System.Drawing.Color.White;
            this.btn_ThemHH.Location = new System.Drawing.Point(7, 174);
            this.btn_ThemHH.Name = "btn_ThemHH";
            this.btn_ThemHH.Size = new System.Drawing.Size(180, 45);
            this.btn_ThemHH.TabIndex = 12;
            this.btn_ThemHH.Text = "Thêm";
            // 
            // btn_SuaHH
            // 
            this.btn_SuaHH.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_SuaHH.BorderColor = System.Drawing.Color.White;
            this.btn_SuaHH.BorderRadius = 5;
            this.btn_SuaHH.BorderThickness = 2;
            this.btn_SuaHH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_SuaHH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_SuaHH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_SuaHH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_SuaHH.FillColor = System.Drawing.Color.Transparent;
            this.btn_SuaHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaHH.ForeColor = System.Drawing.Color.White;
            this.btn_SuaHH.Location = new System.Drawing.Point(7, 253);
            this.btn_SuaHH.Name = "btn_SuaHH";
            this.btn_SuaHH.Size = new System.Drawing.Size(180, 45);
            this.btn_SuaHH.TabIndex = 13;
            this.btn_SuaHH.Text = "Sửa";
            // 
            // btn_XoaHH
            // 
            this.btn_XoaHH.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_XoaHH.BorderColor = System.Drawing.Color.White;
            this.btn_XoaHH.BorderRadius = 5;
            this.btn_XoaHH.BorderThickness = 2;
            this.btn_XoaHH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_XoaHH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_XoaHH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_XoaHH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_XoaHH.FillColor = System.Drawing.Color.Transparent;
            this.btn_XoaHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaHH.ForeColor = System.Drawing.Color.White;
            this.btn_XoaHH.Location = new System.Drawing.Point(7, 329);
            this.btn_XoaHH.Name = "btn_XoaHH";
            this.btn_XoaHH.Size = new System.Drawing.Size(180, 45);
            this.btn_XoaHH.TabIndex = 14;
            this.btn_XoaHH.Text = "Xóa";
            // 
            // btn_TimKiemHH
            // 
            this.btn_TimKiemHH.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_TimKiemHH.BorderColor = System.Drawing.Color.White;
            this.btn_TimKiemHH.BorderRadius = 5;
            this.btn_TimKiemHH.BorderThickness = 2;
            this.btn_TimKiemHH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_TimKiemHH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_TimKiemHH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TimKiemHH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_TimKiemHH.FillColor = System.Drawing.Color.Transparent;
            this.btn_TimKiemHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiemHH.ForeColor = System.Drawing.Color.White;
            this.btn_TimKiemHH.Location = new System.Drawing.Point(7, 399);
            this.btn_TimKiemHH.Name = "btn_TimKiemHH";
            this.btn_TimKiemHH.Size = new System.Drawing.Size(180, 45);
            this.btn_TimKiemHH.TabIndex = 15;
            this.btn_TimKiemHH.Text = "Tìm Kiếm";
            // 
            // txtb_MaSPHH
            // 
            this.txtb_MaSPHH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtb_MaSPHH.DefaultText = "";
            this.txtb_MaSPHH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtb_MaSPHH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtb_MaSPHH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtb_MaSPHH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtb_MaSPHH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtb_MaSPHH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtb_MaSPHH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtb_MaSPHH.Location = new System.Drawing.Point(211, 74);
            this.txtb_MaSPHH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtb_MaSPHH.Name = "txtb_MaSPHH";
            this.txtb_MaSPHH.PlaceholderText = "";
            this.txtb_MaSPHH.SelectedText = "";
            this.txtb_MaSPHH.Size = new System.Drawing.Size(175, 48);
            this.txtb_MaSPHH.TabIndex = 16;
            // 
            // txtb_TenSPHH
            // 
            this.txtb_TenSPHH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtb_TenSPHH.DefaultText = "";
            this.txtb_TenSPHH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtb_TenSPHH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtb_TenSPHH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtb_TenSPHH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtb_TenSPHH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtb_TenSPHH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtb_TenSPHH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtb_TenSPHH.Location = new System.Drawing.Point(457, 74);
            this.txtb_TenSPHH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtb_TenSPHH.Name = "txtb_TenSPHH";
            this.txtb_TenSPHH.PlaceholderText = "";
            this.txtb_TenSPHH.SelectedText = "";
            this.txtb_TenSPHH.Size = new System.Drawing.Size(175, 48);
            this.txtb_TenSPHH.TabIndex = 17;
            // 
            // txtb_DonViTinhHH
            // 
            this.txtb_DonViTinhHH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtb_DonViTinhHH.DefaultText = "";
            this.txtb_DonViTinhHH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtb_DonViTinhHH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtb_DonViTinhHH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtb_DonViTinhHH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtb_DonViTinhHH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtb_DonViTinhHH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtb_DonViTinhHH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtb_DonViTinhHH.Location = new System.Drawing.Point(742, 74);
            this.txtb_DonViTinhHH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtb_DonViTinhHH.Name = "txtb_DonViTinhHH";
            this.txtb_DonViTinhHH.PlaceholderText = "";
            this.txtb_DonViTinhHH.SelectedText = "";
            this.txtb_DonViTinhHH.Size = new System.Drawing.Size(175, 48);
            this.txtb_DonViTinhHH.TabIndex = 18;
            // 
            // txtb_MotaHH
            // 
            this.txtb_MotaHH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtb_MotaHH.DefaultText = "";
            this.txtb_MotaHH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtb_MotaHH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtb_MotaHH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtb_MotaHH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtb_MotaHH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtb_MotaHH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtb_MotaHH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtb_MotaHH.Location = new System.Drawing.Point(1038, 74);
            this.txtb_MotaHH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtb_MotaHH.Name = "txtb_MotaHH";
            this.txtb_MotaHH.PlaceholderText = "";
            this.txtb_MotaHH.SelectedText = "";
            this.txtb_MotaHH.Size = new System.Drawing.Size(175, 48);
            this.txtb_MotaHH.TabIndex = 19;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(211, 32);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(175, 35);
            this.guna2HtmlLabel1.TabIndex = 20;
            this.guna2HtmlLabel1.Text = "Mã hàng hóa";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(457, 32);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(175, 35);
            this.guna2HtmlLabel2.TabIndex = 21;
            this.guna2HtmlLabel2.Text = "Tên hàng hóa";
            this.guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(742, 32);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(175, 35);
            this.guna2HtmlLabel3.TabIndex = 22;
            this.guna2HtmlLabel3.Text = "Đơn vị tính";
            this.guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(1038, 32);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(175, 35);
            this.guna2HtmlLabel4.TabIndex = 23;
            this.guna2HtmlLabel4.Text = "Mô tả";
            this.guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.btn_ThemHH);
            this.guna2Panel1.Controls.Add(this.btn_SuaHH);
            this.guna2Panel1.Controls.Add(this.btn_XoaHH);
            this.guna2Panel1.Controls.Add(this.btn_TimKiemHH);
            this.guna2Panel1.Location = new System.Drawing.Point(5, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(200, 650);
            this.guna2Panel1.TabIndex = 24;
            // 
            // FormHangHoa_QL
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1249, 656);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.txtb_MotaHH);
            this.Controls.Add(this.txtb_DonViTinhHH);
            this.Controls.Add(this.txtb_TenSPHH);
            this.Controls.Add(this.txtb_MaSPHH);
            this.Controls.Add(this.dgv_ThongTinHangHoa);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormHangHoa_QL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "HangHoa";
            this.Load += new System.EventHandler(this.FormHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongTinHangHoa)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_ThongTinHangHoa;
        private Guna.UI2.WinForms.Guna2Button btn_ThemHH;
        private Guna.UI2.WinForms.Guna2Button btn_SuaHH;
        private Guna.UI2.WinForms.Guna2Button btn_XoaHH;
        private Guna.UI2.WinForms.Guna2Button btn_TimKiemHH;
        private Guna.UI2.WinForms.Guna2TextBox txtb_MaSPHH;
        private Guna.UI2.WinForms.Guna2TextBox txtb_TenSPHH;
        private Guna.UI2.WinForms.Guna2TextBox txtb_DonViTinhHH;
        private Guna.UI2.WinForms.Guna2TextBox txtb_MotaHH;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}