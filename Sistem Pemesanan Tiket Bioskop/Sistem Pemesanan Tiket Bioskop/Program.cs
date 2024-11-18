using Sistem_Pemesanan_Tiket_Bioskop.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Pemesanan_Tiket_Bioskop
{
    public class Program
    {
        private static List<Film> daftarFilm = new List<Film>();
        private static List<Jadwal> daftarJadwal = new List<Jadwal>();
        private static List<Tiket> tiketTersedia = new List<Tiket>();
        private static List<Pengguna> daftarPengguna = new List<Pengguna>();

        public static void Main(string[] args)
        {
            // Membuat dan menambahkan objek Film ke daftar
            Film film = new Film("Interstellar", 169, "Sci-Fi");
            daftarFilm.Add(film);

            // Membuat Jadwal untuk film dan menambahkannya ke daftar
            Jadwal jadwal = new Jadwal("J001", "10:00", "12:49", "Studio 1");
            daftarJadwal.Add(jadwal);

            // Membuat Tiket dan menambahkannya ke daftar
            Tiket tiket1 = new TiketReguler("T001", 50000);
            Tiket tiket2 = new TiketVIP("T002", 100000, "Minuman Gratis");
            tiketTersedia.Add(tiket1);
            tiketTersedia.Add(tiket2);

            // Menambahkan tiket ke jadwal
            jadwal.TambahkanTiket(tiket1);
            jadwal.TambahkanTiket(tiket2);

            // Membuat Pengguna dan menambahkannya ke daftar
            Pengguna pengguna = new Pengguna("John Doe", "john.doe@example.com", "081234567890");
            daftarPengguna.Add(pengguna);

            // Pembayaran
            Pembayaran pembayaran = new DompetDigital();
            pembayaran.ProsesPembayaran(tiket1.GetHarga() + tiket2.GetHarga());

            // Menampilkan daftar film, jadwal, tiket, dan pelanggan
            TampilkanDaftarFilm();
            TampilkanDaftarJadwal();
            TampilkanTiketTersedia();
            TampilkanPelanggan();
        }

        private static void TampilkanDaftarFilm()
        {
            Console.WriteLine("Daftar Film:");
            foreach (var film in daftarFilm)
            {
                Console.WriteLine(film.GetInfo());
            }
        }

        private static void TampilkanDaftarJadwal()
        {
            Console.WriteLine("\nDaftar Jadwal:");
            foreach (var jadwal in daftarJadwal)
            {
                Console.WriteLine(jadwal.GetInfo());
            }
        }

        private static void TampilkanTiketTersedia()
        {
            Console.WriteLine("\nTiket yang Tersedia:");
            foreach (var tiket in tiketTersedia)
            {
                Console.WriteLine(tiket.GetInfo());
            }
        }

        private static void TampilkanPelanggan()
        {
            Console.WriteLine("\nDaftar Pelanggan:");
            foreach (var pengguna in daftarPengguna)
            {
                Console.WriteLine(pengguna.GetInfo());
            }
        }
    }
}
