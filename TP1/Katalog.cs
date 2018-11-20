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
        public string Imie { get; set; }
        public string Opis { get; set; }

        public Katalog(int id, string imie, string autor, string opis)
        {
            Id = id;
            Imie = imie;
            Autor = autor;
            Opis = opis;
        }

        public override string ToString()
        {
            return string.Format("[{0}] {1} : {2} ({3})");
        }
        
        public override bool Equals(object obj)
        {
            if (obj != null && obj is Katalog)
            {
                Katalog prd = obj as Katalog;
                if (Id == prd.Id)
                    return true;
            }
            return false;
        }
    }
}
