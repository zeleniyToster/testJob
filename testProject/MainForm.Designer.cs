namespace testProject
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.измерениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеАктиваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеБанкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерСчетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.общаяСуммаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.денежныеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDBDataSet = new testProject.testDBDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.начальнаяБалансоваяСтоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.остаточнаяБалансоваяСтоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оценочнаяСтоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.измерениеDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.инвентарныйНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПроизводстваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.краткоеОписаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.неденежныеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.денежныеTableAdapter = new testProject.testDBDataSetTableAdapters.ДенежныеTableAdapter();
            this.неденежныеTableAdapter = new testProject.testDBDataSetTableAdapters.НеденежныеTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.денежныеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDBDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.неденежныеBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1503, 549);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1495, 523);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Денежные активы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.измерениеDataGridViewTextBoxColumn,
            this.наименованиеАктиваDataGridViewTextBoxColumn,
            this.наименованиеБанкаDataGridViewTextBoxColumn,
            this.номерСчетаDataGridViewTextBoxColumn,
            this.общаяСуммаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.денежныеBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1489, 517);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 40;
            // 
            // измерениеDataGridViewTextBoxColumn
            // 
            this.измерениеDataGridViewTextBoxColumn.DataPropertyName = "Измерение";
            this.измерениеDataGridViewTextBoxColumn.HeaderText = "Измерение";
            this.измерениеDataGridViewTextBoxColumn.Name = "измерениеDataGridViewTextBoxColumn";
            this.измерениеDataGridViewTextBoxColumn.ReadOnly = true;
            this.измерениеDataGridViewTextBoxColumn.Width = 90;
            // 
            // наименованиеАктиваDataGridViewTextBoxColumn
            // 
            this.наименованиеАктиваDataGridViewTextBoxColumn.DataPropertyName = "Наименование актива";
            this.наименованиеАктиваDataGridViewTextBoxColumn.HeaderText = "Наименование актива";
            this.наименованиеАктиваDataGridViewTextBoxColumn.Name = "наименованиеАктиваDataGridViewTextBoxColumn";
            this.наименованиеАктиваDataGridViewTextBoxColumn.ReadOnly = true;
            this.наименованиеАктиваDataGridViewTextBoxColumn.Width = 133;
            // 
            // наименованиеБанкаDataGridViewTextBoxColumn
            // 
            this.наименованиеБанкаDataGridViewTextBoxColumn.DataPropertyName = "Наименование банка";
            this.наименованиеБанкаDataGridViewTextBoxColumn.HeaderText = "Наименование банка";
            this.наименованиеБанкаDataGridViewTextBoxColumn.Name = "наименованиеБанкаDataGridViewTextBoxColumn";
            this.наименованиеБанкаDataGridViewTextBoxColumn.ReadOnly = true;
            this.наименованиеБанкаDataGridViewTextBoxColumn.Width = 129;
            // 
            // номерСчетаDataGridViewTextBoxColumn
            // 
            this.номерСчетаDataGridViewTextBoxColumn.DataPropertyName = "Номер счета";
            this.номерСчетаDataGridViewTextBoxColumn.HeaderText = "Номер счета";
            this.номерСчетаDataGridViewTextBoxColumn.Name = "номерСчетаDataGridViewTextBoxColumn";
            this.номерСчетаDataGridViewTextBoxColumn.ReadOnly = true;
            this.номерСчетаDataGridViewTextBoxColumn.Width = 89;
            // 
            // общаяСуммаDataGridViewTextBoxColumn
            // 
            this.общаяСуммаDataGridViewTextBoxColumn.DataPropertyName = "Общая сумма";
            this.общаяСуммаDataGridViewTextBoxColumn.HeaderText = "Общая сумма";
            this.общаяСуммаDataGridViewTextBoxColumn.Name = "общаяСуммаDataGridViewTextBoxColumn";
            this.общаяСуммаDataGridViewTextBoxColumn.ReadOnly = true;
            this.общаяСуммаDataGridViewTextBoxColumn.Width = 95;
            // 
            // денежныеBindingSource
            // 
            this.денежныеBindingSource.DataMember = "Денежные";
            this.денежныеBindingSource.DataSource = this.testDBDataSetBindingSource;
            // 
            // testDBDataSetBindingSource
            // 
            this.testDBDataSetBindingSource.DataSource = this.testDBDataSet;
            this.testDBDataSetBindingSource.Position = 0;
            // 
            // testDBDataSet
            // 
            this.testDBDataSet.DataSetName = "testDBDataSet";
            this.testDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1495, 523);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Неденежные активы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.наименованиеDataGridViewTextBoxColumn,
            this.начальнаяБалансоваяСтоимостьDataGridViewTextBoxColumn,
            this.остаточнаяБалансоваяСтоимостьDataGridViewTextBoxColumn,
            this.оценочнаяСтоимостьDataGridViewTextBoxColumn,
            this.измерениеDataGridViewTextBoxColumn1,
            this.инвентарныйНомерDataGridViewTextBoxColumn,
            this.датаПроизводстваDataGridViewTextBoxColumn,
            this.краткоеОписаниеDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.неденежныеBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(1489, 517);
            this.dataGridView2.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.FillWeight = 507.6142F;
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 40;
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.FillWeight = 249.9949F;
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            this.наименованиеDataGridViewTextBoxColumn.ReadOnly = true;
            this.наименованиеDataGridViewTextBoxColumn.Width = 108;
            // 
            // начальнаяБалансоваяСтоимостьDataGridViewTextBoxColumn
            // 
            this.начальнаяБалансоваяСтоимостьDataGridViewTextBoxColumn.DataPropertyName = "Начальная балансовая стоимость";
            this.начальнаяБалансоваяСтоимостьDataGridViewTextBoxColumn.FillWeight = 123.1469F;
            this.начальнаяБалансоваяСтоимостьDataGridViewTextBoxColumn.HeaderText = "Начальная балансовая стоимость";
            this.начальнаяБалансоваяСтоимостьDataGridViewTextBoxColumn.Name = "начальнаяБалансоваяСтоимостьDataGridViewTextBoxColumn";
            this.начальнаяБалансоваяСтоимостьDataGridViewTextBoxColumn.ReadOnly = true;
            this.начальнаяБалансоваяСтоимостьDataGridViewTextBoxColumn.Width = 188;
            // 
            // остаточнаяБалансоваяСтоимостьDataGridViewTextBoxColumn
            // 
            this.остаточнаяБалансоваяСтоимостьDataGridViewTextBoxColumn.DataPropertyName = "Остаточная балансовая стоимость";
            this.остаточнаяБалансоваяСтоимостьDataGridViewTextBoxColumn.FillWeight = 60.68873F;
            this.остаточнаяБалансоваяСтоимостьDataGridViewTextBoxColumn.HeaderText = "Остаточная балансовая стоимость";
            this.остаточнаяБалансоваяСтоимостьDataGridViewTextBoxColumn.Name = "остаточнаяБалансоваяСтоимостьDataGridViewTextBoxColumn";
            this.остаточнаяБалансоваяСтоимостьDataGridViewTextBoxColumn.ReadOnly = true;
            this.остаточнаяБалансоваяСтоимостьDataGridViewTextBoxColumn.Width = 192;
            // 
            // оценочнаяСтоимостьDataGridViewTextBoxColumn
            // 
            this.оценочнаяСтоимостьDataGridViewTextBoxColumn.DataPropertyName = "Оценочная стоимость";
            this.оценочнаяСтоимостьDataGridViewTextBoxColumn.FillWeight = 29.93521F;
            this.оценочнаяСтоимостьDataGridViewTextBoxColumn.HeaderText = "Оценочная стоимость";
            this.оценочнаяСтоимостьDataGridViewTextBoxColumn.Name = "оценочнаяСтоимостьDataGridViewTextBoxColumn";
            this.оценочнаяСтоимостьDataGridViewTextBoxColumn.ReadOnly = true;
            this.оценочнаяСтоимостьDataGridViewTextBoxColumn.Width = 132;
            // 
            // измерениеDataGridViewTextBoxColumn1
            // 
            this.измерениеDataGridViewTextBoxColumn1.DataPropertyName = "Измерение";
            this.измерениеDataGridViewTextBoxColumn1.FillWeight = 14.79261F;
            this.измерениеDataGridViewTextBoxColumn1.HeaderText = "Измерение";
            this.измерениеDataGridViewTextBoxColumn1.Name = "измерениеDataGridViewTextBoxColumn1";
            this.измерениеDataGridViewTextBoxColumn1.ReadOnly = true;
            this.измерениеDataGridViewTextBoxColumn1.Width = 90;
            // 
            // инвентарныйНомерDataGridViewTextBoxColumn
            // 
            this.инвентарныйНомерDataGridViewTextBoxColumn.DataPropertyName = "Инвентарный номер";
            this.инвентарныйНомерDataGridViewTextBoxColumn.FillWeight = 7.336611F;
            this.инвентарныйНомерDataGridViewTextBoxColumn.HeaderText = "Инвентарный номер";
            this.инвентарныйНомерDataGridViewTextBoxColumn.Name = "инвентарныйНомерDataGridViewTextBoxColumn";
            this.инвентарныйНомерDataGridViewTextBoxColumn.ReadOnly = true;
            this.инвентарныйНомерDataGridViewTextBoxColumn.Width = 124;
            // 
            // датаПроизводстваDataGridViewTextBoxColumn
            // 
            this.датаПроизводстваDataGridViewTextBoxColumn.DataPropertyName = "Дата производства";
            this.датаПроизводстваDataGridViewTextBoxColumn.FillWeight = 1.857722F;
            this.датаПроизводстваDataGridViewTextBoxColumn.HeaderText = "Дата производства";
            this.датаПроизводстваDataGridViewTextBoxColumn.Name = "датаПроизводстваDataGridViewTextBoxColumn";
            this.датаПроизводстваDataGridViewTextBoxColumn.ReadOnly = true;
            this.датаПроизводстваDataGridViewTextBoxColumn.Width = 121;
            // 
            // краткоеОписаниеDataGridViewTextBoxColumn
            // 
            this.краткоеОписаниеDataGridViewTextBoxColumn.DataPropertyName = "Краткое Описание";
            this.краткоеОписаниеDataGridViewTextBoxColumn.FillWeight = 0.9676561F;
            this.краткоеОписаниеDataGridViewTextBoxColumn.HeaderText = "Краткое Описание";
            this.краткоеОписаниеDataGridViewTextBoxColumn.Name = "краткоеОписаниеDataGridViewTextBoxColumn";
            this.краткоеОписаниеDataGridViewTextBoxColumn.ReadOnly = true;
            this.краткоеОписаниеDataGridViewTextBoxColumn.Width = 116;
            // 
            // неденежныеBindingSource
            // 
            this.неденежныеBindingSource.DataMember = "Неденежные";
            this.неденежныеBindingSource.DataSource = this.testDBDataSetBindingSource;
            // 
            // денежныеTableAdapter
            // 
            this.денежныеTableAdapter.ClearBeforeFill = true;
            // 
            // неденежныеTableAdapter
            // 
            this.неденежныеTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.изменитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1503, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 628);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.денежныеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDBDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.неденежныеBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource testDBDataSetBindingSource;
        private testDBDataSet testDBDataSet;
        private testDBDataSetTableAdapters.ДенежныеTableAdapter денежныеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn измерениеDataGridViewTextBoxColumn;
        private testDBDataSetTableAdapters.НеденежныеTableAdapter неденежныеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn начальнаяБалансоваяСтоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn остаточнаяБалансоваяСтоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn оценочнаяСтоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn измерениеDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn инвентарныйНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn единицыИзмеренияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПроизводстваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn краткоеОписаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеАктиваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеБанкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерСчетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn общаяСуммаDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.BindingSource денежныеBindingSource;
        public System.Windows.Forms.BindingSource неденежныеBindingSource;
    }
}

