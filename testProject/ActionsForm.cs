using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
        public string conStr;
        private OleDbConnection myCon2;

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

        private void insQ(string col,string Value)
        {
            string query = "INSERT INTO " + tableName + col + " VALUES (" + Value+")";
            OleDbCommand command = new OleDbCommand(query,myCon2);
            command.ExecuteNonQuery();
        }
        public void updQ(string id,string Value)
        {
            string query = "UPDATE "+tableName+" SET "+Value + " WHERE id="+id;
            OleDbCommand command = new OleDbCommand(query, myCon2);
            command.ExecuteNonQuery();
        }
        private void ActionsForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }


        private void ActionsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDBDataSet.Денежные". При необходимости она может быть перемещена или удалена.
            this.денежныеTableAdapter.Fill(this.testDBDataSet.Денежные);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valQuery="", col="";
            if (tableName == "Денежные активы")
            {
                col = "(Наименование актива, Наименование банка, Номер счета, Общая сумма, Измерение)";
                valQuery = textBox1.Text + ", "+ textBox2.Text + ", " + textBox3.Text + ", " + textBox4.Text + ", " + textBox5.Text;
            }    
            if (tableName == "Неденежные активы")
            {
                col = "(Наименование, Начальная балансовая стоимость, Остаточная балансовая стоимость, Оценочная стоимость, Измерение, Инвентарный номер, Дата производства, Краткое Описание)";
                valQuery = textBox6.Text + ", " + textBox7.Text + ", " + textBox8.Text + ", " + textBox9.Text + ", " + textBox10.Text + ", " + textBox11.Text + ", " + maskedTextBox1.Text + ", " + textBox14.Text;
            }

            myCon2 = new OleDbConnection(conStr);
            myCon2.Open();
            insQ(col,valQuery);
            myCon2.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string valQuery = "";
            string n = dataGridView1.CurrentRow.ToString();
            if (tableName == "Денежные активы")
            {
                valQuery = "Наименование актива=" + textBox1.Text + ", Наименование банка=" + textBox2.Text + ", Номер счета=" + textBox3.Text + ", Общая сумма=" + textBox4.Text + ", Измерение=" + textBox5.Text;
            }
            if (tableName == "Неденежные активы")
            {
                valQuery = "Наименование="+textBox6.Text + ", Начальная балансовая стоимость=" + textBox7.Text + ", Остаточная балансовая стоимость=" + textBox8.Text + ", Оценочная стоимость=" + textBox9.Text + ", Измерение=" + textBox10.Text + ", Инвентарный номер=" + textBox11.Text + ", Дата производства=" + maskedTextBox1.Text + ", Краткое Описание=" + textBox14.Text;
            }
            myCon2 = new OleDbConnection(conStr);
            myCon2.Open();
            updQ(n, valQuery);
            myCon2.Close();
        }
    }
}
