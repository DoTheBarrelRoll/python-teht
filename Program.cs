using System;

namespace python_teht
{
    public class KulkuValine
    {
        string Nimi;
        string kirjailija;
        string kustantaja;
        public float hinta;
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
            this.Hinta = hinta;
            this.teemanNimi = teemanNimi;
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
            Kirja k2 = new Kirja("kirja 2", "O. kirjoittaja", "Kustantaja OY", 35.1f, "Jännitys");
            Console.WriteLine(k.Hinta);
            Console.WriteLine(k2.Hinta);
        }
    }
}
