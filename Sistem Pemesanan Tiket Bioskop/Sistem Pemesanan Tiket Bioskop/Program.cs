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
        public static void Main(string[] args)
        {
            // Membuat objek dan menambahkan ke daftar
            Film film = new Film("Interstellar", 169, "Sci-Fi");
            Jadwal jadwal = new Jadwal("J001", "10:00", "12:49", "Studio 1");
            Tiket tiket1 = new TiketReguler("T001", 50000);
            Tiket tiket2 = new TiketVIP("T002", 100000, "Minuman Gratis");
            jadwal.TambahkanTiket(tiket1);
            jadwal.TambahkanTiket(tiket2);
            Pengguna pengguna = new Pengguna("John Doe", "john.doe@example.com", "081234567890");

            // Menampilkan daftar melalui metode di kelas masing-masing
            Film.TampilkanDaftarFilm();
            Jadwal.TampilkanDaftarJadwal();
            Tiket.TampilkanTiketTersedia();
            Pengguna.TampilkanPelanggan();

            // Proses pembayaran
            Console.WriteLine("\nProses Pembayaran:");
            double totalHarga = tiket1.GetHarga() + tiket2.GetHarga();
            Pembayaran pembayaran = new DompetDigital(); // Anda bisa mengganti dengan TransferBank jika diperlukan
            pembayaran.ProsesPembayaran(totalHarga);
        }
    }
}
