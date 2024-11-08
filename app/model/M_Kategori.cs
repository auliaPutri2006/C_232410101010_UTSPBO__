using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_232410101010_utspbo.app.model
{
    public class M_Kategori
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string nama_kategori { get; set; }
    }
}
