using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class Car
    {
        public string Name { get; set; }
        public int EnginePower { get; set; }
        public int SeatsCount { get; set; }
        public Car(string name, int enginePower, int seatsCount)
        {
            this.Name = name;
            this.EnginePower = enginePower;
            this.SeatsCount = seatsCount;
        }
        public virtual double Q() => 0.3 * EnginePower * SeatsCount;
        public double GetQ() => Q();
    }
}
