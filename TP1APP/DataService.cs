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
            foreach (Wykaz w in dataRepository.PobierzWszystkichCzytelnikow())
            {
                Console.WriteLine(w.ToString());

                foreach (Zdarzenie z in dataRepository.PobierzWszystkieZdarzenia())
                {

                }
            }
        }


    }
}
