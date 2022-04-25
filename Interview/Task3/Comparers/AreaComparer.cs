using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Comparers
{
    internal class AreaComparer
    {
        public int Compare(IFigure figure1, IFigure figure2)
        {
            return figure1.Area()>figure2.Area()?-1:1;
        }
    }
}
