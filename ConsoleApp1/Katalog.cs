using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Katalog
    {
        private List<Produkt> klientList = new List<Produkt>();

        public Katalog()
        {
        }

        public void dodajProdukt(Produkt p)
        {
            klientList.Add(p);
        }

        public void usunProdukt(Produkt p)
        {
            klientList.Remove(p);
        }
    }
}
