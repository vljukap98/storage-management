using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Skladiste
{
    public partial class FormPromijeniOtpremnica : Form
    {
        private Otpremnica otpremnica;
        public FormPromijeniOtpremnica(Otpremnica otpremnica)
        {
            InitializeComponent();

            this.otpremnica = otpremnica;
        }

        private void FormPromijeniOtpremnica_Load(object sender, EventArgs e)
        {
            PopuniPodatke();
        }

        private void PopuniPodatke()
        {
            DohvatiZaposlenike();

            txtAdresa.Text = otpremnica.AdresaDostave;
        }

        private void DohvatiZaposlenike()
        {
            using (var context = new skladistedbEntities())
            {
                var query = from z in context.Zaposlenik
                            where z.DatumZavrsetka == null
                            select z;
                cmbZaposlenici.DataSource = query.ToList();

                for(int i = 0; i < cmbZaposlenici.Items.Count; i++)
                {
                    if((cmbZaposlenici.Items[i] as Zaposlenik).ZaposlenikId == otpremnica.ZaposlenikId)
                    {
                        cmbZaposlenici.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private void bntPromijeni_Click(object sender, EventArgs e)
        {
            string adresaDostave = txtAdresa.Text;
            Zaposlenik zaposlenik = cmbZaposlenici.SelectedItem as Zaposlenik;

            using (var context = new skladistedbEntities())
            {
                context.Zaposlenik.Attach(zaposlenik);

                var query = from o in context.Otpremnica
                            where o.OtpremnicaId == otpremnica.OtpremnicaId
                            select o;

                Otpremnica otp = query.SingleOrDefault();

                otp.AdresaDostave = adresaDostave;
                otp.Zaposlenik = zaposlenik;

                context.SaveChanges();
            }
            this.Close();
        }
    }
}
