using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Sphere : ISolid
    {
        private decimal Radius;
        public Sphere(decimal radius)
        {
            Radius = radius;
        }
        public decimal Area()
        {
            return Math.Round(4*Radius*Radius*(decimal)Math.PI,2);
        }

        public decimal Volume()
        {
            return Math.Round(Math.Round(4 * Radius * Radius * (decimal)Math.PI,2)/3, 2);
        }
    }
}
