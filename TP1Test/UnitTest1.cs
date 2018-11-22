using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


using System.Collections.Generic;
using Library;

namespace TP1Test
{
    [TestClass]
    public class UnitTest1
    {
         #region OpisStanu

        [TestMethod]
        public void DodajOpisStanu()
        {
            DataRepository repoTest = new DataRepository(new WypelnijBaze());
            Assert.AreEqual(4, repoTest.PobierzWszystkieOpisyStanu().Count);
            Katalog ksiazka = new Katalog(5, "Czerwony Stoliczek", "Konrad", "Brak");
            OpisStanu stan = new OpisStanu(5, ksiazka, 2, 25, "Nowa");
            repoTest.DodajOpisStanu(stan);
            Assert.AreEqual(5, repoTest.PobierzWszystkieOpisyStanu().Count);
        }

        [TestMethod]
        public void PobierzOpisStanuPoId()
        {
            DataRepository repoTest = new DataRepository(new WypelnijBaze());
            Katalog ksiazka = new Katalog(5, "Czerwony Stoliczek", "Konrad", "Brak");
            OpisStanu stan = new OpisStanu(5, ksiazka, 2, 25, "Nowa");
            repoTest.DodajOpisStanu(stan);
            Assert.AreEqual(stan, repoTest.PobierzOpisStanuPoId(5));
        }

        [TestMethod]
        public void PobierzWszystkieOpisyStanu()
        {
            DataRepository repoTest = new DataRepository(new WypelnijBaze());
            Assert.AreEqual(4, repoTest.PobierzWszystkieOpisyStanu().Count);
        }

        [TestMethod]
        public void UaktualnijOpisStanuPoId()
        {
            DataRepository repoTest = new DataRepository(new WypelnijBaze());
            Katalog ksiazka = new Katalog(5, "Czerwony Stoliczek", "Konrad", "Brak");
            OpisStanu nowystan = new OpisStanu(5, ksiazka, 2, 25, "Nowa");
            OpisStanu stan = repoTest.PobierzOpisStanuPoId(1);

            Assert.AreNotEqual(stan.Id, nowystan.Id);
            Assert.AreNotEqual(stan.Ksiazka, nowystan.Ksiazka);
            Assert.AreNotEqual(stan.DostepnaIlosc, nowystan.DostepnaIlosc);
            Assert.AreNotEqual(stan.Cena, nowystan.Cena);

            Assert.AreEqual(true,repoTest.UaktualnijOpisStanuPoId(1, nowystan));

            Assert.AreNotEqual(stan.Id, nowystan.Id);
            Assert.AreEqual(stan.Ksiazka, nowystan.Ksiazka);
            Assert.AreEqual(stan.Stan, nowystan.Stan);
            Assert.AreEqual(stan.DostepnaIlosc, nowystan.DostepnaIlosc);
            Assert.AreEqual(stan.Cena, nowystan.Cena);
        }

        [TestMethod]
        public void UsunOpisStanuPoId()
        {
            DataRepository repoTest = new DataRepository(new WypelnijBaze());
            Assert.AreEqual(4, repoTest.PobierzWszystkieOpisyStanu().Count);
            Assert.AreNotEqual(false, repoTest.UsunOpisStanuPoId(1));
            Assert.AreEqual(3, repoTest.PobierzWszystkieOpisyStanu().Count);
        }

        #endregion

        #region Zdarzenie

        [TestMethod]
        public void DodajZdarzenie()
        {
            DataRepository repoTest = new DataRepository(new WypelnijBaze());
            Assert.AreEqual(4, repoTest.PobierzWszystkieZdarzenia().Count);
            Katalog ksiazka = new Katalog(5, "C# programowanie", "Krzysztof", "Brak");
            OpisStanu stan = new OpisStanu(5, ksiazka, 5, 10, "Nowa");
            Wykaz czytelnik = new Wykaz(4, "Artur", "Gromadko", "87434997", "Belchatów");
            Zdarzenie zdarzenie = new Zdarzenie(5, stan, czytelnik, 1, new DateTime(2018, 6, 12));
            repoTest.DodajZdarzenie(zdarzenie);
            Assert.AreEqual(5, repoTest.PobierzWszystkieZdarzenia().Count);
        }

        [TestMethod]
        public void PobierzZdarzeniePoId()
        {
            DataRepository repoTest = new DataRepository(new WypelnijBaze());
            Katalog ksiazka = new Katalog(5, "C# programowanie", "Krzysztof", "Brak");
            OpisStanu stan = new OpisStanu(5, ksiazka, 5, 10, "Nowa");
            Wykaz czytelnik = new Wykaz(4, "Artur", "Gromadko", "87434997", "Belchatów");
            Zdarzenie zdarzenie = new Zdarzenie(5, stan, czytelnik, 1, new DateTime(2018, 6, 12));
            repoTest.DodajZdarzenie(zdarzenie);
            Assert.AreEqual(zdarzenie, repoTest.PobierzZdarzeniePoId(5));
        }

        [TestMethod]
        public void PobierzWszystkieZdarzenia()
        {
            DataRepository repoTest = new DataRepository(new WypelnijBaze());
            Assert.AreEqual(4, repoTest.PobierzWszystkieZdarzenia().Count);
            Katalog ksiazka = new Katalog(5, "C# programowanie", "Krzysztof", "Brak");
            OpisStanu stan = new OpisStanu(5, ksiazka, 5, 10, "Nowa");
            Wykaz czytelnik = new Wykaz(4, "Artur", "Gromadko", "87434997", "Belchatów");
            Zdarzenie zdarzenie = new Zdarzenie(5, stan, czytelnik, 1, new DateTime(2018, 6, 12));
            repoTest.DodajZdarzenie(zdarzenie);
            Assert.AreEqual(5, repoTest.PobierzWszystkieZdarzenia().Count);
        }

        [TestMethod]
        public void UaktualnijZdarzeniePoId()
        {
            DataRepository repoTest = new DataRepository(new WypelnijBaze());
            Katalog ksiazka = new Katalog(5, "C# programowanie", "Krzysztof", "Brak");
            OpisStanu stan = new OpisStanu(5, ksiazka, 5, 10, "Nowa");
            Wykaz czytelnik = new Wykaz(5, "Artur", "Gromadko", "87434997", "Belchatów");
            Zdarzenie noweZdarzenie = new Zdarzenie(5, stan, czytelnik, 1, new DateTime(2018, 6, 12));
            Zdarzenie zdarzenie = repoTest.PobierzZdarzeniePoId(1);

            Assert.AreNotEqual(zdarzenie.Id, noweZdarzenie.Id);
            Assert.AreNotEqual(zdarzenie.Opisstanu, noweZdarzenie.Opisstanu);
            Assert.AreNotEqual(zdarzenie.Wykaz, noweZdarzenie.Wykaz);
            Assert.AreNotEqual(zdarzenie.DataWypozyczenia, noweZdarzenie.DataWypozyczenia);

            Assert.AreEqual(true, repoTest.UaktualnijZdarzeniePoId(1,noweZdarzenie));

            Assert.AreNotEqual(zdarzenie.Id, noweZdarzenie.Id);
            Assert.AreEqual(zdarzenie.Ilosc, noweZdarzenie.Ilosc);
            Assert.AreEqual(zdarzenie.Opisstanu, noweZdarzenie.Opisstanu);
            Assert.AreEqual(zdarzenie.Wykaz, noweZdarzenie.Wykaz);
            Assert.AreEqual(zdarzenie.DataWypozyczenia, noweZdarzenie.DataWypozyczenia);
        }

        [TestMethod]
        public void UsunZdarzeniePoId()
        {
            DataRepository repoTest = new DataRepository(new WypelnijBaze());
            Assert.AreEqual(4, repoTest.PobierzWszystkieZdarzenia().Count);
            Assert.AreNotEqual(false, repoTest.UsunZdarzeniePoId(1));
            Assert.AreEqual(3, repoTest.PobierzWszystkieZdarzenia().Count);
        }

        #endregion

        #region Ksiazka

        [TestMethod]
        public void DodajKsiazke()
        {
            DataRepository repoTest = new DataRepository(new WypelnijBaze());
            Assert.AreEqual(4, repoTest.PobierzWszystkieKsiazki().Count);
            Katalog ksiazka = new Katalog(5, "Wiezien Labiryntu", "Dawid", "trylogia");
            repoTest.DodajKsiazke(ksiazka);
            Assert.AreEqual(5, repoTest.PobierzWszystkieKsiazki().Count);
        }

        [TestMethod]
        public void PobierzKsiazkePoId()
        {
            DataRepository repoTest = new DataRepository(new WypelnijBaze());
            Katalog ksiazka = new Katalog(5, "Wiezien Labiryntu", "Dawid", "trylogia");
            repoTest.DodajKsiazke(ksiazka);
            Assert.AreEqual(ksiazka,repoTest.PobierzKsiazkePoId(5));
        }

        [TestMethod]
        public void PobierzWszystkieKsiazki()
        {
            DataRepository repoTest = new DataRepository(new WypelnijBaze());
            Assert.AreEqual(4, repoTest.PobierzWszystkieKsiazki().Count);
            Katalog ksiazka = new Katalog(5, "Wiezien Labiryntu", "Dawid", "trylogia");
            repoTest.DodajKsiazke(ksiazka);
            Assert.AreEqual(5, repoTest.PobierzWszystkieKsiazki().Count);
        }

        [TestMethod]
        public void UaktualnijKsiazkePoId()
        {
            DataRepository repoTest = new DataRepository(new WypelnijBaze());
            Katalog nowaKsiazka = new Katalog(5, "Wiezien Labiryntu", "Dawid", "trylogia");
            Katalog ksiazka = repoTest.PobierzKsiazkePoId(1);

            Assert.AreNotEqual(ksiazka.Id, nowaKsiazka.Id);
            Assert.AreNotEqual(ksiazka.Nazwa, nowaKsiazka.Nazwa);
            Assert.AreNotEqual(ksiazka.Opis, nowaKsiazka.Opis);
            Assert.AreNotEqual(ksiazka.Autor, nowaKsiazka.Autor);

            repoTest.UaktualnijKsiazkePoId(1, nowaKsiazka);

            Assert.AreNotEqual(ksiazka.Id, nowaKsiazka.Id);
            Assert.AreEqual(ksiazka.Nazwa, nowaKsiazka.Nazwa);
            Assert.AreEqual(ksiazka.Opis, nowaKsiazka.Opis);
            Assert.AreEqual(ksiazka.Autor, nowaKsiazka.Autor);
        }

        [TestMethod]
        public void UsunKsiazkePoId()
        {
            DataRepository repoTest = new DataRepository(new WypelnijBaze());
            Assert.AreEqual(4, repoTest.PobierzWszystkieKsiazki().Count);
            Assert.AreEqual(true, repoTest.UsunKsiazkePoId(1));
            Assert.AreEqual(3, repoTest.PobierzWszystkieKsiazki().Count);
        }

        #endregion

        #region Czytelnik

        [TestMethod]
        public void DodajCzytelnika()
        {
            DataRepository repoTest = new DataRepository(new WypelnijBaze());
            Assert.AreEqual(4, repoTest.PobierzWszystkichCzytelnikow().Count);
            Wykaz czytelnik = new Wykaz(5, "Robert", "Testowy", "12345678", "Poznanska");
            repoTest.DodajCzytelnika(czytelnik);
            Assert.AreEqual(5, repoTest.PobierzWszystkichCzytelnikow().Count);
        }

        [TestMethod]
        public void PobierzCzytelnikaPoID()
        {
            DataRepository repoTest = new DataRepository(new WypelnijBaze());
            Wykaz czytelnik = new Wykaz(5, "Robert", "Testowy", "12345678", "Poznanska");
            repoTest.DodajCzytelnika(czytelnik);
            Assert.AreEqual(czytelnik, repoTest.PobierzCzytelnikaPoId(5));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void PobierzCzytelnikaPoId_ArgumentPozaZakresem()
        {
            DataRepository repoTest = new DataRepository(new WypelnijBaze());
            repoTest.PobierzCzytelnikaPoId(-5);
            
        }

        [TestMethod]
        public void PobierzWszystkichCzytelników()
        {
            DataRepository repoTest = new DataRepository(new WypelnijBaze());
            Assert.AreEqual(4, repoTest.PobierzWszystkichCzytelnikow().Count);
        }

        [TestMethod]

        public void UaktualnijCzytelnikaNaId()
        {
            DataRepository repoTest = new DataRepository(new WypelnijBaze());
            Wykaz nowyCzytelnik = new Wykaz(5, "Robert", "Testowy", "12345678", "Poznanska");
            Wykaz czytelnik = repoTest.PobierzCzytelnikaPoId(1);

            Assert.AreNotEqual(czytelnik.Id, nowyCzytelnik.Id);
            Assert.AreNotEqual(czytelnik.Imie, nowyCzytelnik.Imie);
            Assert.AreNotEqual(czytelnik.Nazwisko, nowyCzytelnik.Nazwisko);
            Assert.AreNotEqual(czytelnik.Telefon, nowyCzytelnik.Telefon);
            Assert.AreNotEqual(czytelnik.Adres, nowyCzytelnik.Adres);

            Assert.AreEqual(true,repoTest.UaktualnijCzytelnikaNaId(1, nowyCzytelnik));

            Assert.AreNotEqual(czytelnik.Id, nowyCzytelnik.Id);
            Assert.AreEqual(czytelnik.Imie, nowyCzytelnik.Imie);
            Assert.AreEqual(czytelnik.Nazwisko, nowyCzytelnik.Nazwisko);
            Assert.AreEqual(czytelnik.Telefon, nowyCzytelnik.Telefon);
            Assert.AreEqual(czytelnik.Adres, nowyCzytelnik.Adres);
        }

        [TestMethod]
        public void UsunCzytelnikaPoId()
        {
            DataRepository repoTest = new DataRepository(new WypelnijBaze());
            Assert.AreEqual(4, repoTest.PobierzWszystkichCzytelnikow().Count);
            Assert.AreNotEqual(false, repoTest.UsunCzytelnikaPoId(1));
            Assert.AreEqual(3, repoTest.PobierzWszystkichCzytelnikow().Count);
        }

        #endregion
    }

    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void wypelnienie2_100()
        {
            DataRepository repoTest = new DataRepository(new WypelnianieSposob2(100));
            Assert.AreEqual(100, repoTest.PobierzWszystkichCzytelnikow().Count);
            Assert.AreEqual(100, repoTest.PobierzWszystkieKsiazki().Count);
            Assert.AreEqual(100, repoTest.PobierzWszystkieOpisyStanu().Count);
            Assert.AreEqual(100, repoTest.PobierzWszystkieZdarzenia().Count);
        }

        [TestMethod]
        public void wypelnienie2_1000()
        {
            DataRepository repoTest = new DataRepository(new WypelnianieSposob2(1000));
            Assert.AreEqual(1000, repoTest.PobierzWszystkichCzytelnikow().Count);
            Assert.AreEqual(1000, repoTest.PobierzWszystkieKsiazki().Count);
            Assert.AreEqual(1000, repoTest.PobierzWszystkieOpisyStanu().Count);
            Assert.AreEqual(1000, repoTest.PobierzWszystkieZdarzenia().Count);


        }

        [TestMethod]
        public void wypelnienie2_10000()
        {
            DataRepository repoTest = new DataRepository(new WypelnianieSposob2(10000));
            Assert.AreEqual(10000, repoTest.PobierzWszystkichCzytelnikow().Count);
            Assert.AreEqual(10000, repoTest.PobierzWszystkieKsiazki().Count);
            Assert.AreEqual(10000, repoTest.PobierzWszystkieOpisyStanu().Count);
            Assert.AreEqual(10000, repoTest.PobierzWszystkieZdarzenia().Count);
        }
    }
}
