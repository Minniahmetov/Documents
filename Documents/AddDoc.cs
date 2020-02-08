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
            //using (DocContext db = new DocContext())
            //{
                int ColIndex = dataGridView1.CurrentCell.ColumnIndex;
                if (ColIndex == 1)
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
                else if (ColIndex == 2)
                {
                TextBox tb1 = e.Control as TextBox;
                tb1.AutoCompleteMode = AutoCompleteMode.None;
                if (tb1 != null)
                {
                    tb1.KeyPress += new KeyPressEventHandler(CheckKey);
                }
                }
            //}
        }

        private void CheckKey(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
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
            rowDelete.Enabled = false;
        }

        private void rowDelete_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 1);
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                EnableRowDeleteButton(dataGridView1.Rows.Count);
            }
        }

        private void rowAdd_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            EnableRowDeleteButton(dataGridView1.Rows.Count);
        }

        private void EnableRowDeleteButton(int count)
        {
            if (count > 1)
            {
                rowDelete.Enabled = true;
            }
            else if (count == 1)
            {
                rowDelete.Enabled = false;
            }
            else if (count < 1)
            {
                // что то пошле не так
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.Columns.Count > 0 )
            {
                dataGridView1.Rows[e.RowIndex].Cells[3].Value = "0";
            }
            //dataGridView1.Rows[0].Cells[3].Value = "999";
            //if (e.ColumnIndex == 1)
            //{
            //    DataGridView grid = sender as DataGridView;
            //    if (e.RowIndex > dataGridView1.Rows.Count)
            //    {
            //        return;
            //    }
            //    else
            //    {
            //        dataGridView1.Rows[0].Cells[0].Value = (999).ToString();
            //    }
                
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            using (DocContext db = new DocContext()) 
            {

                Doc newDoc = new Doc();
                newDoc.DocCreateTime = DateTime.Now;
                newDoc.DocType = comboBox1.SelectedItem.ToString();
                TablePart tablePart = new TablePart();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    string nameCellValue = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    if (db.Goods.FirstOrDefault(Good => Good.name == nameCellValue) != null)
                    {
                        TablePartString tablePartString = new TablePartString();
                        tablePartString.serial = i;
                        tablePartString.Good = db.Goods.FirstOrDefault(Good => Good.name == nameCellValue);
                        tablePartString.quantity = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                        tablePartString.balance = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                        tablePart.AddString(tablePartString);
                    }
                    else
                    {
                        MessageBox.Show("Документ НЕ сохранен");
                        return;
                    }
                    
                }
                newDoc.DocTablePart = tablePart;
                

                db.Docs.Add(newDoc);
                foreach (TablePartString stringWhithGoodForAddBalance in tablePart)
                {
                    string goodNameForAddBalance = stringWhithGoodForAddBalance.Good.name.ToString();
                    Good goodForAddBalance = db.Goods.FirstOrDefault(Good => Good.name == goodNameForAddBalance);
                    goodForAddBalance.balance += int.Parse(stringWhithGoodForAddBalance.balance.ToString());
                    try
                    {
                        db.SaveChanges();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Не удалось сохранить изменения в " + stringWhithGoodForAddBalance.serial.ToString() + " строке документа!");
                        throw;
                    }
                }
                //string goodName = dataGridView1.Rows[0].Cells[1].Value.ToString();
                //Good goodItem = db.Goods.FirstOrDefault(Good => Good.name == goodName);
                //goodItem.balance += int.Parse(dataGridView1.Rows[0].Cells[2].Value.ToString());
                //db.SaveChanges();
             

                MessageBox.Show("Документ сохранен");

            }
        }
    }
}
