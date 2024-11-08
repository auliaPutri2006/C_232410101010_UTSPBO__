using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_232410101010_utspbo.app;
using C_232410101010_utspbo.app.core;
using C_232410101010_utspbo.view;

namespace C_232410101010_utspbo.app.context
{
    internal class BarangContext : DataWrapper
    {
        private static string table = "Barang";

        public static DataTable All()
        {
            string query = @"SELECT b.id,b.nama_barang, b.jumlah, b.harga_barang, k.id_kategori, k.nama_kategori 
                            FROM barang b join 
                            JOIN kategori k
                             ON b.id_kategori = k.id_kategori"
        }
    }
}
