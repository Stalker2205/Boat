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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void salesPersonBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.salesPersonBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbBoatDataSet);

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbBoatDataSet.SalesPerson". При необходимости она может быть перемещена или удалена.
            this.salesPersonTableAdapter.Fill(this.dbBoatDataSet.SalesPerson);

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(LoginTextbox.TextLength == 0 || PasswordTextbox.TextLength == 0) { MessageBox.Show("Введите логин и пароль");return; }
            this.salesPersonTableAdapter.Login(dbBoatDataSet.SalesPerson, LoginTextbox.Text, PasswordTextbox.Text);
           if(this.dbBoatDataSet.SalesPerson.Rows.Count == 1) {}
        }
    }
}
