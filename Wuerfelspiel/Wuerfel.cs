using System;

namespace Wuerfelspiel
{
    public class Wuerfel
    {
        private int anzahlSeiten;
        private int letztesErgebnis;
        private bool gesichert;
        Random rnd = new Random();

        Wuerfel(int anzahlSeiten)
        {
            this.anzahlSeiten = anzahlSeiten;
        }
        public int AnzahlSeiten
        {
            get
            {
                return anzahlSeiten;
            }
        }
        public int LetztesErgebnis
        {
            get
            {
                return letztesErgebnis;
            }
        }
        public bool Gesichert
        {
            get
            {
                return gesichert;
            }
            set
            {
                gesichert = value;
            }
        }
        public void SicherungUmschalten()
        {
            //Gesischert true oder false
            gesichert = !gesichert;
        }
        public int Wuerfeln(int ergebnis)
        {
            ergebnis = rnd.Next(0, 7);
            return ergebnis;
        }
    }
}
