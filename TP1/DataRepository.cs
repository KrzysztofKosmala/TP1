using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class DataRepository
    {
        protected DataContext DataContext = new DataContext();

        public DataRepository(Wypelnianie wyp)
        {
            wyp.Wypelnij(DataContext);
        }

        
        #region OpisStanu
        public void DodajOpisStanu(OpisStanu opisStanu)
        {
            if (opisStanu != null)
                DataContext.OpisStanu.Add(opisStanu);
            else
                throw new ArgumentNullException();
        }
     
        public OpisStanu PobierzOpisStanuPoId(int id)
        {
            if (DataContext.OpisStanu.Any(x => x.Id == id))
                return DataContext.OpisStanu.First(x => x.Id == id);
            else
                return null;
        }
        public ObservableCollection<OpisStanu> PobierzWszystkieOpisyStanu()
        {
            return DataContext.OpisStanu;
        }
    
        public bool UaktualnijOpisStanuPoId(int id, OpisStanu nowyOpisStanu)
        {
            if (nowyOpisStanu != null)
            {
                if (DataContext.OpisStanu.Any(x => x.Id == id))
                {
                    OpisStanu opisStanu = DataContext.OpisStanu.First(x => x.Id == id);
                    opisStanu.Cena = nowyOpisStanu.Cena;
                    opisStanu.Ksiazka = nowyOpisStanu.Ksiazka;
                    opisStanu.DostepnaIlosc = nowyOpisStanu.DostepnaIlosc;
                    opisStanu.Stan = nowyOpisStanu.Stan;
                    return true;
                }
                return false;
            }
            else
                throw new ArgumentNullException();
        }
       
        public bool UsunOpisStanuPoId(int id)
        {
            if (DataContext.OpisStanu.Any(x => x.Id == id))
            {
                OpisStanu ProductVariant = DataContext.OpisStanu.First(x => x.Id == id);
                return DataContext.OpisStanu.Remove(ProductVariant);
            }
            return false;
        }
        #endregion

        #region Zdarzenie
        public void DodajZdarzenie(Zdarzenie zdarzenie)
        {
            if (zdarzenie != null)
                DataContext.Wypozyczenia.Add(zdarzenie);
            else
                throw new ArgumentNullException();
        }

        public Zdarzenie PobierzZdarzeniePoId(int id)
        {
            if (DataContext.Wypozyczenia.Any(x => x.Id == id))
                return DataContext.Wypozyczenia.First(x => x.Id == id);
            else
                return null;
        }
        public ObservableCollection<Zdarzenie> PobierzWszystkieZdarzenia()
        {
            return DataContext.Wypozyczenia;
        }
       
        public bool UaktualnijZdarzeniePoId(int id, Zdarzenie noweWypozyczenie)
        {
            if (noweWypozyczenie != null)
            {
                if (DataContext.Wypozyczenia.Any(x => x.Id == id))
                {
                    Zdarzenie wyp = DataContext.Wypozyczenia.First(x => x.Id == id);
                    wyp.Wykaz = noweWypozyczenie.Wykaz;
                    wyp.DataWypozyczenia = noweWypozyczenie.DataWypozyczenia;
                    wyp.Opisstanu = noweWypozyczenie.Opisstanu;
                    wyp.Ilosc = noweWypozyczenie.Ilosc;
                    return true;
                }
                return false;
            }
            else
                throw new ArgumentNullException();
        }
  
        public bool UsunZdarzeniePoId(int id)
        {
            if (DataContext.Wypozyczenia.Any(x => x.Id == id))
            {
                Zdarzenie order = DataContext.Wypozyczenia.First(x => x.Id == id);
                return DataContext.Wypozyczenia.Remove(order);
            }
            return false;
        }
        #endregion

        #region Ksiazka
        public void DodajKsiazke(Katalog ksiazka)
        {
            if (ksiazka != null)
            { 
                DataContext.Ksiazki.Add(ksiazka.Id, ksiazka);
            }
            else
                throw new ArgumentNullException();
        }
        public Katalog PobierzKsiazkePoId(int id)
        {
            return DataContext.Ksiazki[id];
        }
        public Dictionary<int, Katalog> PobierzWszystkieKsiazki()
        {
            return DataContext.Ksiazki;
        }
        public void UaktualnijKsiazkePoId(int id, Katalog nowaKsiazka)
        {
            if (nowaKsiazka != null)
            {
            
                Katalog product = DataContext.Ksiazki[id];
                if (product != null)
                {
                    product.Opis = nowaKsiazka.Opis;
                    product.Autor = nowaKsiazka.Autor;
                    product.Nazwa = nowaKsiazka.Nazwa;
                }
                else
                    throw new NullReferenceException();
            }
            else
                throw new ArgumentNullException();
        }
        public bool UsunKsiazkePoId(int id)
        {
            return DataContext.Ksiazki.Remove(id);
        }
        #endregion

        #region Czytelnik

        public void DodajCzytelnika(Wykaz czytelnik)
        {
            if (czytelnik != null)
                DataContext.Czytelnicy.Add(czytelnik);
            else
                throw new ArgumentNullException();
        }

        public Wykaz PobierzCzytelnikaPoId(int id)
        {
            if (DataContext.Czytelnicy.Exists(x => x.Id == id))
                return DataContext.Czytelnicy.First(x => x.Id == id);
            else
                return null;
        }
        public List<Wykaz> PobierzWszystkichCzytelnikow()
        {
            return DataContext.Czytelnicy;
        }

        public bool UaktualnijCzytelnikaNaId(int id, Wykaz nowyCzytelnik)
        {
            if (nowyCzytelnik != null)
            {
                if (DataContext.Czytelnicy.Exists(x => x.Id == id))
                {
                    Wykaz czytelnik = DataContext.Czytelnicy.First(x => x.Id == id);
                    czytelnik.Adres = nowyCzytelnik.Adres;
                    czytelnik.Telefon = nowyCzytelnik.Telefon;
                    czytelnik.Imie = nowyCzytelnik.Imie;
                    czytelnik.Nazwisko = nowyCzytelnik.Nazwisko;
                    return true;
                }
                return false;
            }
            else
                throw new ArgumentNullException();
        }

        public bool UsunCzytelnikaPoId(int id)
        {
            if (DataContext.Czytelnicy.Exists(x => x.Id == id))
            {
                Wykaz czytelnik = DataContext.Czytelnicy.First(x => x.Id == id);
                return DataContext.Czytelnicy.Remove(czytelnik);
            }
            return false;
        }
        #endregion
    }
}
