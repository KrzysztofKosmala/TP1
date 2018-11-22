using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using TP1Test;

namespace TP1APP
{
    class Program
    {
        public static void Main(string[] args)
        {
            DataRepository repo = new DataRepository(new WypelnianieSposob2(100));
            Console.WriteLine(repo.PobierzWszystkieZdarzenia());
        }
    }
}
