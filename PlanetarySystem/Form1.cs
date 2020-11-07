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
        MT sun, mercury, venus, eart, mars, jupiter, saturn, uranus, neptune;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sun = new MT() { m = 1.9885e+30, v = new Vector(), r = new Vector(pbSun.Left, pbSun.Top) };
            mercury = new MT() { m = 3.2868e+23, v = new Vector(47.87, 0), r = new Vector(pbMercury.Left, pbMercury.Top) };

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double dt = timer1.Interval / 1000.0 * 300000;

            Vector m_e = sun.r - mercury.r;
            double r3 = Math.Pow(m_e.Abs, 3);
            Vector Fe = -6.67e-29 * mercury.m * sun.m * m_e / r3;
            Vector Fm = -Fe;

            mercury.Move(dt, Fm);

            pbMercury.Location = new Point((int)mercury.r.X, (int)mercury.r.Y);
            
        }
    }
}
