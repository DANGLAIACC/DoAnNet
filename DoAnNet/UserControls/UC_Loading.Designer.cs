namespace DoAnNet.UserControls
{
    partial class UC_Loading
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pgbLoading = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.guna2CustomGradientPanel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(435, 338);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.pgbLoading);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(126, 77);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(183, 183);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // pgbLoading
            // 
            this.pgbLoading.Animated = true;
            this.pgbLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgbLoading.FillColor = System.Drawing.Color.Transparent;
            this.pgbLoading.FillThickness = 0;
            this.pgbLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.pgbLoading.Location = new System.Drawing.Point(0, 0);
            this.pgbLoading.Name = "pgbLoading";
            this.pgbLoading.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
            this.pgbLoading.ProgressColor2 = System.Drawing.Color.Cyan;
            this.pgbLoading.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.pgbLoading.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.pgbLoading.ProgressThickness = 35;
            this.pgbLoading.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pgbLoading.ShadowDecoration.Parent = this.pgbLoading;
            this.pgbLoading.ShowPercentage = true;
            this.pgbLoading.Size = new System.Drawing.Size(183, 183);
            this.pgbLoading.TabIndex = 1;
            this.pgbLoading.TabStop = false;
            this.pgbLoading.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.pgbLoading.Value = 100;
            // 
            // timer1
            // 
            this.timer1.Interval = 48;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UC_Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UC_Loading";
            this.Size = new System.Drawing.Size(435, 338);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar pgbLoading;
        private System.Windows.Forms.Timer timer1;
    }
}
