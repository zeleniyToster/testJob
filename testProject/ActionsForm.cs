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

        public string tableName;
        //cash assets
        private string assetNameM, bankName, dimM;
        private int accountNumber, summ;
        //not-cash assets
        private string assetNameNM, dimNM, description;
        private int initBV, resBV, predictivePrice, invNumber;
        private DateTime productionDate;



        public void initLines(int Num)
        {
            if (Num == 1)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
            }
            if (Num == 2)
            {
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                textBox10.Visible = true;
                textBox11.Visible = true;
                textBox14.Visible = true;
                maskedTextBox1.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label15.Visible = true;
                label16.Visible = true;
            }
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

            textBox1.Text = tableName;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
