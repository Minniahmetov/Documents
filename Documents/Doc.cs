using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documents
{
    public class Doc
    {
        public int id { get; set; }
        public string DocType;
        public DateTime DocCreateTime;
        public TablePart DocTablePart;
    }
}
