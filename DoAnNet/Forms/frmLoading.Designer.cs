namespace DoAnNet.Forms
{
    partial class frmLoading
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.uC_Loading1 = new DoAnNet.UserControls.UC_Loading();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // uC_Loading1
            // 
            this.uC_Loading1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Loading1.Location = new System.Drawing.Point(0, 0);
            this.uC_Loading1.Name = "uC_Loading1";
            this.uC_Loading1.Size = new System.Drawing.Size(344, 316);
            this.uC_Loading1.TabIndex = 0;
            // 
            // frmLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 316);
            this.Controls.Add(this.uC_Loading1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLoading";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.UC_Loading uC_Loading1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}