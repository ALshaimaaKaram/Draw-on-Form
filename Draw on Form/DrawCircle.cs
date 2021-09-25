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
    public partial class DrawCircle : Form
    {
        static int oldX = 100;
        static int X = oldX + 10;

        static int y = 100;
        public DrawCircle()
        {
            InitializeComponent();
        }

        private void DrawCircle_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Red, oldX, y, 75, 75);
        }

        private void timermove_Tick(object sender, EventArgs e)
        {
            Graphics gr = CreateGraphics();
            gr.Clear(this.BackColor);
            var condition = oldX < X && X < this.Width - 100;
            oldX = X;
            X = condition ? X + 10 : X - 10;
            if (X < 0)
            {
                var temp = oldX;
                oldX = X;
                X = temp;
            }

            gr.FillEllipse(Brushes.Red, X, y, 75, 75);
        }
        //private void timermove_Tick(object sender, EventArgs e)
        //{
        //    Graphics gr = CreateGraphics();

        //    if (oldX < X && X < this.Width - 100)
        //    {
        //        gr.Clear(this.BackColor);
        //        oldX = X;
        //        X += 10;
        //        //gr.FillEllipse(Brushes.Red, X, y, 75, 75);
        //        //gr.DrawEllipse(Pens.Red, x, y, 75, 75);
        //    }

        //    if (!(oldX < X && X < this.Width - 100))
        //    {
        //        gr.Clear(this.BackColor);
        //        oldX = X;
        //        X -= 10;
        //    }

        //    if (X < 10)
        //    {
        //        var temp = oldX;
        //        oldX = X;
        //        X = temp;
        //    }

        //    gr.FillEllipse(Brushes.Red, X, y, 75, 75);
        //}
    }
}
