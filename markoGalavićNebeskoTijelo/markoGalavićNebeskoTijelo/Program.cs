using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markoGalavićNebeskoTijelo
{
    class Program
    {
        static void Main(string[] args)
        {
            double BrzinaOkoOsi;
            double BrzinaOkoSunca;

            Nebesko_tijelo Planet = new Nebesko_tijelo(100, 300);
            Nebesko_tijelo Satelit = new Nebesko_tijelo(500, 200);

            Planet.setBrzinaOkoOsi(Planet.getBrzinaOkoOsi());
            Planet.setBrzinaOkoSunca(Planet.getBrzinaOkoSunca());

            Satelit.setBrzinaOkoOsi(Satelit.getBrzinaOkoOsi());
            Satelit.setBrzinaOkoSunca(Satelit.getBrzinaOkoSunca());

            
            Console.WriteLine("Brzina Satelita oko osi je:" + BrzinaOkoOsi);
            Console.WriteLine("Brzina Satelita oko Sunca je:" + BrzinaOkoSunca);
            Console.ReadKey();
        }
    }
    }

