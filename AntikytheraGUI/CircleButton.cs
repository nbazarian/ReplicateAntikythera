using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Web;
using System.IO;

namespace AntikytheraGUI
{
    class CircleButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath graphics = new GraphicsPath();
            graphics.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(graphics);

            base.OnPaint(pevent);
        }
    }

    class OvalPictureBox : PictureBox
    {
        public OvalPictureBox()
        {
            this.BackColor = Color.DarkGray;
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            using (var gp = new GraphicsPath())
            {
                gp.AddEllipse(new Rectangle(0, 0, this.Width - 1, this.Height - 1));
                this.Region = new Region(gp);
            }
        }

        public double Angle { get; set; }
        public double Speed { get; set; }
        public double Distance { get; set; }

        public void RotateStep(bool reset)
        {
            if (reset == true)
            {

            }
            else
            {
                var oldX = Math.Cos(Angle) * Distance;
                var oldY = Math.Sin(Angle) * Distance;
                Angle += Speed;
                var x = Math.Cos(Angle) * Distance - oldX;
                var y = Math.Sin(Angle) * Distance - oldY;
                Location += new Size((int)x, (int)y);
            }

        }
    }

  
}
