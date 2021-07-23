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

        bool orbitButton = false;
        bool predictButton = false;
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
            orbitButton = true;
            var timer = new Timer { Interval = 10 };
            timer.Start();

            if (reset == true)
            {
                timer.Stop();
            }

            if (predictButton == true)
            {
                MessageBox.Show("ERROR: Press 'Reset' button before orbitting. \nUnable to predict & orbit at the same time.");
            }
            else
            {
                //mercury
                mercury.Angle = Math.PI;
                mercury.Speed = Math.PI / -22;
                mercury.Distance = 75;
                //ovalPictureBox8.Location = new Point(555, 450);
                Controls.Add(mercury);
                timer.Tick += (sender, args) => mercury.RotateStep(reset);


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


                reset = false;
            }
       
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

            january = false;
            february = false;
            march = false;
            april = false;
            may = false;
            june = false;
            july = false;
            august = false;
            september = false;
            october = false;
            november = false;
            december = false;

            comboBox_month.Text = "";

            orbitButton = false;
            predictButton = false;
            return;
        }

        private void comboBox_month_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox_month.SelectedItem.ToString() == "1 (January)")
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
            predictButton = true;
            if(orbitButton == true)
            {
                MessageBox.Show("ERROR: Press 'Reset' button before predicting. \nUnable to predict & orbit at the same time.");
            }
            else
            {
                if (january == true)
                {
                    //location
                    mercury.Location = new Point(664, 446);
                    venus.Location = new Point(811, 527);
                    earth.Location = new Point(587, 587);
                    mars.Location = new Point(515, 462);
                    jupiter.Location = new Point(864, 370);
                    saturn.Location = new Point(932, 324);
                    uranus.Location = new Point(375, 181);
                    neptune.Location = new Point(811, 12);
                    january = false;

                }
                if (february == true)
                {
                    //location
                    mercury.Location = new Point(714, 579);
                    venus.Location = new Point(791, 422);
                    earth.Location = new Point(614, 608);
                    mars.Location = new Point(513, 520);
                    jupiter.Location = new Point(863, 363);
                    saturn.Location = new Point(956, 315);
                    uranus.Location = new Point(366, 194);
                    neptune.Location = new Point(791, 9);
                    february = false;

                }
                if (march == true)
                {
                    //location
                    mercury.Location = new Point(771, 493);
                    venus.Location = new Point(692, 393);
                    earth.Location = new Point(687, 636);
                    mars.Location = new Point(514, 551);
                    jupiter.Location = new Point(854, 343);
                    saturn.Location = new Point(919, 275); 
                    uranus.Location = new Point(374, 217);
                    neptune.Location = new Point(771, 12);
                    march = false;
                }
                if (april == true)
                {
                    //location
                    mercury.Location = new Point(642, 451);
                    venus.Location = new Point(620, 415);
                    earth.Location = new Point(745, 619);
                    mars.Location = new Point(527, 587);
                    jupiter.Location = new Point(847, 345);
                    saturn.Location = new Point(948, 301);
                    uranus.Location = new Point(368, 231);
                    neptune.Location = new Point(762, 12);
                    april = false;

                }
                if (may == true)
                {
                    //location
                    mercury.Location = new Point(703, 570);
                    venus.Location = new Point(589, 515);
                    earth.Location = new Point(839, 548);
                    mars.Location = new Point(549, 619);
                    jupiter.Location = new Point(839, 335);
                    saturn.Location = new Point(940, 294);
                    uranus.Location = new Point(361, 247);
                    neptune.Location = new Point(745, 12);
                    may = false;
                }
                if (june == true)
                {
                    //location
                    mercury.Location = new Point(765, 483);
                    venus.Location = new Point(613, 570);
                    earth.Location = new Point(838, 493);
                    mars.Location = new Point(579, 646);
                    jupiter.Location = new Point(828, 327);
                    saturn.Location = new Point(932, 282);
                    uranus.Location = new Point(357, 258);
                    neptune.Location = new Point(732, 12);
                    june = false;
                }
                if (july == true)
                {
                    //location
                    mercury.Location = new Point(626, 478);
                    venus.Location = new Point(702, 592);
                    earth.Location = new Point(828, 453);
                    mars.Location = new Point(654, 666);
                    jupiter.Location = new Point(828, 327);
                    saturn.Location = new Point(932, 282);
                    uranus.Location = new Point(350, 273);
                    neptune.Location = new Point(719, 12);
                    july = false;
                }
                if (august == true)
                {
                    //location
                    mercury.Location = new Point(759, 534);
                    venus.Location = new Point(785, 524);
                    earth.Location = new Point(759, 389);
                    mars.Location = new Point(678, 673);
                    jupiter.Location = new Point(794, 316);
                    saturn.Location = new Point(920, 265);
                    uranus.Location = new Point(339, 292);
                    neptune.Location = new Point(692, 12);
                    august = false;

                }
                if (september == true)
                {
                    //location
                    mercury.Location = new Point(755, 472);
                    venus.Location = new Point(785, 462);
                    earth.Location = new Point(691, 374);
                    mars.Location = new Point(734, 666);
                    jupiter.Location = new Point(768, 301);
                    saturn.Location = new Point(913, 251);
                    uranus.Location = new Point(327, 316);
                    neptune.Location = new Point(663, 12);
                    september = false;
                }
                if (october == true)
                {
                    //location
                    mercury.Location = new Point(628, 502);
                    venus.Location = new Point(706, 410);
                    earth.Location = new Point(628, 381);
                    mars.Location = new Point(769, 655);
                    jupiter.Location = new Point(746, 283);
                    saturn.Location = new Point(891, 240);
                    uranus.Location = new Point(321, 333);
                    neptune.Location = new Point(637, 21);
                    october = false;
                }
                if (november == true)
                {
                    //location
                    mercury.Location = new Point(761, 547);
                    venus.Location = new Point(628, 426);
                    earth.Location = new Point(571, 421);
                    mars.Location = new Point(815, 620);
                    jupiter.Location = new Point(721, 267);
                    saturn.Location = new Point(877, 221);
                    uranus.Location = new Point(312, 351);
                    neptune.Location = new Point(608, 31);
                    november = false;
                }
                if (december == true)
                {
                    //location
                    mercury.Location = new Point(725, 446);
                    venus.Location = new Point(586, 477);
                    earth.Location = new Point(540, 493);
                    mars.Location = new Point(851, 570);
                    jupiter.Location = new Point(711, 258);
                    saturn.Location = new Point(861, 207);
                    uranus.Location = new Point(305, 364);
                    neptune.Location = new Point(586, 36);
                    december = false;
                }
            }
           

        }
    }
}
