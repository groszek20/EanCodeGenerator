using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorKodów
{
    public class ZakresKodu
    {
        public String wartosc
        {
            get;
            private set;
        }

        public ZakresKodu(String nWartosc)
        {
            wartosc = nWartosc;
        }
    }
}
