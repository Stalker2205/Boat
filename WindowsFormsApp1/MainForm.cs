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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbBoatDataSet.OrderDetails". При необходимости она может быть перемещена или удалена.
            this.orderDetailsTableAdapter.Fill(this.dbBoatDataSet.OrderDetails);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbBoatDataSet.Order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.dbBoatDataSet.Order);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbBoatDataSet.AccessoriesToBoat". При необходимости она может быть перемещена или удалена.
          //  this.accessoriesToBoatTableAdapter.Fill(this.dbBoatDataSet.AccessoriesToBoat);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbBoatDataSet.Contract". При необходимости она может быть перемещена или удалена.
            this.contractTableAdapter.Fill(this.dbBoatDataSet.Contract);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbBoatDataSet.SalesPerson". При необходимости она может быть перемещена или удалена.
            this.salesPersonTableAdapter.Fill(this.dbBoatDataSet.SalesPerson);
            LoginForm log = new LoginForm();
            log.ShowDialog();
            if (Prem.key == 0) { this.Close(); }
            if (Prem.key == 1) { } else { if (Prem.key == 2) { AdminForm nn = new AdminForm(); nn.ShowDialog(); } }
            if (Prem.key == 0) { this.Close(); }
            if (Prem.key != 0)
            {
                this.salesPersonTableAdapter.ID(dbBoatDataSet.SalesPerson, Prem.kod);
                DateTime n1; n1 = Convert.ToDateTime(dbBoatDataSet.SalesPerson[0][6]);
                if ((n1.Day - DateTime.Now.Day) >= 14)
                {
                    MessageBox.Show("Смените пароль");
                    Password pas = new Password();
                    pas.ShowDialog();
                }
                this.salesPersonTableAdapter.UpdateQuery(DateTime.Now, Prem.kod);
               // Close();
            }
            else
            {
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prem.keyCreat = 0; 
            CreateZaka Cz = new CreateZaka();
            Cz.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ForumRab nn = new ForumRab();
            nn.ShowDialog();
        }
    }
}
