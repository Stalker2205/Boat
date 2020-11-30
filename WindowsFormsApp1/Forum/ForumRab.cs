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
    public partial class ForumRab : Form
    {
        public ForumRab()
        {
            InitializeComponent();
        }
        int ger = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
           
           
            this.table_1TableAdapter.Select(dbBoatDataSet.Table_1);
            int k = dbBoatDataSet.Table_1.Rows.Count;
            // k--;
            if (ger != k)
            { 
                textBox1.Clear();
                string soo;
                for (int i = 0; i < k; i++)
                {
                    soo = dbBoatDataSet.Table_1[i][1].ToString() + ":" + dbBoatDataSet.Table_1[i][2].ToString() + "\r\n";
                    textBox1.AppendText(soo);
                    ger = k;
                }
            }
        }

        private void Forum_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbBoatDataSet.Table_1". При необходимости она может быть перемещена или удалена.
            this.table_1TableAdapter.Fill(this.dbBoatDataSet.Table_1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.table_1TableAdapter.InsertQuery(textBox3.Text, textBox2.Text);
            this.table_1TableAdapter.Fill(this.dbBoatDataSet.Table_1);


        }
    }
}
