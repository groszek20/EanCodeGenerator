using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorKodów
{
    class Generator
    {
        private int[] EAN13 = new int[13];

        public String generujKodProduktu(int zakresMinimum, int zakresMaksimum)
        {
            System.Random kod = new Random(DateTime.Now.Millisecond);
            int x = kod.Next(zakresMinimum, zakresMaksimum);
            String kodProduktu=x.ToString();
            return kodProduktu;
        }

        public String generujCyfręKontrolną(String gckPrefix, String gckKodPoducenta,
            String gckKodProduktu) {

            String numer = gckPrefix + gckKodPoducenta + gckKodProduktu;

            for (int i = 0; i < 12; i++)
            {
                EAN13[i] = int.Parse(numer.Substring(i, i-i+1));
            }

            int sum = 1 * EAN13[0] + 3 * EAN13[1] + 1 * EAN13[2] + 3 * EAN13[3] +
             1 * EAN13[4] + 3 * EAN13[5] + 1 * EAN13[6] + 3 * EAN13[7] + 1 * EAN13[8]
             + 3 * EAN13[9] + 1 * EAN13[10] + 3 * EAN13[11] + 1 * EAN13[12];

            sum %= 10;
            sum = 10 - sum;
            sum %= 10;

            String cyfraKontrolna = sum.ToString();
            return cyfraKontrolna;

        }

        public String zwróćZera(String liczba)
        {
            String zero = "0";
            String tmp = "";
            String liczbaZer = null;
            for (int i = liczba.Length; i <= 4; i++)
            {
                tmp = tmp + zero;
            }

            liczbaZer = tmp;
            return liczbaZer + liczba;
        }
    }
}
