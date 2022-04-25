using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Square:IFigure
    {
        private decimal Side;

        public Square(decimal side)
        {
            Side = side;
        }

        public decimal Area()
        {
            return Side*Side;
        }
    }
}
