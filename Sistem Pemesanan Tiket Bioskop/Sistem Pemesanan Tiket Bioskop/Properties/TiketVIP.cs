﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Pemesanan_Tiket_Bioskop.Properties
{
    class TiketVIP : Tiket
    {
        private string fasilitasTambahan;

        public TiketVIP(string id, double harga, string fasilitasTambahan) : base(id, "VIP", harga)
        {
            this.fasilitasTambahan = fasilitasTambahan;
        }

        // Gunakan override
        public override string GetInfo()
        {
            return base.GetInfo() + $", Fasilitas Tambahan: {fasilitasTambahan}";
        }
    }
}