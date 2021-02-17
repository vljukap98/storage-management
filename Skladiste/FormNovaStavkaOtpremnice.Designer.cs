
namespace Skladiste
{
    partial class FormNovaStavkaOtpremnice
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
            this.cmbOprema = new System.Windows.Forms.ComboBox();
            this.txtKol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNovaStavkaO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbOprema
            // 
            this.cmbOprema.FormattingEnabled = true;
            this.cmbOprema.Location = new System.Drawing.Point(12, 25);
            this.cmbOprema.Name = "cmbOprema";
            this.cmbOprema.Size = new System.Drawing.Size(193, 21);
            this.cmbOprema.TabIndex = 0;
            // 
            // txtKol
            // 
            this.txtKol.Location = new System.Drawing.Point(12, 65);
            this.txtKol.Name = "txtKol";
            this.txtKol.Size = new System.Drawing.Size(193, 20);
            this.txtKol.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Oprema";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Količina";
            // 
            // btnNovaStavkaO
            // 
            this.btnNovaStavkaO.Location = new System.Drawing.Point(63, 91);
            this.btnNovaStavkaO.Name = "btnNovaStavkaO";
            this.btnNovaStavkaO.Size = new System.Drawing.Size(92, 23);
            this.btnNovaStavkaO.TabIndex = 4;
            this.btnNovaStavkaO.Text = "Dodaj stavku";
            this.btnNovaStavkaO.UseVisualStyleBackColor = true;
            this.btnNovaStavkaO.Click += new System.EventHandler(this.btnNovaStavkaO_Click);
            // 
            // FormNovaStavkaOtpremnice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 128);
            this.Controls.Add(this.btnNovaStavkaO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKol);
            this.Controls.Add(this.cmbOprema);
            this.Name = "FormNovaStavkaOtpremnice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova stavka otpremnice";
            this.Load += new System.EventHandler(this.FormNovaStavkaOtpremnice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOprema;
        private System.Windows.Forms.TextBox txtKol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNovaStavkaO;
    }
}