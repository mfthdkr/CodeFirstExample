using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExample.Entity
{
    public class Context : DbContext
    {
        public  DbSet<Urunler> Urunlers { get; set; }
        public  DbSet<Kategori> Kategoris { get; set; }
    }
}
