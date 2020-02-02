using System;
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
    public partial class AddGood : Form
    {
        public AddGood()
        {
            InitializeComponent();
            using (DocContext db = new DocContext())
            {
                var GoodsList = db.Goods;
                this.objectListView1.SetObjects(GoodsList);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (DocContext db = new DocContext())
            {
                if (!String.IsNullOrEmpty(textBox_name.Text))
                {
                    var CheckGood = db.Goods.FirstOrDefault(Good => Good.name == textBox_name.Text);
                    if (CheckGood == null)
                    {
                        Good good = new Good();
                        good.name = textBox_name.Text;

                        db.Goods.Add(good);
                        db.SaveChanges();
                        objectListView1.Refresh();
                        errorProvider1.Clear();
                        this.Close();

                    }
                    else
                    {
                        errorProvider1.SetError(textBox_name, "Не уникальное имя комплектующей!");
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
