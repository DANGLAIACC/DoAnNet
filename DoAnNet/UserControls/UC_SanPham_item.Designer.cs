namespace DoAnNet.UserControls
{
    partial class UC_SanPham_item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_SanPham_item));
            this.ptb = new System.Windows.Forms.PictureBox();
            this.lbl = new System.Windows.Forms.Label();
            this.btn = new Guna.UI2.WinForms.Guna2Button();
            this.lblGia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptb)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb
            // 
            this.ptb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptb.Image = ((System.Drawing.Image)(resources.GetObject("ptb.Image")));
            this.ptb.Location = new System.Drawing.Point(54, 14);
            this.ptb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ptb.Name = "ptb";
            this.ptb.Size = new System.Drawing.Size(140, 140);
            this.ptb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb.TabIndex = 0;
            this.ptb.TabStop = false;
            // 
            // lbl
            // 
            this.lbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(0, 169);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(250, 19);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "lbl";
            // 
            // btn
            // 
            this.btn.CheckedState.Parent = this.btn;
            this.btn.CustomImages.Parent = this.btn;
            this.btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn.ForeColor = System.Drawing.Color.White;
            this.btn.HoverState.Parent = this.btn;
            this.btn.Image = ((System.Drawing.Image)(resources.GetObject("btn.Image")));
            this.btn.Location = new System.Drawing.Point(142, 191);
            this.btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn.Name = "btn";
            this.btn.ShadowDecoration.Parent = this.btn;
            this.btn.Size = new System.Drawing.Size(90, 43);
            this.btn.TabIndex = 2;
            this.btn.Text = "Thêm";
            // 
            // lblGia
            // 
            this.lblGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.ForeColor = System.Drawing.Color.Red;
            this.lblGia.Location = new System.Drawing.Point(3, 191);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(104, 43);
            this.lblGia.TabIndex = 3;
            this.lblGia.Text = "lblGia";
            this.lblGia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UC_SanPham_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.ptb);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UC_SanPham_item";
            this.Size = new System.Drawing.Size(250, 256);
            ((System.ComponentModel.ISupportInitialize)(this.ptb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb;
        private System.Windows.Forms.Label lbl;
        private Guna.UI2.WinForms.Guna2Button btn;
        private System.Windows.Forms.Label lblGia;
    }
}
