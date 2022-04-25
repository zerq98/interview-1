using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Cube : ISolid
    {
        private decimal Side;

        public Cube(decimal side)
        {
            Side = side;
        }
        public decimal Area()
        {
            return Side * Side * 6;
        }

        public decimal Volume()
        {
            return Side * Side * Side;
        }
    }
}
