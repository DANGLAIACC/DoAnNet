namespace DoAnNet.Forms
{
    partial class frmDoiMatKhau
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
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.txtCurrentPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThoat = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.pnTop = new System.Windows.Forms.Panel();
            this.pnBottom = new System.Windows.Forms.FlowLayoutPanel();
            this.txtNewPassword2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnTop.SuspendLayout();
            this.pnBottom.SuspendLayout();
            this.pnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.Location = new System.Drawing.Point(18, 21);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(117, 23);
            this.lblCurrentPassword.TabIndex = 0;
            this.lblCurrentPassword.Text = "Mật khẩu cũ";
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.AutoRoundedCorners = true;
            this.txtCurrentPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtCurrentPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtCurrentPassword.BorderRadius = 15;
            this.txtCurrentPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCurrentPassword.DefaultText = "";
            this.txtCurrentPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCurrentPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCurrentPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCurrentPassword.DisabledState.Parent = this.txtCurrentPassword;
            this.txtCurrentPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCurrentPassword.FocusedState.Parent = this.txtCurrentPassword;
            this.txtCurrentPassword.Font = new System.Drawing.Font("SVN-Gilroy Light", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPassword.ForeColor = System.Drawing.Color.Black;
            this.txtCurrentPassword.HoverState.Parent = this.txtCurrentPassword;
            this.txtCurrentPassword.Location = new System.Drawing.Point(191, 14);
            this.txtCurrentPassword.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.PasswordChar = '\0';
            this.txtCurrentPassword.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCurrentPassword.PlaceholderText = "";
            this.txtCurrentPassword.SelectedText = "";
            this.txtCurrentPassword.ShadowDecoration.BorderRadius = 0;
            this.txtCurrentPassword.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.txtCurrentPassword.ShadowDecoration.Depth = 20;
            this.txtCurrentPassword.ShadowDecoration.Parent = this.txtCurrentPassword;
            this.txtCurrentPassword.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(4, 3, 4, 5);
            this.txtCurrentPassword.ShortcutsEnabled = false;
            this.txtCurrentPassword.Size = new System.Drawing.Size(185, 33);
            this.txtCurrentPassword.TabIndex = 0;
            this.txtCurrentPassword.TextOffset = new System.Drawing.Point(8, 0);
            this.txtCurrentPassword.WordWrap = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BorderRadius = 5;
            this.btnThoat.CheckedState.Parent = this.btnThoat;
            this.btnThoat.CustomImages.Parent = this.btnThoat;
            this.btnThoat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.HoverState.Parent = this.btnThoat;
            this.btnThoat.Location = new System.Drawing.Point(317, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ShadowDecoration.Parent = this.btnThoat;
            this.btnThoat.Size = new System.Drawing.Size(80, 42);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BorderRadius = 5;
            this.btnLuu.CheckedState.Parent = this.btnLuu;
            this.btnLuu.CustomImages.Parent = this.btnLuu;
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.HoverState.Parent = this.btnLuu;
            this.btnLuu.Location = new System.Drawing.Point(182, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ShadowDecoration.Parent = this.btnLuu;
            this.btnLuu.Size = new System.Drawing.Size(129, 42);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu thông tin";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.txtCurrentPassword);
            this.pnTop.Controls.Add(this.lblCurrentPassword);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(400, 57);
            this.pnTop.TabIndex = 19;
            // 
            // pnBottom
            // 
            this.pnBottom.Controls.Add(this.btnThoat);
            this.pnBottom.Controls.Add(this.btnLuu);
            this.pnBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBottom.Location = new System.Drawing.Point(0, 175);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnBottom.Size = new System.Drawing.Size(400, 57);
            this.pnBottom.TabIndex = 21;
            // 
            // txtNewPassword2
            // 
            this.txtNewPassword2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNewPassword2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNewPassword2.AutoRoundedCorners = true;
            this.txtNewPassword2.BackColor = System.Drawing.Color.Transparent;
            this.txtNewPassword2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtNewPassword2.BorderRadius = 15;
            this.txtNewPassword2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassword2.DefaultText = "";
            this.txtNewPassword2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewPassword2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewPassword2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPassword2.DisabledState.Parent = this.txtNewPassword2;
            this.txtNewPassword2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPassword2.FocusedState.Parent = this.txtNewPassword2;
            this.txtNewPassword2.Font = new System.Drawing.Font("SVN-Gilroy Light", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword2.ForeColor = System.Drawing.Color.Black;
            this.txtNewPassword2.HoverState.Parent = this.txtNewPassword2;
            this.txtNewPassword2.Location = new System.Drawing.Point(192, 58);
            this.txtNewPassword2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtNewPassword2.Name = "txtNewPassword2";
            this.txtNewPassword2.PasswordChar = '\0';
            this.txtNewPassword2.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNewPassword2.PlaceholderText = "";
            this.txtNewPassword2.SelectedText = "";
            this.txtNewPassword2.ShadowDecoration.BorderRadius = 0;
            this.txtNewPassword2.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.txtNewPassword2.ShadowDecoration.Depth = 20;
            this.txtNewPassword2.ShadowDecoration.Parent = this.txtNewPassword2;
            this.txtNewPassword2.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(4, 3, 4, 5);
            this.txtNewPassword2.ShortcutsEnabled = false;
            this.txtNewPassword2.Size = new System.Drawing.Size(185, 33);
            this.txtNewPassword2.TabIndex = 2;
            this.txtNewPassword2.TextOffset = new System.Drawing.Point(8, 0);
            this.txtNewPassword2.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu mới";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNewPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNewPassword.AutoRoundedCorners = true;
            this.txtNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtNewPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtNewPassword.BorderRadius = 15;
            this.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassword.DefaultText = "";
            this.txtNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPassword.DisabledState.Parent = this.txtNewPassword;
            this.txtNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPassword.FocusedState.Parent = this.txtNewPassword;
            this.txtNewPassword.Font = new System.Drawing.Font("SVN-Gilroy Light", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.ForeColor = System.Drawing.Color.Black;
            this.txtNewPassword.HoverState.Parent = this.txtNewPassword;
            this.txtNewPassword.Location = new System.Drawing.Point(192, 11);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '\0';
            this.txtNewPassword.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNewPassword.PlaceholderText = "";
            this.txtNewPassword.SelectedText = "";
            this.txtNewPassword.ShadowDecoration.BorderRadius = 0;
            this.txtNewPassword.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.txtNewPassword.ShadowDecoration.Depth = 20;
            this.txtNewPassword.ShadowDecoration.Parent = this.txtNewPassword;
            this.txtNewPassword.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(4, 3, 4, 5);
            this.txtNewPassword.ShortcutsEnabled = false;
            this.txtNewPassword.Size = new System.Drawing.Size(185, 33);
            this.txtNewPassword.TabIndex = 1;
            this.txtNewPassword.TextOffset = new System.Drawing.Point(8, 0);
            this.txtNewPassword.WordWrap = false;
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.txtNewPassword);
            this.pnMain.Controls.Add(this.label2);
            this.pnMain.Controls.Add(this.label3);
            this.pnMain.Controls.Add(this.txtNewPassword2);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 57);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(400, 175);
            this.pnMain.TabIndex = 20;
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(400, 232);
            this.Controls.Add(this.pnBottom);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnTop);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.pnBottom.ResumeLayout(false);
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtCurrentPassword;
        private Guna.UI2.WinForms.Guna2Button btnThoat;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.FlowLayoutPanel pnBottom;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPassword2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPassword;
        private System.Windows.Forms.Panel pnMain;
    }
}