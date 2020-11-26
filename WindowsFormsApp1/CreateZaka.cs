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
    public partial class CreateZaka : Form
    {
        public CreateZaka()
        {
            InitializeComponent();
        }


        private void CreateZaka_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbBoatDataSet.Accessory". При необходимости она может быть перемещена или удалена.
            this.accessoryTableAdapter.Fill(this.dbBoatDataSet.Accessory);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbBoatDataSet.Customer". При необходимости она может быть перемещена или удалена.
            this.customerTableAdapter.Fill(this.dbBoatDataSet.Customer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbBoatDataSet.SalesPerson". При необходимости она может быть перемещена или удалена.
            this.salesPersonTableAdapter.Fill(this.dbBoatDataSet.SalesPerson);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbBoatDataSet.Boat". При необходимости она может быть перемещена или удалена.
            this.boatTableAdapter.Fill(this.dbBoatDataSet.Boat);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbBoatDataSet.Contract". При необходимости она может быть перемещена или удалена.
            this.contractTableAdapter.Fill(this.dbBoatDataSet.Contract);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbBoatDataSet.Order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.dbBoatDataSet.Order);
            this.orderBindingSource.AddNew();
            this.contractBindingSource.AddNew();

        }
        int key = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (orderTextBox.TextLength == 0 || deliveryAddressTextBox.TextLength == 0 || cityTextBox.TextLength == 0 || contractIDTextBox.TextLength == 0
                || depositPayedTextBox.TextLength == 0 || orderIDTextBox.TextLength == 0 || 
                contractTotalPriceTextBox.TextLength == 0 || contracTotalPriceinclVATTextBox.TextLength == 0
                || detailIDTextBox.TextLength == 0
                )
            {
                MessageBox.Show("Введите все значения"); return;
            }
            if (Convert.ToInt32(contractTotalPriceTextBox.Text) * 0.15 > Convert.ToInt32(depositPayedTextBox.Text))
            {
                this.contractTableAdapter.InsertQuery(Convert.ToInt32(contractIDTextBox.Text), DateTime.Now, Convert.ToInt32(depositPayedTextBox.Text),
    Prem.numZ, Convert.ToInt32(contractTotalPriceTextBox.Text), 15, "Начато производство");
                MessageBox.Show("Контракт создан"); Close();
            }
            this.contractTableAdapter.InsertQuery(Convert.ToInt32(contractIDTextBox.Text), DateTime.Now, Convert.ToInt32(depositPayedTextBox.Text),
                Prem.numZ, Convert.ToInt32(contractTotalPriceTextBox.Text), 15, "Работы не начаты");
            MessageBox.Show("Контракт создан"); Close();


        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.customerTableAdapter.ID(dbBoatDataSet.Customer, comboBox3.SelectedIndex);
        }
        int Price = 0;
        private void button3_Click_1(object sender, EventArgs e)
        {
            if(deliveryAddressTextBox.TextLength == 0|| cityTextBox.TextLength == 0) { MessageBox.Show("Введите значения");return; }
            if (key == 0)
            {
                try
                {
                    this.orderTableAdapter.ID(dbBoatDataSet.Order, Convert.ToInt32(orderTextBox.Text));
                }
                catch { MessageBox.Show("Номер заказа должен быть числом");return; }
                if (dbBoatDataSet.Order.Rows.Count != 0)
                {
                    MessageBox.Show("Заказ с таким номером уже существует"); return;
                }
                else
                {
                    key = 1;
                }
            }
            if (key == 1)
            {
                
                try
                {
                    this.orderTableAdapter.Insert1(Convert.ToInt32(orderTextBox.Text), Convert.ToString(DateTime.Now),
                        Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox3.SelectedValue), Convert.ToInt32(
                        boatDataGridView[0, boatDataGridView.CurrentCell.RowIndex].Value), deliveryAddressTextBox.Text, cityTextBox.Text);
                }catch { MessageBox.Show("Единовременно можно купить только 1 лодку");return; }
                Price = Price + Convert.ToInt32(boatDataGridView[7, boatDataGridView.CurrentCell.RowIndex].Value);
                contractTotalPriceTextBox.Text = Convert.ToString(Price);
                Prem.numZ = Convert.ToInt32(orderTextBox.Text);


            }
        }
        int prik;
        int kol;
        private void button2_Click(object sender, EventArgs e)
        {
            kol =Convert.ToInt32( detailIDTextBox.Text);
            try
            {
                this.orderDetailsTableAdapter1.ID(dbBoatDataSet.OrderDetails, Convert.ToInt32(detailIDTextBox.Text));
            }
            catch { MessageBox.Show("введите");return; }
            if(dbBoatDataSet.OrderDetails.Rows.Count !=0)
            {
                MessageBox.Show("Выберите другой номер");return;
            }
            orderDetailsTableAdapter1.InsertQuery(kol, Convert.ToInt32(accessoryDataGridView[0, accessoryDataGridView.CurrentCell.RowIndex].Value), Prem.numZ);
            prik =Convert.ToInt32( accessoryDataGridView[3, accessoryDataGridView.CurrentCell.RowIndex].Value)+ prik;
            Price = Price + prik;
            contractTotalPriceTextBox.Text = Convert.ToString(Price);
        }
    }
}
