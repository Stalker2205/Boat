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
    public partial class meneger : Form
    {
        public meneger()
        {
            InitializeComponent();
        }


        private void meneger_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbBoatDataSet.SalesPerson". При необходимости она может быть перемещена или удалена.
            this.salesPersonTableAdapter.Fill(this.dbBoatDataSet.SalesPerson);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreatMen cm = new CreatMen();
            cm.ShowDialog();
            this.salesPersonTableAdapter.Fill(this.dbBoatDataSet.SalesPerson);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Prem.update = Convert.ToInt32(salesPersonDataGridView[0, salesPersonDataGridView.CurrentCell.RowIndex].Value);
            UpdateMen um = new UpdateMen();
            um.ShowDialog();
            this.salesPersonTableAdapter.Fill(this.dbBoatDataSet.SalesPerson);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(salesPersonDataGridView[0, salesPersonDataGridView.CurrentCell.RowIndex].Value);
            try
            {
                this.salesPersonTableAdapter.Delete1((int)salesPersonDataGridView[0,
                    salesPersonDataGridView.CurrentCell.RowIndex].Value);
            }
            catch { MessageBox.Show("Продавец участвует в сделке, вы не можите его удалить"); return; }
            this.salesPersonTableAdapter.Fill(this.dbBoatDataSet.SalesPerson);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ForumRab nn = new ForumRab();
            nn.ShowDialog();
        }
    }
}
