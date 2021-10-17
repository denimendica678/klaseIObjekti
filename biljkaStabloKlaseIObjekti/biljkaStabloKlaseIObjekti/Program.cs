using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biljkaStabloKlaseIObjekti
{
    class Program
    {
        static void Main(string[] args)
        {
            Biljka.Stablo.Bijelogoricno bijelogoricno = new Biljka.Stablo.Bijelogoricno(true);
            Biljka.Stablo.Bijelogoricno Hrast = bijelogoricno;

            Biljka.Stablo.Crnogoricno crnogoricno = new Biljka.Stablo.Crnogoricno(true);
            Biljka.Stablo.Crnogoricno Bor = crnogoricno;

            Console.WriteLine("Bijelogorično je hrast: " + Hrast.OpadajuListovi1);
            Console.WriteLine("Crnogorično je bor: " + Bor.OpadajuListovi1);



            Console.ReadKey();
        }
    }
}
