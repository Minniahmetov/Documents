using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documents
{
    public class TablePart
    {
        public List<TablePartString> Strings;
        public TablePart() { Strings = new List<TablePartString>(); }   

        public void AddString(TablePartString String4Add)
        {
            //if (Strings.Count <= 0)
            //{
            //   Strings = new List<TablePartString>();
            //}
            Strings.Add(String4Add);
        }
    }
}
