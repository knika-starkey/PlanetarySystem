namespace PlanetarySystem
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tBScale = new System.Windows.Forms.TrackBar();
            this.pbNeptune = new System.Windows.Forms.PictureBox();
            this.pbUrarnus = new System.Windows.Forms.PictureBox();
            this.pbSaturn = new System.Windows.Forms.PictureBox();
            this.pbJupiter = new System.Windows.Forms.PictureBox();
            this.pbMars = new System.Windows.Forms.PictureBox();
            this.pbEarth = new System.Windows.Forms.PictureBox();
            this.pbVenus = new System.Windows.Forms.PictureBox();
            this.pbMercury = new System.Windows.Forms.PictureBox();
            this.pbSun = new System.Windows.Forms.PictureBox();
            this.pbMoon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tBScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNeptune)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUrarnus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSaturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJupiter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEarth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVenus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMercury)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoon)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1091, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 24);
            this.button1.TabIndex = 9;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 33;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tBScale
            // 
            this.tBScale.Location = new System.Drawing.Point(1091, 42);
            this.tBScale.Maximum = 90;
            this.tBScale.Minimum = 1;
            this.tBScale.Name = "tBScale";
            this.tBScale.Size = new System.Drawing.Size(81, 45);
            this.tBScale.TabIndex = 10;
            this.tBScale.Value = 10;
            this.tBScale.Scroll += new System.EventHandler(this.tBScale_Scroll);
            // 
            // pbNeptune
            // 
            this.pbNeptune.Image = global::PlanetarySystem.Properties.Resources.neptune;
            this.pbNeptune.Location = new System.Drawing.Point(694, 163);
            this.pbNeptune.Name = "pbNeptune";
            this.pbNeptune.Size = new System.Drawing.Size(6, 6);
            this.pbNeptune.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNeptune.TabIndex = 8;
            this.pbNeptune.TabStop = false;
            // 
            // pbUrarnus
            // 
            this.pbUrarnus.Image = global::PlanetarySystem.Properties.Resources.uranus;
            this.pbUrarnus.Location = new System.Drawing.Point(673, 183);
            this.pbUrarnus.Name = "pbUrarnus";
            this.pbUrarnus.Size = new System.Drawing.Size(6, 6);
            this.pbUrarnus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUrarnus.TabIndex = 7;
            this.pbUrarnus.TabStop = false;
            // 
            // pbSaturn
            // 
            this.pbSaturn.Image = global::PlanetarySystem.Properties.Resources.saturn;
            this.pbSaturn.Location = new System.Drawing.Point(615, 202);
            this.pbSaturn.Name = "pbSaturn";
            this.pbSaturn.Size = new System.Drawing.Size(20, 10);
            this.pbSaturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSaturn.TabIndex = 6;
            this.pbSaturn.TabStop = false;
            // 
            // pbJupiter
            // 
            this.pbJupiter.Image = global::PlanetarySystem.Properties.Resources.jupiter;
            this.pbJupiter.Location = new System.Drawing.Point(587, 239);
            this.pbJupiter.Name = "pbJupiter";
            this.pbJupiter.Size = new System.Drawing.Size(10, 10);
            this.pbJupiter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbJupiter.TabIndex = 5;
            this.pbJupiter.TabStop = false;
            // 
            // pbMars
            // 
            this.pbMars.Image = global::PlanetarySystem.Properties.Resources.mars;
            this.pbMars.Location = new System.Drawing.Point(573, 286);
            this.pbMars.Name = "pbMars";
            this.pbMars.Size = new System.Drawing.Size(4, 4);
            this.pbMars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMars.TabIndex = 4;
            this.pbMars.TabStop = false;
            // 
            // pbEarth
            // 
            this.pbEarth.Image = global::PlanetarySystem.Properties.Resources.earth;
            this.pbEarth.Location = new System.Drawing.Point(545, 312);
            this.pbEarth.Name = "pbEarth";
            this.pbEarth.Size = new System.Drawing.Size(5, 5);
            this.pbEarth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEarth.TabIndex = 3;
            this.pbEarth.TabStop = false;
            // 
            // pbVenus
            // 
            this.pbVenus.Image = global::PlanetarySystem.Properties.Resources.venus;
            this.pbVenus.Location = new System.Drawing.Point(509, 351);
            this.pbVenus.Name = "pbVenus";
            this.pbVenus.Size = new System.Drawing.Size(5, 5);
            this.pbVenus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVenus.TabIndex = 2;
            this.pbVenus.TabStop = false;
            // 
            // pbMercury
            // 
            this.pbMercury.Image = global::PlanetarySystem.Properties.Resources.mercury;
            this.pbMercury.Location = new System.Drawing.Point(468, 403);
            this.pbMercury.Name = "pbMercury";
            this.pbMercury.Size = new System.Drawing.Size(3, 3);
            this.pbMercury.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMercury.TabIndex = 1;
            this.pbMercury.TabStop = false;
            // 
            // pbSun
            // 
            this.pbSun.Image = global::PlanetarySystem.Properties.Resources.sun;
            this.pbSun.Location = new System.Drawing.Point(358, 420);
            this.pbSun.Name = "pbSun";
            this.pbSun.Size = new System.Drawing.Size(7, 7);
            this.pbSun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSun.TabIndex = 0;
            this.pbSun.TabStop = false;
            this.pbSun.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbMoon
            // 
            this.pbMoon.Image = global::PlanetarySystem.Properties.Resources.moon;
            this.pbMoon.Location = new System.Drawing.Point(562, 321);
            this.pbMoon.Name = "pbMoon";
            this.pbMoon.Size = new System.Drawing.Size(5, 5);
            this.pbMoon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMoon.TabIndex = 11;
            this.pbMoon.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1184, 1061);
            this.Controls.Add(this.pbMoon);
            this.Controls.Add(this.tBScale);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbNeptune);
            this.Controls.Add(this.pbUrarnus);
            this.Controls.Add(this.pbSaturn);
            this.Controls.Add(this.pbJupiter);
            this.Controls.Add(this.pbMars);
            this.Controls.Add(this.pbEarth);
            this.Controls.Add(this.pbVenus);
            this.Controls.Add(this.pbMercury);
            this.Controls.Add(this.pbSun);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNeptune)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUrarnus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSaturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJupiter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEarth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVenus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMercury)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSun;
        private System.Windows.Forms.PictureBox pbMercury;
        private System.Windows.Forms.PictureBox pbVenus;
        private System.Windows.Forms.PictureBox pbEarth;
        private System.Windows.Forms.PictureBox pbMars;
        private System.Windows.Forms.PictureBox pbJupiter;
        private System.Windows.Forms.PictureBox pbSaturn;
        private System.Windows.Forms.PictureBox pbUrarnus;
        private System.Windows.Forms.PictureBox pbNeptune;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar tBScale;
        private System.Windows.Forms.PictureBox pbMoon;
    }
}

