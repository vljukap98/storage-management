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
    public partial class FormStatistikaZap : Form
    {
        public FormStatistikaZap()
        {
            InitializeComponent();
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            DateTime vrijemeOd = dtpOd.Value;
            DateTime vrijemeDo = dtpDo.Value;
            Oprema oprema = cmbOprema.SelectedItem as Oprema;

            using (var context = new skladistedbEntities())
            {
                var query = from vo in context.VrstaOpreme
                            join o in context.Oprema on vo.VrstaOpremeId equals o.VrstaOpremeId
                            join sp in context.StavkaPrimke on o.OpremaId equals sp.OpremaId
                            join pri in context.Primka on sp.PrimkaId equals pri.PrimkaId
                            where pri.DatumKreiranja > vrijemeOd
                            && pri.DatumKreiranja < vrijemeDo
                            && o.OpremaId == oprema.OpremaId
                            select new
                            {
                                Naziv = o.Naziv,
                                Vrsta = vo.Naziv,
                                JedCijena = o.JedCijena,
                                Primka = pri.PrimkaId,
                                Datum = pri.DatumKreiranja,
                                Kolicina = sp.Kol
                            };

                dgvStatistikaZap.DataSource = query.ToList();
            }
        }

        private void FormStatistikaZap_Load(object sender, EventArgs e)
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
    }
}
