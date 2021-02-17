
namespace Skladiste
{
    partial class FormOprema
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
            this.dgvOprema = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbVrstaOpr = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaxKol = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMinKol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJedCijena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.btnAddOp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOprema)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOprema
            // 
            this.dgvOprema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOprema.Location = new System.Drawing.Point(12, 12);
            this.dgvOprema.Name = "dgvOprema";
            this.dgvOprema.Size = new System.Drawing.Size(630, 252);
            this.dgvOprema.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbVrstaOpr);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaxKol);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMinKol);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtJedCijena);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNaziv);
            this.groupBox1.Controls.Add(this.btnAddOp);
            this.groupBox1.Location = new System.Drawing.Point(648, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 252);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nova oprema:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Vrsta opreme";
            // 
            // cmbVrstaOpr
            // 
            this.cmbVrstaOpr.FormattingEnabled = true;
            this.cmbVrstaOpr.Location = new System.Drawing.Point(6, 123);
            this.cmbVrstaOpr.Name = "cmbVrstaOpr";
            this.cmbVrstaOpr.Size = new System.Drawing.Size(228, 21);
            this.cmbVrstaOpr.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Maksimalna količina";
            // 
            // txtMaxKol
            // 
            this.txtMaxKol.Location = new System.Drawing.Point(134, 75);
            this.txtMaxKol.Name = "txtMaxKol";
            this.txtMaxKol.Size = new System.Drawing.Size(100, 20);
            this.txtMaxKol.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Minimalna količina";
            // 
            // txtMinKol
            // 
            this.txtMinKol.Location = new System.Drawing.Point(6, 75);
            this.txtMinKol.Name = "txtMinKol";
            this.txtMinKol.Size = new System.Drawing.Size(100, 20);
            this.txtMinKol.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Jedinična cijena";
            // 
            // txtJedCijena
            // 
            this.txtJedCijena.Location = new System.Drawing.Point(134, 32);
            this.txtJedCijena.Name = "txtJedCijena";
            this.txtJedCijena.Size = new System.Drawing.Size(100, 20);
            this.txtJedCijena.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(6, 32);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(100, 20);
            this.txtNaziv.TabIndex = 4;
            // 
            // btnAddOp
            // 
            this.btnAddOp.Location = new System.Drawing.Point(6, 223);
            this.btnAddOp.Name = "btnAddOp";
            this.btnAddOp.Size = new System.Drawing.Size(228, 23);
            this.btnAddOp.TabIndex = 3;
            this.btnAddOp.Text = "Nova oprema";
            this.btnAddOp.UseVisualStyleBackColor = true;
            this.btnAddOp.Click += new System.EventHandler(this.btnAddOp_Click);
            // 
            // FormOprema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 276);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvOprema);
            this.Name = "FormOprema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oprema";
            this.Load += new System.EventHandler(this.FormOprema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOprema)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOprema;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddOp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJedCijena;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbVrstaOpr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaxKol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMinKol;
    }
}