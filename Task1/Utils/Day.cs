using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class Day
    {
        public int Number { get; set; }
        public DayOfTheWeek Name { get; set; }
        public Day(DayOfTheWeek name, int number)
        {
            this.Name = name;
            this.Number = number;
        }
    }
}
