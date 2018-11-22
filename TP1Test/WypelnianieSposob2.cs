using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1Test
{
    class WypelnianieSposob2 : Wypelnianie
    {

        int IleRekordow;
        Random r;
        int rInt;

        WypelnianieSposob2(int IleRekordow)
        {

            this.IleRekordow = IleRekordow;
             r = new Random();
             rInt = r.Next(0, IleRekordow);

        }
            public void Wypelnij(DataContext dataContext)
            {
                for (int i = 0; i < IleRekordow; i++)
                {
                    Katalog ksiazka1 = new Katalog(i, Faker.Lorem.Sentence(), Faker.Name.FullName(), "Brak");
                    dataContext.Ksiazki.Add(ksiazka1.Id, ksiazka1);
                    Wykaz czytelnik1 = new Wykaz(i, Faker.Name.First(), Faker.Name.Last(), Faker.Phone.Number(), Faker.Address.StreetName());
                    dataContext.Czytelnicy.Add(czytelnik1);

                    var randHelper= r.Next(0, IleRekordow);
                    var randHelper2 = r.Next(0, IleRekordow);

                    OpisStanu stan1 = new OpisStanu(i, ksiazka1, randHelper, randHelper2, Faker.Lorem.GetFirstWord());
                    dataContext.OpisStanu.Add(stan1);

                    var randHelper3= r.Next(0, IleRekordow);

                    DateTime start = new DateTime(1995, 1, 1);
                    int range = (DateTime.Today - start).Days;

                    Zdarzenie zdarznie1 = new Zdarzenie(i, stan1, czytelnik1, randHelper3, start.AddDays(r.Next(range)));
                    dataContext.Wypozyczenia.Add(zdarznie1);
                }
             }

      
    }
}
