using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biljkaStabloKlaseIObjekti
{
    public class Biljka
    {
        public class Cvijet : Biljka
        {
            public Cvijet()
            {
            }
        }

        public class Stablo : Biljka
        {
             bool opadajuListovi;


            public Stablo(bool opadajuListovi) => this.opadajuListovi = opadajuListovi;

            public bool OpadajuListovi1 { get => opadajuListovi; set => opadajuListovi = value; }

            public static void OpadajuListovi()
            {
                
            }

            public class Bijelogoricno : Stablo
            {
                public Bijelogoricno(bool opadajuListovi) : base(opadajuListovi)
                {
                    OpadajuListovi = opadajuListovi;
                }

                public bool OpadajuListovi { get; }
            }

            public class Crnogoricno : Stablo
            {
                

                public Crnogoricno(bool opadajuListovi) : base(opadajuListovi)
                {
                    OpadajuListovi = opadajuListovi;
                }

                public bool OpadajuListovi { get; }
            }

        }
    }
}
