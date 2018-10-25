using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Wykaz
    {
        private List<Klient> klientList = new List<Klient>();

        public Wykaz()
        {
        }

        public void dodajKlienta(Klient k)
        {
            klientList.Add(k);
        }

        public void usunKlienta(Klient k)
        {
            klientList.Remove(k);
        }
    }
}
