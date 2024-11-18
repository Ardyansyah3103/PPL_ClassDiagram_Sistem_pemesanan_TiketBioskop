using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Pemesanan_Tiket_Bioskop.Properties
{
    // Kelas Film
    // Kelas Film
    class Film
    {
        private string judul;
        private int durasi; // dalam menit
        private string genre;

        public Film(string judul, int durasi, string genre)
        {
            this.judul = judul;
            this.durasi = durasi;
            this.genre = genre;
        }

        public string GetJudul()
        {
            return judul;
        }

        public string GetInfo()
        {
            return $"Judul: {judul}, Durasi: {durasi} menit, Genre: {genre}";
        }
    }
}
