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
    public partial class FormMeni : Form
    {
        public FormMeni()
        {
            InitializeComponent();
            this.CancelButton = btnOdjava;
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            Prijava.Odjava();
            this.Close();
        }

        private void btnZaposlenici_Click(object sender, EventArgs e)
        {
            FormZaposlenici formZaposlenici = new FormZaposlenici();
            formZaposlenici.ShowDialog();
        }

        private void btnOtpremnice_Click(object sender, EventArgs e)
        {
            FormOtpremnice formOtpremnice = new FormOtpremnice();
            formOtpremnice.ShowDialog();
        }

        private void btnPrimke_Click(object sender, EventArgs e)
        {
            FormPrimke formPrimke = new FormPrimke();
            formPrimke.ShowDialog();
        }

        private void btnNarudzbenice_Click(object sender, EventArgs e)
        {
            FormNarudzbenice formNarudzbenice = new FormNarudzbenice();
            formNarudzbenice.ShowDialog();
        }

        private void btnOprema_Click(object sender, EventArgs e)
        {
            //TODO funkcionalnost opreme i statistika pod mozda
            FormOprema formOprema = new FormOprema();
            formOprema.ShowDialog();
        }

        private void FormMeni_FormClosing(object sender, FormClosingEventArgs e)
        {
            Prijava.Odjava();
        }

        private void btnStatistikaOtp_Click(object sender, EventArgs e)
        {
            FormStatistikaOtp formStatistikaOtp = new FormStatistikaOtp();
            formStatistikaOtp.ShowDialog();
        }

        private void btnStatistikaZap_Click(object sender, EventArgs e)
        {
            FormStatistikaZap formStatistikaZap = new FormStatistikaZap();
            formStatistikaZap.ShowDialog();
        }
    }
}
