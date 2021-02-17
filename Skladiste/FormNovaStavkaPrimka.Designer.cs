
namespace Skladiste
{
    partial class FormNovaStavkaPrimka
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
            this.btnNovaStavkaP = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKol = new System.Windows.Forms.TextBox();
            this.cmbOprema = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnNovaStavkaP
            // 
            this.btnNovaStavkaP.Location = new System.Drawing.Point(63, 90);
            this.btnNovaStavkaP.Name = "btnNovaStavkaP";
            this.btnNovaStavkaP.Size = new System.Drawing.Size(92, 23);
            this.btnNovaStavkaP.TabIndex = 9;
            this.btnNovaStavkaP.Text = "Dodaj stavku";
            this.btnNovaStavkaP.UseVisualStyleBackColor = true;
            this.btnNovaStavkaP.Click += new System.EventHandler(this.btnNovaStavkaP_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Količina";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Oprema";
            // 
            // txtKol
            // 
            this.txtKol.Location = new System.Drawing.Point(12, 64);
            this.txtKol.Name = "txtKol";
            this.txtKol.Size = new System.Drawing.Size(193, 20);
            this.txtKol.TabIndex = 6;
            // 
            // cmbOprema
            // 
            this.cmbOprema.FormattingEnabled = true;
            this.cmbOprema.Location = new System.Drawing.Point(12, 24);
            this.cmbOprema.Name = "cmbOprema";
            this.cmbOprema.Size = new System.Drawing.Size(193, 21);
            this.cmbOprema.TabIndex = 5;
            // 
            // FormNovaStavkaPrimka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 119);
            this.Controls.Add(this.btnNovaStavkaP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKol);
            this.Controls.Add(this.cmbOprema);
            this.Name = "FormNovaStavkaPrimka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova stavka primke";
            this.Load += new System.EventHandler(this.FormNovaStavkaPrimka_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovaStavkaP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKol;
        private System.Windows.Forms.ComboBox cmbOprema;
    }
}