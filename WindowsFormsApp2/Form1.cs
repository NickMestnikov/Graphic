using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black, 3f);

            Point[] points = new Point[10000];

            for (int i = 0; i < points.Length; i++)
            {
                int j = i - 9000;
                points[i] = new Point(j, (int)(1 * j * j - 4 * j + 5 + 200));
            }
            graphics.DrawLines(pen, points);
        }
    }
}
