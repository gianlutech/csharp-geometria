using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_geometria
{
    internal class Rettangolo
    {
        private readonly double baseRettangolo;
        private readonly double altezzaRettangolo;

        private readonly string nomeRettangolo; //lo chiede nella parte finale dell'esercizio
                                                //quando dice di creare tanti rettangoli con nomi diversi...

        //Costruttore senza parametri, inizializza tutto a 0
        //Notare che un costruttore non ha mai un valore di ritorno!!!
        public Rettangolo()
        {
            baseRettangolo = 0;
            altezzaRettangolo = 0;
            nomeRettangolo = "Rettangolo";
        }

        //Costruttore con due parametri, per creare rettangolo con base e altezza dati
        public Rettangolo(double baseR, double altezzaR) //non posso usare "base" poichè è parola chiave di C#
        {
            baseRettangolo = baseR;
            altezzaRettangolo = altezzaR;
            nomeRettangolo = "Rettangolo";
        }

        //Costruttore con tre parametri, per creare rettangolo con base e altezza dati
        public Rettangolo(double baseRettangolo, double altezzaR, string nomeR)
        {
            this.baseRettangolo = baseRettangolo;
            altezzaRettangolo = altezzaR;
            nomeRettangolo = nomeR;
        }

        public double CalcolaArea()
        {
            //area del rettandolo: base * altezza
            return baseRettangolo * altezzaRettangolo;
        }

        public double CalcolaPerimetro()
        {
            //Perimetrodel rettandolo: 2*base + 2*altezza
            return baseRettangolo * 2 + altezzaRettangolo * 2;
        }

        public void StampaRettangolo()
        {
            Console.WriteLine("—— {0} ——", nomeRettangolo);
            Console.WriteLine("base: {0} cm", baseRettangolo);
            Console.WriteLine("altezza: {0} cm", altezzaRettangolo);
            Console.WriteLine("Perimetro: {0} cm", CalcolaPerimetro());
            Console.WriteLine("Area: {0} cm", CalcolaArea());
            Console.WriteLine();
        }

        public void Disegna()
        {
            Console.Write("+");
            for (int i = 1; i < (baseRettangolo-1); ++i)
                Console.Write("-");
            Console.WriteLine("+");

            for (int i = 1; i < (altezzaRettangolo - 1); ++i)
                Console.WriteLine("|{0}|", new String(' ', (int)(baseRettangolo-2)));

            Console.Write("+");
            for (int i = 1; i < (baseRettangolo - 1); ++i)
                Console.Write("-");
            Console.WriteLine("+");
        }
    }
}
