using System;
using System.Collections.Generic;

namespace Sistem_Pemesanan_Tiket_Bioskop.Properties
{
    public class Jadwal
    {
        private string id;
        private string waktuMulai;
        private string waktuSelesai;
        private string ruangan;
        private Film film;
        private static List<Jadwal> daftarJadwal = new List<Jadwal>();
        private List<Tiket> tiketTerjual = new List<Tiket>();

        public Jadwal(string id, string waktuMulai, string waktuSelesai, string ruangan, Film film)
        {
            this.id = id;
            this.waktuMulai = waktuMulai;
            this.waktuSelesai = waktuSelesai;
            this.ruangan = ruangan;
            this.film = film;
            daftarJadwal.Add(this);
        }

        public void TambahkanTiket(Tiket tiket)
        {
            tiketTerjual.Add(tiket);
        }

        public string Id
        {
            get { return id; }
        }

        public void HapusJadwal()
        {
            Console.WriteLine($"Menghapus jadwal {Id} untuk film {film.GetJudul()} dan semua tiketnya...");
            foreach (var tiket in tiketTerjual)
            {
                Tiket.HapusTiket(tiket); 
            }
            tiketTerjual.Clear();
        }


        public string GetInfo()
        {
            return $"ID Jadwal: {id}, Film: {film.GetJudul()}, Waktu Mulai: {waktuMulai}, Waktu Selesai: {waktuSelesai}, Ruangan: {ruangan}";
        }

        public static void TampilkanDaftarJadwal()
        {
            Console.WriteLine("\nDaftar Jadwal:");
            foreach (var jadwal in daftarJadwal)
            {
                Console.WriteLine(jadwal.GetInfo());
            }
        }
    }
}
