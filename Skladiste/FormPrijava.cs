using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skladiste
{
    public partial class FormPrijava : Form
    {
        public FormPrijava()
        {
            InitializeComponent();
            this.AcceptButton = btnPrijava;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            string korIme = txtKorIme.Text;
            string lozinka = txtLoz.Text;

            Prijava.PrijaviSe(korIme, lozinka);
            if (Prijava.PrijavljenZaposlenik != null)
            {
                FormMeni formMeni = new FormMeni();
                formMeni.ShowDialog();
                txtKorIme.Text = "";
                txtLoz.Text = "";
                this.ActiveControl = txtKorIme;
            }
            else
            {
                MessageBox.Show("Pogrešni podaci ili zaposlenik \nviše ne radi!");
            }
        }
    }
}
