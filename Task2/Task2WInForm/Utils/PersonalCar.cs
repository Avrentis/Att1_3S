using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class PersonalCar : Car
    {
        public int YearMade { get; set; }
        public int CurrentYear { get; set; }
        public PersonalCar(string name, int enginePower, int seatsCount, int yearMade, int currentYear = 2018) : base(name, enginePower, seatsCount)
        {
            YearMade = yearMade;
            this.CurrentYear = currentYear;
        }
        public override double Q()
        {
            return base.Q()-1.5*(CurrentYear-YearMade);
        }

    }
}
