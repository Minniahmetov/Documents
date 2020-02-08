using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Documents
{
    public class TablePart : IEnumerable
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

        public int Count(TablePart tablePart)
        {
            return Strings.Count;
        }

        public IEnumerator GetEnumerator()
        {
            return Strings.GetEnumerator();
        }
    }
}
