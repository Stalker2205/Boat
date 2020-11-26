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


            this.salesPersonTableAdapter.Fill(this.dbBoatDataSet.SalesPerson);
            Prem.key = 3;

            DateTime n1; n1 = Convert.ToDateTime(dbBoatDataSet.SalesPerson[0][6]);

            if ((n1.Day - DateTime.Now.Day) >= 14)
            {
                MessageBox.Show("Смените пароль");
                Password pas = new Password();
                pas.ShowDialog();
            }
            else
            {
                if ((n1.Month - DateTime.Now.Month) > 1)
                {
                    this.salesPersonTableAdapter.Statys("Блокирована", Prem.kod); return;
                    MessageBox.Show("Ваша учетная запись заблокирована, обратитесь к администратору"); return;
                }
                this.salesPersonTableAdapter.UpdateQuery(DateTime.Now, Prem.kod);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            meneger mn = new meneger();
            mn.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BoatForm bf = new BoatForm();
            bf.ShowDialog();
        }
    }
}
