using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanetarySystem
{
    public partial class Form1 : Form
    {
        MT sun, mercury, venus, earth, mars, jupiter, saturn, uranus, neptune;

        

        MT[] planets;
        PictureBox[] pbPlanets;
        private void tBScale_Scroll(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sun = new MT() { m = 1.9885e+30, v = new Vector(), r = new Vector(0, 0) };
            mercury = new MT() { m = 3.2868e+23, v = new Vector(47360, 0), r = new Vector(0, 5.79e+10) };
            venus = new MT() { m = 4.867e+24, v = new Vector(35020, 0), r = new Vector(0, 1.0755e+11) };
            earth = new MT() { m = 5.972e+24, v = new Vector(29783, 0), r = new Vector(0, 1.4796e+11) };
            mars = new MT() { m = 6.39e+23, v = new Vector(24130, 0), r = new Vector(0, 2.183e+11) };
            jupiter = new MT() { m = 1.898e+27, v = new Vector(13070, 0), r = new Vector(0, 7.783e+11) };
            saturn = new MT() { m = 5.683e+26, v = new Vector(9670, 0), r = new Vector(0, 1.4298e+12) };
            uranus = new MT() { m = 8.681e+25, v = new Vector(6840, 0), r = new Vector(0, 2.87e+12) };
            neptune = new MT() { m = 1.024e+26, v = new Vector(5480, 0), r = new Vector(0, 4.495e+12) };

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            planets = new MT[] { mercury, venus, earth, mars, jupiter, saturn, uranus, neptune };
            pbPlanets = new PictureBox[] { pbMercury, pbVenus, pbEarth, pbMars, pbJupiter, pbSaturn, pbUrarnus, pbNeptune };


            double dt = 172800;//время двух ней в секундах;
            Vector Fe;
            Vector FSun = new Vector(0,0);
            for (int i = 0; i < planets.Length; i++)
            {
                Fe = GetF(planets[i], sun);
                FSun -= Fe;
                planets[i].Move(dt, Fe);
                pbPlanets[i].Location = MT.GetCoords(planets[i].r, tBScale.Value);
            }

            sun.Move(dt, FSun);
            pbSun.Location = MT.GetCoords(sun.r, tBScale.Value);
            
        }

        private Vector GetF(MT mt, MT c)
        {
            Vector m_e;
            double r3;

            m_e = mt.r - c.r;
            r3 = Math.Pow(m_e.Abs, 3);

            return -6.67e-11 * c.m * mt.m * m_e / r3;
        }

    }
}
