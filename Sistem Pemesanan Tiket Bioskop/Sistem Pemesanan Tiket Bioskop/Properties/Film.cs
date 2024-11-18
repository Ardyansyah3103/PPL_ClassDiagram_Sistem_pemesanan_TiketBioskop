using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Pemesanan_Tiket_Bioskop.Properties
{
    // Kelas Film
    public class Film
    {
        private string judul;
        private int durasi; // dalam menit
        private string genre;
        private static List<Film> daftarFilm = new List<Film>();

        public Film(string judul, int durasi, string genre)
        {
            this.judul = judul;
            this.durasi = durasi;
            this.genre = genre;
            daftarFilm.Add(this);
        }

        public string GetInfo()
        {
            return $"Judul: {judul}, Durasi: {durasi} menit, Genre: {genre}";
        }

        public static void TampilkanDaftarFilm()
        {
            Console.WriteLine("Daftar Film:");
            foreach (var film in daftarFilm)
            {
                Console.WriteLine(film.GetInfo());
            }
        }
    }
}
