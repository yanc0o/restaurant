using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace restaurant
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }
        double smetka = 0;
        List<string> smetca = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                smetka += 19.99 * double.Parse(textBox1.Text);
                smetca.Add($"пъстра зелена салата x 19.99 лв {textBox1.Text}");
            }
            if (checkBox2.Checked)
            {
                smetka += 19.99 * double.Parse(textBox2.Text);
                smetca.Add($"салата цезар x 19.99 лв {textBox2.Text}");
            }
            if (checkBox3.Checked)
            {
                smetka += 17.50 * double.Parse(textBox3.Text);
                smetca.Add($"салата капрезе x 17.50 лв {textBox3.Text}");
            }
            if (checkBox4.Checked)
            {
                smetka += 25 * int.Parse(textBox4.Text);
                smetca.Add($"задушено пилешко филе x 25 лв {textBox4.Text}");
            }
            if (checkBox5.Checked)
            {
                smetka += 23 * int.Parse(textBox5.Text);
                smetca.Add($"пълнени печени картофи x 23 лв {textBox5.Text}");
            }
            if (checkBox6.Checked)
            {
                smetka += 28 * int.Parse(textBox6.Text);
                smetca.Add($"печен свински котлет x 28 лв {textBox6.Text}");
            }
            if (checkBox7.Checked)
            {
                smetka += 9 * int.Parse(textBox7.Text);
                smetca.Add($"брауни x 9 лв {textBox7.Text}");
            }
            if (checkBox8.Checked)
            {
                smetka += 8 * int.Parse(textBox8.Text);
                smetca.Add($"тирамису x 8 лв {textBox8.Text}");
            }
            if (checkBox9.Checked)
            {
                smetka += 9.90 * double.Parse(textBox9.Text);
                smetca.Add($"торта орео x 9.90 лв {textBox9.Text}");
            }
            if (checkBox10.Checked)
            {
                smetka += 6 * int.Parse(textBox10.Text);
                smetca.Add($"уиски x 6 лв {textBox10.Text}");
            }
            if (checkBox11.Checked)
            {
                smetka += 7 * int.Parse(textBox11.Text);
                smetca.Add($"водка x 7 лв {textBox11.Text}");

            if (checkBox12.Checked)
            {
                smetka += 7 * int.Parse(textBox12.Text);
                smetca.Add($"джин x 7 лв {textBox12.Text}");
            }
                if (checkBox13.Checked)
                {
                    smetka += 3 * int.Parse(textBox13.Text);
                    smetca.Add($"кока кола x 3 лв {textBox13.Text}");
                }
                if (checkBox14.Checked)
                {
                    smetka += 3 * int.Parse(textBox14.Text);
                    smetca.Add($"сок капи x 3 лв {textBox14.Text}");
                }
                if (checkBox15.Checked)
                {
                    smetka += 2.50 * double.Parse(textBox15.Text);
                    smetca.Add($"газ.вода x 2.50 лв {textBox15.Text}");
                }
                if (checkBox16.Checked)
                {
                    smetka += 3 * int.Parse(textBox16.Text);
                    smetca.Add($"кафе x 3 лв {textBox16.Text}");
                }
                if (checkBox17.Checked)
                {
                    smetka += 3 * int.Parse(textBox17.Text);
                    smetca.Add($"чай x 3 лв {textBox17.Text}");
                }
                if (checkBox18.Checked)
                {
                    smetka += 4 * int.Parse(textBox18.Text);
                    smetca.Add($"горещ шоколад x 4 лв {textBox18.Text}");
                }
                double tax = smetka * 0.05;
                if (radioButton1.Checked==true)
                {
                    MessageBox.Show($"{string.Join(Environment.NewLine, smetca)}" +
                $"\n smetkata ti e :{smetka:F2}lv");
                    smetka = 0;

                }
                else if (radioButton2.Checked==true) 
                {
                    MessageBox.Show($"{string.Join(Environment.NewLine, smetca)}" +
                $"\n smetkata ti e :{smetka*tax}lv");
                    smetka = 0;

                }
            }
          
        }
    }

    
}
