using System;

namespace Sistem_Pemesanan_Tiket_Bioskop.Properties
{
    public class TiketReguler : Tiket
    {
        public TiketReguler(string id, double harga, Film film, Jadwal jadwal)
            : base(id, "Reguler", harga, film, jadwal) 
        {
        }
    }
}
