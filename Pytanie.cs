using System;
using System.Collection.Generic;
using System.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz {
    class Pytanie {

        public int id { get; set; }
        public string odp1 { get; set; }
        public string odp2 { get; set; }
        public string odp2 { get; set; }
        public string odp3 { get; set; }
        public string tresc { get; set; }
        public int kategoria { get; set; }

        public void PokazNaEkranieX() { // Void nic nie zwraca
            Console.WriteLine("X");
        }

        public int dodaj(int x, int y) { 
            return x + y;
        }

    }
}