using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometrijskiLikKlaseIObjekti
{
    public class GeometrijskiLik

    {
        int BrojStranica;
        private double[] stranice = new double[10];

        public int BrojStranica1 { get => BrojStranica; set => BrojStranica = value; }
        public double[] Stranice { get => stranice; set => stranice = value; }

        public GeometrijskiLik(int brojStranica, double[] stranice)
        {
            BrojStranica = brojStranica;
            Stranice = stranice;
        }



        static void UcitajStranice()
        {

        }

            public double Opseg()
            {
                double opseg=0;

                foreach(double broj in Stranice)
                {
                    opseg = broj + opseg;
                }

                return opseg;
        }

    }

    class Trokut : GeometrijskiLik
    {
        public Trokut(int brojStranica, double[] stranice) : base(brojStranica, stranice)
        {

        }


    }

    class Cetverokut : GeometrijskiLik
    {
        public Cetverokut(int brojStranica, double[] stranice) : base(brojStranica, stranice)
        {
            Stranice = new double[brojStranica];
            for (int i = 0; i <= 4; i++)
            {
                Console.Write("Unesite brojeve stranica:");
                Stranice[i] = Convert.ToDouble(Console.ReadLine());

            }
        }
    }
}
