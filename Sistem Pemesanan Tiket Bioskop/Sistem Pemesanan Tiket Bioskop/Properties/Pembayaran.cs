using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Pemesanan_Tiket_Bioskop.Properties
{
    // Interface Pembayaran
    public interface Pembayaran
    {
        void ProsesPembayaran(double jumlah);
    }
}
