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
    public partial class UpdateMen : Form
    {
        public UpdateMen()
        {
            InitializeComponent();
        }


        private void CreatMen_Load(object sender, EventArgs e)
        {

            this.salesPersonTableAdapter.ID(dbBoatDataSet.SalesPerson, Prem.update);
        }
        string first,
            family,
            login,
            passwoed;
        private void button1_Click(object sender, EventArgs e)
        {
            first = firstNameTextBox.Text;
            family = familyNameTextBox.Text;
            login = loginTextBox.Text;
            passwoed = passwordTextBox.Text;
            if (salesPersonIDTextBox.TextLength == 0 || firstNameTextBox.TextLength == 0 || familyNameTextBox.TextLength == 0 || loginTextBox.TextLength == 0 || passwordTextBox.TextLength == 0)
            {
                MessageBox.Show("Введите все значения"); return;
            }
            else
            {
                this.salesPersonTableAdapter.LogPass(dbBoatDataSet.SalesPerson, login, passwoed);
                if (dbBoatDataSet.SalesPerson.Rows.Count != 0)
                {
                    MessageBox.Show("Пользователь уже существует "); return;
                }

            }
            this.salesPersonTableAdapter.UpdateQuery2(first,
                family, login, passwoed,
                comboBox1.Text, Prem.update);
            MessageBox.Show("Обновлено");
            Close();
        }
    }
}

