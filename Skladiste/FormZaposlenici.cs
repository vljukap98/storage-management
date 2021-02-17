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
    public partial class FormZaposlenici : Form
    {
        public FormZaposlenici()
        {
            InitializeComponent();
        }

        private void FormZaposlenici_Load(object sender, EventArgs e)
        {
            Osvjezi();
            ProvjeriPrijavljenog();
        }

        private void ProvjeriPrijavljenog()
        {
            if(Prijava.PrijavljenZaposlenik.ZaposlenikId != 13)
            {
                groupBox1.Enabled = false;
            }
        }

        private void Osvjezi()
        {
            using (var context = new skladistedbEntities())
            {
                var query = from z in context.Zaposlenik
                            select z;
                dgvZaposlenici.DataSource = query.ToList();
                dgvZaposlenici.Columns["ZaposlenikId"].Visible = false;
                dgvZaposlenici.Columns["Narudzbenica"].Visible = false;
                dgvZaposlenici.Columns["Primka"].Visible = false;
                dgvZaposlenici.Columns["Otpremnica"].Visible = false;

                if(Prijava.PrijavljenZaposlenik.KorIme != "ljakovic")
                {
                    dgvZaposlenici.Columns["Lozinka"].Visible = false;

                }
            }
        }

        private void btnDeleteZ_Click(object sender, EventArgs e)
        {
            Zaposlenik zaposlenik = SelektiraniZaposlenik();
            using (var context = new skladistedbEntities())
            {
                context.Zaposlenik.Attach(zaposlenik);
                context.Zaposlenik.Remove(zaposlenik);
                context.SaveChanges();
            }
            Osvjezi();
        }

        private Zaposlenik SelektiraniZaposlenik()
        {
            return dgvZaposlenici.CurrentRow.DataBoundItem as Zaposlenik;
        }

        private void dgvZaposlenici_SelectionChanged(object sender, EventArgs e)
        {

            Zaposlenik zaposlenik = SelektiraniZaposlenik();
            if (zaposlenik.DatumZavrsetka == null 
                && Prijava.PrijavljenZaposlenik.ZaposlenikId == 13
                && zaposlenik.ZaposlenikId != Prijava.PrijavljenZaposlenik.ZaposlenikId)
            {
                btnDeleteZ.Enabled = true;
            }
            else
            {
                btnDeleteZ.Enabled = false;
            }
        }

        private void btnNoviZ_Click(object sender, EventArgs e)
        {
            try
            {
                string ime = txtIme.Text;
                string prezime = txtPrezime.Text;
                string korIme = txtKorIme.Text;
                string lozinka = txtLozinka.Text;

                if(!CheckEmptyInput(ime, prezime, korIme, lozinka))
                {
                    using (var context = new skladistedbEntities())
                    {
                        Zaposlenik noviZaposlenik = new Zaposlenik();
                        noviZaposlenik.Ime = ime;
                        noviZaposlenik.Prezime = prezime;
                        noviZaposlenik.KorIme = korIme;
                        noviZaposlenik.Lozinka = lozinka;

                        context.Zaposlenik.Add(noviZaposlenik);
                        context.SaveChanges();
                        Osvjezi();
                    }
                } else
                {
                    MessageBox.Show("Sva polja moraju biti popunjena!");

                }
            } catch (Exception ex)
            {
                MessageBox.Show("Dogodila se greska!");
            }
        }

        private bool CheckEmptyInput(string ime, string prezime, string korIme, string lozinka)
        {
            bool emptyInput = false;

            if (ime == "" || prezime == "" || korIme == "" || lozinka == "") { 
                emptyInput = true;
            }

            return emptyInput;
        }
    }
}
