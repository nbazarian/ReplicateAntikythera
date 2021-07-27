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
        //flags
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

        bool y2022 = false;
        bool y2023 = false;
        bool y2024 = false;
        bool y2025 = false;
        bool y2026 = false;
        bool y2027 = false;
        bool y2028 = false;
        bool y2029 = false;
        bool y2030 = false;
        bool y2031 = false;

        bool monthCheck = false;
        bool yearCheck = false;

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

            this.mercury.MouseHover += button1_MouseHover;
            this.venus.MouseHover += button2_MouseHover;
            this.earth.MouseHover += button3_MouseHover;
            this.mars.MouseHover += button4_MouseHover;
            this.jupiter.MouseHover += button5_MouseHover;
            this.saturn.MouseHover += button6_MouseHover;
            this.uranus.MouseHover += button7_MouseHover;
            this.neptune.MouseHover += button8_MouseHover;
        }

        ToolTip t1 = new ToolTip();
        ToolTip t2 = new ToolTip();
        ToolTip t3 = new ToolTip();
        ToolTip t4 = new ToolTip();
        ToolTip t5 = new ToolTip();
        ToolTip t6 = new ToolTip();
        ToolTip t7 = new ToolTip();
        ToolTip t8 = new ToolTip();

        private void button1_MouseHover(object sender, EventArgs e)
        {
            t1.Show("Name: Mercury\nOrbit Period: 88 days\nOrbit Speed: 29 mi/s\nDistance from the sun: 43.382 million miles\nMass: 3.285 * 10^23 kg\nPlanet Type: Rough Surface", mercury);

        }
        private void button2_MouseHover(object sender, EventArgs e)
        {
            t2.Show("Name: Venus\nOrbit Period: 225 days\nOrbit Speed: 21.748 mi/s\nDistance from the sun: 66.785 million miles\nMass: 4.867 * 10^24 kg\nPlanet Type: Terrestrial", venus);

        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            t3.Show("Name: Earth\nOrbit Period: 365 days\nOrbit Speed: 18.6411 mi/s\nDistance from the sun: 94.369 million miles\nMass: 5.972 * 10^24 kg\nPlanet Type: Terrestrial", earth);

        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            t4.Show("Name: Mars\nOrbit Period: 687 days\nOrbit Speed: 14.9607 mi/s\nDistance from the sun: 155.27 million miles\nMass: 6.39 * 10^23 kg\nPlanet Type: Terrestrial", mars);

        }
        private void button5_MouseHover(object sender, EventArgs e)
        {
            t5.Show("Name: Jupiter\nOrbit Period: 11.86 years\nOrbit Speed: 8.1213215 mi/s\nDistance from the sun: 469.23 million miles\nMass: 1.898 * 10^27 kg\nPlanet Type: Gas-Giant", jupiter);

        }
        private void button6_MouseHover(object sender, EventArgs e)
        {
            t6.Show("Name: Saturn\nOrbit Period: 29 years\nOrbit Speed: 6.021087 mi/s\nDistance from the sun: 924.19 million miles\nMass: 5.683 * 10^26 kg\nPlanet Type: Gas-Giant", saturn);

        }
        private void button7_MouseHover(object sender, EventArgs e)
        {
            t7.Show("Name: Uranus\nOrbit Period: 83.75 years\nOrbit Speed: 4.23153781914 mi/s\nDistance from the sun: 1.8357 billion miles\nMass: 8.681 * 10^25 kg\nPlanet Type: Ice Giant", uranus);
        }
        private void button8_MouseHover(object sender, EventArgs e)
        {
            t8.Show("Name: Neptune\nOrbit Period: 163.72 years\nOrbit Speed: 3.374046 mi/s\nDistance from the sun: 2.7809 billion miles\nMass: 1.024 * 10^26 kg\nPlanet Type: Ice Giant", neptune);
        }
        private void btn_start_Click(object s, EventArgs e)
        {
            orbitButton = true;
            btn_orbit.BackColor = System.Drawing.Color.Green;
            var timer = new Timer { Interval = 10 };
            timer.Start();

            if (reset == true)
            {
                timer.Stop();
            }

            if (predictButton == true)
            {
                btn_orbit.BackColor = System.Drawing.Color.Red;

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

            y2022 = false;
            y2023 = false;
            y2024 = false;
            y2025 = false;
            y2026 = false;
            y2027 = false;
            y2028 = false;
            y2029 = false;
            y2030 = false;
            y2031 = false;

            comboBox_year.Text = "";
            comboBox_month.Text = "";


            checkBox_month.Checked = false;
            checkBox1.Checked = false;

            comboBox_month.Visible = false;
            comboBox_year.Visible = false;


            monthCheck = false;
            yearCheck = false;

            orbitButton = false;
            predictButton = false;

            btn_orbit.BackColor = Control.DefaultBackColor;
            btn_orbit.ForeColor = System.Drawing.Color.Black;

            btn_predict.BackColor = Control.DefaultBackColor;
            btn_predict.ForeColor = System.Drawing.Color.Black;
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

            if (orbitButton == true)
            {
                btn_predict.BackColor = System.Drawing.Color.Red;

                MessageBox.Show("ERROR: Press 'Reset' button before predicting. \nUnable to predict & orbit at the same time.");
            }
            else if(comboBox_year.Visible == true && comboBox_month.Visible == true)
            {
                btn_predict.BackColor = System.Drawing.Color.Red;

                MessageBox.Show("ERROR: Press 'Reset' button before predicting. \nUnable to predict month and year at the same time.");
                

            }
            else if(comboBox_month.Visible == true && comboBox_year.Visible == true)
            {
                btn_predict.BackColor = System.Drawing.Color.Red;

                MessageBox.Show("ERROR: Press 'Reset' button before predicting. \nUnable to predict month and year at the same time.");

               

            }
            else
            {

                //months
                if (january == true)
                {
                    btn_predict.BackColor = System.Drawing.Color.Green;

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
                    btn_predict.BackColor = System.Drawing.Color.Green;

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
                    btn_predict.BackColor = System.Drawing.Color.Green;

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
                    btn_predict.BackColor = System.Drawing.Color.Green;

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
                    btn_predict.BackColor = System.Drawing.Color.Green;

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
                    btn_predict.BackColor = System.Drawing.Color.Green;

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
                    btn_predict.BackColor = System.Drawing.Color.Green;

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
                    btn_predict.BackColor = System.Drawing.Color.Green;

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
                    btn_predict.BackColor = System.Drawing.Color.Green;

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
                    btn_predict.BackColor = System.Drawing.Color.Green;

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
                    btn_predict.BackColor = System.Drawing.Color.Green;

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
                    btn_predict.BackColor = System.Drawing.Color.Green;

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


                //years
                if(y2022 == true)
                {
                    btn_predict.BackColor = System.Drawing.Color.Green;

                    //location
                    mercury.Location = new Point(654, 563);
                    venus.Location = new Point(599, 462);
                    earth.Location = new Point(826, 414);
                    mars.Location = new Point(699, 354);
                    jupiter.Location = new Point(687, 257);
                    saturn.Location = new Point(902, 282);
                    uranus.Location = new Point(354, 231);
                    neptune.Location = new Point(785, 32);
                    y2022 = false;
                }
                if (y2023 == true)
                {
                    btn_predict.BackColor = System.Drawing.Color.Green;

                    //location
                    mercury.Location = new Point(730, 563);
                    venus.Location = new Point(807, 462);
                    earth.Location = new Point(826, 414);
                    mars.Location = new Point(696, 663);
                    jupiter.Location = new Point(537, 284);
                    saturn.Location = new Point(843, 231);
                    uranus.Location = new Point(337, 243);
                    neptune.Location = new Point(746, 21);
                    y2023 = false;
                }
                if (y2024 == true)
                {
                    btn_predict.BackColor = System.Drawing.Color.Green;

                    //location
                    mercury.Location = new Point(767, 514);
                    venus.Location = new Point(641, 580);
                    earth.Location = new Point(826, 414);
                    mars.Location = new Point(573, 364);
                    jupiter.Location = new Point(419, 414);
                    saturn.Location = new Point(730, 191);
                    uranus.Location = new Point(311, 275);
                    neptune.Location = new Point(710, 9);
                    y2024 = false;
                }
                if (y2025 == true)
                {
                    btn_predict.BackColor = System.Drawing.Color.Green;

                    //location
                    mercury.Location = new Point(766, 481);
                    venus.Location = new Point(645, 404);
                    earth.Location = new Point(826, 414);
                    mars.Location = new Point(722, 675);
                    jupiter.Location = new Point(421, 493);
                    saturn.Location = new Point(692, 181);
                    uranus.Location = new Point(304, 293);
                    neptune.Location = new Point(654, 21);
                    y2025 = false;
                }
                if (y2026 == true)
                {
                    btn_predict.BackColor = System.Drawing.Color.Green;

                    //location
                    mercury.Location = new Point(705, 436);
                    venus.Location = new Point(817, 537);
                    earth.Location = new Point(826, 414);
                    mars.Location = new Point(525, 414);
                    jupiter.Location = new Point(444, 570);
                    saturn.Location = new Point(620, 193);
                    uranus.Location = new Point(289, 318);
                    neptune.Location = new Point(635, 30);
                    y2026 = false;
                }
                if (y2027 == true)
                {
                    btn_predict.BackColor = System.Drawing.Color.Green;

                    //location
                    mercury.Location = new Point(638, 462);
                    venus.Location = new Point(587, 515);
                    earth.Location = new Point(826, 414);
                    mars.Location = new Point(826, 626);
                    jupiter.Location = new Point(587, 705);
                    saturn.Location = new Point(543, 222);
                    uranus.Location = new Point(287, 338);
                    neptune.Location = new Point(567, 30);
                    y2027 = false;
                }
                if (y2028 == true)
                {
                    btn_predict.BackColor = System.Drawing.Color.Green;

                    //location
                    mercury.Location = new Point(629, 534);
                    venus.Location = new Point(769, 419);
                    earth.Location = new Point(826, 414);
                    mars.Location = new Point(513, 462);
                    jupiter.Location = new Point(699, 720);
                    saturn.Location = new Point(483, 253);
                    uranus.Location = new Point(271, 372);
                    neptune.Location = new Point(519, 37);
                    y2028 = false;
                }
                if (y2029 == true)
                {
                    btn_predict.BackColor = System.Drawing.Color.Green;

                    //location
                    mercury.Location = new Point(704, 580);
                    venus.Location = new Point(720, 605);
                    earth.Location = new Point(826, 414);
                    mars.Location = new Point(866, 551);
                    jupiter.Location = new Point(813, 705);
                    saturn.Location = new Point(429, 308);
                    uranus.Location = new Point(258, 404);
                    neptune.Location = new Point(483, 44);
                    y2029 = false;
                }
                if (y2030 == true)
                {
                    btn_predict.BackColor = System.Drawing.Color.Green;

                    //location
                    mercury.Location = new Point(749, 563);
                    venus.Location = new Point(587, 473);
                    earth.Location = new Point(826, 414);
                    mars.Location = new Point(507, 520);
                    jupiter.Location = new Point(942, 619);
                    saturn.Location = new Point(389, 394);
                    uranus.Location = new Point(245, 437);
                    neptune.Location = new Point(444, 52);

                    y2030 = false;
                }
                if (y2031 == true)
                {
                    btn_predict.BackColor = System.Drawing.Color.Green;

                    //location
                    mercury.Location = new Point(776, 493);
                    venus.Location = new Point(810, 448);
                    earth.Location = new Point(826, 414);
                    mars.Location = new Point(885, 507);
                    jupiter.Location = new Point(950, 507);
                    saturn.Location = new Point(365, 448);
                    uranus.Location = new Point(233, 458);
                    neptune.Location = new Point(389, 64);
                    y2031 = false;
                }

            }
           

        }

        private void comboBox_year_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox_year.SelectedItem.ToString() == "2022")
            {
                y2022 = true;
            }
            if (comboBox_year.SelectedItem.ToString() == "2023")
            {
                y2023 = true;
            }
            if (comboBox_year.SelectedItem.ToString() == "2024")
            {
                y2024 = true;
            }
            if (comboBox_year.SelectedItem.ToString() == "2025")
            {
                y2025 = true;
            }
            if (comboBox_year.SelectedItem.ToString() == "2026")
            {
                y2026 = true;
            }
            if (comboBox_year.SelectedItem.ToString() == "2027")
            {
                y2027 = true;
            }
            if (comboBox_year.SelectedItem.ToString() == "2028")
            {
                y2028 = true;
            }
            if (comboBox_year.SelectedItem.ToString() == "2029")
            {
                y2029 = true;
            }
            if (comboBox_year.SelectedItem.ToString() == "2030")
            {
                y2030 = true;
            }
            if (comboBox_year.SelectedItem.ToString() == "2031")
            {
                y2031 = true;
            }
        }

        private void checkBox_month_CheckedChanged(object sender, EventArgs e)
        {

            monthCheck = true;
            comboBox_month.Visible = true;
     
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            yearCheck = true;

            comboBox_year.Visible = true;
            
            
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }
    }
}
