using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Информационная_система
{
    public partial class Form1 : Form
    {
        int Counter;
        string Login;
        string Password;
        int Tryes;
        int VarTryes;
        public Form1()
        {
            InitializeComponent();
            textBox_pass.UseSystemPasswordChar = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Counter = 0;
            Login = "Login";
            Password = "Pass";

            Tryes = 5;
            VarTryes = Tryes;
            numericUpDown1.Value = 30;
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            // Проверка ввода логина и пароля
            if (textBox_login.Text == Login && textBox_pass.Text == Password)
            {
                Form2 newForm2 = new Form2();
                newForm2.ShowDialog();
                Counter = 0;
                VarTryes = Tryes;
                label_tryescount.Visible = false;
                label_tryestext.Visible = false;
                Close();
            }
            else
            {
                textBox_pass.Text = "";
                label_error.Visible = true;
                Counter = Counter + 1;
                VarTryes = VarTryes - 1;
                label_tryescount.Visible = true;
                label_tryestext.Visible = true;
                label_tryescount.Text = Convert.ToString(VarTryes);
            }

            // Проверка на количество неправильных вводов
            if (Counter > Tryes - 1)
            {
                timer1.Enabled = true;
                button_enter.Enabled = false;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Таймер активен
            if(timer1.Enabled == true)
            {
                label_timer.Visible = true;
                numericUpDown1.Value = numericUpDown1.Value - 1;
                label_timer.Text = Convert.ToString(numericUpDown1.Value);
                label1.Visible = true;
                label2.Visible = true;

            }

            // Таймер закончил работу
            if (numericUpDown1.Value == 0)
            {
                timer1.Enabled = false;
                button_enter.Enabled = true;
                Counter = 0;
                VarTryes = Tryes;
                label_tryescount.Text = Convert.ToString(VarTryes);
                numericUpDown1.Value = 60;
                label_timer.Visible = false;
            }
        }

        private void label_error_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
                textBox_pass.UseSystemPasswordChar = false;
            else
                textBox_pass.UseSystemPasswordChar = true;
        }
    }
}
