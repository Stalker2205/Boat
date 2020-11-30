using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilityForm;

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
            Prem.keyCreat = 1;
            try
            {
                Convert.ToInt32(pecent.Text);
            }
            catch
            {

                MessageBox.Show("Процент должен быть числом"); return;
            }



            if (orderTextBox.TextLength == 0 || deliveryAddressTextBox.TextLength == 0 || cityTextBox.TextLength == 0 || contractIDTextBox.TextLength == 0
                || depositPayedTextBox.TextLength == 0 || orderIDTextBox.TextLength == 0 ||
                contractTotalPriceTextBox.TextLength == 0 || contracTotalPriceinclVATTextBox.TextLength == 0
                || detailIDTextBox.TextLength == 0
                )
            {
                MessageBox.Show("Введите все значения"); return;
            }
            if (Convert.ToInt32(contractTotalPriceTextBox.Text) * (Convert.ToInt32(pecent.Text) / 100) > Convert.ToInt32(depositPayedTextBox.Text))
            {
                this.contractTableAdapter.InsertQuery(Convert.ToInt32(contractIDTextBox.Text), DateTime.Now, Convert.ToInt32(depositPayedTextBox.Text),
                 Prem.numZ, Convert.ToInt32(contractTotalPriceTextBox.Text), Convert.ToInt32(contractTotalPriceTextBox.Text)
                * Convert.ToInt32(pecent.Text) + Convert.ToInt32(contractTotalPriceTextBox.Text), "Начато производство");
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
            if (deliveryAddressTextBox.TextLength == 0 || cityTextBox.TextLength == 0) { MessageBox.Show("Введите значения"); return; }
            if (key == 0)
            {
                try
                {
                    this.orderTableAdapter.ID(dbBoatDataSet.Order, Convert.ToInt32(orderTextBox.Text));
                }
                catch { MessageBox.Show("Номер заказа должен быть числом"); return; }
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
                }
                catch { MessageBox.Show("Единовременно можно купить только 1 лодку"); return; }
                Price = Price + Convert.ToInt32(boatDataGridView[7, boatDataGridView.CurrentCell.RowIndex].Value);
                contractTotalPriceTextBox.Text = Convert.ToString(Price);
                Prem.numZ = Convert.ToInt32(orderTextBox.Text);
                orderIDTextBox.Text = orderTextBox.Text;

            }
        }
        int prik;
        int kol;
        int price;
        int size = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            // FormOpener.Instance.OpenChildForm(new Password(), tabPage4);
            try
            {
                kol = Convert.ToInt32(detailIDTextBox.Text);
            }
            catch { MessageBox.Show("Введите ID"); return; }
            orderIDTextBox.Enabled = false;
            try
            {
                this.orderDetailsTableAdapter1.ID(dbBoatDataSet.OrderDetails, Convert.ToInt32(detailIDTextBox.Text));
            }
            catch { MessageBox.Show("введите Другой id"); return; }
            if (dbBoatDataSet.OrderDetails.Rows.Count != 0)
            {
                MessageBox.Show("Выберите другой номер"); return;
            }
            if (Prem.numZ == 0)
            {
                MessageBox.Show("Введите номер заказа"); return;
            }
            orderDetailsTableAdapter1.InsertQuery(kol, Convert.ToInt32(accessoryDataGridView[0, accessoryDataGridView.CurrentCell.RowIndex].Value), Prem.numZ);
            prik = Convert.ToInt32(accessoryDataGridView[3, accessoryDataGridView.CurrentCell.RowIndex].Value) + prik;
            Price = Price + prik;
            size = size + (int)accessoryDataGridView[3, accessoryDataGridView.CurrentCell.RowIndex].Value;
            textBox1.Text = size.ToString();
            contractTotalPriceTextBox.Text = Convert.ToString(Price);
            kol++;
            detailIDTextBox.Text = kol.ToString();
            detailIDTextBox.ReadOnly = true;
            textBox1.Text = accessoryDataGridView[3, accessoryDataGridView.CurrentCell.RowIndex].Value.ToString();
            price = price + Convert.ToInt32(textBox1.Text);
            textBox1.Text = price.ToString();
            listBox1.Items.Add(Convert.ToString(accessoryDataGridView[1, accessoryDataGridView.CurrentCell.RowIndex].Value));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string jh = kio;
            if (orderTextBox.TextLength == 0) { MessageBox.Show("Введите номер заказа"); return; }
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(Convert.ToInt32(ki));

                re = 1;
                this.accessoryTableAdapter.AccName(dbBoatDataSet.Accessory, Convert.ToString(jh));
                this.orderDetailsTableAdapter1.DeleteAcc((int)accessoryDataGridView[0, 0].Value, Convert.ToInt32(orderTextBox.Text));
                contractTotalPriceTextBox.Text = Convert.ToString(Convert.ToInt32(contractTotalPriceTextBox.Text) -
                    (int)accessoryDataGridView[3, 0].Value);
                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) -
                    (int)accessoryDataGridView[3, 0].Value);
                this.accessoryTableAdapter.Fill(this.dbBoatDataSet.Accessory);
                re = 0;
            }

        }
        string ki, kio; int re = 0;

        private void CreateZaka_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Prem.keyCreat == 0)
            {
                this.orderDetailsTableAdapter1.DeleteID(Convert.ToInt32(detailIDTextBox.Text));
                this.orderTableAdapter.DeleteID(Convert.ToInt32(orderTextBox.Text));
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ForumRab nn = new ForumRab();
            nn.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (re == 0)
            {
                ki = listBox1.SelectedIndex.ToString();
                try
                {
                    kio = listBox1.SelectedItem.ToString();
                }
                catch { }
            }
        }
    }
}
