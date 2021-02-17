using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skladiste
{
    public static class Prijava
    {
        public static Zaposlenik PrijavljenZaposlenik { get; set; }

        public static void PrijaviSe(string korIme, string lozinka)
        {
            using (var context = new skladistedbEntities())
            {
                var query = from z in context.Zaposlenik
                            where z.KorIme == korIme 
                            && z.Lozinka == lozinka
                            && z.DatumZavrsetka == null //garantira da se prijavljuje 'aktualni' zaposlenik
                            select z;
                PrijavljenZaposlenik = query.SingleOrDefault();
            }
        }

        public static void Odjava()
        {
            PrijavljenZaposlenik = null;
        }
    }
}
