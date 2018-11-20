using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class OpisStanu
    {
        public int Id { get; set; }
        public Katalog Ksiazka { get; set; }
        public double DostepnaIlosc { get; set; }
        public double Cena { get; set; }
        public string Opis { get; set; }

        public OpisStanu(int id, Katalog ksiazka, double dostepnaIlosc, double cena, string opis)
        {
            Id = id;
            Ksiazka = ksiazka;
            DostepnaIlosc = dostepnaIlosc;
            Cena = cena;
            Opis = opis;
        }

     
    }
}
