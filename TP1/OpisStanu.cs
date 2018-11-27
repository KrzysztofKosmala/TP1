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
        public string Stan { get; set; }

        public OpisStanu(int id, Katalog ksiazka, double dostepnaIlosc, double cena, string stan)
        {
            Id = id;
            Ksiazka = ksiazka;
            DostepnaIlosc = dostepnaIlosc;
            Cena = cena;
            Stan = stan;
        }

        public override string ToString()
        {
            return string.Format("[{0}] Id Książki :{1}  Dostępna ilość: {2}  Cena: {3} stan: {4}", Id, Ksiazka.Id, DostepnaIlosc, Cena, Stan);
        }

    }
}
