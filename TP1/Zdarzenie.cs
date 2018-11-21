using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Zdarzenie
    {
        public int Id { get; set; }
        public OpisStanu Opisstanu { get; set;}
        public Wykaz Wykaz { get; set; }
        public double Ilosc { get; set; }
        public DateTime DataWypozyczenia { get; set; }

        public Zdarzenie(int id, OpisStanu opisStanu, Wykaz wykaz, double ilosc, DateTime dataWypozyczenia)
        {
            Id = id;
            Opisstanu = opisStanu;
            Wykaz = wykaz;
            Ilosc = ilosc;
            DataWypozyczenia = dataWypozyczenia;
        }
        
        public override string ToString()
        {
            return string.Format("[{0}] {1} - {2} ({3} ; {4})", Id, Opisstanu.Id, Wykaz.Id, Ilosc, DataWypozyczenia);
        }


    }
}
