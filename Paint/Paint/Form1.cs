using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        private bool drawing = false;
        private Point previousPoint;
        private Pen currentPen = new Pen(Color.Black, 2);
        public Form1()
        {
            InitializeComponent();
            panelDrawing.MouseDown += PanelDrawing_MouseDown;
            panelDrawing.MouseMove += PanelDrawing_MouseMove;
            panelDrawing.MouseUp += PanelDrawing_MouseUp;

        }
    
            private void PanelDrawing_MouseDown(object sender, MouseEventArgs e)
        {
            if (rbDraw.Checked)
            {
                drawing = true;
                previousPoint = e.Location;
            }
            else if (rbWrite.Checked)
            {
                richTextBox1.Focus();
                richTextBox1.SelectionStart = richTextBox1.Text.Length;
            }
        }

        private void PanelDrawing_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                using (Graphics g = panelDrawing.CreateGraphics())
                {
                    g.DrawLine(currentPen, previousPoint, e.Location);
                    previousPoint = e.Location;
                }
            }
        }

        private void PanelDrawing_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            currentPen.Color = panelDrawing.BackColor;
            currentPen.Width = 20;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            currentPen.Color = Color.White;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            currentPen.Color = Color.Red;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            currentPen.Color = Color.Fuchsia;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            currentPen.Color = Color.Black;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            currentPen.Color = Color.Yellow;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            currentPen.Color = Color.Blue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentPen.Width = 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentPen.Width = 5;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            currentPen.Width = 2;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panelDrawing.Cursor = Cursors.Default;
            richTextBox1.Visible = false;
            panelDrawing.Visible = true;
            rbLowercase.Visible = false;
            rbUppercase.Visible = false;
            groupBox1.Visible = true;
            groupBox2.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panelDrawing.Cursor = Cursors.IBeam;
            panelDrawing.Visible = false;
            richTextBox1.Visible = true;
            rbLowercase.Visible = true;
            rbUppercase.Visible = true;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (rbUppercase.Checked)
            {
                richTextBox1.Text = richTextBox1.Text.ToUpper();
            }
            else if (rbLowercase.Checked)
            {
                richTextBox1.Text = richTextBox1.Text.ToLower();
            }
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
        }

    }
}
