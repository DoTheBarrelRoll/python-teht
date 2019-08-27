using System;

namespace python_teht
{
    public class Kirja
    {
        string Nimi;
        string kirjailija;
        string kustantaja;
        float hinta;
        public string teemanNimi;

        public float Hinta
        {
            get
            {
                return hinta;
            }

            set
            {
                if (value > 30)
                {
                    hinta = value * 0.9f;
                } else
                {
                    hinta = value;
                }
            }
        }
        public Kirja(string Nimi, string kirjailija, string kustantaja, float hinta, string teemanNimi)
        {
            this.Nimi = Nimi;
            this.kirjailija = kirjailija;
            this.kustantaja = kustantaja;
            this.hinta = hinta;
            this.teemanNimi = teemanNimi;
        }

        public void haeKirja(string Nimi)
        {
            if (Nimi == this.Nimi)
            {
                System.Console.WriteLine(this.Nimi + ", " + this.kirjailija + ", " + this.kustantaja + ", " + this.teemanNimi + ", " + this.hinta);
            }
            else
            {
                System.Console.WriteLine("Kirjaa ei löytynyt.");
            }
        }

        static void VaihdaTeema(Kirja kirja, string uusiTeema)
        {
            kirja.teemanNimi = uusiTeema;
        }
    }
    class Program
    {
        static void VaihdaTeema(Kirja kirja, string uusiTeema)
        {
            kirja.teemanNimi = uusiTeema;
        }
        static void Main(string[] args)
        {
            Kirja k = new Kirja("kirja", "k.kirjailija", "Kustantaja", 21.2f, "Draama");

            k.haeKirja("kirja");

            VaihdaTeema(k, "Jännitys");

            k.haeKirja("kirja");
        }
    }
}
