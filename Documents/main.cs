﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Documents.classes;

namespace Documents
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            using (DocContext db = new DocContext())
            {
                //Doc Doc1 = new Doc();
                //Doc1.id = 1;
                //Doc1.DocType = "income";
                //Doc1.DocCreateTime = DateTime.Now;
                //TablePartString String1 = new TablePartString();
                //Good Good1 = new Good();
                //Good1.id = 1;
                //Good1.name = "STL-25";
                //Good Good2 = new Good();
                //Good2.id = 2;
                //Good2.name = "SV-400";
                //String1.Good = Good1;
                //String1.quantity = 10;
                //String1.balance = 5;
                //Doc1.DocTablePart = new TablePart();
                //Doc1.DocTablePart.AddString(String1);
                //TablePartString String2 = new TablePartString();
                //String2.Good = Good2;
                //String2.quantity = 2;
                //String2.balance = 0;
                //Doc1.DocTablePart.AddString(String2);
                //List<Doc> Docs = new List<Doc>();
                //Docs.Add(Doc1);
                var DocList = db.Docs;
                this.objectListView1.SetObjects(DocList);
            }
        }

        private void AddGood_Click(object sender, EventArgs e)
        {
            AddGood AddGoodForm = new AddGood();
            AddGoodForm.Show();
        }

        private void AddDoc_Click(object sender, EventArgs e)
        {
            AddDoc AddDocForm = new AddDoc();
            AddDocForm.Show();
        }

        private void objectListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
