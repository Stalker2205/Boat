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
    public partial class BoatForm : Form
    {
        public BoatForm()
        {
            InitializeComponent();
        }



        private void BoatForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbBoatDataSet.Boat". При необходимости она может быть перемещена или удалена.
            this.boatTableAdapter.Fill(this.dbBoatDataSet.Boat);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreatBoatForm cbf = new CreatBoatForm();
            cbf.ShowDialog();
            this.boatTableAdapter.Fill(this.dbBoatDataSet.Boat);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Prem.CodeBoat = (int)boatDataGridView[0, boatDataGridView.CurrentCell.RowIndex].Value;
            UpdateBoat ub = new UpdateBoat();
            ub.ShowDialog();
            this.boatTableAdapter.Fill(this.dbBoatDataSet.Boat);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.boatTableAdapter.DeleteID((int)boatDataGridView[0, boatDataGridView.CurrentCell.RowIndex].Value);
            MessageBox.Show("Удалено");
            this.boatTableAdapter.Fill(this.dbBoatDataSet.Boat);

        }
    }
}
