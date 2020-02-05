namespace Documents
{
    partial class AddGood
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
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.OK_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.good_id = new System.Windows.Forms.Label();
            this.good_name = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(167, 55);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 20);
            this.textBox_id.TabIndex = 0;
            this.textBox_id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(167, 109);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 20);
            this.textBox_name.TabIndex = 1;
            // 
            // OK_button
            // 
            this.OK_button.Location = new System.Drawing.Point(167, 156);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(75, 23);
            this.OK_button.TabIndex = 2;
            this.OK_button.Text = "ОК";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(259, 156);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 3;
            this.cancel_button.Text = "Отмена";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // good_id
            // 
            this.good_id.AutoSize = true;
            this.good_id.Location = new System.Drawing.Point(116, 55);
            this.good_id.Name = "good_id";
            this.good_id.Size = new System.Drawing.Size(26, 13);
            this.good_id.TabIndex = 4;
            this.good_id.Text = "Код";
            // 
            // good_name
            // 
            this.good_name.AutoSize = true;
            this.good_name.Location = new System.Drawing.Point(69, 112);
            this.good_name.Name = "good_name";
            this.good_name.Size = new System.Drawing.Size(83, 13);
            this.good_name.TabIndex = 5;
            this.good_name.Text = "Наименование";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add(this.olvColumn1);
            this.objectListView1.AllColumns.Add(this.olvColumn2);
            this.objectListView1.CellEditUseWholeCell = false;
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2});
            this.objectListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView1.HideSelection = false;
            this.objectListView1.Location = new System.Drawing.Point(399, 55);
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.Size = new System.Drawing.Size(375, 163);
            this.objectListView1.TabIndex = 6;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "id";
            this.olvColumn1.Text = "Код";
            this.olvColumn1.Width = 119;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "name";
            this.olvColumn2.Text = "Наименование";
            this.olvColumn2.Width = 93;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // AddGood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.objectListView1);
            this.Controls.Add(this.good_name);
            this.Controls.Add(this.good_id);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_id);
            this.Name = "AddGood";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Label good_id;
        private System.Windows.Forms.Label good_name;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private BrightIdeasSoftware.ObjectListView objectListView1;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}