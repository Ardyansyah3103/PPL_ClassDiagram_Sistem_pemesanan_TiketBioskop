using Sistem_Pemesanan_Tiket_Bioskop.Properties;
using System;

namespace Sistem_Pemesanan_Tiket_Bioskop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Membuat objek Film
            Film film1 = new Film("Interstellar", 169, "Sci-Fi");
            Film film2 = new Film("Inception", 148, "Sci-Fi");
            Film film3 = new Film("Dunkirk", 106, "War/Drama");

            // Menampilkan daftar film
            Console.WriteLine("== DAFTAR FILM ==");
            Film.TampilkanDaftarFilm();

            // Membuat jadwal
            Jadwal jadwal1 = new Jadwal("J001", "12:00", "15:00", "Studio 1", film1);
            Jadwal jadwal2 = new Jadwal("J002", "16:00", "18:30", "Studio 2", film2);

            // Membuat tiket yang terkait dengan jadwal
            Tiket tiket1 = new TiketReguler("T001", 50000, film1, jadwal1);
            Tiket tiket2 = new TiketVIP("T002", 100000, "Minuman Gratis", film2, jadwal2);
            Tiket tiket3 = new TiketReguler("T003", 45000, film3, jadwal1);
            Tiket tiket4 = new TiketVIP("T004", 120000, "Snack dan Minuman Gratis", film1, jadwal1);
            Tiket tiket5 = new TiketVIP("T005", 170000, "Makan Gratis", film2, jadwal2);

            // Menampilkan tiket yang tersedia
            Console.WriteLine("\n== TIKET TERSEDIA ==");
            Tiket.TampilkanTiketTersedia();

            // Menghapus salah satu tiket secara langsung
            Tiket.HapusTiket(tiket5);
            Console.WriteLine("\n== TIKET TERSEDIA (Setelah Menghapus Tiket)==");
            Tiket.TampilkanTiketTersedia();

            // Menampilkan daftar jadwal
            Jadwal.TampilkanDaftarJadwal();

            // Menghapus jadwal beserta tiket terkait
            Console.WriteLine("\nMenghapus Jadwal:");
            jadwal1.HapusJadwal(); // Menghapus jadwal dan semua tiket terkait

            // Menampilkan tiket setelah jadwal dihapus
            Console.WriteLine("\nDaftar Tiket setelah Jadwal dihapus:");
            Tiket.TampilkanTiketTersedia(); // Tiket yang terkait dengan jadwal1 harus dihapus

            // Proses pembayaran contoh
            Console.WriteLine("\n== PROSES PEMBAYARAN ==");
            double totalHarga = tiket1.GetHarga() + tiket2.GetHarga() + tiket3.GetHarga() + tiket4.GetHarga();
            Console.WriteLine($"Total harga tiket yang harus dibayar: Rp{totalHarga}");

            Console.WriteLine("\nPilih metode pembayaran:");
            Console.WriteLine("1. Dompet Digital");
            Console.WriteLine("2. Transfer Bank");
            Console.Write("Masukkan pilihan (1/2): ");
            int pilihan = Convert.ToInt32(Console.ReadLine());

            Pembayaran pembayaran;
            if (pilihan == 1)
            {
                pembayaran = new DompetDigital();
            }
            else if (pilihan == 2)
            {
                pembayaran = new TransferBank();
            }
            else
            {
                Console.WriteLine("Pilihan tidak valid. Pembayaran dibatalkan.");
                return;
            }

            pembayaran.ProsesPembayaran(totalHarga);
        }
    }
}
