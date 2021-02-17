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
    public partial class FormNovaStavkaNarudzbenice : Form
    {
        Narudzbenica narudzbenica;
        public FormNovaStavkaNarudzbenice(Narudzbenica narudzbenica)
        {
            InitializeComponent();
            this.narudzbenica = narudzbenica;
        }

        private void FormNovaStavkaNarudzbenice_Load(object sender, EventArgs e)
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

        private void btnNovaStavkaN_Click(object sender, EventArgs e)
        {
            int kol = int.Parse(txtKol.Text);
            Oprema oprema = cmbOprema.SelectedItem as Oprema;

            using (var context = new skladistedbEntities())
            {
                StavkaNarudzbenice novaStavkaNarudzbenice = new StavkaNarudzbenice();
                novaStavkaNarudzbenice.Narudzbenica = narudzbenica;
                novaStavkaNarudzbenice.Oprema = oprema;
                novaStavkaNarudzbenice.Kol = kol;

                context.Narudzbenica.Attach(narudzbenica);
                context.Oprema.Attach(oprema);
                context.StavkaNarudzbenice.Add(novaStavkaNarudzbenice);
                context.SaveChanges();

                this.Close();
            }
        }
    }
}
