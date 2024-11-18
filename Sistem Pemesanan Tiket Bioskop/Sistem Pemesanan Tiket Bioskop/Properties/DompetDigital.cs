using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Pemesanan_Tiket_Bioskop.Properties
{
    public class DompetDigital : Pembayaran
    {
        public void ProsesPembayaran(double jumlah)
        {
            Console.WriteLine("Pembayaran melalui dompet digital sejumlah: " + jumlah);
        }
    }
}
