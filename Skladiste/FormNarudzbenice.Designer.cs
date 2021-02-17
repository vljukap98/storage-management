
namespace Skladiste
{
    partial class FormNarudzbenice
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
            this.dgvNarudzbenice = new System.Windows.Forms.DataGridView();
            this.labelZaposlenik = new System.Windows.Forms.Label();
            this.btnDelN = new System.Windows.Forms.Button();
            this.btnCreateN = new System.Windows.Forms.Button();
            this.gbStavkeNar = new System.Windows.Forms.GroupBox();
            this.dgvStavkeNarudzbenice = new System.Windows.Forms.DataGridView();
            this.btnPotvrdiN = new System.Windows.Forms.Button();
            this.btnDelnS = new System.Windows.Forms.Button();
            this.btnAddNS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbenice)).BeginInit();
            this.gbStavkeNar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeNarudzbenice)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNarudzbenice
            // 
            this.dgvNarudzbenice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarudzbenice.Location = new System.Drawing.Point(12, 12);
            this.dgvNarudzbenice.Name = "dgvNarudzbenice";
            this.dgvNarudzbenice.Size = new System.Drawing.Size(238, 150);
            this.dgvNarudzbenice.TabIndex = 13;
            this.dgvNarudzbenice.SelectionChanged += new System.EventHandler(this.dgvNarudzbenice_SelectionChanged);
            // 
            // labelZaposlenik
            // 
            this.labelZaposlenik.AutoSize = true;
            this.labelZaposlenik.Location = new System.Drawing.Point(256, 12);
            this.labelZaposlenik.Name = "labelZaposlenik";
            this.labelZaposlenik.Size = new System.Drawing.Size(0, 13);
            this.labelZaposlenik.TabIndex = 18;
            // 
            // btnDelN
            // 
            this.btnDelN.Location = new System.Drawing.Point(259, 138);
            this.btnDelN.Name = "btnDelN";
            this.btnDelN.Size = new System.Drawing.Size(136, 23);
            this.btnDelN.TabIndex = 17;
            this.btnDelN.Text = "Obriši dokument";
            this.btnDelN.UseVisualStyleBackColor = true;
            this.btnDelN.Click += new System.EventHandler(this.btnDelN_Click);
            // 
            // btnCreateN
            // 
            this.btnCreateN.Location = new System.Drawing.Point(259, 109);
            this.btnCreateN.Name = "btnCreateN";
            this.btnCreateN.Size = new System.Drawing.Size(136, 23);
            this.btnCreateN.TabIndex = 15;
            this.btnCreateN.Text = "Nova narudžbenica";
            this.btnCreateN.UseVisualStyleBackColor = true;
            this.btnCreateN.Click += new System.EventHandler(this.btnCreateN_Click);
            // 
            // gbStavkeNar
            // 
            this.gbStavkeNar.Controls.Add(this.btnDelnS);
            this.gbStavkeNar.Controls.Add(this.dgvStavkeNarudzbenice);
            this.gbStavkeNar.Controls.Add(this.btnAddNS);
            this.gbStavkeNar.Location = new System.Drawing.Point(12, 181);
            this.gbStavkeNar.Name = "gbStavkeNar";
            this.gbStavkeNar.Size = new System.Drawing.Size(383, 176);
            this.gbStavkeNar.TabIndex = 14;
            this.gbStavkeNar.TabStop = false;
            // 
            // dgvStavkeNarudzbenice
            // 
            this.dgvStavkeNarudzbenice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeNarudzbenice.Location = new System.Drawing.Point(6, 19);
            this.dgvStavkeNarudzbenice.Name = "dgvStavkeNarudzbenice";
            this.dgvStavkeNarudzbenice.Size = new System.Drawing.Size(232, 150);
            this.dgvStavkeNarudzbenice.TabIndex = 1;
            // 
            // btnPotvrdiN
            // 
            this.btnPotvrdiN.Location = new System.Drawing.Point(259, 59);
            this.btnPotvrdiN.Name = "btnPotvrdiN";
            this.btnPotvrdiN.Size = new System.Drawing.Size(136, 23);
            this.btnPotvrdiN.TabIndex = 19;
            this.btnPotvrdiN.Text = "Potvrdi narudžbenicu";
            this.btnPotvrdiN.UseVisualStyleBackColor = true;
            this.btnPotvrdiN.Click += new System.EventHandler(this.btnPotvrdiN_Click);
            // 
            // btnDelnS
            // 
            this.btnDelnS.Location = new System.Drawing.Point(244, 145);
            this.btnDelnS.Name = "btnDelnS";
            this.btnDelnS.Size = new System.Drawing.Size(133, 23);
            this.btnDelnS.TabIndex = 21;
            this.btnDelnS.Text = "Obriši stavku";
            this.btnDelnS.UseVisualStyleBackColor = true;
            this.btnDelnS.Click += new System.EventHandler(this.btnDelnS_Click);
            // 
            // btnAddNS
            // 
            this.btnAddNS.Location = new System.Drawing.Point(244, 116);
            this.btnAddNS.Name = "btnAddNS";
            this.btnAddNS.Size = new System.Drawing.Size(133, 23);
            this.btnAddNS.TabIndex = 20;
            this.btnAddNS.Text = "Dodaj stavku";
            this.btnAddNS.UseVisualStyleBackColor = true;
            this.btnAddNS.Click += new System.EventHandler(this.btnAddNS_Click);
            // 
            // FormNarudzbenice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 368);
            this.Controls.Add(this.btnPotvrdiN);
            this.Controls.Add(this.dgvNarudzbenice);
            this.Controls.Add(this.labelZaposlenik);
            this.Controls.Add(this.btnDelN);
            this.Controls.Add(this.btnCreateN);
            this.Controls.Add(this.gbStavkeNar);
            this.Name = "FormNarudzbenice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Narudžbenice";
            this.Load += new System.EventHandler(this.FormNarudzbenice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbenice)).EndInit();
            this.gbStavkeNar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeNarudzbenice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNarudzbenice;
        private System.Windows.Forms.Label labelZaposlenik;
        private System.Windows.Forms.Button btnDelN;
        private System.Windows.Forms.Button btnCreateN;
        private System.Windows.Forms.GroupBox gbStavkeNar;
        private System.Windows.Forms.DataGridView dgvStavkeNarudzbenice;
        private System.Windows.Forms.Button btnPotvrdiN;
        private System.Windows.Forms.Button btnDelnS;
        private System.Windows.Forms.Button btnAddNS;
    }
}