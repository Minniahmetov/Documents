namespace Documents
{
    partial class AddDoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowDelete = new System.Windows.Forms.Button();
            this.docContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.docContextBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rowAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docContextBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docContextBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Поступление",
            "Списание"});
            this.comboBox1.Location = new System.Drawing.Point(39, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(39, 78);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.name,
            this.quantity,
            this.balance});
            this.dataGridView1.Location = new System.Drawing.Point(39, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(531, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // number
            // 
            this.number.HeaderText = "№";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // name
            // 
            this.name.HeaderText = "Наименование";
            this.name.Name = "name";
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Количество";
            this.quantity.Name = "quantity";
            // 
            // balance
            // 
            this.balance.HeaderText = "Остаток";
            this.balance.Name = "balance";
            this.balance.ReadOnly = true;
            // 
            // rowDelete
            // 
            this.rowDelete.Location = new System.Drawing.Point(180, 138);
            this.rowDelete.Name = "rowDelete";
            this.rowDelete.Size = new System.Drawing.Size(106, 23);
            this.rowDelete.TabIndex = 3;
            this.rowDelete.Text = "Удалить строку";
            this.rowDelete.UseVisualStyleBackColor = true;
            this.rowDelete.Click += new System.EventHandler(this.rowDelete_Click);
            // 
            // docContextBindingSource
            // 
            this.docContextBindingSource.DataSource = typeof(Documents.classes.DocContext);
            // 
            // docContextBindingSource1
            // 
            this.docContextBindingSource1.DataSource = typeof(Documents.classes.DocContext);
            // 
            // rowAdd
            // 
            this.rowAdd.Location = new System.Drawing.Point(39, 138);
            this.rowAdd.Name = "rowAdd";
            this.rowAdd.Size = new System.Drawing.Size(107, 23);
            this.rowAdd.TabIndex = 4;
            this.rowAdd.Text = "Добавить строку";
            this.rowAdd.UseVisualStyleBackColor = true;
            this.rowAdd.Click += new System.EventHandler(this.rowAdd_Click);
            // 
            // AddDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rowAdd);
            this.Controls.Add(this.rowDelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Name = "AddDoc";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AddDoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docContextBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docContextBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource docContextBindingSource;
        private System.Windows.Forms.BindingSource docContextBindingSource1;
        private System.Windows.Forms.Button rowDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn balance;
        private System.Windows.Forms.Button rowAdd;
    }
}