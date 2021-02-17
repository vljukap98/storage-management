
namespace Skladiste
{
    partial class FormStatistikaZap
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
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.dgvStatistikaZap = new System.Windows.Forms.DataGridView();
            this.cmbOprema = new System.Windows.Forms.ComboBox();
            this.dtpDo = new System.Windows.Forms.DateTimePicker();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistikaZap)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(555, 12);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(81, 23);
            this.btnPretrazi.TabIndex = 13;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // dgvStatistikaZap
            // 
            this.dgvStatistikaZap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistikaZap.Location = new System.Drawing.Point(12, 38);
            this.dgvStatistikaZap.Name = "dgvStatistikaZap";
            this.dgvStatistikaZap.Size = new System.Drawing.Size(624, 211);
            this.dgvStatistikaZap.TabIndex = 12;
            // 
            // cmbOprema
            // 
            this.cmbOprema.FormattingEnabled = true;
            this.cmbOprema.Location = new System.Drawing.Point(425, 12);
            this.cmbOprema.Name = "cmbOprema";
            this.cmbOprema.Size = new System.Drawing.Size(123, 21);
            this.cmbOprema.TabIndex = 11;
            // 
            // dtpDo
            // 
            this.dtpDo.Location = new System.Drawing.Point(218, 12);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.Size = new System.Drawing.Size(200, 20);
            this.dtpDo.TabIndex = 10;
            // 
            // dtpOd
            // 
            this.dtpOd.Location = new System.Drawing.Point(12, 12);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(200, 20);
            this.dtpOd.TabIndex = 9;
            // 
            // FormStatistikaZap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 261);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.dgvStatistikaZap);
            this.Controls.Add(this.cmbOprema);
            this.Controls.Add(this.dtpDo);
            this.Controls.Add(this.dtpOd);
            this.Name = "FormStatistikaZap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistika zaprimljene robe";
            this.Load += new System.EventHandler(this.FormStatistikaZap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistikaZap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.DataGridView dgvStatistikaZap;
        private System.Windows.Forms.ComboBox cmbOprema;
        private System.Windows.Forms.DateTimePicker dtpDo;
        private System.Windows.Forms.DateTimePicker dtpOd;
    }
}