
namespace Skladiste
{
    partial class FormNovaOtpremnica
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
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbZaposlenici = new System.Windows.Forms.ComboBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Location = new System.Drawing.Point(78, 93);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(75, 23);
            this.btnKreiraj.TabIndex = 9;
            this.btnKreiraj.Text = "Kreiraj";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Zaposlenik:";
            // 
            // cmbZaposlenici
            // 
            this.cmbZaposlenici.FormattingEnabled = true;
            this.cmbZaposlenici.Location = new System.Drawing.Point(12, 66);
            this.cmbZaposlenici.Name = "cmbZaposlenici";
            this.cmbZaposlenici.Size = new System.Drawing.Size(210, 21);
            this.cmbZaposlenici.TabIndex = 7;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(15, 27);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(207, 20);
            this.txtAdresa.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Adresa:";
            // 
            // FormNovaOtpremnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 126);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbZaposlenici);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.label1);
            this.Name = "FormNovaOtpremnica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNovaOtpremnica";
            this.Load += new System.EventHandler(this.FormNovaOtpremnica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbZaposlenici;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label label1;
    }
}