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


        private void LoginForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbBoatDataSet.SalesPerson". При необходимости она может быть перемещена или удалена.
            this.salesPersonTableAdapter.Fill(this.dbBoatDataSet.SalesPerson);
            Prem.key = 0;
            popitLabel.Text = "Количество попыток : 3";
        }
        int pop = 3;
        int step = 15;
        int mul = 20;
        int key = 0;
        DateTime dat1;
        private void LoginButton_Click(object sender, EventArgs e)
        {
           if (pop == 0)
            {
                int sec =dat1.Minute*60+ dat1.Second+step;
                if(sec<DateTime.Now.Minute*60+DateTime.Now.Second)
                {
                    pop = 3;
                }
                else
                {
                    MessageBox.Show("Подождите");return;
                }
             }
            if (LoginTextbox.TextLength == 0 || PasswordTextbox.TextLength == 0) { MessageBox.Show("Введите логин и пароль");return; }
            this.salesPersonTableAdapter.Login(dbBoatDataSet.SalesPerson, LoginTextbox.Text, PasswordTextbox.Text);
            if (this.dbBoatDataSet.SalesPerson.Rows.Count == 1)
            {
              Prem.Role = Convert.ToString( this.dbBoatDataSet.SalesPerson[0][5]);
                Prem.kod = Convert.ToInt32(this.dbBoatDataSet.SalesPerson[0][0]);
                if (Prem.Role == "Администратор") { Prem.key = 2; } else { Prem.key = 1; }
              Close();
            } 
            else
            { 
                MessageBox.Show("Вы ввели неверный логин или пароль. Пожалуйста, проверьте ещё раз введенные данные");
                pop--;
                popitLabel.Text = $"Количество попыток : {pop}";
                if(pop == 0)
                {
                    dat1 = DateTime.Now;
                    MessageBox.Show($"Подождите {step} секунд");
                    step += 20;
                    dat1 = DateTime.Now;
                    key = 1;
                    return;
                }
                return;
            }
            
        }
    }
}
