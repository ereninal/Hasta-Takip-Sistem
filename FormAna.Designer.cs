namespace SaglikOcagiSistem
{
    partial class FormAna
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
            this.menuStripAna = new System.Windows.Forms.MenuStrip();
            this.referanslarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polikilinikTanıtmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıTanıtmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaKabulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripAna.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripAna
            // 
            this.menuStripAna.Enabled = false;
            this.menuStripAna.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStripAna.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.referanslarToolStripMenuItem,
            this.hastaKabulToolStripMenuItem,
            this.raporlarToolStripMenuItem});
            this.menuStripAna.Location = new System.Drawing.Point(0, 0);
            this.menuStripAna.Name = "menuStripAna";
            this.menuStripAna.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStripAna.Size = new System.Drawing.Size(1291, 28);
            this.menuStripAna.TabIndex = 0;
            this.menuStripAna.Text = "menuStrip1";
            // 
            // referanslarToolStripMenuItem
            // 
            this.referanslarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.polikilinikTanıtmaToolStripMenuItem,
            this.kullanıcıTanıtmaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.referanslarToolStripMenuItem.Name = "referanslarToolStripMenuItem";
            this.referanslarToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.referanslarToolStripMenuItem.Text = "Referanslar";
            this.referanslarToolStripMenuItem.Visible = false;
            this.referanslarToolStripMenuItem.Click += new System.EventHandler(this.referanslarToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // polikilinikTanıtmaToolStripMenuItem
            // 
            this.polikilinikTanıtmaToolStripMenuItem.Name = "polikilinikTanıtmaToolStripMenuItem";
            this.polikilinikTanıtmaToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.polikilinikTanıtmaToolStripMenuItem.Text = "Polikilinik Tanıtma";
            this.polikilinikTanıtmaToolStripMenuItem.Click += new System.EventHandler(this.polikilinikTanıtmaToolStripMenuItem_Click);
            // 
            // kullanıcıTanıtmaToolStripMenuItem
            // 
            this.kullanıcıTanıtmaToolStripMenuItem.Name = "kullanıcıTanıtmaToolStripMenuItem";
            this.kullanıcıTanıtmaToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.kullanıcıTanıtmaToolStripMenuItem.Text = "Kullanıcı Tanıtma";
            this.kullanıcıTanıtmaToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıTanıtmaToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // hastaKabulToolStripMenuItem
            // 
            this.hastaKabulToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaİşlemleriToolStripMenuItem});
            this.hastaKabulToolStripMenuItem.Name = "hastaKabulToolStripMenuItem";
            this.hastaKabulToolStripMenuItem.ShortcutKeyDisplayString = "d";
            this.hastaKabulToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.hastaKabulToolStripMenuItem.Text = "Hasta Kabul";
            // 
            // hastaİşlemleriToolStripMenuItem
            // 
            this.hastaİşlemleriToolStripMenuItem.Name = "hastaİşlemleriToolStripMenuItem";
            this.hastaİşlemleriToolStripMenuItem.ShortcutKeyDisplayString = "F2";
            this.hastaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.hastaİşlemleriToolStripMenuItem.Text = "Hasta İşlemleri";
            this.hastaİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.hastaİşlemleriToolStripMenuItem_Click);
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            this.raporlarToolStripMenuItem.Click += new System.EventHandler(this.raporlarToolStripMenuItem_Click);
            // 
            // FormAna
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1291, 733);
            this.Controls.Add(this.menuStripAna);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStripAna;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAna";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sağlık Ocağı Takip Sistemi";
            this.Load += new System.EventHandler(this.FrmAna_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAna_KeyDown);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FrmAna_MouseDoubleClick);
            this.menuStripAna.ResumeLayout(false);
            this.menuStripAna.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polikilinikTanıtmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıTanıtmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaKabulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStripAna;
        public System.Windows.Forms.ToolStripMenuItem referanslarToolStripMenuItem;
    }
}

