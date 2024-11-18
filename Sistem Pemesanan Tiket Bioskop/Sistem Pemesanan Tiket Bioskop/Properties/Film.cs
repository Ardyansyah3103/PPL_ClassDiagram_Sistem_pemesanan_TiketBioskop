using System;
using System.Collections.Generic;

namespace Sistem_Pemesanan_Tiket_Bioskop.Properties
{
    public class Film
    {
        private string judul;
        private int durasi; 
        private string genre;
        private static List<Film> daftarFilm = new List<Film>();

        public Film(string judul, int durasi, string genre)
        {
            this.judul = judul;
            this.durasi = durasi;
            this.genre = genre;
            daftarFilm.Add(this);
        }

        public string GetJudul()
        {
            return judul;
        }

        public int GetDurasi()
        {
            return durasi;
        }

        public string GetGenre()
        {
            return genre;
        }

        public static void TampilkanDaftarFilm()
        {
            Console.WriteLine("Daftar Film:");
            foreach (var film in daftarFilm)
            {
                Console.WriteLine($"- Judul: {film.GetJudul()}, Durasi: {film.GetDurasi()} menit, Genre: {film.GetGenre()}");
            }
        }
    }
}
