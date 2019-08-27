using System;

namespace python_teht
{
    public class KulkuValine
    {
        protected string tyyppi;
        protected string merkki;
        protected int vuosiMalli;
        protected float hinta;

        public KulkuValine(string tyyppi, string merkki, int vuosiMalli, float hinta)
        {
            this.tyyppi = tyyppi;
            this.merkki = merkki;
            this.vuosiMalli = vuosiMalli;
            this.hinta = hinta;   
        }

        public void tulostaTiedot() {
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            KulkuValine auto = new KulkuValine("Henkilöauto", "Tojota", 1998, 20000f);

        }
    }
}
