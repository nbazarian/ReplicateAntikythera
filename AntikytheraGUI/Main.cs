using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntikytheraGUI
{
    public partial class Main : Form
    {
        bool reset = false;

        bool january = false;
        bool february = false;
        bool march = false;
        bool april = false;
        bool may = false;
        bool june = false;
        bool july = false;
        bool august = false;
        bool september = false;
        bool october = false;
        bool november = false;
        bool december = false;

        public Main()
        {

            InitializeComponent();

            //var pictureBox = new OvalPictureBox
            //{
            //    Angle = Math.PI,
            //    Speed = Math.PI / 20,
            //    Distance = 50,
            //    BackColor = Color.Black,
            //    Width = 10,
            //    Height = 10,
            //    Location = new Point(100, 50)
            //};
            //Controls.Add(pictureBox);

            //timer.Tick += (sender, args) => pictureBox.RotateStep();
            //timer.Start();


        }

        private void btn_start_Click(object s, EventArgs e)
        {
            reset = false;
            var timer = new Timer { Interval = 10 };
            timer.Start();
            //mercury
            mercury.Angle = Math.PI;
            mercury.Speed = Math.PI / -22;
            mercury.Distance = 75;
            //ovalPictureBox8.Location = new Point(555, 450);
            Controls.Add(mercury);
            if(reset == true)
            {
                timer.Stop();
            }
            else
            {
                timer.Tick += (sender, args) => mercury.RotateStep(reset);
            }

            //venus
            venus.Angle = Math.PI;
            venus.Speed = Math.PI / -30;
            venus.Distance = 120;
            //ovalPictureBox8.Location = new Point(555, 450);
            Controls.Add(venus);
            timer.Tick += (sender, args) => venus.RotateStep(reset);

            //earth
            earth.Angle = Math.PI;
            earth.Speed = Math.PI / -36;
            earth.Distance = 152;
            //ovalPictureBox8.Location = new Point(555, 450);
            Controls.Add(earth);
            timer.Tick += (sender, args) => earth.RotateStep(reset);

            //mars
            mars.Angle = Math.PI;
            mars.Speed = Math.PI / -44;
            mars.Distance = 194;
            //ovalPictureBox8.Location = new Point(555, 450);
            Controls.Add(mars);
            timer.Tick += (sender, args) => mars.RotateStep(reset);

            //jupiter
            jupiter.Angle = Math.PI;
            jupiter.Speed = Math.PI / -82;
            jupiter.Distance = 266;
            //ovalPictureBox8.Location = new Point(555, 450);
            Controls.Add(jupiter);
            timer.Tick += (sender, args) => jupiter.RotateStep(reset);

            //saturn
            saturn.Angle = Math.PI;
            saturn.Speed = Math.PI / -110;
            saturn.Distance = 337;
            //ovalPictureBox8.Location = new Point(555, 450);
            Controls.Add(saturn);
            timer.Tick += (sender, args) => saturn.RotateStep(reset);

            //uranus
            uranus.Angle = Math.PI;
            uranus.Speed = Math.PI / -158;
            uranus.Distance = 426;
            //ovalPictureBox8.Location = new Point(555, 450);
            Controls.Add(uranus);
            timer.Tick += (sender, args) => uranus.RotateStep(reset);

            //neptune
            neptune.Angle = Math.PI;
            neptune.Speed = Math.PI / -200;
            neptune.Distance = 532;
            //ovalPictureBox8.Location = new Point(555, 450);
            Controls.Add(neptune);
            timer.Tick += (sender, args) => neptune.RotateStep(reset);

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset = true;
            mercury.Location = new Point(628, 505);
            venus.Location = new Point(592, 500);
            earth.Location = new Point(552, 498);
            mars.Location = new Point(516, 503);
            jupiter.Location = new Point(416, 485);
            saturn.Location = new Point(348, 488);
            uranus.Location = new Point(264, 493);
            neptune.Location = new Point(160, 495);
            return;
        }

        private void comboBox_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_month.SelectedItem.ToString() == "1 (January)")
            {
                january = true;
            }
            if (comboBox_month.SelectedItem.ToString() == "2 (February)")
            {
                february = true;

            }
            if (comboBox_month.SelectedItem.ToString() == "3 (March)")
            {
                march = true;
            }
            if (comboBox_month.SelectedItem.ToString() == "4 (April)")
            {
                april = true;
            }
            if (comboBox_month.SelectedItem.ToString() == "5 (May)")
            {
                may = true;
            }
            if (comboBox_month.SelectedItem.ToString() == "6 (June)")
            {
                june = true;
            }
            if (comboBox_month.SelectedItem.ToString() == "7 (July)")
            {
                july = true;
            }
            if (comboBox_month.SelectedItem.ToString() == "8 (August)")
            {
                august = true;
            }
            if (comboBox_month.SelectedItem.ToString() == "9 (September)")
            {
                september = true;
            }
            if (comboBox_month.SelectedItem.ToString() == "10 (October)")
            {
                october = true;
            }
            if (comboBox_month.SelectedItem.ToString() == "11 (November)")
            {
                november = true;
            }
            if (comboBox_month.SelectedItem.ToString() == "12 (December)")
            {
                december = true;
            }
        }

        private void btn_predict_Click(object sender, EventArgs e)
        {


            if(january == true)
            {
                //location

            }
            if (february == true)
            {
                //location

            }
            if (march == true)
            {
                //location

            }
            if (april == true)
            {
                //location

            }
            if (may == true)
            {
                //location

            }
            if (june == true)
            {
                //location

            }
            if (july == true)
            {
                //location

            }
            if (august == true)
            {
                //location

            }
            if (september == true)
            {
                //location

            }
            if (october == true)
            {
                //location

            }
            if (november == true)
            {
                //location

            }
            if (december == true)
            {
                //location

            }

        }
    }
}
