using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static Point GetCoords(Vector v)
        {
            Vector s = v / 9e+9;//расстояние в метрах до марса *1у+9
            Point p = new Point((int)s.X + 600, (int)s.Y + 500);
            return p;
        }

    }
}
