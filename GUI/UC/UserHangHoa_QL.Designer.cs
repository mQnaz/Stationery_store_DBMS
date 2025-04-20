namespace Quanlybanhang.GUI.UC

{
    partial class UserHangHoa_QL
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.tabPageSearch = new System.Windows.Forms.TabPage();
            this.tabPageUpdate = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_AddHH = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dgv_HangHoa = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbUpdateDetail = new System.Windows.Forms.TextBox();
            this.txtbUpdateQuanHH = new System.Windows.Forms.TextBox();
            this.txtbUpdateName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtbUpdateID = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabPageSale = new System.Windows.Forms.TabPage();
            this.cbo_Loaihang = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dtp_Start = new System.Windows.Forms.DateTimePicker();
            this.dtp_End = new System.Windows.Forms.DateTimePicker();
            this.txtb_Giam = new System.Windows.Forms.TextBox();
            this.dgv_Sale = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPageAdd.SuspendLayout();
            this.tabPageSearch.SuspendLayout();
            this.tabPageUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HangHoa)).BeginInit();
            this.tabPageSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sale)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPageAdd);
            this.tabControl1.Controls.Add(this.tabPageSearch);
            this.tabControl1.Controls.Add(this.tabPageUpdate);
            this.tabControl1.Controls.Add(this.tabPageSale);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1048, 611);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.Controls.Add(this.btn_AddHH);
            this.tabPageAdd.Controls.Add(this.label5);
            this.tabPageAdd.Controls.Add(this.textBox4);
            this.tabPageAdd.Controls.Add(this.textBox3);
            this.tabPageAdd.Controls.Add(this.textBox2);
            this.tabPageAdd.Controls.Add(this.label4);
            this.tabPageAdd.Controls.Add(this.label3);
            this.tabPageAdd.Controls.Add(this.label2);
            this.tabPageAdd.Controls.Add(this.label1);
            this.tabPageAdd.Controls.Add(this.textBox1);
            this.tabPageAdd.Location = new System.Drawing.Point(4, 4);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdd.Size = new System.Drawing.Size(1040, 575);
            this.tabPageAdd.TabIndex = 0;
            this.tabPageAdd.Text = "Thêm";
            this.tabPageAdd.UseVisualStyleBackColor = true;
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.Controls.Add(this.dgv_HangHoa);
            this.tabPageSearch.Controls.Add(this.label7);
            this.tabPageSearch.Controls.Add(this.textBox5);
            this.tabPageSearch.Controls.Add(this.label6);
            this.tabPageSearch.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearch.Size = new System.Drawing.Size(1040, 575);
            this.tabPageSearch.TabIndex = 1;
            this.tabPageSearch.Text = "Tìm kiếm";
            this.tabPageSearch.UseVisualStyleBackColor = true;
            // 
            // tabPageUpdate
            // 
            this.tabPageUpdate.Controls.Add(this.btnDelete);
            this.tabPageUpdate.Controls.Add(this.btnUpdate);
            this.tabPageUpdate.Controls.Add(this.txtbUpdateDetail);
            this.tabPageUpdate.Controls.Add(this.txtbUpdateQuanHH);
            this.tabPageUpdate.Controls.Add(this.txtbUpdateName);
            this.tabPageUpdate.Controls.Add(this.label9);
            this.tabPageUpdate.Controls.Add(this.label10);
            this.tabPageUpdate.Controls.Add(this.label11);
            this.tabPageUpdate.Controls.Add(this.label12);
            this.tabPageUpdate.Controls.Add(this.txtbUpdateID);
            this.tabPageUpdate.Controls.Add(this.label8);
            this.tabPageUpdate.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpdate.Name = "tabPageUpdate";
            this.tabPageUpdate.Size = new System.Drawing.Size(1040, 575);
            this.tabPageUpdate.TabIndex = 2;
            this.tabPageUpdate.Text = "Cập nhật và xóa";
            this.tabPageUpdate.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(365, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 30);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã hàng hóa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(228, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mô tả";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(365, 148);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(262, 30);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(365, 212);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(262, 30);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(365, 276);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(467, 144);
            this.textBox4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(30, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 46);
            this.label5.TabIndex = 8;
            this.label5.Text = "Thêm hàng hóa:";
            // 
            // btn_AddHH
            // 
            this.btn_AddHH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_AddHH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddHH.ForeColor = System.Drawing.Color.White;
            this.btn_AddHH.Location = new System.Drawing.Point(365, 460);
            this.btn_AddHH.Name = "btn_AddHH";
            this.btn_AddHH.Size = new System.Drawing.Size(118, 48);
            this.btn_AddHH.TabIndex = 9;
            this.btn_AddHH.Text = "Thêm";
            this.btn_AddHH.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(30, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 46);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tìm kiếm:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(314, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Mã hàng hóa";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(318, 117);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(262, 30);
            this.textBox5.TabIndex = 10;
            // 
            // dgv_HangHoa
            // 
            this.dgv_HangHoa.AllowUserToAddRows = false;
            this.dgv_HangHoa.AllowUserToDeleteRows = false;
            this.dgv_HangHoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_HangHoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_HangHoa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_HangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_HangHoa.Location = new System.Drawing.Point(53, 176);
            this.dgv_HangHoa.Name = "dgv_HangHoa";
            this.dgv_HangHoa.ReadOnly = true;
            this.dgv_HangHoa.RowHeadersWidth = 51;
            this.dgv_HangHoa.RowTemplate.Height = 24;
            this.dgv_HangHoa.Size = new System.Drawing.Size(927, 368);
            this.dgv_HangHoa.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaHH";
            this.Column1.HeaderText = "Mã hàng hóa";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenHH";
            this.Column2.HeaderText = "Tên hàng hóa";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SoLuongHH";
            this.Column3.HeaderText = "Số Lượng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MotaHH";
            this.Column4.HeaderText = "Mô tả";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(30, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 46);
            this.label8.TabIndex = 10;
            this.label8.Text = "Cập nhật và Xóa:";
            // 
            // txtbUpdateDetail
            // 
            this.txtbUpdateDetail.Location = new System.Drawing.Point(404, 286);
            this.txtbUpdateDetail.Multiline = true;
            this.txtbUpdateDetail.Name = "txtbUpdateDetail";
            this.txtbUpdateDetail.Size = new System.Drawing.Size(467, 144);
            this.txtbUpdateDetail.TabIndex = 18;
            // 
            // txtbUpdateQuanHH
            // 
            this.txtbUpdateQuanHH.Location = new System.Drawing.Point(404, 222);
            this.txtbUpdateQuanHH.Name = "txtbUpdateQuanHH";
            this.txtbUpdateQuanHH.Size = new System.Drawing.Size(262, 30);
            this.txtbUpdateQuanHH.TabIndex = 17;
            // 
            // txtbUpdateName
            // 
            this.txtbUpdateName.Location = new System.Drawing.Point(404, 158);
            this.txtbUpdateName.Name = "txtbUpdateName";
            this.txtbUpdateName.Size = new System.Drawing.Size(262, 30);
            this.txtbUpdateName.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(267, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 23);
            this.label9.TabIndex = 15;
            this.label9.Text = "Mô tả";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(267, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 23);
            this.label10.TabIndex = 14;
            this.label10.Text = "Số lượng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(267, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 23);
            this.label11.TabIndex = 13;
            this.label11.Text = "Tên hàng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(267, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 23);
            this.label12.TabIndex = 12;
            this.label12.Text = "Mã hàng hóa";
            // 
            // txtbUpdateID
            // 
            this.txtbUpdateID.Location = new System.Drawing.Point(404, 101);
            this.txtbUpdateID.Name = "txtbUpdateID";
            this.txtbUpdateID.Size = new System.Drawing.Size(262, 30);
            this.txtbUpdateID.TabIndex = 11;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(404, 504);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 48);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(605, 504);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 48);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // tabPageSale
            // 
            this.tabPageSale.Controls.Add(this.dgv_Sale);
            this.tabPageSale.Controls.Add(this.txtb_Giam);
            this.tabPageSale.Controls.Add(this.dtp_End);
            this.tabPageSale.Controls.Add(this.dtp_Start);
            this.tabPageSale.Controls.Add(this.label16);
            this.tabPageSale.Controls.Add(this.label15);
            this.tabPageSale.Controls.Add(this.label14);
            this.tabPageSale.Controls.Add(this.label13);
            this.tabPageSale.Controls.Add(this.cbo_Loaihang);
            this.tabPageSale.Location = new System.Drawing.Point(4, 4);
            this.tabPageSale.Name = "tabPageSale";
            this.tabPageSale.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSale.Size = new System.Drawing.Size(1040, 575);
            this.tabPageSale.TabIndex = 3;
            this.tabPageSale.Text = "Giảm giá";
            this.tabPageSale.UseVisualStyleBackColor = true;
            // 
            // cbo_Loaihang
            // 
            this.cbo_Loaihang.FormattingEnabled = true;
            this.cbo_Loaihang.Location = new System.Drawing.Point(226, 87);
            this.cbo_Loaihang.Name = "cbo_Loaihang";
            this.cbo_Loaihang.Size = new System.Drawing.Size(149, 31);
            this.cbo_Loaihang.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(61, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 23);
            this.label13.TabIndex = 13;
            this.label13.Text = "Loại hàng hóa";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(61, 160);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 23);
            this.label14.TabIndex = 14;
            this.label14.Text = "Từ ngày:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(381, 160);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 23);
            this.label15.TabIndex = 15;
            this.label15.Text = "đến ngày:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(61, 224);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(139, 23);
            this.label16.TabIndex = 16;
            this.label16.Text = "Phần trăm giảm";
            // 
            // dtp_Start
            // 
            this.dtp_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Start.Location = new System.Drawing.Point(226, 160);
            this.dtp_Start.Name = "dtp_Start";
            this.dtp_Start.Size = new System.Drawing.Size(149, 30);
            this.dtp_Start.TabIndex = 17;
            // 
            // dtp_End
            // 
            this.dtp_End.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_End.Location = new System.Drawing.Point(485, 160);
            this.dtp_End.Name = "dtp_End";
            this.dtp_End.Size = new System.Drawing.Size(149, 30);
            this.dtp_End.TabIndex = 18;
            // 
            // txtb_Giam
            // 
            this.txtb_Giam.Location = new System.Drawing.Point(226, 224);
            this.txtb_Giam.Name = "txtb_Giam";
            this.txtb_Giam.Size = new System.Drawing.Size(149, 30);
            this.txtb_Giam.TabIndex = 19;
            // 
            // dgv_Sale
            // 
            this.dgv_Sale.AllowUserToAddRows = false;
            this.dgv_Sale.AllowUserToDeleteRows = false;
            this.dgv_Sale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Sale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgv_Sale.Location = new System.Drawing.Point(65, 328);
            this.dgv_Sale.Name = "dgv_Sale";
            this.dgv_Sale.ReadOnly = true;
            this.dgv_Sale.RowHeadersWidth = 51;
            this.dgv_Sale.RowTemplate.Height = 24;
            this.dgv_Sale.Size = new System.Drawing.Size(907, 150);
            this.dgv_Sale.TabIndex = 20;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "mahh";
            this.Column5.FillWeight = 150F;
            this.Column5.HeaderText = "Mã hàng hóa";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "tenhh";
            this.Column6.HeaderText = "Tên hàng hóa";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "giabandau";
            this.Column7.HeaderText = "Giá ban đầu";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.DataPropertyName = "saukhigiam";
            this.Column8.HeaderText = "Sau khi giảm";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // UserHangHoa_QL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserHangHoa_QL";
            this.Size = new System.Drawing.Size(1048, 757);
            this.tabControl1.ResumeLayout(false);
            this.tabPageAdd.ResumeLayout(false);
            this.tabPageAdd.PerformLayout();
            this.tabPageSearch.ResumeLayout(false);
            this.tabPageSearch.PerformLayout();
            this.tabPageUpdate.ResumeLayout(false);
            this.tabPageUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HangHoa)).EndInit();
            this.tabPageSale.ResumeLayout(false);
            this.tabPageSale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.TabPage tabPageSearch;
        private System.Windows.Forms.TabPage tabPageUpdate;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_AddHH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_HangHoa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtbUpdateDetail;
        private System.Windows.Forms.TextBox txtbUpdateQuanHH;
        private System.Windows.Forms.TextBox txtbUpdateName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtbUpdateID;
        private System.Windows.Forms.TabPage tabPageSale;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbo_Loaihang;
        private System.Windows.Forms.DateTimePicker dtp_End;
        private System.Windows.Forms.DateTimePicker dtp_Start;
        private System.Windows.Forms.TextBox txtb_Giam;
        private System.Windows.Forms.DataGridView dgv_Sale;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}
