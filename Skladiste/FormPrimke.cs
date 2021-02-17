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
    public partial class FormPrimke : Form
    {
        public FormPrimke()
        {
            InitializeComponent();
        }

        private void btnCreateP_Click(object sender, EventArgs e)
        {
            DateTime datumKreiranja = DateTime.Now;
            Zaposlenik kreiraoZaposlenik = Prijava.PrijavljenZaposlenik;

            using (var context = new skladistedbEntities())
            {
                Primka novaPrimka = new Primka();
                novaPrimka.DatumKreiranja = datumKreiranja;
                novaPrimka.Zaposlenik = kreiraoZaposlenik;

                context.Zaposlenik.Attach(kreiraoZaposlenik);
                context.Primka.Add(novaPrimka);
                context.SaveChanges();

                Osvjezi();
            }
        }

        private void FormPrimke_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void Osvjezi()
        {
            using (var context = new skladistedbEntities())
            {
                var query = from p in context.Primka
                            select p;
                dgvPrimke.DataSource = query.ToList();
                dgvPrimke.Columns["Zaposlenik"].Visible = false;
                dgvPrimke.Columns["ZaposlenikId"].Visible = false;
                dgvPrimke.Columns["StavkaPrimke"].Visible = false;
            }
        }

        private void btnDelP_Click(object sender, EventArgs e)
        {
            try
            {
                Primka primka = SelektiranaPrimka();
                using (var context = new skladistedbEntities())
                {
                    context.Primka.Attach(primka);
                    context.Primka.Remove(primka);
                    context.SaveChanges();
                    Osvjezi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska kod brisanja, postoje stavke!");
            }
        }

        private void dgvPrimke_SelectionChanged(object sender, EventArgs e)
        {
            Primka primka = SelektiranaPrimka();
            PopuniPodatke(primka);
        }

        private void PopuniPodatke(Primka primka)
        {
            gbStavkePrim.Text = "Stavke primke pod šifrom: " + primka.PrimkaId.ToString();
            using (var context = new skladistedbEntities())
            {
                var query = from sp in context.StavkaPrimke
                            where sp.PrimkaId == primka.PrimkaId
                            select sp;

                dgvStavkePrimke.DataSource = query.ToList();
                dgvStavkePrimke.Columns["PrimkaId"].Visible = false;
                dgvStavkePrimke.Columns["Oprema"].Visible = false;
                dgvStavkePrimke.Columns["Primka"].Visible = false;


                var queryZ = from z in context.Zaposlenik
                             where z.ZaposlenikId == primka.ZaposlenikId
                             select z;

                Zaposlenik zap = queryZ.SingleOrDefault();
                if (zap != null)
                {
                    labelZaposlenik.Text = "Dokument kreirao: \n\n";
                    labelZaposlenik.Text += zap.Ime + " " + zap.Prezime;
                }
            }
        }

        private Primka SelektiranaPrimka()
        {
            return dgvPrimke.CurrentRow.DataBoundItem as Primka;
        }

        private void btnDelPS_Click(object sender, EventArgs e)
        {
            try
            {
                Primka primka = SelektiranaPrimka();
                StavkaPrimke stavkaPrimke = SelektiranaStavkaPrimke();

                using (var context = new skladistedbEntities())
                {
                    context.StavkaPrimke.Attach(stavkaPrimke);
                    context.StavkaPrimke.Remove(stavkaPrimke);
                    context.SaveChanges();
                }

                PopuniPodatke(primka);
            } catch (Exception ex)
            {
                if(ex.InnerException.InnerException != null)
                {
                    MessageBox.Show(ex.InnerException.InnerException.Message);
                }
            }
            
        }

        private StavkaPrimke SelektiranaStavkaPrimke()
        {
            return dgvStavkePrimke.CurrentRow.DataBoundItem as StavkaPrimke;
        }

        private void btnAddPS_Click(object sender, EventArgs e)
        {
            Primka primka = SelektiranaPrimka();
            FormNovaStavkaPrimka formNovaStavkaPrimka = new FormNovaStavkaPrimka(primka);
            formNovaStavkaPrimka.ShowDialog();
        }
    }
}
