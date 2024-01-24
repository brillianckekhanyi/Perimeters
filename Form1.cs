using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perimeters
{
    public partial class Form1 : Form
    {
        private object area;
        private object perimeter;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validate input
            int length, breadth, area,perimeter;
            length = Convert.ToInt32(textBox1.Text);
            breadth = Convert.ToInt32(textBox2.Text);
            area = length * breadth;
            textBox3.Text = area.ToString("n");
            perimeter = 2 * (length + breadth);
            textBox4.Text = perimeter.ToString("n");
        }

    }
    }

