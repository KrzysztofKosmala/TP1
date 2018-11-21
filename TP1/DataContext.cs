using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class DataContext
    {
        public Dictionary<int, Katalog> Ksiazki { get; set; } = new Dictionary<int, Katalog>();

        public ObservableCollection<OpisStanu> OpisStanu { get; set; } = new ObservableCollection<OpisStanu>();

        public List<Wykaz> Czytelnicy { get; set; } = new List<Wykaz>();

        public ObservableCollection<Zdarzenie> Wypozyczenia { get; set; } = new ObservableCollection<Zdarzenie>();

        

        internal DataContext()
        {
           
        }
    }
}
