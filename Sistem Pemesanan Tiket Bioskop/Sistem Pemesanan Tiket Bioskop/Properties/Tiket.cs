using System;
using System.Collections.Generic;

namespace Sistem_Pemesanan_Tiket_Bioskop.Properties
{
    public class Tiket
    {
        private string id;
        private string jenis;
        private double harga;
        private Film film;
        private Jadwal jadwal; 
        private static List<Tiket> tiketTersedia = new List<Tiket>();

        public Tiket(string id, string jenis, double harga, Film film, Jadwal jadwal)
        {
            this.id = id;
            this.jenis = jenis;
            this.harga = harga;
            this.film = film;
            this.jadwal = jadwal;
            tiketTersedia.Add(this);
            jadwal.TambahkanTiket(this); 
        }

        public double GetHarga()
        {
            return harga;
        }

        public string GetId()
        {
            return id;
        }

        public virtual string GetInfo()
        {
            return $"ID Tiket: {id}, Jenis: {jenis}, Harga: {harga}, Film: {film.GetJudul()}";
        }

        public static void HapusTiket(Tiket tiket)
        {
            tiketTersedia.Remove(tiket);
            Console.WriteLine($"Tiket dengan ID {tiket.id} telah dihapus.");
        }


        public static void TampilkanTiketTersedia()
        {
            Console.WriteLine("\nTiket yang Tersedia:");
            foreach (var tiket in tiketTersedia)
            {
                Console.WriteLine(tiket.GetInfo());
            }
        }
    }
}
