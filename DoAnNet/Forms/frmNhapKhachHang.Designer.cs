namespace DoAnNet.Forms
{
#pragma warning disable 0436
    partial class frmNhapKhachHang
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapKhachHang));
            this.label1 = new System.Windows.Forms.Label();
            this.txtDT1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboChiNhanh = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenKH1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblSoHoaDon = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaChi1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNgayMua = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenKH2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDiaChi2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNgayNhan = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDT2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCopy = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.btnIn = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("SVN-Gilroy", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1148, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHẬP THÔNG TIN HÓA ĐƠN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDT1
            // 
            this.txtDT1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDT1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDT1.AutoRoundedCorners = true;
            this.txtDT1.BackColor = System.Drawing.Color.Transparent;
            this.txtDT1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtDT1.BorderRadius = 25;
            this.txtDT1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDT1.DefaultText = "";
            this.txtDT1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDT1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDT1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDT1.DisabledState.Parent = this.txtDT1;
            this.txtDT1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDT1.FocusedState.Parent = this.txtDT1;
            this.txtDT1.Font = new System.Drawing.Font("SVN-Gilroy Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDT1.ForeColor = System.Drawing.Color.Black;
            this.txtDT1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.txtDT1.HoverState.Parent = this.txtDT1;
            this.txtDT1.Location = new System.Drawing.Point(221, 155);
            this.txtDT1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtDT1.Name = "txtDT1";
            this.txtDT1.PasswordChar = '\0';
            this.txtDT1.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtDT1.PlaceholderText = "Nhập số điện thoại";
            this.txtDT1.SelectedText = "";
            this.txtDT1.ShadowDecoration.BorderRadius = 0;
            this.txtDT1.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.txtDT1.ShadowDecoration.Depth = 20;
            this.txtDT1.ShadowDecoration.Parent = this.txtDT1;
            this.txtDT1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(4, 3, 4, 5);
            this.txtDT1.Size = new System.Drawing.Size(284, 53);
            this.txtDT1.TabIndex = 1;
            this.txtDT1.TextOffset = new System.Drawing.Point(8, 0);
            this.txtDT1.WordWrap = false;
            this.txtDT1.TextChanged += new System.EventHandler(this.txtDT1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số điện thoại";
            // 
            // cboChiNhanh
            // 
            this.cboChiNhanh.FormattingEnabled = true;
            this.cboChiNhanh.Location = new System.Drawing.Point(847, 98);
            this.cboChiNhanh.Name = "cboChiNhanh";
            this.cboChiNhanh.Size = new System.Drawing.Size(280, 39);
            this.cboChiNhanh.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(653, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chọn chi nhánh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên khách hàng";
            // 
            // txtTenKH1
            // 
            this.txtTenKH1.AutoRoundedCorners = true;
            this.txtTenKH1.BackColor = System.Drawing.Color.Transparent;
            this.txtTenKH1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtTenKH1.BorderRadius = 25;
            this.txtTenKH1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenKH1.DefaultText = "";
            this.txtTenKH1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenKH1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenKH1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKH1.DisabledState.Parent = this.txtTenKH1;
            this.txtTenKH1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKH1.FocusedState.Parent = this.txtTenKH1;
            this.txtTenKH1.Font = new System.Drawing.Font("SVN-Gilroy Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH1.ForeColor = System.Drawing.Color.Black;
            this.txtTenKH1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.txtTenKH1.HoverState.Parent = this.txtTenKH1;
            this.txtTenKH1.Location = new System.Drawing.Point(221, 222);
            this.txtTenKH1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtTenKH1.Name = "txtTenKH1";
            this.txtTenKH1.PasswordChar = '\0';
            this.txtTenKH1.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtTenKH1.PlaceholderText = "Nhập Tên khách hàng";
            this.txtTenKH1.SelectedText = "";
            this.txtTenKH1.ShadowDecoration.BorderRadius = 0;
            this.txtTenKH1.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.txtTenKH1.ShadowDecoration.Depth = 20;
            this.txtTenKH1.ShadowDecoration.Parent = this.txtTenKH1;
            this.txtTenKH1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(4, 3, 4, 5);
            this.txtTenKH1.Size = new System.Drawing.Size(284, 53);
            this.txtTenKH1.TabIndex = 2;
            this.txtTenKH1.TextOffset = new System.Drawing.Point(8, 0);
            this.txtTenKH1.WordWrap = false;
            this.txtTenKH1.TextChanged += new System.EventHandler(this.txtTenKH1_TextChanged);
            // 
            // lblTime
            // 
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblTime.Location = new System.Drawing.Point(875, 60);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(252, 32);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "05:05:00 15/09/2020";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSoHoaDon
            // 
            this.lblSoHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lblSoHoaDon.Location = new System.Drawing.Point(522, 57);
            this.lblSoHoaDon.Name = "lblSoHoaDon";
            this.lblSoHoaDon.Size = new System.Drawing.Size(216, 32);
            this.lblSoHoaDon.TabIndex = 5;
            this.lblSoHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SVN-Gilroy Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(378, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 31);
            this.label6.TabIndex = 6;
            this.label6.Text = "Số hóa đơn:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("SVN-Gilroy Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(764, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 31);
            this.label7.TabIndex = 7;
            this.label7.Text = "Thời gian";
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.lblTenNhanVien.Location = new System.Drawing.Point(134, 101);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(314, 32);
            this.lblTenNhanVien.TabIndex = 5;
            this.lblTenNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Địa chỉ";
            // 
            // txtDiaChi1
            // 
            this.txtDiaChi1.AutoRoundedCorners = true;
            this.txtDiaChi1.BackColor = System.Drawing.Color.Transparent;
            this.txtDiaChi1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtDiaChi1.BorderRadius = 25;
            this.txtDiaChi1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi1.DefaultText = "";
            this.txtDiaChi1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiaChi1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiaChi1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi1.DisabledState.Parent = this.txtDiaChi1;
            this.txtDiaChi1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi1.FocusedState.Parent = this.txtDiaChi1;
            this.txtDiaChi1.Font = new System.Drawing.Font("SVN-Gilroy Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi1.ForeColor = System.Drawing.Color.Black;
            this.txtDiaChi1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.txtDiaChi1.HoverState.Parent = this.txtDiaChi1;
            this.txtDiaChi1.Location = new System.Drawing.Point(221, 288);
            this.txtDiaChi1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtDiaChi1.Name = "txtDiaChi1";
            this.txtDiaChi1.PasswordChar = '\0';
            this.txtDiaChi1.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtDiaChi1.PlaceholderText = "Địa chỉ khách hàng";
            this.txtDiaChi1.SelectedText = "";
            this.txtDiaChi1.ShadowDecoration.BorderRadius = 0;
            this.txtDiaChi1.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.txtDiaChi1.ShadowDecoration.Depth = 20;
            this.txtDiaChi1.ShadowDecoration.Parent = this.txtDiaChi1;
            this.txtDiaChi1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(4, 3, 4, 5);
            this.txtDiaChi1.Size = new System.Drawing.Size(284, 53);
            this.txtDiaChi1.TabIndex = 3;
            this.txtDiaChi1.TextOffset = new System.Drawing.Point(8, 0);
            this.txtDiaChi1.WordWrap = false;
            this.txtDiaChi1.TextChanged += new System.EventHandler(this.txtDiaChi1_TextChanged);
            // 
            // txtNgayMua
            // 
            this.txtNgayMua.AutoRoundedCorners = true;
            this.txtNgayMua.BackColor = System.Drawing.Color.Transparent;
            this.txtNgayMua.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtNgayMua.BorderRadius = 25;
            this.txtNgayMua.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNgayMua.DefaultText = "";
            this.txtNgayMua.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNgayMua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNgayMua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNgayMua.DisabledState.Parent = this.txtNgayMua;
            this.txtNgayMua.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNgayMua.FocusedState.Parent = this.txtNgayMua;
            this.txtNgayMua.Font = new System.Drawing.Font("SVN-Gilroy Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayMua.ForeColor = System.Drawing.Color.Black;
            this.txtNgayMua.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.txtNgayMua.HoverState.Parent = this.txtNgayMua;
            this.txtNgayMua.Location = new System.Drawing.Point(221, 355);
            this.txtNgayMua.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtNgayMua.Name = "txtNgayMua";
            this.txtNgayMua.PasswordChar = '\0';
            this.txtNgayMua.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtNgayMua.PlaceholderText = "Ngày mua";
            this.txtNgayMua.SelectedText = "";
            this.txtNgayMua.ShadowDecoration.BorderRadius = 0;
            this.txtNgayMua.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.txtNgayMua.ShadowDecoration.Depth = 20;
            this.txtNgayMua.ShadowDecoration.Parent = this.txtNgayMua;
            this.txtNgayMua.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(4, 3, 4, 5);
            this.txtNgayMua.Size = new System.Drawing.Size(248, 53);
            this.txtNgayMua.TabIndex = 4;
            this.txtNgayMua.TextOffset = new System.Drawing.Point(8, 0);
            this.txtNgayMua.WordWrap = false;
            this.txtNgayMua.TextChanged += new System.EventHandler(this.txtNgayMua_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 32);
            this.label8.TabIndex = 9;
            this.label8.Text = "Ngày mua";
            // 
            // txtTenKH2
            // 
            this.txtTenKH2.AutoRoundedCorners = true;
            this.txtTenKH2.BackColor = System.Drawing.Color.Transparent;
            this.txtTenKH2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtTenKH2.BorderRadius = 25;
            this.txtTenKH2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenKH2.DefaultText = "";
            this.txtTenKH2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenKH2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenKH2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKH2.DisabledState.Parent = this.txtTenKH2;
            this.txtTenKH2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKH2.FocusedState.Parent = this.txtTenKH2;
            this.txtTenKH2.Font = new System.Drawing.Font("SVN-Gilroy Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH2.ForeColor = System.Drawing.Color.Black;
            this.txtTenKH2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.txtTenKH2.HoverState.Parent = this.txtTenKH2;
            this.txtTenKH2.Location = new System.Drawing.Point(843, 222);
            this.txtTenKH2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtTenKH2.Name = "txtTenKH2";
            this.txtTenKH2.PasswordChar = '\0';
            this.txtTenKH2.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtTenKH2.PlaceholderText = "Tên người nhận";
            this.txtTenKH2.SelectedText = "";
            this.txtTenKH2.ShadowDecoration.BorderRadius = 0;
            this.txtTenKH2.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.txtTenKH2.ShadowDecoration.Depth = 20;
            this.txtTenKH2.ShadowDecoration.Parent = this.txtTenKH2;
            this.txtTenKH2.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(4, 3, 4, 5);
            this.txtTenKH2.Size = new System.Drawing.Size(284, 53);
            this.txtTenKH2.TabIndex = 7;
            this.txtTenKH2.TextOffset = new System.Drawing.Point(8, 0);
            this.txtTenKH2.WordWrap = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(653, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 32);
            this.label9.TabIndex = 2;
            this.label9.Text = "Tên người nhận";
            // 
            // txtDiaChi2
            // 
            this.txtDiaChi2.AutoRoundedCorners = true;
            this.txtDiaChi2.BackColor = System.Drawing.Color.Transparent;
            this.txtDiaChi2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtDiaChi2.BorderRadius = 25;
            this.txtDiaChi2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi2.DefaultText = "";
            this.txtDiaChi2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiaChi2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiaChi2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi2.DisabledState.Parent = this.txtDiaChi2;
            this.txtDiaChi2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi2.FocusedState.Parent = this.txtDiaChi2;
            this.txtDiaChi2.Font = new System.Drawing.Font("SVN-Gilroy Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi2.ForeColor = System.Drawing.Color.Black;
            this.txtDiaChi2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.txtDiaChi2.HoverState.Parent = this.txtDiaChi2;
            this.txtDiaChi2.Location = new System.Drawing.Point(843, 288);
            this.txtDiaChi2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtDiaChi2.Name = "txtDiaChi2";
            this.txtDiaChi2.PasswordChar = '\0';
            this.txtDiaChi2.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtDiaChi2.PlaceholderText = "Địa chỉ nhận hàng";
            this.txtDiaChi2.SelectedText = "";
            this.txtDiaChi2.ShadowDecoration.BorderRadius = 0;
            this.txtDiaChi2.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.txtDiaChi2.ShadowDecoration.Depth = 20;
            this.txtDiaChi2.ShadowDecoration.Parent = this.txtDiaChi2;
            this.txtDiaChi2.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(4, 3, 4, 5);
            this.txtDiaChi2.Size = new System.Drawing.Size(284, 53);
            this.txtDiaChi2.TabIndex = 8;
            this.txtDiaChi2.TextOffset = new System.Drawing.Point(8, 0);
            this.txtDiaChi2.WordWrap = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(653, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 32);
            this.label10.TabIndex = 9;
            this.label10.Text = "Địa chỉ nhận";
            // 
            // txtNgayNhan
            // 
            this.txtNgayNhan.AutoRoundedCorners = true;
            this.txtNgayNhan.BackColor = System.Drawing.Color.Transparent;
            this.txtNgayNhan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtNgayNhan.BorderRadius = 25;
            this.txtNgayNhan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNgayNhan.DefaultText = "";
            this.txtNgayNhan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNgayNhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNgayNhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNgayNhan.DisabledState.Parent = this.txtNgayNhan;
            this.txtNgayNhan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNgayNhan.FocusedState.Parent = this.txtNgayNhan;
            this.txtNgayNhan.Font = new System.Drawing.Font("SVN-Gilroy Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayNhan.ForeColor = System.Drawing.Color.Black;
            this.txtNgayNhan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.txtNgayNhan.HoverState.Parent = this.txtNgayNhan;
            this.txtNgayNhan.Location = new System.Drawing.Point(843, 355);
            this.txtNgayNhan.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtNgayNhan.Name = "txtNgayNhan";
            this.txtNgayNhan.PasswordChar = '\0';
            this.txtNgayNhan.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtNgayNhan.PlaceholderText = "Ngày Giao hàng";
            this.txtNgayNhan.SelectedText = "";
            this.txtNgayNhan.ShadowDecoration.BorderRadius = 0;
            this.txtNgayNhan.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.txtNgayNhan.ShadowDecoration.Depth = 20;
            this.txtNgayNhan.ShadowDecoration.Parent = this.txtNgayNhan;
            this.txtNgayNhan.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(4, 3, 4, 5);
            this.txtNgayNhan.Size = new System.Drawing.Size(284, 53);
            this.txtNgayNhan.TabIndex = 9;
            this.txtNgayNhan.TextOffset = new System.Drawing.Point(8, 0);
            this.txtNgayNhan.WordWrap = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(653, 365);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 32);
            this.label11.TabIndex = 9;
            this.label11.Text = "Ngày giao";
            // 
            // txtDT2
            // 
            this.txtDT2.AutoRoundedCorners = true;
            this.txtDT2.BackColor = System.Drawing.Color.Transparent;
            this.txtDT2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtDT2.BorderRadius = 25;
            this.txtDT2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDT2.DefaultText = "";
            this.txtDT2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDT2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDT2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDT2.DisabledState.Parent = this.txtDT2;
            this.txtDT2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDT2.FocusedState.Parent = this.txtDT2;
            this.txtDT2.Font = new System.Drawing.Font("SVN-Gilroy Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDT2.ForeColor = System.Drawing.Color.Black;
            this.txtDT2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.txtDT2.HoverState.Parent = this.txtDT2;
            this.txtDT2.Location = new System.Drawing.Point(843, 155);
            this.txtDT2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtDT2.Name = "txtDT2";
            this.txtDT2.PasswordChar = '\0';
            this.txtDT2.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtDT2.PlaceholderText = "Số điện thoại người nhận";
            this.txtDT2.SelectedText = "";
            this.txtDT2.ShadowDecoration.BorderRadius = 0;
            this.txtDT2.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.txtDT2.ShadowDecoration.Depth = 20;
            this.txtDT2.ShadowDecoration.Parent = this.txtDT2;
            this.txtDT2.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(4, 3, 4, 5);
            this.txtDT2.Size = new System.Drawing.Size(284, 53);
            this.txtDT2.TabIndex = 6;
            this.txtDT2.TextOffset = new System.Drawing.Point(8, 0);
            this.txtDT2.WordWrap = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(653, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(178, 32);
            this.label12.TabIndex = 2;
            this.label12.Text = "ĐT người nhận";
            // 
            // btnCopy
            // 
            this.btnCopy.Checked = true;
            this.btnCopy.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnCopy.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnCopy.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.btnCopy.CheckedState.InnerColor = System.Drawing.Color.White;
            this.btnCopy.CheckedState.Parent = this.btnCopy;
            this.btnCopy.Location = new System.Drawing.Point(570, 177);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.ShadowDecoration.Parent = this.btnCopy;
            this.btnCopy.Size = new System.Drawing.Size(35, 20);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btnCopy.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btnCopy.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.btnCopy.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.btnCopy.UncheckedState.Parent = this.btnCopy;
            this.btnCopy.CheckedChanged += new System.EventHandler(this.btnCopy_CheckedChanged);
            // 
            // btnReset
            // 
            this.btnReset.BorderRadius = 5;
            this.btnReset.CheckedState.Parent = this.btnReset;
            this.btnReset.CustomImages.Parent = this.btnReset;
            this.btnReset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.HoverState.Parent = this.btnReset;
            this.btnReset.Location = new System.Drawing.Point(528, 354);
            this.btnReset.Name = "btnReset";
            this.btnReset.ShadowDecoration.Parent = this.btnReset;
            this.btnReset.Size = new System.Drawing.Size(119, 45);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnIn
            // 
            this.btnIn.BorderRadius = 5;
            this.btnIn.CheckedState.Parent = this.btnIn;
            this.btnIn.CustomImages.Parent = this.btnIn;
            this.btnIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(81)))));
            this.btnIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnIn.ForeColor = System.Drawing.Color.White;
            this.btnIn.HoverState.Parent = this.btnIn;
            this.btnIn.Location = new System.Drawing.Point(528, 253);
            this.btnIn.Name = "btnIn";
            this.btnIn.ShadowDecoration.Parent = this.btnIn;
            this.btnIn.Size = new System.Drawing.Size(119, 45);
            this.btnIn.TabIndex = 11;
            this.btnIn.Text = "In";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(477, 364);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(32, 35);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmNhapKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1148, 439);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNgayNhan);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNgayMua);
            this.Controls.Add(this.txtDiaChi2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDiaChi1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTenNhanVien);
            this.Controls.Add(this.lblSoHoaDon);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboChiNhanh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenKH2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenKH1);
            this.Controls.Add(this.txtDT2);
            this.Controls.Add(this.txtDT1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("SVN-Gilroy", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmNhapKhachHang";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmNhapKhachHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtDT1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboChiNhanh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtTenKH1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblSoHoaDon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChi1;
        private Guna.UI2.WinForms.Guna2TextBox txtNgayMua;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtTenKH2;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChi2;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txtNgayNhan;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox txtDT2;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2ToggleSwitch btnCopy;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2Button btnIn;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Timer timer1;
    }
}