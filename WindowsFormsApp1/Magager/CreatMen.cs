using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CreatMen : Form
    {
        public CreatMen()
        {
            InitializeComponent();
        }


        private void CreatMen_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbBoatDataSet.SalesPerson". При необходимости она может быть перемещена или удалена.
            this.salesPersonTableAdapter.Fill(this.dbBoatDataSet.SalesPerson);
            this.salesPersonBindingSource.AddNew();
        }
        int id;
        string first,
            family
            , log,
            pas;
        private void button1_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(salesPersonIDTextBox.Text);
            first = firstNameTextBox.Text;
            family = familyNameTextBox.Text;
            log = loginTextBox.Text;
            pas = passwordTextBox.Text;
            if (salesPersonIDTextBox.TextLength == 0 || firstNameTextBox.TextLength == 0 ||
                familyNameTextBox.TextLength == 0 || loginTextBox.TextLength == 0 ||
                passwordTextBox.TextLength == 0)
            {
                MessageBox.Show("Введите все значения"); return;
            }
            else
            {
                this.salesPersonTableAdapter.creatManager(dbBoatDataSet.SalesPerson, 
                    passwordTextBox.Text, loginTextBox.Text, Convert.ToInt32(salesPersonIDTextBox.Text));
                if (dbBoatDataSet.SalesPerson.Rows.Count != 0)
                {
                    MessageBox.Show("Пользователь уже существует, попробуйте изменить id,логин или пароль "); return;
                }
                try
                {
                    Convert.ToInt32(id);
                }
                catch { MessageBox.Show("id должно быть числом"); return; }
                this.salesPersonTableAdapter.InsertQuery(id,
                    first, family,
                    log, pas,
                    comboBox1.Text, DateTime.Now, "Активна");
                MessageBox.Show("Создано"); Close();
            }
        }
    }
}
