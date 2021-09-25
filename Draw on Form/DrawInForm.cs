using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw_on_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics gr = this.CreateGraphics();
            if(e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                gr.FillRectangle(Brushes.Green, e.X, e.Y, 10, 10);
            }
            else if(e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                gr.Clear(this.BackColor);
            }
        }
    }
}
