using System;

namespace Wuerfelspiel
{
    public class Wuerfel
    {
        private int anzahlSeiten;
        private int letztesErgebnis;
        private bool gesischert;
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
                return anzahlSeiten;
            }
        }
        public bool Gesischert
        {
            get
            {
                return gesischert;
            }
            set
            {
                gesischert = value;
            }
        }
        public static void SicherungUmschalten()
        {
            //Gesischert true oder false
            
        }
        public static int Wuerfeln()
        {
            if()
        }
    }
}
