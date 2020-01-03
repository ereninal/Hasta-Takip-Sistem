namespace SaglikOcagiSistem
{
    partial class FormBaskiOnizleme
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
            this.RaporGoster = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.baskiOnizleme11 = new SaglikOcagiSistem.BaskiOnizleme1();
            this.SuspendLayout();
            // 
            // RaporGoster
            // 
            this.RaporGoster.ActiveViewIndex = -1;
            this.RaporGoster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RaporGoster.Cursor = System.Windows.Forms.Cursors.Default;
            this.RaporGoster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RaporGoster.Location = new System.Drawing.Point(0, 0);
            this.RaporGoster.Name = "RaporGoster";
            this.RaporGoster.Size = new System.Drawing.Size(1016, 649);
            this.RaporGoster.TabIndex = 0;
            this.RaporGoster.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // FormBaskiOnizleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 649);
            this.Controls.Add(this.RaporGoster);
            this.Name = "FormBaskiOnizleme";
            this.Text = "FormBaskiOnizleme";
            this.Load += new System.EventHandler(this.FormBaskiOnizleme_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public BaskiOnizleme1 baskiOnizleme11;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer RaporGoster;
    }
}