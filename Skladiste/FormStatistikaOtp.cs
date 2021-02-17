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
    public partial class FormStatistikaOtp : Form
    {
        public FormStatistikaOtp()
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
                            join so in context.StavkaOtpremnice on o.OpremaId equals so.OpremaId
                            join otp in context.Otpremnica on so.OtpremnicaId equals otp.OtpremnicaId
                            where otp.DatumKreiranja > vrijemeOd
                            && otp.DatumKreiranja < vrijemeDo
                            && o.OpremaId == oprema.OpremaId
                            select new
                            {
                                Naziv = o.Naziv, 
                                Vrsta = vo.Naziv, 
                                JedCijena = o.JedCijena, 
                                Otpremnica = otp.OtpremnicaId, 
                                Datum = otp.DatumKreiranja, 
                                Kolicina = so.Kol
                            };

                dgvStatistikaOtp.DataSource = query.ToList();
            }
        }

        private void FormStatistikaOtp_Load(object sender, EventArgs e)
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
