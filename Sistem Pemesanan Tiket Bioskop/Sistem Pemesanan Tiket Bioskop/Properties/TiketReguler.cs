using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Pemesanan_Tiket_Bioskop.Properties
{
    public class TiketReguler : Tiket
    {
        public TiketReguler(string id, double harga) : base(id, "Reguler", harga) { }
    }
}
