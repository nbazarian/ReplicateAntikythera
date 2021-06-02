
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AntikytheraGUI.Properties.Resources.Space_Free_PNG_Image;
            this.ClientSize = new System.Drawing.Size(1105, 588);
            this.Controls.Add(this.titleHeading);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Replicate Antikythera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleHeading;
    }
}

