using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Pemesanan_Tiket_Bioskop.Properties
{
    // Kelas Tiket (Generalization) / (inheritance)
    public class Tiket
    {
        protected string id;
        protected string jenis;
        protected double harga;
        protected static List<Tiket> tiketTersedia = new List<Tiket>();

        public Tiket(string id, string jenis, double harga)
        {
            this.id = id;
            this.jenis = jenis;
            this.harga = harga;
            tiketTersedia.Add(this);
        } 



        public virtual string GetInfo()
        {
            return $"ID Tiket: {id}, Jenis: {jenis}, Harga: {harga}";
        }

        //getter id
        public string GetId()
        {
            return id;
        }


        // Tambahkan metode GetHarga
        public double GetHarga()
        {
            return harga;
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
