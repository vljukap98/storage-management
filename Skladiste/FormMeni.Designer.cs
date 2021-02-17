
namespace Skladiste
{
    partial class FormMeni
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
            this.btnOtpremnice = new System.Windows.Forms.Button();
            this.btnPrimke = new System.Windows.Forms.Button();
            this.btnNarudzbenice = new System.Windows.Forms.Button();
            this.btnOprema = new System.Windows.Forms.Button();
            this.btnZaposlenici = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnStatistikaZap = new System.Windows.Forms.Button();
            this.btnStatistikaOtp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOtpremnice
            // 
            this.btnOtpremnice.Location = new System.Drawing.Point(12, 12);
            this.btnOtpremnice.Name = "btnOtpremnice";
            this.btnOtpremnice.Size = new System.Drawing.Size(179, 23);
            this.btnOtpremnice.TabIndex = 0;
            this.btnOtpremnice.Text = "Otpremnice";
            this.btnOtpremnice.UseVisualStyleBackColor = true;
            this.btnOtpremnice.Click += new System.EventHandler(this.btnOtpremnice_Click);
            // 
            // btnPrimke
            // 
            this.btnPrimke.Location = new System.Drawing.Point(12, 41);
            this.btnPrimke.Name = "btnPrimke";
            this.btnPrimke.Size = new System.Drawing.Size(179, 23);
            this.btnPrimke.TabIndex = 1;
            this.btnPrimke.Text = "Primke";
            this.btnPrimke.UseVisualStyleBackColor = true;
            this.btnPrimke.Click += new System.EventHandler(this.btnPrimke_Click);
            // 
            // btnNarudzbenice
            // 
            this.btnNarudzbenice.Location = new System.Drawing.Point(12, 70);
            this.btnNarudzbenice.Name = "btnNarudzbenice";
            this.btnNarudzbenice.Size = new System.Drawing.Size(179, 23);
            this.btnNarudzbenice.TabIndex = 2;
            this.btnNarudzbenice.Text = "Narudžbenice";
            this.btnNarudzbenice.UseVisualStyleBackColor = true;
            this.btnNarudzbenice.Click += new System.EventHandler(this.btnNarudzbenice_Click);
            // 
            // btnOprema
            // 
            this.btnOprema.Location = new System.Drawing.Point(12, 99);
            this.btnOprema.Name = "btnOprema";
            this.btnOprema.Size = new System.Drawing.Size(179, 23);
            this.btnOprema.TabIndex = 3;
            this.btnOprema.Text = "Oprema";
            this.btnOprema.UseVisualStyleBackColor = true;
            this.btnOprema.Click += new System.EventHandler(this.btnOprema_Click);
            // 
            // btnZaposlenici
            // 
            this.btnZaposlenici.Location = new System.Drawing.Point(12, 128);
            this.btnZaposlenici.Name = "btnZaposlenici";
            this.btnZaposlenici.Size = new System.Drawing.Size(179, 23);
            this.btnZaposlenici.TabIndex = 5;
            this.btnZaposlenici.Text = "Zaposlenici";
            this.btnZaposlenici.UseVisualStyleBackColor = true;
            this.btnZaposlenici.Click += new System.EventHandler(this.btnZaposlenici_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(12, 242);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(179, 23);
            this.btnOdjava.TabIndex = 6;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // btnStatistikaZap
            // 
            this.btnStatistikaZap.Location = new System.Drawing.Point(12, 186);
            this.btnStatistikaZap.Name = "btnStatistikaZap";
            this.btnStatistikaZap.Size = new System.Drawing.Size(179, 23);
            this.btnStatistikaZap.TabIndex = 7;
            this.btnStatistikaZap.Text = "Statistika zaprimljene robe";
            this.btnStatistikaZap.UseVisualStyleBackColor = true;
            this.btnStatistikaZap.Click += new System.EventHandler(this.btnStatistikaZap_Click);
            // 
            // btnStatistikaOtp
            // 
            this.btnStatistikaOtp.Location = new System.Drawing.Point(12, 157);
            this.btnStatistikaOtp.Name = "btnStatistikaOtp";
            this.btnStatistikaOtp.Size = new System.Drawing.Size(179, 23);
            this.btnStatistikaOtp.TabIndex = 8;
            this.btnStatistikaOtp.Text = "Statistika otpremljene robe";
            this.btnStatistikaOtp.UseVisualStyleBackColor = true;
            this.btnStatistikaOtp.Click += new System.EventHandler(this.btnStatistikaOtp_Click);
            // 
            // FormMeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 277);
            this.Controls.Add(this.btnStatistikaOtp);
            this.Controls.Add(this.btnStatistikaZap);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.btnZaposlenici);
            this.Controls.Add(this.btnOprema);
            this.Controls.Add(this.btnNarudzbenice);
            this.Controls.Add(this.btnPrimke);
            this.Controls.Add(this.btnOtpremnice);
            this.Name = "FormMeni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skladiste";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMeni_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOtpremnice;
        private System.Windows.Forms.Button btnPrimke;
        private System.Windows.Forms.Button btnNarudzbenice;
        private System.Windows.Forms.Button btnOprema;
        private System.Windows.Forms.Button btnZaposlenici;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button btnStatistikaZap;
        private System.Windows.Forms.Button btnStatistikaOtp;
    }
}