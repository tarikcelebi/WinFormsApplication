using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApplication
{
    public class Customer
    {
        public string Telefon { get; set; }
        public string IsimSoyisim { get; set; }
        public int Yas { get; set; }
        public string Adres { get; set; }

        public Customer(string telefon, string isimSoyisim, int yas, string adres)
        {
            Telefon = telefon;
            IsimSoyisim = isimSoyisim;
            Yas = yas;
            Adres = adres;
        }
    }
}
