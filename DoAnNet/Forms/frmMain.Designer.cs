using System.Drawing;
#pragma warning disable 0436

namespace DoAnNet
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnMenu = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnThongKe = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSanPham = new Guna.UI2.WinForms.Guna2Button();
            this.btnHoaDon = new Guna.UI2.WinForms.Guna2Button();
            this.btnKhachHang = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhanVien = new Guna.UI2.WinForms.Guna2Button();
            this.btnGioiThieu = new Guna.UI2.WinForms.Guna2Button();
            this.imgSlide = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ptbUser = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnInHoaDon = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCartCount = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnGioHang = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNotificationCount = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnThongBao = new Guna.UI2.WinForms.Guna2Button();
            this.panel0 = new System.Windows.Forms.Panel();
            this.pnMain = new System.Windows.Forms.Panel();
            this.flpSanPham = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.pnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlide)).BeginInit();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUser)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel0.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 570);
            this.panel1.TabIndex = 0;
            // 
            // pnMenu
            // 
            this.pnMenu.BorderRadius = 18;
            this.pnMenu.Controls.Add(this.btnThongKe);
            this.pnMenu.Controls.Add(this.pictureBox2);
            this.pnMenu.Controls.Add(this.btnSanPham);
            this.pnMenu.Controls.Add(this.btnHoaDon);
            this.pnMenu.Controls.Add(this.btnKhachHang);
            this.pnMenu.Controls.Add(this.btnNhanVien);
            this.pnMenu.Controls.Add(this.btnGioiThieu);
            this.pnMenu.Controls.Add(this.imgSlide);
            this.pnMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.pnMenu.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.pnMenu.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.pnMenu.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.pnMenu.Location = new System.Drawing.Point(13, 10);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.ShadowDecoration.Parent = this.pnMenu;
            this.pnMenu.Size = new System.Drawing.Size(86, 551);
            this.pnMenu.TabIndex = 0;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.Transparent;
            this.btnThongKe.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.btnThongKe.BorderRadius = 24;
            this.btnThongKe.BorderThickness = 1;
            this.btnThongKe.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnThongKe.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnThongKe.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnThongKe.CheckedState.Parent = this.btnThongKe;
            this.btnThongKe.CustomImages.Parent = this.btnThongKe;
            this.btnThongKe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.HoverState.Parent = this.btnThongKe;
            this.btnThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Image")));
            this.btnThongKe.ImageSize = new System.Drawing.Size(35, 35);
            this.btnThongKe.Location = new System.Drawing.Point(23, 407);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.ShadowDecoration.Parent = this.btnThongKe;
            this.btnThongKe.Size = new System.Drawing.Size(60, 50);
            this.btnThongKe.TabIndex = 1;
            this.btnThongKe.UseTransparentBackground = true;
            this.btnThongKe.CheckedChanged += new System.EventHandler(this.button_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(25, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btnSanPham
            // 
            this.btnSanPham.BackColor = System.Drawing.Color.Transparent;
            this.btnSanPham.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.btnSanPham.BorderRadius = 24;
            this.btnSanPham.BorderThickness = 1;
            this.btnSanPham.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSanPham.Checked = true;
            this.btnSanPham.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnSanPham.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnSanPham.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnSanPham.CheckedState.Image")));
            this.btnSanPham.CheckedState.Parent = this.btnSanPham;
            this.btnSanPham.CustomImages.Parent = this.btnSanPham;
            this.btnSanPham.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.btnSanPham.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSanPham.ForeColor = System.Drawing.Color.White;
            this.btnSanPham.HoverState.Parent = this.btnSanPham;
            this.btnSanPham.Image = ((System.Drawing.Image)(resources.GetObject("btnSanPham.Image")));
            this.btnSanPham.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSanPham.Location = new System.Drawing.Point(23, 122);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.ShadowDecoration.Parent = this.btnSanPham;
            this.btnSanPham.Size = new System.Drawing.Size(60, 50);
            this.btnSanPham.TabIndex = 0;
            this.btnSanPham.UseTransparentBackground = true;
            this.btnSanPham.CheckedChanged += new System.EventHandler(this.button_CheckedChanged);
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.BackColor = System.Drawing.Color.Transparent;
            this.btnHoaDon.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.btnHoaDon.BorderRadius = 24;
            this.btnHoaDon.BorderThickness = 1;
            this.btnHoaDon.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnHoaDon.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnHoaDon.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnHoaDon.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnHoaDon.CheckedState.Image")));
            this.btnHoaDon.CheckedState.Parent = this.btnHoaDon;
            this.btnHoaDon.CustomImages.Parent = this.btnHoaDon;
            this.btnHoaDon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.btnHoaDon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnHoaDon.HoverState.Parent = this.btnHoaDon;
            this.btnHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnHoaDon.Image")));
            this.btnHoaDon.ImageSize = new System.Drawing.Size(30, 30);
            this.btnHoaDon.Location = new System.Drawing.Point(23, 192);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.ShadowDecoration.Parent = this.btnHoaDon;
            this.btnHoaDon.Size = new System.Drawing.Size(60, 50);
            this.btnHoaDon.TabIndex = 0;
            this.btnHoaDon.UseTransparentBackground = true;
            this.btnHoaDon.CheckedChanged += new System.EventHandler(this.button_CheckedChanged);
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.btnKhachHang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.btnKhachHang.BorderRadius = 24;
            this.btnKhachHang.BorderThickness = 1;
            this.btnKhachHang.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnKhachHang.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnKhachHang.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnKhachHang.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.CheckedState.Image")));
            this.btnKhachHang.CheckedState.Parent = this.btnKhachHang;
            this.btnKhachHang.CustomImages.Parent = this.btnKhachHang;
            this.btnKhachHang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.btnKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnKhachHang.HoverState.Parent = this.btnKhachHang;
            this.btnKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.Image")));
            this.btnKhachHang.ImageSize = new System.Drawing.Size(30, 30);
            this.btnKhachHang.Location = new System.Drawing.Point(23, 266);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.ShadowDecoration.Parent = this.btnKhachHang;
            this.btnKhachHang.Size = new System.Drawing.Size(60, 50);
            this.btnKhachHang.TabIndex = 0;
            this.btnKhachHang.UseTransparentBackground = true;
            this.btnKhachHang.CheckedChanged += new System.EventHandler(this.button_CheckedChanged);
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.btnNhanVien.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.btnNhanVien.BorderRadius = 24;
            this.btnNhanVien.BorderThickness = 1;
            this.btnNhanVien.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnNhanVien.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnNhanVien.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnNhanVien.CheckedState.Parent = this.btnNhanVien;
            this.btnNhanVien.CustomImages.Parent = this.btnNhanVien;
            this.btnNhanVien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.btnNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.HoverState.Parent = this.btnNhanVien;
            this.btnNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.Image")));
            this.btnNhanVien.ImageSize = new System.Drawing.Size(35, 35);
            this.btnNhanVien.Location = new System.Drawing.Point(23, 340);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.ShadowDecoration.Parent = this.btnNhanVien;
            this.btnNhanVien.Size = new System.Drawing.Size(60, 50);
            this.btnNhanVien.TabIndex = 0;
            this.btnNhanVien.UseTransparentBackground = true;
            this.btnNhanVien.CheckedChanged += new System.EventHandler(this.button_CheckedChanged);
            // 
            // btnGioiThieu
            // 
            this.btnGioiThieu.BackColor = System.Drawing.Color.Transparent;
            this.btnGioiThieu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.btnGioiThieu.BorderRadius = 24;
            this.btnGioiThieu.BorderThickness = 1;
            this.btnGioiThieu.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnGioiThieu.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnGioiThieu.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnGioiThieu.CheckedState.Image")));
            this.btnGioiThieu.CheckedState.Parent = this.btnGioiThieu;
            this.btnGioiThieu.CustomImages.Parent = this.btnGioiThieu;
            this.btnGioiThieu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.btnGioiThieu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGioiThieu.ForeColor = System.Drawing.Color.White;
            this.btnGioiThieu.HoverState.Parent = this.btnGioiThieu;
            this.btnGioiThieu.Image = ((System.Drawing.Image)(resources.GetObject("btnGioiThieu.Image")));
            this.btnGioiThieu.ImageSize = new System.Drawing.Size(30, 30);
            this.btnGioiThieu.Location = new System.Drawing.Point(16, 483);
            this.btnGioiThieu.Name = "btnGioiThieu";
            this.btnGioiThieu.ShadowDecoration.Parent = this.btnGioiThieu;
            this.btnGioiThieu.Size = new System.Drawing.Size(60, 50);
            this.btnGioiThieu.TabIndex = 0;
            this.btnGioiThieu.UseTransparentBackground = true;
            // 
            // imgSlide
            // 
            this.imgSlide.Image = ((System.Drawing.Image)(resources.GetObject("imgSlide.Image")));
            this.imgSlide.Location = new System.Drawing.Point(48, 97);
            this.imgSlide.Name = "imgSlide";
            this.imgSlide.Size = new System.Drawing.Size(39, 101);
            this.imgSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSlide.TabIndex = 0;
            this.imgSlide.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.lblTitle);
            this.pnTop.Controls.Add(this.ptbUser);
            this.pnTop.Controls.Add(this.flowLayoutPanel1);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(100, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Padding = new System.Windows.Forms.Padding(5);
            this.pnTop.Size = new System.Drawing.Size(796, 64);
            this.pnTop.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(66, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(456, 52);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Danh sách sản phẩm";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ptbUser
            // 
            this.ptbUser.BackColor = System.Drawing.Color.Transparent;
            this.ptbUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptbUser.Image = ((System.Drawing.Image)(resources.GetObject("ptbUser.Image")));
            this.ptbUser.Location = new System.Drawing.Point(5, 5);
            this.ptbUser.Name = "ptbUser";
            this.ptbUser.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ptbUser.ShadowDecoration.Parent = this.ptbUser;
            this.ptbUser.Size = new System.Drawing.Size(54, 54);
            this.ptbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbUser.TabIndex = 0;
            this.ptbUser.TabStop = false;
            this.ptbUser.Click += new System.EventHandler(this.ptbUser_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnClose);
            this.flowLayoutPanel1.Controls.Add(this.btnMinimize);
            this.flowLayoutPanel1.Controls.Add(this.btnInHoaDon);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(528, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(263, 54);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Location = new System.Drawing.Point(241, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(14, 14);
            this.btnClose.TabIndex = 0;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.CheckedState.Parent = this.btnMinimize;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.CustomImages.Parent = this.btnMinimize;
            this.btnMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(52)))));
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.HoverState.Parent = this.btnMinimize;
            this.btnMinimize.Location = new System.Drawing.Point(221, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(14, 14);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.BackColor = System.Drawing.Color.Transparent;
            this.btnInHoaDon.BorderColor = System.Drawing.Color.Empty;
            this.btnInHoaDon.BorderRadius = 24;
            this.btnInHoaDon.BorderThickness = 1;
            this.btnInHoaDon.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnInHoaDon.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnInHoaDon.CheckedState.Parent = this.btnInHoaDon;
            this.btnInHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInHoaDon.CustomImages.Parent = this.btnInHoaDon;
            this.btnInHoaDon.FillColor = System.Drawing.Color.Empty;
            this.btnInHoaDon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnInHoaDon.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnInHoaDon.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnInHoaDon.HoverState.Parent = this.btnInHoaDon;
            this.btnInHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnInHoaDon.Image")));
            this.btnInHoaDon.ImageSize = new System.Drawing.Size(40, 40);
            this.btnInHoaDon.Location = new System.Drawing.Point(155, 3);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.PressedColor = System.Drawing.Color.Transparent;
            this.btnInHoaDon.PressedDepth = 0;
            this.btnInHoaDon.ShadowDecoration.Parent = this.btnInHoaDon;
            this.btnInHoaDon.Size = new System.Drawing.Size(60, 50);
            this.btnInHoaDon.TabIndex = 2;
            this.btnInHoaDon.UseTransparentBackground = true;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCartCount);
            this.panel2.Controls.Add(this.btnGioHang);
            this.panel2.Location = new System.Drawing.Point(84, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(65, 49);
            this.panel2.TabIndex = 3;
            // 
            // btnCartCount
            // 
            this.btnCartCount.BackColor = System.Drawing.Color.Transparent;
            this.btnCartCount.CheckedState.Parent = this.btnCartCount;
            this.btnCartCount.CustomImages.Parent = this.btnCartCount;
            this.btnCartCount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnCartCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCartCount.ForeColor = System.Drawing.Color.White;
            this.btnCartCount.HoverState.Parent = this.btnCartCount;
            this.btnCartCount.Location = new System.Drawing.Point(37, 1);
            this.btnCartCount.Name = "btnCartCount";
            this.btnCartCount.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnCartCount.ShadowDecoration.Parent = this.btnCartCount;
            this.btnCartCount.Size = new System.Drawing.Size(20, 20);
            this.btnCartCount.TabIndex = 2;
            this.btnCartCount.Text = "2";
            this.btnCartCount.UseTransparentBackground = true;
            // 
            // btnGioHang
            // 
            this.btnGioHang.AutoRoundedCorners = true;
            this.btnGioHang.BackColor = System.Drawing.Color.Transparent;
            this.btnGioHang.BorderColor = System.Drawing.Color.Empty;
            this.btnGioHang.BorderRadius = 24;
            this.btnGioHang.BorderThickness = 1;
            this.btnGioHang.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnGioHang.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnGioHang.CheckedState.Parent = this.btnGioHang;
            this.btnGioHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGioHang.CustomImages.Parent = this.btnGioHang;
            this.btnGioHang.FillColor = System.Drawing.Color.Empty;
            this.btnGioHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGioHang.ForeColor = System.Drawing.Color.White;
            this.btnGioHang.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnGioHang.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnGioHang.HoverState.Parent = this.btnGioHang;
            this.btnGioHang.Image = ((System.Drawing.Image)(resources.GetObject("btnGioHang.Image")));
            this.btnGioHang.ImageSize = new System.Drawing.Size(40, 40);
            this.btnGioHang.Location = new System.Drawing.Point(-2, 2);
            this.btnGioHang.Name = "btnGioHang";
            this.btnGioHang.PressedColor = System.Drawing.Color.Transparent;
            this.btnGioHang.PressedDepth = 0;
            this.btnGioHang.ShadowDecoration.BorderRadius = 24;
            this.btnGioHang.ShadowDecoration.Parent = this.btnGioHang;
            this.btnGioHang.Size = new System.Drawing.Size(60, 50);
            this.btnGioHang.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnNotificationCount);
            this.panel3.Controls.Add(this.btnThongBao);
            this.panel3.Location = new System.Drawing.Point(13, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(65, 49);
            this.panel3.TabIndex = 5;
            // 
            // btnNotificationCount
            // 
            this.btnNotificationCount.BackColor = System.Drawing.Color.Transparent;
            this.btnNotificationCount.CheckedState.Parent = this.btnNotificationCount;
            this.btnNotificationCount.CustomImages.Parent = this.btnNotificationCount;
            this.btnNotificationCount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnNotificationCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNotificationCount.ForeColor = System.Drawing.Color.White;
            this.btnNotificationCount.HoverState.Parent = this.btnNotificationCount;
            this.btnNotificationCount.Location = new System.Drawing.Point(37, 1);
            this.btnNotificationCount.Name = "btnNotificationCount";
            this.btnNotificationCount.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnNotificationCount.ShadowDecoration.Parent = this.btnNotificationCount;
            this.btnNotificationCount.Size = new System.Drawing.Size(20, 20);
            this.btnNotificationCount.TabIndex = 2;
            this.btnNotificationCount.Text = "2";
            this.btnNotificationCount.UseTransparentBackground = true;
            // 
            // btnThongBao
            // 
            this.btnThongBao.BackColor = System.Drawing.Color.Transparent;
            this.btnThongBao.BorderColor = System.Drawing.Color.Empty;
            this.btnThongBao.BorderRadius = 24;
            this.btnThongBao.BorderThickness = 1;
            this.btnThongBao.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnThongBao.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnThongBao.CheckedState.Parent = this.btnThongBao;
            this.btnThongBao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongBao.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnThongBao.CustomImages.Parent = this.btnThongBao;
            this.btnThongBao.FillColor = System.Drawing.Color.Empty;
            this.btnThongBao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThongBao.ForeColor = System.Drawing.Color.White;
            this.btnThongBao.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnThongBao.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnThongBao.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnThongBao.HoverState.Parent = this.btnThongBao;
            this.btnThongBao.Image = ((System.Drawing.Image)(resources.GetObject("btnThongBao.Image")));
            this.btnThongBao.ImageSize = new System.Drawing.Size(40, 40);
            this.btnThongBao.Location = new System.Drawing.Point(3, 0);
            this.btnThongBao.Name = "btnThongBao";
            this.btnThongBao.PressedColor = System.Drawing.Color.Transparent;
            this.btnThongBao.ShadowDecoration.Parent = this.btnThongBao;
            this.btnThongBao.Size = new System.Drawing.Size(60, 50);
            this.btnThongBao.TabIndex = 1;
            this.btnThongBao.UseTransparentBackground = true;
            this.btnThongBao.Click += new System.EventHandler(this.btnThongBao_Click);
            // 
            // panel0
            // 
            this.panel0.BackColor = System.Drawing.Color.Transparent;
            this.panel0.Controls.Add(this.pnMain);
            this.panel0.Controls.Add(this.flpSanPham);
            this.panel0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel0.Location = new System.Drawing.Point(100, 64);
            this.panel0.Name = "panel0";
            this.panel0.Size = new System.Drawing.Size(796, 506);
            this.panel0.TabIndex = 2;
            // 
            // pnMain
            // 
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(796, 506);
            this.pnMain.TabIndex = 0;
            // 
            // flpSanPham
            // 
            this.flpSanPham.AutoScroll = true;
            this.flpSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpSanPham.Location = new System.Drawing.Point(0, 0);
            this.flpSanPham.Name = "flpSanPham";
            this.flpSanPham.Size = new System.Drawing.Size(796, 506);
            this.flpSanPham.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(896, 570);
            this.Controls.Add(this.panel0);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.pnMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlide)).EndInit();
            this.pnTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbUser)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel0.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnMenu;
        private Guna.UI2.WinForms.Guna2Button btnSanPham;
        private System.Windows.Forms.PictureBox imgSlide;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnGioiThieu;
        private Guna.UI2.WinForms.Guna2Button btnNhanVien;
        private Guna.UI2.WinForms.Guna2Button btnKhachHang;
        private Guna.UI2.WinForms.Guna2Button btnHoaDon;
        private System.Windows.Forms.Panel panel0;
        private System.Windows.Forms.Panel pnTop;
        private Guna.UI2.WinForms.Guna2Button btnThongKe;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ptbUser;
        private Guna.UI2.WinForms.Guna2Button btnGioHang;
        private Guna.UI2.WinForms.Guna2Button btnInHoaDon;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2CircleButton btnClose;
        private Guna.UI2.WinForms.Guna2CircleButton btnMinimize;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2CircleButton btnNotificationCount;
        private Guna.UI2.WinForms.Guna2Button btnThongBao;
        private System.Windows.Forms.Label lblTitle;
        public Guna.UI2.WinForms.Guna2CircleButton btnCartCount;
        private System.Windows.Forms.FlowLayoutPanel flpSanPham;
        private System.Windows.Forms.Panel pnMain;
    }
}

