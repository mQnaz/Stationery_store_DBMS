namespace Quanlybanhang.GUI
{
    partial class FormGiamGia_HH
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtb_PhanTramGiam = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtb_Ngaybatdau = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtbNgayketthuc = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_Loaihang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_Xacnhan = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(37, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 36);
            this.label2.TabIndex = 11;
            this.label2.Text = "Phần trăm giảm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtb_PhanTramGiam
            // 
            this.txtb_PhanTramGiam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtb_PhanTramGiam.DefaultText = "";
            this.txtb_PhanTramGiam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtb_PhanTramGiam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtb_PhanTramGiam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtb_PhanTramGiam.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtb_PhanTramGiam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtb_PhanTramGiam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtb_PhanTramGiam.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtb_PhanTramGiam.Location = new System.Drawing.Point(241, 211);
            this.txtb_PhanTramGiam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtb_PhanTramGiam.Name = "txtb_PhanTramGiam";
            this.txtb_PhanTramGiam.PlaceholderText = "";
            this.txtb_PhanTramGiam.SelectedText = "";
            this.txtb_PhanTramGiam.Size = new System.Drawing.Size(160, 36);
            this.txtb_PhanTramGiam.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(49, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 36);
            this.label1.TabIndex = 13;
            this.label1.Text = "Từ ngày";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(405, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 36);
            this.label3.TabIndex = 14;
            this.label3.Text = "đến ngày";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtb_Ngaybatdau
            // 
            this.dtb_Ngaybatdau.BackColor = System.Drawing.Color.Transparent;
            this.dtb_Ngaybatdau.Checked = true;
            this.dtb_Ngaybatdau.FillColor = System.Drawing.Color.White;
            this.dtb_Ngaybatdau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtb_Ngaybatdau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtb_Ngaybatdau.Location = new System.Drawing.Point(239, 127);
            this.dtb_Ngaybatdau.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtb_Ngaybatdau.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtb_Ngaybatdau.Name = "dtb_Ngaybatdau";
            this.dtb_Ngaybatdau.Size = new System.Drawing.Size(160, 36);
            this.dtb_Ngaybatdau.TabIndex = 15;
            this.dtb_Ngaybatdau.UseTransparentBackground = true;
            this.dtb_Ngaybatdau.Value = new System.DateTime(2025, 4, 20, 14, 5, 32, 250);
            // 
            // dtbNgayketthuc
            // 
            this.dtbNgayketthuc.Checked = true;
            this.dtbNgayketthuc.FillColor = System.Drawing.Color.White;
            this.dtbNgayketthuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtbNgayketthuc.ForeColor = System.Drawing.Color.Black;
            this.dtbNgayketthuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtbNgayketthuc.Location = new System.Drawing.Point(567, 127);
            this.dtbNgayketthuc.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtbNgayketthuc.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtbNgayketthuc.Name = "dtbNgayketthuc";
            this.dtbNgayketthuc.Size = new System.Drawing.Size(160, 36);
            this.dtbNgayketthuc.TabIndex = 16;
            this.dtbNgayketthuc.Value = new System.DateTime(2025, 4, 20, 13, 48, 43, 16);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(49, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 36);
            this.label4.TabIndex = 17;
            this.label4.Text = "Loại hàng hóa";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbo_Loaihang
            // 
            this.cbo_Loaihang.BackColor = System.Drawing.Color.Transparent;
            this.cbo_Loaihang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_Loaihang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Loaihang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_Loaihang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_Loaihang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbo_Loaihang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbo_Loaihang.ItemHeight = 30;
            this.cbo_Loaihang.Location = new System.Drawing.Point(241, 51);
            this.cbo_Loaihang.Name = "cbo_Loaihang";
            this.cbo_Loaihang.Size = new System.Drawing.Size(158, 36);
            this.cbo_Loaihang.TabIndex = 18;
            // 
            // btn_Xacnhan
            // 
            this.btn_Xacnhan.BackColor = System.Drawing.Color.Transparent;
            this.btn_Xacnhan.BorderRadius = 5;
            this.btn_Xacnhan.BorderThickness = 2;
            this.btn_Xacnhan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xacnhan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xacnhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Xacnhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Xacnhan.FillColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Xacnhan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xacnhan.ForeColor = System.Drawing.Color.Black;
            this.btn_Xacnhan.Location = new System.Drawing.Point(567, 211);
            this.btn_Xacnhan.Name = "btn_Xacnhan";
            this.btn_Xacnhan.Size = new System.Drawing.Size(141, 36);
            this.btn_Xacnhan.TabIndex = 19;
            this.btn_Xacnhan.Text = "Xác nhận";
            // 
            // FormGiamGia_HH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 588);
            this.Controls.Add(this.btn_Xacnhan);
            this.Controls.Add(this.cbo_Loaihang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtbNgayketthuc);
            this.Controls.Add(this.dtb_Ngaybatdau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtb_PhanTramGiam);
            this.Controls.Add(this.label2);
            this.Name = "FormGiamGia_HH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGiamGia_HH";
            this.Load += new System.EventHandler(this.FormGiamGia_HH_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtb_PhanTramGiam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtb_Ngaybatdau;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtbNgayketthuc;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_Loaihang;
        private Guna.UI2.WinForms.Guna2Button btn_Xacnhan;
    }
}