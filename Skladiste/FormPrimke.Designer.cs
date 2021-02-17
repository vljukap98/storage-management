
namespace Skladiste
{
    partial class FormPrimke
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
            this.dgvPrimke = new System.Windows.Forms.DataGridView();
            this.dgvStavkePrimke = new System.Windows.Forms.DataGridView();
            this.labelZaposlenik = new System.Windows.Forms.Label();
            this.btnDelP = new System.Windows.Forms.Button();
            this.btnCreateP = new System.Windows.Forms.Button();
            this.gbStavkePrim = new System.Windows.Forms.GroupBox();
            this.btnDelPS = new System.Windows.Forms.Button();
            this.btnAddPS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkePrimke)).BeginInit();
            this.gbStavkePrim.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPrimke
            // 
            this.dgvPrimke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrimke.Location = new System.Drawing.Point(12, 12);
            this.dgvPrimke.Name = "dgvPrimke";
            this.dgvPrimke.Size = new System.Drawing.Size(238, 150);
            this.dgvPrimke.TabIndex = 7;
            this.dgvPrimke.SelectionChanged += new System.EventHandler(this.dgvPrimke_SelectionChanged);
            // 
            // dgvStavkePrimke
            // 
            this.dgvStavkePrimke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkePrimke.Location = new System.Drawing.Point(6, 19);
            this.dgvStavkePrimke.Name = "dgvStavkePrimke";
            this.dgvStavkePrimke.Size = new System.Drawing.Size(232, 150);
            this.dgvStavkePrimke.TabIndex = 1;
            // 
            // labelZaposlenik
            // 
            this.labelZaposlenik.AutoSize = true;
            this.labelZaposlenik.Location = new System.Drawing.Point(256, 12);
            this.labelZaposlenik.Name = "labelZaposlenik";
            this.labelZaposlenik.Size = new System.Drawing.Size(0, 13);
            this.labelZaposlenik.TabIndex = 12;
            // 
            // btnDelP
            // 
            this.btnDelP.Location = new System.Drawing.Point(259, 138);
            this.btnDelP.Name = "btnDelP";
            this.btnDelP.Size = new System.Drawing.Size(136, 23);
            this.btnDelP.TabIndex = 11;
            this.btnDelP.Text = "Obriši dokument";
            this.btnDelP.UseVisualStyleBackColor = true;
            this.btnDelP.Click += new System.EventHandler(this.btnDelP_Click);
            // 
            // btnCreateP
            // 
            this.btnCreateP.Location = new System.Drawing.Point(259, 109);
            this.btnCreateP.Name = "btnCreateP";
            this.btnCreateP.Size = new System.Drawing.Size(136, 23);
            this.btnCreateP.TabIndex = 9;
            this.btnCreateP.Text = "Nova primka";
            this.btnCreateP.UseVisualStyleBackColor = true;
            this.btnCreateP.Click += new System.EventHandler(this.btnCreateP_Click);
            // 
            // gbStavkePrim
            // 
            this.gbStavkePrim.Controls.Add(this.btnDelPS);
            this.gbStavkePrim.Controls.Add(this.btnAddPS);
            this.gbStavkePrim.Controls.Add(this.dgvStavkePrimke);
            this.gbStavkePrim.Location = new System.Drawing.Point(12, 181);
            this.gbStavkePrim.Name = "gbStavkePrim";
            this.gbStavkePrim.Size = new System.Drawing.Size(383, 176);
            this.gbStavkePrim.TabIndex = 8;
            this.gbStavkePrim.TabStop = false;
            // 
            // btnDelPS
            // 
            this.btnDelPS.Location = new System.Drawing.Point(244, 146);
            this.btnDelPS.Name = "btnDelPS";
            this.btnDelPS.Size = new System.Drawing.Size(133, 23);
            this.btnDelPS.TabIndex = 14;
            this.btnDelPS.Text = "Obriši stavku";
            this.btnDelPS.UseVisualStyleBackColor = true;
            this.btnDelPS.Click += new System.EventHandler(this.btnDelPS_Click);
            // 
            // btnAddPS
            // 
            this.btnAddPS.Location = new System.Drawing.Point(244, 117);
            this.btnAddPS.Name = "btnAddPS";
            this.btnAddPS.Size = new System.Drawing.Size(133, 23);
            this.btnAddPS.TabIndex = 13;
            this.btnAddPS.Text = "Dodaj stavku";
            this.btnAddPS.UseVisualStyleBackColor = true;
            this.btnAddPS.Click += new System.EventHandler(this.btnAddPS_Click);
            // 
            // FormPrimke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 368);
            this.Controls.Add(this.dgvPrimke);
            this.Controls.Add(this.labelZaposlenik);
            this.Controls.Add(this.btnDelP);
            this.Controls.Add(this.btnCreateP);
            this.Controls.Add(this.gbStavkePrim);
            this.Name = "FormPrimke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Primke";
            this.Load += new System.EventHandler(this.FormPrimke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkePrimke)).EndInit();
            this.gbStavkePrim.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrimke;
        private System.Windows.Forms.DataGridView dgvStavkePrimke;
        private System.Windows.Forms.Label labelZaposlenik;
        private System.Windows.Forms.Button btnDelP;
        private System.Windows.Forms.Button btnCreateP;
        private System.Windows.Forms.GroupBox gbStavkePrim;
        private System.Windows.Forms.Button btnDelPS;
        private System.Windows.Forms.Button btnAddPS;
    }
}