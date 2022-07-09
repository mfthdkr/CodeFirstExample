using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExample.Entity
{
    public class Kategori
    {
        [Key]
        public int KategoriId { get; set; }
        public  string KategoriAd { get; set; }
    }
}
