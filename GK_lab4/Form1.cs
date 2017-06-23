using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GK_lab4
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private Pen pen;
        

        public Form1()
        {
            InitializeComponent();
            graphics = pictureBox1.CreateGraphics();
            pen = new Pen(Color.Black);
        }

        private void drawSquare()
        {
            graphics.DrawRectangle(pen, 50, 50, 200, 200);
        }

        private void drawCircle()
        {
            graphics.DrawEllipse(pen, 50, 50, 200, 200);
        }

        private void drawEllipse()
        {
            graphics.DrawEllipse(pen, 50, 50, 100, 200);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            drawCircle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            drawSquare();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            drawEllipse();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            graphics.TranslateTransform((float)Double.Parse(textBox1.Text), (float)Double.Parse(textBox2.Text));
            drawCircle();
            graphics.ResetTransform();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            graphics.RotateTransform((float)Double.Parse(textBox3.Text));
            drawSquare();
            graphics.ResetTransform();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            graphics.ScaleTransform((float)Double.Parse(textBox4.Text), (float)Double.Parse(textBox5.Text));
            drawEllipse();
            graphics.ResetTransform();
        }
    }
}
