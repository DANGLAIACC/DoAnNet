namespace DoAnNet.Forms
{
    partial class frmThemNhanVien
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
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.btnGioiTinh = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSt_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSt_phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSt_lastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSt_firstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSt_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(655, 179);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(66, 32);
            this.lblGioiTinh.TabIndex = 121;
            this.lblGioiTinh.Text = "Nam";
            // 
            // btnGioiTinh
            // 
            this.btnGioiTinh.Checked = true;
            this.btnGioiTinh.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnGioiTinh.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnGioiTinh.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.btnGioiTinh.CheckedState.InnerColor = System.Drawing.Color.White;
            this.btnGioiTinh.CheckedState.Parent = this.btnGioiTinh;
            this.btnGioiTinh.Location = new System.Drawing.Point(614, 185);
            this.btnGioiTinh.Name = "btnGioiTinh";
            this.btnGioiTinh.ShadowDecoration.Parent = this.btnGioiTinh;
            this.btnGioiTinh.Size = new System.Drawing.Size(35, 20);
            this.btnGioiTinh.TabIndex = 5;
            this.btnGioiTinh.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btnGioiTinh.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btnGioiTinh.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.btnGioiTinh.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.btnGioiTinh.UncheckedState.Parent = this.btnGioiTinh;
            this.btnGioiTinh.CheckedChanged += new System.EventHandler(this.btnGioiTinh_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(449, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 32);
            this.label7.TabIndex = 119;
            this.label7.Text = "Giới tính";
            // 
            // txtSt_email
            // 
            this.txtSt_email.AutoRoundedCorners = true;
            this.txtSt_email.BackColor = System.Drawing.Color.Transparent;
            this.txtSt_email.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtSt_email.BorderRadius = 17;
            this.txtSt_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSt_email.DefaultText = "";
            this.txtSt_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSt_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSt_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSt_email.DisabledState.Parent = this.txtSt_email;
            this.txtSt_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSt_email.FocusedState.Parent = this.txtSt_email;
            this.txtSt_email.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSt_email.ForeColor = System.Drawing.Color.Black;
            this.txtSt_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.txtSt_email.HoverState.Parent = this.txtSt_email;
            this.txtSt_email.Location = new System.Drawing.Point(608, 125);
            this.txtSt_email.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtSt_email.Name = "txtSt_email";
            this.txtSt_email.PasswordChar = '\0';
            this.txtSt_email.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtSt_email.PlaceholderText = "";
            this.txtSt_email.SelectedText = "";
            this.txtSt_email.ShadowDecoration.BorderRadius = 0;
            this.txtSt_email.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.txtSt_email.ShadowDecoration.Depth = 20;
            this.txtSt_email.ShadowDecoration.Parent = this.txtSt_email;
            this.txtSt_email.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(4, 3, 4, 5);
            this.txtSt_email.Size = new System.Drawing.Size(185, 37);
            this.txtSt_email.TabIndex = 4;
            this.txtSt_email.TextOffset = new System.Drawing.Point(8, 0);
            this.txtSt_email.WordWrap = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(449, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 32);
            this.label6.TabIndex = 117;
            this.label6.Text = "Email";
            // 
            // txtSt_phone
            // 
            this.txtSt_phone.AutoRoundedCorners = true;
            this.txtSt_phone.BackColor = System.Drawing.Color.Transparent;
            this.txtSt_phone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtSt_phone.BorderRadius = 17;
            this.txtSt_phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSt_phone.DefaultText = "";
            this.txtSt_phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSt_phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSt_phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSt_phone.DisabledState.Parent = this.txtSt_phone;
            this.txtSt_phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSt_phone.FocusedState.Parent = this.txtSt_phone;
            this.txtSt_phone.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSt_phone.ForeColor = System.Drawing.Color.Black;
            this.txtSt_phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.txtSt_phone.HoverState.Parent = this.txtSt_phone;
            this.txtSt_phone.Location = new System.Drawing.Point(608, 74);
            this.txtSt_phone.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtSt_phone.Name = "txtSt_phone";
            this.txtSt_phone.PasswordChar = '\0';
            this.txtSt_phone.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtSt_phone.PlaceholderText = "";
            this.txtSt_phone.SelectedText = "";
            this.txtSt_phone.ShadowDecoration.BorderRadius = 0;
            this.txtSt_phone.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.txtSt_phone.ShadowDecoration.Depth = 20;
            this.txtSt_phone.ShadowDecoration.Parent = this.txtSt_phone;
            this.txtSt_phone.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(4, 3, 4, 5);
            this.txtSt_phone.Size = new System.Drawing.Size(185, 37);
            this.txtSt_phone.TabIndex = 3;
            this.txtSt_phone.TextOffset = new System.Drawing.Point(8, 0);
            this.txtSt_phone.WordWrap = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(449, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 32);
            this.label5.TabIndex = 115;
            this.label5.Text = "Số điện thoại";
            // 
            // txtSt_lastName
            // 
            this.txtSt_lastName.AutoRoundedCorners = true;
            this.txtSt_lastName.BackColor = System.Drawing.Color.Transparent;
            this.txtSt_lastName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtSt_lastName.BorderRadius = 17;
            this.txtSt_lastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSt_lastName.DefaultText = "";
            this.txtSt_lastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSt_lastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSt_lastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSt_lastName.DisabledState.Parent = this.txtSt_lastName;
            this.txtSt_lastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSt_lastName.FocusedState.Parent = this.txtSt_lastName;
            this.txtSt_lastName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSt_lastName.ForeColor = System.Drawing.Color.Black;
            this.txtSt_lastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.txtSt_lastName.HoverState.Parent = this.txtSt_lastName;
            this.txtSt_lastName.Location = new System.Drawing.Point(232, 177);
            this.txtSt_lastName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtSt_lastName.Name = "txtSt_lastName";
            this.txtSt_lastName.PasswordChar = '\0';
            this.txtSt_lastName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtSt_lastName.PlaceholderText = "";
            this.txtSt_lastName.SelectedText = "";
            this.txtSt_lastName.ShadowDecoration.BorderRadius = 0;
            this.txtSt_lastName.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.txtSt_lastName.ShadowDecoration.Depth = 20;
            this.txtSt_lastName.ShadowDecoration.Parent = this.txtSt_lastName;
            this.txtSt_lastName.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(4, 3, 4, 5);
            this.txtSt_lastName.Size = new System.Drawing.Size(185, 37);
            this.txtSt_lastName.TabIndex = 2;
            this.txtSt_lastName.TextOffset = new System.Drawing.Point(8, 0);
            this.txtSt_lastName.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 32);
            this.label4.TabIndex = 113;
            this.label4.Text = "Tên";
            // 
            // txtSt_firstName
            // 
            this.txtSt_firstName.AutoRoundedCorners = true;
            this.txtSt_firstName.BackColor = System.Drawing.Color.Transparent;
            this.txtSt_firstName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtSt_firstName.BorderRadius = 17;
            this.txtSt_firstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSt_firstName.DefaultText = "";
            this.txtSt_firstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSt_firstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSt_firstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSt_firstName.DisabledState.Parent = this.txtSt_firstName;
            this.txtSt_firstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSt_firstName.FocusedState.Parent = this.txtSt_firstName;
            this.txtSt_firstName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSt_firstName.ForeColor = System.Drawing.Color.Black;
            this.txtSt_firstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.txtSt_firstName.HoverState.Parent = this.txtSt_firstName;
            this.txtSt_firstName.Location = new System.Drawing.Point(232, 126);
            this.txtSt_firstName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtSt_firstName.Name = "txtSt_firstName";
            this.txtSt_firstName.PasswordChar = '\0';
            this.txtSt_firstName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtSt_firstName.PlaceholderText = "";
            this.txtSt_firstName.SelectedText = "";
            this.txtSt_firstName.ShadowDecoration.BorderRadius = 0;
            this.txtSt_firstName.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.txtSt_firstName.ShadowDecoration.Depth = 20;
            this.txtSt_firstName.ShadowDecoration.Parent = this.txtSt_firstName;
            this.txtSt_firstName.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(4, 3, 4, 5);
            this.txtSt_firstName.Size = new System.Drawing.Size(185, 37);
            this.txtSt_firstName.TabIndex = 1;
            this.txtSt_firstName.TextOffset = new System.Drawing.Point(8, 0);
            this.txtSt_firstName.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 32);
            this.label3.TabIndex = 111;
            this.label3.Text = "Họ";
            // 
            // txtSt_id
            // 
            this.txtSt_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSt_id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSt_id.AutoRoundedCorners = true;
            this.txtSt_id.BackColor = System.Drawing.Color.Transparent;
            this.txtSt_id.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtSt_id.BorderRadius = 17;
            this.txtSt_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSt_id.DefaultText = "";
            this.txtSt_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSt_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSt_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSt_id.DisabledState.Parent = this.txtSt_id;
            this.txtSt_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSt_id.FocusedState.Parent = this.txtSt_id;
            this.txtSt_id.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSt_id.ForeColor = System.Drawing.Color.Black;
            this.txtSt_id.HoverState.Parent = this.txtSt_id;
            this.txtSt_id.Location = new System.Drawing.Point(232, 75);
            this.txtSt_id.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtSt_id.Name = "txtSt_id";
            this.txtSt_id.PasswordChar = '\0';
            this.txtSt_id.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSt_id.PlaceholderText = "";
            this.txtSt_id.SelectedText = "";
            this.txtSt_id.ShadowDecoration.BorderRadius = 0;
            this.txtSt_id.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.txtSt_id.ShadowDecoration.Depth = 20;
            this.txtSt_id.ShadowDecoration.Parent = this.txtSt_id;
            this.txtSt_id.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(4, 3, 4, 5);
            this.txtSt_id.Size = new System.Drawing.Size(185, 37);
            this.txtSt_id.TabIndex = 0;
            this.txtSt_id.TextOffset = new System.Drawing.Point(8, 0);
            this.txtSt_id.WordWrap = false;
            this.txtSt_id.TextChanged += new System.EventHandler(this.txtSt_id_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 32);
            this.label2.TabIndex = 109;
            this.label2.Text = "Tên đăng nhập";
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblHeader.Location = new System.Drawing.Point(29, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(796, 47);
            this.lblHeader.TabIndex = 108;
            this.lblHeader.Text = "Thêm mới nhân viên";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.BorderRadius = 5;
            this.btnClear.CheckedState.Parent = this.btnClear;
            this.btnClear.CustomImages.Parent = this.btnClear;
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.HoverState.Parent = this.btnClear;
            this.btnClear.Location = new System.Drawing.Point(721, 242);
            this.btnClear.Name = "btnClear";
            this.btnClear.ShadowDecoration.Parent = this.btnClear;
            this.btnClear.Size = new System.Drawing.Size(70, 30);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 5;
            this.btnThem.CheckedState.Parent = this.btnThem;
            this.btnThem.CustomImages.Parent = this.btnThem;
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.HoverState.Parent = this.btnThem;
            this.btnThem.Location = new System.Drawing.Point(574, 242);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(110, 30);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm NV";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // frmThemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 322);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.btnGioiTinh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSt_email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSt_phone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSt_lastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSt_firstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSt_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmThemNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm mới nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGioiTinh;
        private Guna.UI2.WinForms.Guna2ToggleSwitch btnGioiTinh;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtSt_email;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtSt_phone;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtSt_lastName;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtSt_firstName;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtSt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHeader;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private System.Windows.Forms.ErrorProvider err;
    }
}