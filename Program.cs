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

        public virtual void tulostaTiedot()
        {
            Console.WriteLine("{0}, {1}, {2}, {3}", this.tyyppi, this.merkki, this.vuosiMalli, this.hinta);
        }
    }

    class Auto : KulkuValine
    {
        int koneenKoko;
        string malli;
        int ovienLkm;

        public Auto(string tyyppi, string merkki, int vuosiMalli, float hinta, int koneenKoko, string malli, int ovienLkm) : base(tyyppi, merkki, vuosiMalli, hinta)
        {
            this.koneenKoko = koneenKoko;
            this.malli = malli;
            this.ovienLkm = ovienLkm;
        }

        public override void tulostaTiedot()
        {
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}", this.tyyppi, this.merkki, this.vuosiMalli, this.hinta, this.koneenKoko, this.malli, this.ovienLkm);
        }

        public override string ToString()
        {
            return this.tyyppi + ", " + this.merkki + ", " + this.vuosiMalli + ", " + this.hinta + ", " + this.koneenKoko + ", " + this.malli + ", " + this.ovienLkm;
        }

        public override bool Equals(object obj)
        {
            if (this.tyyppi == ((Auto)obj).tyyppi)
            {
                return true;
            } else {
                return false;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto("Henkilöauto", "Tojota", 1998, 20000f, 2000, "Carina", 4);
            Auto kaara = new Auto("Henkilöauto", "Nissan", 2019, 20000f, 2000, "Cube", 5);
            Console.WriteLine(kaara.ToString());
            Console.WriteLine(auto.Equals(kaara));
        }
    }
}
