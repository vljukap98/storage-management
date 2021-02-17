
namespace Skladiste
{
    partial class FormOtpremnice
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
            this.dgvOtpremnice = new System.Windows.Forms.DataGridView();
            this.dgvStavkeOtpremnice = new System.Windows.Forms.DataGridView();
            this.gbStavkeOtp = new System.Windows.Forms.GroupBox();
            this.labelTrenutnaKolOprema = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelMaxOprema = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelMinOprema = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNazivOpreme = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelOS = new System.Windows.Forms.Button();
            this.btnAddOS = new System.Windows.Forms.Button();
            this.btnCreateO = new System.Windows.Forms.Button();
            this.btnUpdO = new System.Windows.Forms.Button();
            this.btnDelO = new System.Windows.Forms.Button();
            this.labelZaposlenik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtpremnice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeOtpremnice)).BeginInit();
            this.gbStavkeOtp.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOtpremnice
            // 
            this.dgvOtpremnice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOtpremnice.Location = new System.Drawing.Point(12, 12);
            this.dgvOtpremnice.Name = "dgvOtpremnice";
            this.dgvOtpremnice.Size = new System.Drawing.Size(338, 150);
            this.dgvOtpremnice.TabIndex = 0;
            this.dgvOtpremnice.SelectionChanged += new System.EventHandler(this.dgvOtpremnice_SelectionChanged);
            // 
            // dgvStavkeOtpremnice
            // 
            this.dgvStavkeOtpremnice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeOtpremnice.Location = new System.Drawing.Point(6, 19);
            this.dgvStavkeOtpremnice.Name = "dgvStavkeOtpremnice";
            this.dgvStavkeOtpremnice.Size = new System.Drawing.Size(243, 150);
            this.dgvStavkeOtpremnice.TabIndex = 1;
            this.dgvStavkeOtpremnice.SelectionChanged += new System.EventHandler(this.dgvStavkeOtpremnice_SelectionChanged);
            // 
            // gbStavkeOtp
            // 
            this.gbStavkeOtp.Controls.Add(this.labelTrenutnaKolOprema);
            this.gbStavkeOtp.Controls.Add(this.label7);
            this.gbStavkeOtp.Controls.Add(this.labelMaxOprema);
            this.gbStavkeOtp.Controls.Add(this.label5);
            this.gbStavkeOtp.Controls.Add(this.labelMinOprema);
            this.gbStavkeOtp.Controls.Add(this.label3);
            this.gbStavkeOtp.Controls.Add(this.labelNazivOpreme);
            this.gbStavkeOtp.Controls.Add(this.label1);
            this.gbStavkeOtp.Controls.Add(this.btnDelOS);
            this.gbStavkeOtp.Controls.Add(this.btnAddOS);
            this.gbStavkeOtp.Controls.Add(this.dgvStavkeOtpremnice);
            this.gbStavkeOtp.Location = new System.Drawing.Point(12, 181);
            this.gbStavkeOtp.Name = "gbStavkeOtp";
            this.gbStavkeOtp.Size = new System.Drawing.Size(480, 176);
            this.gbStavkeOtp.TabIndex = 2;
            this.gbStavkeOtp.TabStop = false;
            // 
            // labelTrenutnaKolOprema
            // 
            this.labelTrenutnaKolOprema.AutoSize = true;
            this.labelTrenutnaKolOprema.Location = new System.Drawing.Point(416, 32);
            this.labelTrenutnaKolOprema.Name = "labelTrenutnaKolOprema";
            this.labelTrenutnaKolOprema.Size = new System.Drawing.Size(0, 13);
            this.labelTrenutnaKolOprema.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(391, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Trenutna količina";
            // 
            // labelMaxOprema
            // 
            this.labelMaxOprema.AutoSize = true;
            this.labelMaxOprema.Location = new System.Drawing.Point(255, 102);
            this.labelMaxOprema.Name = "labelMaxOprema";
            this.labelMaxOprema.Size = new System.Drawing.Size(0, 13);
            this.labelMaxOprema.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Maksimalna količina";
            // 
            // labelMinOprema
            // 
            this.labelMinOprema.AutoSize = true;
            this.labelMinOprema.Location = new System.Drawing.Point(255, 64);
            this.labelMinOprema.Name = "labelMinOprema";
            this.labelMinOprema.Size = new System.Drawing.Size(0, 13);
            this.labelMinOprema.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Minimalna količina";
            // 
            // labelNazivOpreme
            // 
            this.labelNazivOpreme.AutoSize = true;
            this.labelNazivOpreme.Location = new System.Drawing.Point(255, 32);
            this.labelNazivOpreme.Name = "labelNazivOpreme";
            this.labelNazivOpreme.Size = new System.Drawing.Size(0, 13);
            this.labelNazivOpreme.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Naziv";
            // 
            // btnDelOS
            // 
            this.btnDelOS.Location = new System.Drawing.Point(372, 146);
            this.btnDelOS.Name = "btnDelOS";
            this.btnDelOS.Size = new System.Drawing.Size(102, 23);
            this.btnDelOS.TabIndex = 3;
            this.btnDelOS.Text = "Obriši stavku";
            this.btnDelOS.UseVisualStyleBackColor = true;
            this.btnDelOS.Click += new System.EventHandler(this.btnDelOS_Click);
            // 
            // btnAddOS
            // 
            this.btnAddOS.Location = new System.Drawing.Point(255, 146);
            this.btnAddOS.Name = "btnAddOS";
            this.btnAddOS.Size = new System.Drawing.Size(102, 23);
            this.btnAddOS.TabIndex = 2;
            this.btnAddOS.Text = "Dodaj stavku";
            this.btnAddOS.UseVisualStyleBackColor = true;
            this.btnAddOS.Click += new System.EventHandler(this.btnAddOS_Click);
            // 
            // btnCreateO
            // 
            this.btnCreateO.Location = new System.Drawing.Point(356, 81);
            this.btnCreateO.Name = "btnCreateO";
            this.btnCreateO.Size = new System.Drawing.Size(136, 23);
            this.btnCreateO.TabIndex = 3;
            this.btnCreateO.Text = "Nova otpremnica";
            this.btnCreateO.UseVisualStyleBackColor = true;
            this.btnCreateO.Click += new System.EventHandler(this.btnCreateO_Click);
            // 
            // btnUpdO
            // 
            this.btnUpdO.Location = new System.Drawing.Point(356, 110);
            this.btnUpdO.Name = "btnUpdO";
            this.btnUpdO.Size = new System.Drawing.Size(136, 23);
            this.btnUpdO.TabIndex = 4;
            this.btnUpdO.Text = "Promijeni podatke";
            this.btnUpdO.UseVisualStyleBackColor = true;
            this.btnUpdO.Click += new System.EventHandler(this.btnUpdO_Click);
            // 
            // btnDelO
            // 
            this.btnDelO.Location = new System.Drawing.Point(356, 139);
            this.btnDelO.Name = "btnDelO";
            this.btnDelO.Size = new System.Drawing.Size(136, 23);
            this.btnDelO.TabIndex = 5;
            this.btnDelO.Text = "Obriši dokument";
            this.btnDelO.UseVisualStyleBackColor = true;
            this.btnDelO.Click += new System.EventHandler(this.btnDelO_Click);
            // 
            // labelZaposlenik
            // 
            this.labelZaposlenik.AutoSize = true;
            this.labelZaposlenik.Location = new System.Drawing.Point(356, 12);
            this.labelZaposlenik.Name = "labelZaposlenik";
            this.labelZaposlenik.Size = new System.Drawing.Size(0, 13);
            this.labelZaposlenik.TabIndex = 6;
            // 
            // FormOtpremnice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 368);
            this.Controls.Add(this.labelZaposlenik);
            this.Controls.Add(this.btnDelO);
            this.Controls.Add(this.btnUpdO);
            this.Controls.Add(this.btnCreateO);
            this.Controls.Add(this.gbStavkeOtp);
            this.Controls.Add(this.dgvOtpremnice);
            this.Name = "FormOtpremnice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otpremnice";
            this.Load += new System.EventHandler(this.FormOtpremnice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtpremnice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeOtpremnice)).EndInit();
            this.gbStavkeOtp.ResumeLayout(false);
            this.gbStavkeOtp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOtpremnice;
        private System.Windows.Forms.DataGridView dgvStavkeOtpremnice;
        private System.Windows.Forms.GroupBox gbStavkeOtp;
        private System.Windows.Forms.Button btnCreateO;
        private System.Windows.Forms.Button btnUpdO;
        private System.Windows.Forms.Button btnDelO;
        private System.Windows.Forms.Label labelZaposlenik;
        private System.Windows.Forms.Button btnDelOS;
        private System.Windows.Forms.Button btnAddOS;
        private System.Windows.Forms.Label labelTrenutnaKolOprema;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelMaxOprema;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelMinOprema;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNazivOpreme;
        private System.Windows.Forms.Label label1;
    }
}