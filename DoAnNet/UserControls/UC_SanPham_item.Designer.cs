﻿namespace DoAnNet.UserControls
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
            this.ptb.Location = new System.Drawing.Point(44, 96);
            this.ptb.Name = "ptb";
            this.ptb.Size = new System.Drawing.Size(250, 250);
            this.ptb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb.TabIndex = 0;
            this.ptb.TabStop = false;
            // 
            // lbl
            // 
            this.lbl.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(13, 13);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(309, 80);
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
            this.btn.Location = new System.Drawing.Point(197, 365);
            this.btn.Name = "btn";
            this.btn.ShadowDecoration.Parent = this.btn;
            this.btn.Size = new System.Drawing.Size(125, 45);
            this.btn.TabIndex = 2;
            this.btn.Text = "Thêm vào giỏ";
            // 
            // lblGia
            // 
            this.lblGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.Location = new System.Drawing.Point(18, 365);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(173, 45);
            this.lblGia.TabIndex = 3;
            this.lblGia.Text = "lblGia";
            // 
            // UC_SanPham_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.ptb);
            this.Name = "UC_SanPham_item";
            this.Size = new System.Drawing.Size(335, 426);
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
