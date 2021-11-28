using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hraci_Kostka_Objekty
{
    /// <summary>
    /// Třída reprezentuje hrací kostku
    /// </summary>
    class Kostka
    {
        private Random random;
        private int pocetSten;

        public Kostka()
        {
            pocetSten = 6;
            random = new Random();
        }

        public Kostka(int pocetSten)
        {
            this.pocetSten = pocetSten;
            random = new Random();
        }

        public int VratPocetSten()
        {
            return pocetSten;
        }

        public int hod()
        {
            return random.Next(1, pocetSten + 1);
        }

        /// <summary>
        /// Vrací textovou reprezentaci kostky
        /// </summary>
        /// <returns>Textová reprezentace kostky</returns>
        public override string ToString()
        {
            return String.Format("Kostka s {0} stěnami", pocetSten);
        }
    }
}
