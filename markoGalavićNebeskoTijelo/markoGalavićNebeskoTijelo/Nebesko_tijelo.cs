using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markoGalavićNebeskoTijelo
{
    class Nebesko_tijelo
    {
         private double BrzinaOkoOsi;
         private double BrzinaOkoSunca;

        public override string ToString()
        {
            string ispis = "\nBrzina oko osi: " + BrzinaOkoOsi + "\nBrzina oko Sunca: " + BrzinaOkoSunca;
            return ispis;
        }
        public Nebesko_tijelo()
        {

        }

        public Nebesko_tijelo(double BrzinaOkoOsi, double BrzinaOkoSunca)
        {
            this.BrzinaOkoOsi = BrzinaOkoOsi;
            this.BrzinaOkoSunca = BrzinaOkoSunca;
        }




        public double getBrzinaOkoOsi()
        {
            return BrzinaOkoOsi;
        }
        public void setBrzinaOkoOsi(double BrzinaOkoOsi)
        {
            this.BrzinaOkoOsi = BrzinaOkoOsi;
        }
        public double getBrzinaOkoSunca()
        {
            return BrzinaOkoSunca;
        }
        public void setBrzinaOkoSunca(double BrzinaOkoSunca)
        {
            this.BrzinaOkoSunca = BrzinaOkoSunca;
        }


    }
}
