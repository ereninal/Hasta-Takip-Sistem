namespace SaglikOcagiSistem
{
    partial class FormPoliklinikTanıtma
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPoliklinikAdi = new System.Windows.Forms.ComboBox();
            this.chckSecim = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "SOHATS - Poliklinik Tanıtma";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Poliklinik Adı :";
            // 
            // cmbPoliklinikAdi
            // 
            this.cmbPoliklinikAdi.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cmbPoliklinikAdi.FormattingEnabled = true;
            this.cmbPoliklinikAdi.Location = new System.Drawing.Point(116, 56);
            this.cmbPoliklinikAdi.Name = "cmbPoliklinikAdi";
            this.cmbPoliklinikAdi.Size = new System.Drawing.Size(201, 26);
            this.cmbPoliklinikAdi.Sorted = true;
            this.cmbPoliklinikAdi.TabIndex = 2;
            this.cmbPoliklinikAdi.DropDown += new System.EventHandler(this.cmbPoliklinikAdi_DropDown);
            this.cmbPoliklinikAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbPoliklinikAdi_KeyPress);
            // 
            // chckSecim
            // 
            this.chckSecim.AutoSize = true;
            this.chckSecim.Location = new System.Drawing.Point(117, 87);
            this.chckSecim.Name = "chckSecim";
            this.chckSecim.Size = new System.Drawing.Size(138, 22);
            this.chckSecim.TabIndex = 3;
            this.chckSecim.Text = "Geçerli/Geçersiz";
            this.chckSecim.UseVisualStyleBackColor = true;
            // 
            // FormPoliklinikTanıtma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(329, 114);
            this.Controls.Add(this.chckSecim);
            this.Controls.Add(this.cmbPoliklinikAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPoliklinikTanıtma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPoliklinikTanıtma";
            this.Load += new System.EventHandler(this.FrmPoliklinikTanıtma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chckSecim;
        public System.Windows.Forms.ComboBox cmbPoliklinikAdi;
    }
}