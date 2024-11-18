using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Pemesanan_Tiket_Bioskop.Properties
{
    // Kelas Jadwal (Komposisi)
    class Jadwal
    {
        private string id;
        private string waktuMulai;
        private string waktuSelesai;
        private string ruangan;
        private List<Tiket> tiketTerjual = new List<Tiket>();

        public Jadwal(string id, string waktuMulai, string waktuSelesai, string ruangan)
        {
            this.id = id;
            this.waktuMulai = waktuMulai;
            this.waktuSelesai = waktuSelesai;
            this.ruangan = ruangan;
        }

        public void TambahkanTiket(Tiket tiket)
        {
            tiketTerjual.Add(tiket);
        }

        public string GetInfo()
        {
            return $"ID Jadwal: {id}, Waktu Mulai: {waktuMulai}, Waktu Selesai: {waktuSelesai}, Ruangan: {ruangan}";
        }

        public List<Tiket> GetTiketTerjual()
        {
            return tiketTerjual;
        }
    }
}
