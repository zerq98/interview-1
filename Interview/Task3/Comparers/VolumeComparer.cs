using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Comparers
{
    internal class VolumeComparer
    {
        public int Compare(ISolid figure1, ISolid figure2)
        {
            return figure1.Volume() > figure2.Volume() ? -1 : 1;
        }
    }
}
