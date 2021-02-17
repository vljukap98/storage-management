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
    public partial class FormNovaStavkaPrimka : Form
    {
        Primka primka;
        public FormNovaStavkaPrimka(Primka primka)
        {
            InitializeComponent();
            this.primka = primka;
        }

        private void FormNovaStavkaPrimka_Load(object sender, EventArgs e)
        {
            DohvatiOpremu();
        }

        private void DohvatiOpremu()
        {
            using (var context = new skladistedbEntities())
            {
                var query = from o in context.Oprema
                            select o;
                cmbOprema.DataSource = query.ToList();
            }
        }

        private void btnNovaStavkaP_Click(object sender, EventArgs e)
        {
            int kol = int.Parse(txtKol.Text);
            Oprema oprema = cmbOprema.SelectedItem as Oprema;

            try
            {
                using (var context = new skladistedbEntities())
                {
                    StavkaPrimke novaStavkaPrimke = new StavkaPrimke();
                    novaStavkaPrimke.Primka = primka;
                    novaStavkaPrimke.Oprema = oprema;
                    novaStavkaPrimke.Kol = kol;

                    context.Primka.Attach(primka);
                    context.Oprema.Attach(oprema);
                    context.StavkaPrimke.Add(novaStavkaPrimke);
                    context.SaveChanges();

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                if(ex.InnerException.InnerException != null)
                {
                    MessageBox.Show(ex.InnerException.InnerException.Message);
                }
            }
        }
    }
}
