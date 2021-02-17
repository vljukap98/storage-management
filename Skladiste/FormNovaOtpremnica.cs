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
    public partial class FormNovaOtpremnica : Form
    {
        public FormNovaOtpremnica()
        {
            InitializeComponent();
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            string adresaDostave = txtAdresa.Text;
            Zaposlenik zaposlenik = cmbZaposlenici.SelectedItem as Zaposlenik;
            DateTime datumKreiranja = DateTime.Now;

            using (var context = new skladistedbEntities())
            {
                Otpremnica novaOtpremnica = new Otpremnica();
                

                context.Zaposlenik.Attach(zaposlenik); //ako ne "attachamo" inserta se novi zapis s istim podacima

                novaOtpremnica.AdresaDostave = adresaDostave;
                novaOtpremnica.DatumKreiranja = datumKreiranja;
                novaOtpremnica.Zaposlenik = zaposlenik;

                context.Otpremnica.Add(novaOtpremnica);

                context.SaveChanges();
            }
            this.Close();
        }

        private void FormNovaOtpremnica_Load(object sender, EventArgs e)
        {
            PopuniPodatke();
        }

        private void PopuniPodatke()
        {
            using (var context = new skladistedbEntities())
            {
                var query = from z in context.Zaposlenik
                            where z.DatumZavrsetka == null
                            select z;
                cmbZaposlenici.DataSource = query.ToList();
            }
        }
    }
}
