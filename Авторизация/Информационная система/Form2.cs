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
    public partial class Form2 : Form
    {
        int pin;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pin = 3565;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Проверка ввода пинкода
            if (textBox_pin.Text == Convert.ToString(pin))
            {
                Form3 newForm3 = new Form3();
                MessageBox.Show("Вход успешен");
                Close();
                newForm3.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Неверный код аутентификации");
            }
        }

        private void textBox_pin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
