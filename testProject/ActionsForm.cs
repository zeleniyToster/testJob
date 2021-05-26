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
    public partial class ActionsForm : Form
    {
        public ActionsForm()
        {
            InitializeComponent();
        }

        private string tableName;
        //cash assets
        private string assetNameM, bankName, dimM;
        private int accountNumber, summ;
        //not-cash assets
        private string assetNameNM, dimNM, description;
        private int initBV, resBV, predictivePrice, invNumber;
        private DateTime productionDate;

        public BindingSource bs = new BindingSource();

        private void initTable()
        {
            //tableName = comboBox1.SelectedItem.ToString();
        }

        private void ActionsForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void ActionsForm_Load(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDBDataSet.Денежные". При необходимости она может быть перемещена или удалена.
            this.денежныеTableAdapter.Fill(this.testDBDataSet.Денежные);
            
            //switch (comboBox1.SelectedIndex)
            //{
            //    case 0:
            //        dataGridView1.DataSource = mf.денежныеBindingSource;
            //        break;
            //    case 1:
            //        dataGridView1.DataSource = mf.неденежныеBindingSource;
            //        break;
            //    default:
            //        break;
            //}
            initTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
