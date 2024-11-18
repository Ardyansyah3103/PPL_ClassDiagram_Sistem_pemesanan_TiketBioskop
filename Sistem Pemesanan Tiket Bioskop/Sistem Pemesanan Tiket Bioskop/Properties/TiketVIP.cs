using System;

namespace Sistem_Pemesanan_Tiket_Bioskop.Properties
{
    public class TiketVIP : Tiket
    {
        private string fasilitasTambahan;

        public TiketVIP(string id, double harga, string fasilitasTambahan, Film film, Jadwal jadwal)
            : base(id, "VIP", harga, film, jadwal) 
        {
            this.fasilitasTambahan = fasilitasTambahan;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $", Fasilitas Tambahan: {fasilitasTambahan}";
        }
    }
}
