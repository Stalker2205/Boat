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
    public partial class CreatBoatForm : Form
    {
        public CreatBoatForm()
        {
            InitializeComponent();
        }

        private void CreatBoatForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbBoatDataSet.Boat". При необходимости она может быть перемещена или удалена.
            this.boatTableAdapter.Fill(this.dbBoatDataSet.Boat);
            this.boatBindingSource.AddNew();

        }
        int id, price, rowers;
        string type;


        bool mast;

        private void button1_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(iDTextBox.Text);
            type = boatTypeTextBox.Text;
            try
            {
                rowers = Convert.ToInt32(numberOfRowersTextBox.Text);
            }
            catch { MessageBox.Show("Количество гребцов должно быть числом"); return; }
            try
            {
                price = Convert.ToInt32(basePriceTextBox.Text);
            }
            catch { MessageBox.Show("Цена должна быть числом"); return; }
            mast = mastCheckBox.Checked;


            if (iDTextBox.TextLength == 0 || boatTypeTextBox.TextLength == 0 || numberOfRowersTextBox.TextLength == 0 || basePriceTextBox.TextLength == 0)
            {
                MessageBox.Show("Заполните все поля"); return;
            }
            this.boatTableAdapter.ID(dbBoatDataSet.Boat, Convert.ToInt32(iDTextBox.Text));
            if (dbBoatDataSet.Boat.Rows.Count != 0)
            {
                MessageBox.Show("Лодка с таким номером уже существует"); return;
            }
            this.boatTableAdapter.newBoat(id, comboBox1.Text, type, rowers, mast, comboBox2.Text, comboBox3.Text, price, 15);
            MessageBox.Show("Добавлено"); Close();

        }
    }
}
