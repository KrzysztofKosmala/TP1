using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Library;

namespace TP1Test
{
    public class WypelnijBaze : Wypelnianie
    {
     

        public void Wypelnij(DataContext dataContext)
        {

            Katalog ksiazka1 = new Katalog(1, "Przygody Tomka", "Maciek", "Brak");
            Katalog ksiazka2 = new Katalog(2, "c# od podstaw", "Krzysztof", "Brak");
            Katalog ksiazka3 = new Katalog(3, "2 Wojna", "Adolf", "Brak");
            Katalog ksiazka4 = new Katalog(4, "Java w 21 dni", "Sebastian", "Brak");

            dataContext.Ksiazki.Add(ksiazka1.Id, ksiazka1);
            dataContext.Ksiazki.Add(ksiazka2.Id, ksiazka2);
            dataContext.Ksiazki.Add(ksiazka3.Id, ksiazka3);
            dataContext.Ksiazki.Add(ksiazka4.Id, ksiazka4);

            Wykaz czytelnik1 = new Wykaz(1, "Krzysztof", "Kosmala", "56780187", "Łódzka");
            Wykaz czytelnik2 = new Wykaz(2, "Maciek", "Kozłowski", "56780666", "Pabianicka");
            Wykaz czytelnik3 = new Wykaz(3, "Tomasz", "Gromadko", "52231187", "Odrzanska");
            Wykaz czytelnik4 = new Wykaz(4, "Artur", "Badura", "87434887", "Joanny");

            dataContext.Czytelnicy.Add(czytelnik1);
            dataContext.Czytelnicy.Add(czytelnik2);
            dataContext.Czytelnicy.Add(czytelnik3);
            dataContext.Czytelnicy.Add(czytelnik4);

            OpisStanu stan1 = new OpisStanu(1, ksiazka1, 5, 10, "Nowa");
            OpisStanu stan2 = new OpisStanu(2, ksiazka2, 2, 12, "Używana");
            OpisStanu stan3 = new OpisStanu(3, ksiazka3, 4, 13, "Zniszczona");
            OpisStanu stan4 = new OpisStanu(4, ksiazka4, 5, 11, "Nowa");

            dataContext.OpisStanu.Add(stan1);
            dataContext.OpisStanu.Add(stan2);
            dataContext.OpisStanu.Add(stan3);
            dataContext.OpisStanu.Add(stan4);

            Zdarzenie zdarznie1 = new Zdarzenie(1,stan2,czytelnik3,1,new DateTime(2018,5,12) );
            Zdarzenie zdarznie2 = new Zdarzenie(1, stan2, czytelnik4, 1, new DateTime(2018, 12, 13));
            Zdarzenie zdarznie3 = new Zdarzenie(1, stan4, czytelnik2, 1, new DateTime(2018, 5, 17));
            Zdarzenie zdarznie4 = new Zdarzenie(1, stan1, czytelnik1, 1, new DateTime(2018, 4, 1));

            dataContext.Wypozyczenia.Add(zdarznie1);
            dataContext.Wypozyczenia.Add(zdarznie2);
            dataContext.Wypozyczenia.Add(zdarznie3);
            dataContext.Wypozyczenia.Add(zdarznie4);


            
        }
    }
}
