using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Katalog
    {
        public int Id { get; set; }
        public string Autor { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }

        public Katalog(int id, string nazwa, string autor, string opis)
        {
            Id = id;
            Nazwa = nazwa;
            Autor = autor;
            Opis = opis;
        }

        public override string ToString()
        {
            return string.Format("[{0}] {1} autor: {2} ({3})", Id, Nazwa, Autor, Opis);
        }
    }
}
