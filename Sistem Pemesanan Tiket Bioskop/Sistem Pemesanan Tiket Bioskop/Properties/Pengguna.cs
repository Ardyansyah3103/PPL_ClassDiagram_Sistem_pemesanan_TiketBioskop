using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Pemesanan_Tiket_Bioskop.Properties
{ 
    public class Pengguna
    {
        private string nama;
        private string email;
        private string nomorTelepon;
        private static List<Pengguna> daftarPengguna = new List<Pengguna>();

        public Pengguna(string nama, string email, string nomorTelepon)
        {
            this.nama = nama;
            this.email = email;
            this.nomorTelepon = nomorTelepon;
            daftarPengguna.Add(this);
        }

        public string GetInfo()
        {
            return $"Nama: {nama}, Email: {email}, Nomor Telepon: {nomorTelepon}";
        }

        public static void TampilkanPelanggan()
        {
            Console.WriteLine("\nDaftar Pelanggan:");
            foreach (var pengguna in daftarPengguna)
            {
                Console.WriteLine(pengguna.GetInfo());
            }
        }

        
        public void ProsesPembayaran(Tiket tiket, Pembayaran pembayaran)
        {
            Console.WriteLine($"\n{nama} memproses pembayaran untuk tiket dengan ID: {tiket.GetId()}");
            pembayaran.ProsesPembayaran(tiket.GetHarga());
        }
    }
}
