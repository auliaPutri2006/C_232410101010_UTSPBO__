using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_232410101010_utspbo.app.model
{
    public class M_Barang
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string nama_barang { get; set; }
        [Required]
        public int jumlah { get; set; }
        [Required]
        public int harga_barang { get; set; }

        public int id_kategoeri { get; set; }
        [ForeignKey(M_Kategori)]
    }
    
}
