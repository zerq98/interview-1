using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Circle : IFigure
    {
        private decimal Radius;
        public Circle(decimal radius)
        {
            Radius = radius;
        }
        public decimal Area()
        {
            return Math.Round(Radius * Radius * (decimal)Math.PI, 2);
        }
    }
}
