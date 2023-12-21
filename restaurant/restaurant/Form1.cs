using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pushachi = textBox2.Text;
            int broihora =int.Parse(textBox1.Text);

            if (broihora > 15 || broihora <= 0)
            {
                MessageBox.Show("нямаме маса за толкова хора ");

            }
            else if (pushachi == "да")
            {
                MessageBox.Show($"заповядайте в зоната за пушачи, на маса за {broihora} човека");
               menu menu = new menu();
                menu.Show();
                this.Hide();
            }
            else if (pushachi == "не")
            {
                MessageBox.Show($"заповядайте в зоната за непушачи на маса за {broihora} човека");

                menu menu = new menu();
                menu.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("моля отговорете на въпроса с  'да' или 'не'.");

            }
           

        }

  
    }
}
