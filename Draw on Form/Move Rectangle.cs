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
    public partial class Move_Rectangle : Form
    {
        Rectangle rect = new Rectangle(125, 125, 50, 50);
        bool isMouseDown = false;

        public Move_Rectangle()
        {
            InitializeComponent();
        }

        private void Move_Rectangle_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Yellow, rect);
            //e.Graphics.FillRectangle(Brushes.Yellow, 100, 50, 75, 75); ;
        }

        private void Move_Rectangle_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
        }

        private void Move_Rectangle_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown == true)
            {
                rect.X = e.X - 25;
                rect.Y = e.Y - 25;

                if (rect.Right > this.Width)
                {
                    rect.X = this.Width - rect.Width - rect.Width/2;
                }
                if (rect.Top < 0)
                {
                    rect.Y = 0;
                }
                if (rect.Left < 0)
                {
                    rect.X = 0;
                }
                if (rect.Bottom > this.Height)
                {
                    rect.Y = this.Height - rect.Height - rect.Height*2;
                }
                Refresh();
            }
        }

        private void Move_Rectangle_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }
    }
}
