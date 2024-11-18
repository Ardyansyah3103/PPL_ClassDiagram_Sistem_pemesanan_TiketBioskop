using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Pemesanan_Tiket_Bioskop.Properties
{
    // Kelas Pengguna
    class Pengguna
    {
        private string nama;
        private string email;
        private string nomorTelepon;

        public Pengguna(string nama, string email, string nomorTelepon)
        {
            this.nama = nama;
            this.email = email;
            this.nomorTelepon = nomorTelepon;
        }

        public string GetInfo()
        {
            return $"Nama: {nama}, Email: {email}, Nomor Telepon: {nomorTelepon}";
        }
    }
}
