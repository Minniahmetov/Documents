﻿namespace Documents
{
    partial class main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.AddGood = new System.Windows.Forms.Button();
            this.AddDoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add(this.olvColumn1);
            this.objectListView1.AllColumns.Add(this.olvColumn2);
            this.objectListView1.AllColumns.Add(this.olvColumn3);
            this.objectListView1.CellEditUseWholeCell = false;
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3});
            this.objectListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView1.HideSelection = false;
            this.objectListView1.Location = new System.Drawing.Point(56, 36);
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.Size = new System.Drawing.Size(637, 292);
            this.objectListView1.TabIndex = 0;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            this.objectListView1.SelectedIndexChanged += new System.EventHandler(this.objectListView1_SelectedIndexChanged);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "id";
            this.olvColumn1.Text = "Номер";
            this.olvColumn1.Width = 57;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "DocType";
            this.olvColumn2.Text = "Тип документа";
            this.olvColumn2.Width = 139;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "DocCreateTime";
            this.olvColumn3.Text = "Дата";
            this.olvColumn3.Width = 179;
            // 
            // AddGood
            // 
            this.AddGood.Location = new System.Drawing.Point(56, 346);
            this.AddGood.Name = "AddGood";
            this.AddGood.Size = new System.Drawing.Size(75, 23);
            this.AddGood.TabIndex = 1;
            this.AddGood.Text = "AddGood";
            this.AddGood.UseVisualStyleBackColor = true;
            this.AddGood.Click += new System.EventHandler(this.AddGood_Click);
            // 
            // AddDoc
            // 
            this.AddDoc.Location = new System.Drawing.Point(56, 4);
            this.AddDoc.Name = "AddDoc";
            this.AddDoc.Size = new System.Drawing.Size(175, 23);
            this.AddDoc.TabIndex = 2;
            this.AddDoc.Text = "Создать документ";
            this.AddDoc.UseVisualStyleBackColor = true;
            this.AddDoc.Click += new System.EventHandler(this.AddDoc_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddDoc);
            this.Controls.Add(this.AddGood);
            this.Controls.Add(this.objectListView1);
            this.Name = "main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView objectListView1;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private System.Windows.Forms.Button AddGood;
        private System.Windows.Forms.Button AddDoc;
    }
}

