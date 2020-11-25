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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbBoatDataSet.SalesPerson". При необходимости она может быть перемещена или удалена.
            this.salesPersonTableAdapter.Fill(this.dbBoatDataSet.SalesPerson);
            Prem.key = 0;
            this.salesPersonTableAdapter.UpdateQuery(DateTime.Now, Prem.kod);
            DateTime n1; n1 = Convert.ToDateTime(dbBoatDataSet.SalesPerson[0][6]);
            if ((n1.Day - DateTime.Now.Day) >= 14)
            {
                MessageBox.Show("Смените пароль");
                Password pas = new Password();
                pas.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            meneger mn = new meneger();
            mn.ShowDialog();
        }
    }
}
