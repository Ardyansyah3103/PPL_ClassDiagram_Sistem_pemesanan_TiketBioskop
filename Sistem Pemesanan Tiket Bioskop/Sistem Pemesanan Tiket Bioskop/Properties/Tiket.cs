using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Pemesanan_Tiket_Bioskop.Properties
{
    // Kelas Tiket (Generalization)
    // Kelas Tiket (Generalization)
    class Tiket
    {
        protected string id;
        protected string jenis;
        protected double harga;

        public Tiket(string id, string jenis, double harga)
        {
            this.id = id;
            this.jenis = jenis;
            this.harga = harga;
        }

        // Tandai metode ini sebagai virtual
        public virtual string GetInfo()
        {
            return $"ID Tiket: {id}, Jenis: {jenis}, Harga: {harga}";
        }

        public double GetHarga()
        {
            return harga;
        }
    }
}
