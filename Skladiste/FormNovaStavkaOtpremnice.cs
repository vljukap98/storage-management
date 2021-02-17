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
    public partial class FormNovaStavkaOtpremnice : Form
    {
        Otpremnica otpremnica;
        public FormNovaStavkaOtpremnice(Otpremnica otpremnica)
        {
            InitializeComponent();
            this.otpremnica = otpremnica;
        }

        private void btnNovaStavkaO_Click(object sender, EventArgs e)
        {
            try
            {
                int kol = int.Parse(txtKol.Text);
                Oprema oprema = cmbOprema.SelectedItem as Oprema;

                using (var context = new skladistedbEntities())
                {
                    StavkaOtpremnice novaStavkaOtpremnice = new StavkaOtpremnice();
                    novaStavkaOtpremnice.Otpremnica = otpremnica;
                    novaStavkaOtpremnice.Oprema = oprema;
                    novaStavkaOtpremnice.Kol = kol;

                    context.Otpremnica.Attach(otpremnica);
                    context.Oprema.Attach(oprema);
                    context.StavkaOtpremnice.Add(novaStavkaOtpremnice);
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

        private void FormNovaStavkaOtpremnice_Load(object sender, EventArgs e)
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
