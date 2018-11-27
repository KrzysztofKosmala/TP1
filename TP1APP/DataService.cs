using Library;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1APP
{
    class DataService
    {
        private DataRepository dataRepository;

        public DataService(DataRepository data)
        {
            dataRepository = data;
        }

        #region Wypisywanie
        public void WypiszCzytelnikow(List<Wykaz> czytelnicy)
        {
            foreach (Wykaz c in czytelnicy)
                Console.WriteLine(c.ToString());
        }
        public void WypiszKsiazki(Dictionary<int, Katalog> ksiazki)
        {
            foreach (Katalog k in ksiazki.Values)
                Console.WriteLine(k.ToString());
        }
        public void WypiszOpisyStanu(ObservableCollection<OpisStanu> opis)
        {
            foreach (OpisStanu o in opis)
                Console.WriteLine(o.ToString());
        }
        public void WypiszZdarzenia(ObservableCollection<Zdarzenie> zdarznie)
        {
            foreach (Zdarzenie z in zdarznie)
                Console.WriteLine(z.ToString());
        }

        public void WypiszWszystko()
        {
            Console.WriteLine("Czytelnicy");
            WypiszCzytelnikow(dataRepository.PobierzWszystkichCzytelnikow());
            Console.WriteLine("Ksiażki");
            WypiszKsiazki(dataRepository.PobierzWszystkieKsiazki());
            Console.WriteLine("Zdarzenia");
            WypiszZdarzenia(dataRepository.PobierzWszystkieZdarzenia());
            //WypiszOpisyStanu(dataRepository.PobierzWszystkieOpisyStanu());
        }
 #endregion 

        #region OpisStanu

        public OpisStanu DodajOpisStanu(int id, Katalog ksiazka, double dostepnaIlosc, double cena, string stan)
        {
            OpisStanu opis = new OpisStanu(id, ksiazka, dostepnaIlosc, cena, stan);
            dataRepository.DodajOpisStanu(opis);
            return opis;
        }

        public void PobierzOpisStanuPoId(int id)
        {
            dataRepository.PobierzOpisStanuPoId(id);
        }

        public void UaktualnijOpisStanuPoId(int id, int nowyId, Katalog ksiazka, double dostepnaIlosc, double cena, string stan)
        {
            OpisStanu opis =  DodajOpisStanu(nowyId, ksiazka, dostepnaIlosc, cena, stan);
            dataRepository.UaktualnijOpisStanuPoId(id, opis);
        }
        public void UsunOpisStanuPoId(int id)
        {
            dataRepository.UsunOpisStanuPoId(id);
        }
#endregion

        #region Zdarzenia

        public Zdarzenie DodajZdarzenie(int id, OpisStanu opisStanu, Wykaz wykaz, double ilosc, DateTime dataWypozyczenia)
        {
            Zdarzenie z = new Zdarzenie(id, opisStanu, wykaz, ilosc, dataWypozyczenia);
            dataRepository.DodajZdarzenie(z);
            return z;
        }

        public void PobierzZdarzeniePoId(int id)
        {
            dataRepository.PobierzZdarzeniePoId(id);
        }

        public void UaktualnijZdarzeniePoId(int id, int noweId, OpisStanu opisStanu, Wykaz wykaz, double ilosc, DateTime dataWypozyczenia)
        {
            Zdarzenie z = DodajZdarzenie(noweId, opisStanu, wykaz, ilosc, dataWypozyczenia);
            dataRepository.UaktualnijZdarzeniePoId(id, z);
        }
        public void UsunZdarzeniePoId(int id)
        {
            dataRepository.UsunZdarzeniePoId(id);
        }
#endregion

        #region Ksiazki

        public Katalog DodajKsiazke(int id, string nazwa, string autor, string opis)
        {
            Katalog k = new Katalog(id, nazwa, autor, opis);
            dataRepository.DodajKsiazke(k);
            return k;
        }

        public void PobierzKsiazkePoId(int id)
        {
            dataRepository.PobierzKsiazkePoId(id);
        }

        public void UaktualnijKsiazkePoId(int id, int noweId, string nazwa, string autor, string opis)
        {
            Katalog k = DodajKsiazke(noweId, nazwa, autor, opis);
            dataRepository.UaktualnijKsiazkePoId(id, k);
        }

        public void UsunKsiazkePoId(int id)
        {
            dataRepository.UsunKsiazkePoId(id);
        }
#endregion

        #region Czytelnik
        public Wykaz DodajCzytelnika(int id, string imie, string nazwisko, string telefon, string adres)
        {
            Wykaz cz = new Wykaz(id, imie, nazwisko, telefon, adres);
            dataRepository.DodajCzytelnika(cz);
            return cz;

        }

        public void PobierzCzytelnikaPoId(int id)
        {
            dataRepository.PobierzCzytelnikaPoId(id);
        }

        public void UaktualnijCzytelnikaNaId(int id, int noweId, string imie, string nazwisko, string telefon, string adres)
        {
            Wykaz cz = DodajCzytelnika(noweId, imie, nazwisko, telefon, adres);
            dataRepository.UaktualnijCzytelnikaNaId(id, cz);
        }

        public void UsunCzytelnikaPoID(int id)
        {
            dataRepository.UsunCzytelnikaPoId(id);
        }
        #endregion

        #region Wyszukiwanie danych

        public void WyszukajPoImieniu(string name)
        {
            foreach (Wykaz w in dataRepository.PobierzWszystkichCzytelnikow())
            {
                if (name == w.Imie)
                {
                    Console.WriteLine(w.ToString());
                }
            }
        }

        public void WyszukajPoNazwisku(string name)
        {
            foreach (Wykaz w in dataRepository.PobierzWszystkichCzytelnikow())
            {
                if (name == w.Nazwisko)
                {
                    Console.WriteLine(w.ToString());
                }
            }
        }

        public void WyszukajPoTelefonie(string name)
        {
            foreach (Wykaz w in dataRepository.PobierzWszystkichCzytelnikow())
            {
                if (name == w.Telefon)
                {
                    Console.WriteLine(w.ToString());
                }
            }
        }

        public void WyszukajPoAdresie(string name)
        {
            foreach (Wykaz w in dataRepository.PobierzWszystkichCzytelnikow())
            {
                if (name == w.Adres)
                {
                    Console.WriteLine(w.ToString());
                }
            }
        }

        public void WyszukajPoNazwie(string name)
        {
            foreach (Katalog k in dataRepository.PobierzWszystkieKsiazki().Values)
            {
                if (name == k.Nazwa)
                {
                    Console.WriteLine(k.ToString());
                }
            }
        }

        public void WyszukajPoAutorze(string name)
        {
            foreach (Katalog k in dataRepository.PobierzWszystkieKsiazki().Values)
            {
                if (name == k.Autor)
                {
                    Console.WriteLine(k.ToString());
                }
            }
        }


        #endregion
    }
}
