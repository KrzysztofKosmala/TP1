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
        public List<Wykaz> Czytelnicy { get; set; } = new List<Wykaz>();
        public Dictionary<int, Katalog> Ksiazki { get; set; } = new Dictionary<int, Katalog>();
        public ObservableCollection<Zdarzenie> Wypozyczenie { get; set; } = new ObservableCollection<Zdarzenie>();
        public ObservableCollection<OpisStanu> OpisStanu { get; set; } = new ObservableCollection<OpisStanu>();

        internal DataContext()
        {
            // EMPTY
        }
    }
}
