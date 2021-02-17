
namespace Skladiste
{
    partial class FormStatistikaOtp
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
            this.dgvStatistikaOtp = new System.Windows.Forms.DataGridView();
            this.cmbOprema = new System.Windows.Forms.ComboBox();
            this.dtpDo = new System.Windows.Forms.DateTimePicker();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.btnPretrazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistikaOtp)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStatistikaOtp
            // 
            this.dgvStatistikaOtp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistikaOtp.Location = new System.Drawing.Point(12, 36);
            this.dgvStatistikaOtp.Name = "dgvStatistikaOtp";
            this.dgvStatistikaOtp.Size = new System.Drawing.Size(624, 211);
            this.dgvStatistikaOtp.TabIndex = 7;
            // 
            // cmbOprema
            // 
            this.cmbOprema.FormattingEnabled = true;
            this.cmbOprema.Location = new System.Drawing.Point(425, 10);
            this.cmbOprema.Name = "cmbOprema";
            this.cmbOprema.Size = new System.Drawing.Size(123, 21);
            this.cmbOprema.TabIndex = 6;
            // 
            // dtpDo
            // 
            this.dtpDo.Location = new System.Drawing.Point(218, 10);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.Size = new System.Drawing.Size(200, 20);
            this.dtpDo.TabIndex = 5;
            // 
            // dtpOd
            // 
            this.dtpOd.Location = new System.Drawing.Point(12, 10);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(200, 20);
            this.dtpOd.TabIndex = 4;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(555, 10);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(81, 23);
            this.btnPretrazi.TabIndex = 8;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // FormStatistikaOtp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 258);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.dgvStatistikaOtp);
            this.Controls.Add(this.cmbOprema);
            this.Controls.Add(this.dtpDo);
            this.Controls.Add(this.dtpOd);
            this.Name = "FormStatistikaOtp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistika otpremljene robe";
            this.Load += new System.EventHandler(this.FormStatistikaOtp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistikaOtp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStatistikaOtp;
        private System.Windows.Forms.ComboBox cmbOprema;
        private System.Windows.Forms.DateTimePicker dtpDo;
        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.Button btnPretrazi;
    }
}