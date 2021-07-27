
namespace AntikytheraGUI
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.titleHeading = new System.Windows.Forms.Label();
            this.btn_orbit = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.comboBox_month = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_predict = new System.Windows.Forms.Button();
            this.lbl_year = new System.Windows.Forms.Label();
            this.comboBox_year = new System.Windows.Forms.ComboBox();
            this.checkBox_month = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.ovalPictureBox12 = new AntikytheraGUI.OvalPictureBox();
            this.venus = new AntikytheraGUI.OvalPictureBox();
            this.uranus = new AntikytheraGUI.OvalPictureBox();
            this.saturn = new AntikytheraGUI.OvalPictureBox();
            this.neptune = new AntikytheraGUI.OvalPictureBox();
            this.mercury = new AntikytheraGUI.OvalPictureBox();
            this.mars = new AntikytheraGUI.OvalPictureBox();
            this.jupiter = new AntikytheraGUI.OvalPictureBox();
            this.earth = new AntikytheraGUI.OvalPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.venus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uranus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neptune)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercury)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jupiter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.earth)).BeginInit();
            this.SuspendLayout();
            // 
            // titleHeading
            // 
            this.titleHeading.AutoSize = true;
            this.titleHeading.BackColor = System.Drawing.Color.Transparent;
            this.titleHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleHeading.ForeColor = System.Drawing.SystemColors.Control;
            this.titleHeading.Location = new System.Drawing.Point(1520, 9);
            this.titleHeading.Name = "titleHeading";
            this.titleHeading.Size = new System.Drawing.Size(392, 42);
            this.titleHeading.TabIndex = 0;
            this.titleHeading.Text = "Replicate Antikythera";
            // 
            // btn_orbit
            // 
            this.btn_orbit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_orbit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_orbit.Location = new System.Drawing.Point(1551, 570);
            this.btn_orbit.Name = "btn_orbit";
            this.btn_orbit.Size = new System.Drawing.Size(155, 42);
            this.btn_orbit.TabIndex = 15;
            this.btn_orbit.Text = "Orbit";
            this.btn_orbit.UseVisualStyleBackColor = false;
            this.btn_orbit.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(1734, 570);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(155, 42);
            this.btn_reset.TabIndex = 16;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // comboBox_month
            // 
            this.comboBox_month.FormattingEnabled = true;
            this.comboBox_month.Items.AddRange(new object[] {
            "1 (January)",
            "2 (February)",
            "3 (March)",
            "4 (April)",
            "5 (May)",
            "6 (June)",
            "7 (July)",
            "8 (August)",
            "9 (September)",
            "10 (October)",
            "11 (November)",
            "12 (December)"});
            this.comboBox_month.Location = new System.Drawing.Point(1622, 231);
            this.comboBox_month.Name = "comboBox_month";
            this.comboBox_month.Size = new System.Drawing.Size(192, 21);
            this.comboBox_month.TabIndex = 17;
            this.comboBox_month.Visible = false;
            this.comboBox_month.SelectedIndexChanged += new System.EventHandler(this.comboBox_month_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(1665, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 37);
            this.label1.TabIndex = 18;
            this.label1.Text = "Month";
            // 
            // btn_predict
            // 
            this.btn_predict.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_predict.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_predict.Location = new System.Drawing.Point(1644, 493);
            this.btn_predict.Name = "btn_predict";
            this.btn_predict.Size = new System.Drawing.Size(155, 42);
            this.btn_predict.TabIndex = 19;
            this.btn_predict.Text = "Predict";
            this.btn_predict.UseVisualStyleBackColor = false;
            this.btn_predict.Click += new System.EventHandler(this.btn_predict_Click);
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.BackColor = System.Drawing.Color.Transparent;
            this.lbl_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_year.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_year.Location = new System.Drawing.Point(1665, 279);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(89, 37);
            this.lbl_year.TabIndex = 21;
            this.lbl_year.Text = "Year";
            // 
            // comboBox_year
            // 
            this.comboBox_year.FormattingEnabled = true;
            this.comboBox_year.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031"});
            this.comboBox_year.Location = new System.Drawing.Point(1622, 319);
            this.comboBox_year.Name = "comboBox_year";
            this.comboBox_year.Size = new System.Drawing.Size(192, 21);
            this.comboBox_year.TabIndex = 20;
            this.comboBox_year.Visible = false;
            this.comboBox_year.SelectedIndexChanged += new System.EventHandler(this.comboBox_year_SelectedIndexChanged);
            // 
            // checkBox_month
            // 
            this.checkBox_month.AutoSize = true;
            this.checkBox_month.Location = new System.Drawing.Point(1644, 190);
            this.checkBox_month.Name = "checkBox_month";
            this.checkBox_month.Size = new System.Drawing.Size(15, 14);
            this.checkBox_month.TabIndex = 22;
            this.checkBox_month.UseVisualStyleBackColor = true;
            this.checkBox_month.CheckedChanged += new System.EventHandler(this.checkBox_month_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1644, 288);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btn_Quit
            // 
            this.btn_Quit.BackColor = System.Drawing.Color.Red;
            this.btn_Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quit.Location = new System.Drawing.Point(1644, 642);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(155, 42);
            this.btn_Quit.TabIndex = 24;
            this.btn_Quit.Text = "Quit";
            this.btn_Quit.UseVisualStyleBackColor = false;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // ovalPictureBox12
            // 
            this.ovalPictureBox12.Angle = 0D;
            this.ovalPictureBox12.BackColor = System.Drawing.Color.DarkGray;
            this.ovalPictureBox12.Distance = 0D;
            this.ovalPictureBox12.Image = global::AntikytheraGUI.Properties.Resources.sun1;
            this.ovalPictureBox12.Location = new System.Drawing.Point(654, 462);
            this.ovalPictureBox12.Name = "ovalPictureBox12";
            this.ovalPictureBox12.Size = new System.Drawing.Size(95, 95);
            this.ovalPictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ovalPictureBox12.Speed = 0D;
            this.ovalPictureBox12.TabIndex = 14;
            this.ovalPictureBox12.TabStop = false;
            // 
            // venus
            // 
            this.venus.Angle = 0D;
            this.venus.BackColor = System.Drawing.Color.DarkGray;
            this.venus.Distance = 0D;
            this.venus.Image = global::AntikytheraGUI.Properties.Resources.venus2;
            this.venus.Location = new System.Drawing.Point(592, 500);
            this.venus.Name = "venus";
            this.venus.Size = new System.Drawing.Size(20, 20);
            this.venus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.venus.Speed = 0D;
            this.venus.TabIndex = 13;
            this.venus.TabStop = false;
            // 
            // uranus
            // 
            this.uranus.Angle = 0D;
            this.uranus.BackColor = System.Drawing.Color.DarkGray;
            this.uranus.Distance = 0D;
            this.uranus.Image = global::AntikytheraGUI.Properties.Resources.uranus2;
            this.uranus.Location = new System.Drawing.Point(264, 493);
            this.uranus.Name = "uranus";
            this.uranus.Size = new System.Drawing.Size(35, 35);
            this.uranus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.uranus.Speed = 0D;
            this.uranus.TabIndex = 12;
            this.uranus.TabStop = false;
            // 
            // saturn
            // 
            this.saturn.Angle = 0D;
            this.saturn.BackColor = System.Drawing.Color.DarkGray;
            this.saturn.Distance = 0D;
            this.saturn.Image = global::AntikytheraGUI.Properties.Resources.saturn_2;
            this.saturn.Location = new System.Drawing.Point(348, 488);
            this.saturn.Name = "saturn";
            this.saturn.Size = new System.Drawing.Size(45, 45);
            this.saturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.saturn.Speed = 0D;
            this.saturn.TabIndex = 11;
            this.saturn.TabStop = false;
            // 
            // neptune
            // 
            this.neptune.Angle = 0D;
            this.neptune.BackColor = System.Drawing.Color.DarkGray;
            this.neptune.Distance = 0D;
            this.neptune.Image = global::AntikytheraGUI.Properties.Resources.neptune2;
            this.neptune.Location = new System.Drawing.Point(160, 495);
            this.neptune.Name = "neptune";
            this.neptune.Size = new System.Drawing.Size(30, 30);
            this.neptune.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.neptune.Speed = 0D;
            this.neptune.TabIndex = 9;
            this.neptune.TabStop = false;
            // 
            // mercury
            // 
            this.mercury.Angle = 0D;
            this.mercury.BackColor = System.Drawing.Color.DarkGray;
            this.mercury.Distance = 0D;
            this.mercury.Image = global::AntikytheraGUI.Properties.Resources.mercury2;
            this.mercury.Location = new System.Drawing.Point(628, 505);
            this.mercury.Name = "mercury";
            this.mercury.Size = new System.Drawing.Size(10, 10);
            this.mercury.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mercury.Speed = 0D;
            this.mercury.TabIndex = 7;
            this.mercury.TabStop = false;
            // 
            // mars
            // 
            this.mars.Angle = 0D;
            this.mars.BackColor = System.Drawing.Color.DarkGray;
            this.mars.Distance = 0D;
            this.mars.Image = global::AntikytheraGUI.Properties.Resources.mars;
            this.mars.Location = new System.Drawing.Point(516, 503);
            this.mars.Name = "mars";
            this.mars.Size = new System.Drawing.Size(15, 15);
            this.mars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mars.Speed = 0D;
            this.mars.TabIndex = 6;
            this.mars.TabStop = false;
            // 
            // jupiter
            // 
            this.jupiter.Angle = 0D;
            this.jupiter.BackColor = System.Drawing.Color.DarkGray;
            this.jupiter.Distance = 0D;
            this.jupiter.Image = global::AntikytheraGUI.Properties.Resources.jupiter;
            this.jupiter.Location = new System.Drawing.Point(416, 485);
            this.jupiter.Name = "jupiter";
            this.jupiter.Size = new System.Drawing.Size(50, 50);
            this.jupiter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.jupiter.Speed = 0D;
            this.jupiter.TabIndex = 5;
            this.jupiter.TabStop = false;
            // 
            // earth
            // 
            this.earth.Angle = 0D;
            this.earth.BackColor = System.Drawing.Color.DarkGray;
            this.earth.Distance = 0D;
            this.earth.Image = global::AntikytheraGUI.Properties.Resources.earth2;
            this.earth.Location = new System.Drawing.Point(552, 498);
            this.earth.Name = "earth";
            this.earth.Size = new System.Drawing.Size(25, 25);
            this.earth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.earth.Speed = 0D;
            this.earth.TabIndex = 2;
            this.earth.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AntikytheraGUI.Properties.Resources.Space_Free_PNG_Image;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.btn_Quit);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBox_month);
            this.Controls.Add(this.lbl_year);
            this.Controls.Add(this.comboBox_year);
            this.Controls.Add(this.btn_predict);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_month);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_orbit);
            this.Controls.Add(this.ovalPictureBox12);
            this.Controls.Add(this.venus);
            this.Controls.Add(this.uranus);
            this.Controls.Add(this.saturn);
            this.Controls.Add(this.neptune);
            this.Controls.Add(this.mercury);
            this.Controls.Add(this.mars);
            this.Controls.Add(this.jupiter);
            this.Controls.Add(this.earth);
            this.Controls.Add(this.titleHeading);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Replicate Antikythera";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.venus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uranus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neptune)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercury)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jupiter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.earth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleHeading;
        private OvalPictureBox earth;
        private OvalPictureBox jupiter;
        private OvalPictureBox mars;
        private OvalPictureBox mercury;
        private OvalPictureBox neptune;
        private OvalPictureBox saturn;
        private OvalPictureBox uranus;
        private OvalPictureBox venus;
        private OvalPictureBox ovalPictureBox12;
        private System.Windows.Forms.Button btn_orbit;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.ComboBox comboBox_month;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_predict;
        private System.Windows.Forms.Label lbl_year;
        private System.Windows.Forms.ComboBox comboBox_year;
        private System.Windows.Forms.CheckBox checkBox_month;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btn_Quit;
    }
}

