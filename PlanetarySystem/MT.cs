using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanetarySystem
{
    public class MT
    {
        public Vector r { get; set; }
        public Vector v { get; set; }
        public double m { get; set; }
        public void Move(double dt, Vector F)
        {
            Vector a = F / m;
            v += a * dt;
            r += v * dt;

        }

        public static Point GetCoords(Vector v, int n)
        {
            Vector s = v / (n*1e+8);//расстояние в метрах до марса *1у+9
            Point p = new Point((int)s.X + 600, (int)s.Y + 500);
            return p;
        }

        public static Point GetCoordsSatellite(Vector v, int n, Point o)
        {
            Vector s = v / (n * 1e+8);//расстояние в метрах до марса *1у+9
            Point p = new Point((int)s.X + o.X, (int)s.Y + o.Y);
            return p;
        }

    }
}
