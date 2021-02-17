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
    public partial class FormNarudzbenice : Form
    {
        public FormNarudzbenice()
        {
            InitializeComponent();
        }

        private void FormNarudzbenice_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void Osvjezi()
        {
            using (var context = new skladistedbEntities())
            {
                var query = from n in context.Narudzbenica
                            select n;
                dgvNarudzbenice.DataSource = query.ToList();
                dgvNarudzbenice.Columns["Zaposlenik"].Visible = false;
                dgvNarudzbenice.Columns["ZaposlenikId"].Visible = false;
                dgvNarudzbenice.Columns["StavkaNarudzbenice"].Visible = false;
            }
        }

        private void dgvNarudzbenice_SelectionChanged(object sender, EventArgs e)
        {
            Narudzbenica narudzbenica = SelektiranaNarudzbenica();
            PopuniPodatke(narudzbenica);
        }

        private void PopuniPodatke(Narudzbenica narudzbenica)
        {
            gbStavkeNar.Text = "Stavke narudžbenice pod šifrom: " + narudzbenica.NarudzbenicaId.ToString();
            using (var context = new skladistedbEntities())
            {
                var query = from sn in context.StavkaNarudzbenice
                            where sn.NarudzbenicaId == narudzbenica.NarudzbenicaId
                            select sn;

                dgvStavkeNarudzbenice.DataSource = query.ToList();
                dgvStavkeNarudzbenice.Columns["NarudzbenicaId"].Visible = false;
                dgvStavkeNarudzbenice.Columns["Oprema"].Visible = false;
                dgvStavkeNarudzbenice.Columns["Narudzbenica"].Visible = false;


                var queryZ = from z in context.Zaposlenik
                             where z.ZaposlenikId == narudzbenica.ZaposlenikId
                             select z;

                Zaposlenik zap = queryZ.SingleOrDefault();
                if (zap != null)
                {
                    labelZaposlenik.Text = "Dokument kreirao/potvrdio: \n\n";
                    labelZaposlenik.Text += zap.Ime + " " + zap.Prezime;
                }
            }
        }

        private Narudzbenica SelektiranaNarudzbenica()
        {
            return dgvNarudzbenice.CurrentRow.DataBoundItem as Narudzbenica;
        }

        private void btnDelN_Click(object sender, EventArgs e)
        {
            try
            {
                Narudzbenica narudzbenica = SelektiranaNarudzbenica();
                using (var context = new skladistedbEntities())
                {
                    context.Narudzbenica.Attach(narudzbenica);
                    context.Narudzbenica.Remove(narudzbenica);
                    context.SaveChanges();
                    Osvjezi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska kod brisanja, postoje stavke!");
            }
        }

        private void btnCreateN_Click(object sender, EventArgs e)
        {
            DateTime datumKreiranja = DateTime.Now;
            Zaposlenik kreiraoZaposlenik = Prijava.PrijavljenZaposlenik;

            using (var context = new skladistedbEntities())
            {
                Narudzbenica novaNarudzbenica = new Narudzbenica();
                novaNarudzbenica.DatumKreiranja = datumKreiranja;
                novaNarudzbenica.Zaposlenik = kreiraoZaposlenik;

                context.Zaposlenik.Attach(kreiraoZaposlenik);
                context.Narudzbenica.Add(novaNarudzbenica);
                context.SaveChanges();

                Osvjezi();
            }
        }

        private void btnPotvrdiN_Click(object sender, EventArgs e)
        {
            Narudzbenica narudzbenica = SelektiranaNarudzbenica();

            using (var context = new skladistedbEntities())
            {
                var query = from z in context.Zaposlenik
                            where z.ZaposlenikId == Prijava.PrijavljenZaposlenik.ZaposlenikId
                            select z;

                Zaposlenik zaposlenik = query.SingleOrDefault();

                context.Zaposlenik.Attach(zaposlenik);
                context.Narudzbenica.Attach(narudzbenica);

                narudzbenica.Zaposlenik = zaposlenik;
                
                context.SaveChanges();
            }
        }

        private void btnDelnS_Click(object sender, EventArgs e)
        {
            Narudzbenica narudzbenica = SelektiranaNarudzbenica();
            StavkaNarudzbenice stavkaNarudzbenice = SelektiranaStavkaNarudzbenice();

            using (var context = new skladistedbEntities())
            {
                context.StavkaNarudzbenice.Attach(stavkaNarudzbenice);
                context.StavkaNarudzbenice.Remove(stavkaNarudzbenice);
                context.SaveChanges();
            }

            PopuniPodatke(narudzbenica);
        }

        private void btnAddNS_Click(object sender, EventArgs e)
        {
            Narudzbenica narudzbenica = SelektiranaNarudzbenica();
            FormNovaStavkaNarudzbenice formNovaStavkaNarudzbenice = new FormNovaStavkaNarudzbenice(narudzbenica);
            formNovaStavkaNarudzbenice.ShowDialog();

            PopuniPodatke(narudzbenica);
        }

        private StavkaNarudzbenice SelektiranaStavkaNarudzbenice()
        {
            return dgvStavkeNarudzbenice.CurrentRow.DataBoundItem as StavkaNarudzbenice;
        }
    }
}
