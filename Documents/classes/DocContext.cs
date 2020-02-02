using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Documents.classes
{
    public class DocContext : DbContext
    {
        public DocContext()
            :base("DbConnection")
        {}
        public DbSet<Doc> Docs { get; set; }
        public DbSet<Good> Goods { get; set; }
    }
}
