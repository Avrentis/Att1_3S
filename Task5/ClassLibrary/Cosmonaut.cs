using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Cosmonaut
    {
        public CosmonautStatus Status { get; set; }
        public Cosmonaut()
        {
            Status = CosmonautStatus.OnTheEarth;
        }
        public void GoInOrbit()
        {
            Status = CosmonautStatus.InOrbit;
        }
    }
}
