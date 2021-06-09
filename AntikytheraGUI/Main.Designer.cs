
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
            this.comboBox_Stars = new System.Windows.Forms.ComboBox();
            this.comboBox_Planets = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lbl_stars = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleHeading
            // 
            this.titleHeading.AutoSize = true;
            this.titleHeading.BackColor = System.Drawing.Color.Transparent;
            this.titleHeading.Font = new System.Drawing.Font("Myriad Pro Cond", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleHeading.ForeColor = System.Drawing.SystemColors.Control;
            this.titleHeading.Location = new System.Drawing.Point(399, 9);
            this.titleHeading.Name = "titleHeading";
            this.titleHeading.Size = new System.Drawing.Size(304, 45);
            this.titleHeading.TabIndex = 0;
            this.titleHeading.Text = "Replicate Antikythera";
            // 
            // comboBox_Stars
            // 
            this.comboBox_Stars.FormattingEnabled = true;
            this.comboBox_Stars.Location = new System.Drawing.Point(407, 110);
            this.comboBox_Stars.Name = "comboBox_Stars";
            this.comboBox_Stars.Size = new System.Drawing.Size(296, 21);
            this.comboBox_Stars.TabIndex = 1;
            // 
            // comboBox_Planets
            // 
            this.comboBox_Planets.FormattingEnabled = true;
            this.comboBox_Planets.Location = new System.Drawing.Point(407, 158);
            this.comboBox_Planets.Name = "comboBox_Planets";
            this.comboBox_Planets.Size = new System.Drawing.Size(296, 21);
            this.comboBox_Planets.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(407, 208);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(296, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // lbl_stars
            // 
            this.lbl_stars.AutoSize = true;
            this.lbl_stars.BackColor = System.Drawing.Color.Transparent;
            this.lbl_stars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stars.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_stars.Location = new System.Drawing.Point(333, 111);
            this.lbl_stars.Name = "lbl_stars";
            this.lbl_stars.Size = new System.Drawing.Size(57, 20);
            this.lbl_stars.TabIndex = 4;
            this.lbl_stars.Text = "Stars:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AntikytheraGUI.Properties.Resources.Space_Free_PNG_Image;
            this.ClientSize = new System.Drawing.Size(1105, 588);
            this.Controls.Add(this.lbl_stars);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox_Planets);
            this.Controls.Add(this.comboBox_Stars);
            this.Controls.Add(this.titleHeading);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Replicate Antikythera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleHeading;
        private System.Windows.Forms.ComboBox comboBox_Stars;
        private System.Windows.Forms.ComboBox comboBox_Planets;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lbl_stars;
    }
}

