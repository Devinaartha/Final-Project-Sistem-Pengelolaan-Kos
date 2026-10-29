namespace Sistem_Pengelolaan_Kos
{
    partial class FormDashboard
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
            this.pnlSiDebar = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlSiDebar
            // 
            this.pnlSiDebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlSiDebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSiDebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSiDebar.Name = "pnlSiDebar";
            this.pnlSiDebar.Size = new System.Drawing.Size(270, 735);
            this.pnlSiDebar.TabIndex = 0;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 735);
            this.Controls.Add(this.pnlSiDebar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistem Pengelolaan Kos-Dashboard Utama";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSiDebar;
    }
}

