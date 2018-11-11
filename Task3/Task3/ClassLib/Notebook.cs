using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public abstract class Notebook : IPaper
    {
        private int _quality;
        private double _thickness;

        public int Quality
        {
            get { return _quality; }
            set
            {
                if(value > 0 && value <= 10)
                {
                    _quality = value;
                }
                else
                {
                    throw new Exception();
                }
            }
        }

        public double Thickness
        {
            get { return _thickness; }
            set
            {
                if (value >= 0.5 && value <= 2)
                {
                    _thickness = value;
                }
                else
                {
                    throw new Exception();
                }
            }
        }

        public string TypeOfProduct { get; set; }

        public abstract string DefineTypeOfProduct(); 

        public int OutputQuality()
        {
            return Quality;
        }
        public double OutputThickness()
        {
            return Thickness;
        }



    }
}
