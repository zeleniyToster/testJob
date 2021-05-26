using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDBDataSet.Неденежные". При необходимости она может быть перемещена или удалена.
            this.неденежныеTableAdapter.Fill(this.testDBDataSet.Неденежные);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDBDataSet.Денежные". При необходимости она может быть перемещена или удалена.
            this.денежныеTableAdapter.Fill(this.testDBDataSet.Денежные);
            
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActionsForm AF = new ActionsForm();
            AF.Show();
            int num=0;
            if (tabControl1.SelectedTab == tabPage1)
            {
                AF.comboBox1.SelectedIndex = 0;
                AF.comboBox2.SelectedIndex = 0;
                AF.dataGridView1.DataSource = денежныеBindingSource;
                AF.tableName = tabPage1.Text;
                num = 1;
            }
            if (tabControl1.SelectedTab == tabPage2)
            {
                AF.comboBox1.SelectedIndex = 1;
                AF.comboBox2.SelectedIndex = 1;
                AF.dataGridView1.DataSource = неденежныеBindingSource;
                AF.tableName = tabPage2.Text;
                num = 2;
            }
            AF.initLines(num);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActionsForm AF = new ActionsForm();
            AF.Show();
            if (tabControl1.SelectedTab == tabPage1)
            {
                AF.comboBox1.SelectedIndex = 0;
                AF.comboBox2.SelectedIndex = 0;
                AF.dataGridView1.DataSource = денежныеBindingSource;
                AF.tableName = tabPage1.Text;
            }
            if (tabControl1.SelectedTab == tabPage2)
            {
                AF.comboBox1.SelectedIndex = 1;
                AF.comboBox2.SelectedIndex = 1;
                AF.dataGridView1.DataSource = неденежныеBindingSource;
                AF.tableName = tabPage2.Text;
            }
        }
    }
}
