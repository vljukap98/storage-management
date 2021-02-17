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
    public partial class FormOprema : Form
    {
        public FormOprema()
        {
            InitializeComponent();
        }

        private void FormOprema_Load(object sender, EventArgs e)
        {
            Osvjezi();
            PopuniVrsteOpreme();
        }

        private void PopuniVrsteOpreme()
        {
            using (var context = new skladistedbEntities())
            {
                var query = from vo in context.VrstaOpreme
                            select vo;

                cmbVrstaOpr.DataSource = query.ToList();
            }
        }

        private void Osvjezi()
        {
            using (var context = new skladistedbEntities())
            {
                var query = from op in context.Oprema
                            select op;
                dgvOprema.DataSource = query.ToList();
                dgvOprema.Columns["StavkaOtpremnice"].Visible = false;
                dgvOprema.Columns["StavkaPrimke"].Visible = false;
                dgvOprema.Columns["StavkaNarudzbenice"].Visible = false;
                dgvOprema.Columns["VrstaOpreme"].Visible = false;
            }
        }

        private void btnAddOp_Click(object sender, EventArgs e)
        {
            string naziv = txtNaziv.Text;
            int minKol = int.Parse(txtMinKol.Text);
            int maxKol = int.Parse(txtMaxKol.Text);
            float jedCijena = float.Parse(txtJedCijena.Text);
            VrstaOpreme vrstaOpreme = cmbVrstaOpr.SelectedItem as VrstaOpreme;

            using (var context = new skladistedbEntities())
            {
                Oprema novaOprema = new Oprema();
                novaOprema.Naziv = naziv;
                novaOprema.MinKol = minKol;
                novaOprema.MaxKol = maxKol;
                novaOprema.Kol = 0;
                novaOprema.JedCijena = jedCijena;
                novaOprema.VrstaOpreme = vrstaOpreme;

                context.VrstaOpreme.Attach(vrstaOpreme);
                context.Oprema.Add(novaOprema);
                context.SaveChanges();

                Osvjezi();
            }
        }
    }
}
