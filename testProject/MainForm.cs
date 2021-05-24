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

        private void button3_Click(object sender, EventArgs e)
        {
            ActionsForm AF = new ActionsForm();
            AF.Show();
        }
    }
}
