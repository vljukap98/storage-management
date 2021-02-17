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
    public partial class FormOtpremnice : Form
    {
        public FormOtpremnice()
        {
            InitializeComponent();
        }

        private void FormOtpremnice_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void Osvjezi()
        {
            using(var context = new skladistedbEntities())
            {
                var query = from o in context.Otpremnica
                            select o;
                dgvOtpremnice.DataSource = query.ToList();
                dgvOtpremnice.Columns["Zaposlenik"].Visible = false;
                dgvOtpremnice.Columns["ZaposlenikId"].Visible = false;
                dgvOtpremnice.Columns["StavkaOtpremnice"].Visible = false;
            }
        }

        private void dgvOtpremnice_SelectionChanged(object sender, EventArgs e)
        {
            Otpremnica otpremnica = SelektiranaOtpremnica();
            PopuniPodatke(otpremnica);
        }

        private void PopuniPodatke(Otpremnica otpremnica)
        {
            gbStavkeOtp.Text = "Stavke otpremnice pod šifrom: " + otpremnica.OtpremnicaId.ToString();
            using(var context = new skladistedbEntities())
            {
                var query = from so in context.StavkaOtpremnice
                            where so.OtpremnicaId == otpremnica.OtpremnicaId
                            select so;

                dgvStavkeOtpremnice.DataSource = query.ToList();
                dgvStavkeOtpremnice.Columns["OtpremnicaId"].Visible = false;
                dgvStavkeOtpremnice.Columns["Oprema"].Visible = false;
                dgvStavkeOtpremnice.Columns["Otpremnica"].Visible = false;


                var queryZ = from z in context.Zaposlenik
                            where z.ZaposlenikId == otpremnica.ZaposlenikId
                            select z;

                Zaposlenik zap = queryZ.SingleOrDefault();
                if(zap != null)
                {
                    labelZaposlenik.Text = "Dokument kreirao: \n\n";
                    labelZaposlenik.Text += zap.Ime + " " + zap.Prezime;
                }
            }
        }

        private Otpremnica SelektiranaOtpremnica()
        {
            return dgvOtpremnice.CurrentRow.DataBoundItem as Otpremnica;
        }

        private void btnDelO_Click(object sender, EventArgs e)
        {
            try
            {
                Otpremnica otpremnica = SelektiranaOtpremnica();
                using (var context = new skladistedbEntities())
                {
                    context.Otpremnica.Attach(otpremnica);
                    context.Otpremnica.Remove(otpremnica);
                    context.SaveChanges();
                    Osvjezi();
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Greska kod brisanja, postoje stavke!");
            }
        }

        private void btnCreateO_Click(object sender, EventArgs e)
        {
            FormNovaOtpremnica formNovaOtpremnica = new FormNovaOtpremnica();
            formNovaOtpremnica.ShowDialog();

            Osvjezi();
        }

        private void btnUpdO_Click(object sender, EventArgs e)
        {
            Otpremnica otpremnica = SelektiranaOtpremnica();
            FormPromijeniOtpremnica formPromijeniOtpremnica = new FormPromijeniOtpremnica(otpremnica);
            formPromijeniOtpremnica.ShowDialog();

            Osvjezi();
        }

        private void btnAddOS_Click(object sender, EventArgs e)
        {
            Otpremnica otpremnica = SelektiranaOtpremnica();
            FormNovaStavkaOtpremnice formNovaStavkaOtpremnice = new FormNovaStavkaOtpremnice(otpremnica);
            formNovaStavkaOtpremnice.ShowDialog();

            PopuniPodatke(otpremnica);
        }

        private void btnDelOS_Click(object sender, EventArgs e)
        {
            try
            {
                Otpremnica otpremnica = SelektiranaOtpremnica();
                StavkaOtpremnice stavkaOtpremnice = SelektiranaStavkaOtpremnice();
                using (var context = new skladistedbEntities())
                {
                    context.StavkaOtpremnice.Attach(stavkaOtpremnice);
                    context.StavkaOtpremnice.Remove(stavkaOtpremnice);
                    context.SaveChanges();
                }

                PopuniPodatke(otpremnica);
            } catch (Exception ex)
            {
                if(ex.InnerException.InnerException != null)
                {
                    MessageBox.Show(ex.InnerException.InnerException.Message);
                }
            }
        }

        private StavkaOtpremnice SelektiranaStavkaOtpremnice()
        {
            return dgvStavkeOtpremnice.CurrentRow.DataBoundItem as StavkaOtpremnice;
        }

        private void dgvStavkeOtpremnice_SelectionChanged(object sender, EventArgs e)
        {
            StavkaOtpremnice stavkaOtpremnice = SelektiranaStavkaOtpremnice();

            using (var context = new skladistedbEntities())
            {
                var query = from o in context.Oprema
                            where o.OpremaId == stavkaOtpremnice.OpremaId
                            select o;

                Oprema opremaUStavki = query.SingleOrDefault();

                if(opremaUStavki != null)
                {
                    labelNazivOpreme.Text = opremaUStavki.Naziv;
                    labelMinOprema.Text = opremaUStavki.MinKol.ToString();
                    labelMaxOprema.Text = opremaUStavki.MaxKol.ToString();
                    labelTrenutnaKolOprema.Text = opremaUStavki.Kol.ToString();
                }
            }
        }
    }
}
