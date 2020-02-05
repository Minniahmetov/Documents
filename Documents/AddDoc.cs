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
    public partial class AddDoc : Form
    {
        public AddDoc()
        {
            InitializeComponent();
            using (DocContext db = new DocContext())
            {
                //var GoodsList = db.Goods;

                //    name.DataSource = GoodsList.ToList();
                //    name.DisplayMember = "name";
                //    name.ValueMember = "name";
                //    name.MaxDropDownItems = 5;
                //name.Items.Add("Найти");
                //name.Items.Add("Добавить");


                //{
                //    name.DataSource = db.Goods;
                //    name.DisplayMember = "Name";
                //    name.ValueMember = "id";
                //}
                //catch (Exception)
                //{

                //   name.Items.Add("None");
                //}

                //name.Items.Add("Добавить из списка");
                //foreach (Good g in db.Goods) name.Items.Add(g);
                //name.DisplayMember = "name";
                //name.ValueMember = "name";
                //name.Items.Add("Найти");
                //name.Items.Add("Добавить");
                //name.AutoComplete = false;
                //name.MaxDropDownItems = 5;
                dataGridView1.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dataGridView1_EditingControlShowing);
                dataGridView1.RowsAdded += new DataGridViewRowsAddedEventHandler(dataGridView1_RowsAdded);
                dataGridView1.RowsRemoved += new DataGridViewRowsRemovedEventHandler(dataGridView1_RowsRemoved);

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridView grid = sender as DataGridView;
            for (int i = 0; i < grid.Rows.Count; i++)
            {
                grid.Rows[i].Cells[0].Value = (i+1).ToString();
            }
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            DataGridView grid = sender as DataGridView;
            for (int i = 0; i < grid.Rows.Count; i++)
            {
                grid.Rows[i].Cells[0].Value = (i+1).ToString();
            }
        }
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            using (DocContext db = new DocContext())
            {
                string titleText = name.HeaderText;
                if (titleText.Equals("Наименование"))
                {
                    TextBox autoText = e.Control as TextBox;
                    if (autoText != null)
                    {
                        autoText.AutoCompleteMode = AutoCompleteMode.Suggest;
                        autoText.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
                        addItems(DataCollection);
                        autoText.AutoCompleteCustomSource = DataCollection;
                    }
                }
            }
        }

        public void addItems(AutoCompleteStringCollection col)
        {
            using (DocContext db = new DocContext())
            {
                foreach (Good g in db.Goods) col.Add(g.name);
            }
        }

        private void AddDoc_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            dataGridView1.Rows[0].Cells[0].Value = "1";
        }

        private void rowDelete_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 1);
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
        }

        private void rowAdd_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
        }
    }
}
