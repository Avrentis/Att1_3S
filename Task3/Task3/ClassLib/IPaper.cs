using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public interface IPaper
    {
        int Quality { get; set; }
        double Thickness { get; set; }

        int OutputQuality();
        double OutputThickness();

    }
}
