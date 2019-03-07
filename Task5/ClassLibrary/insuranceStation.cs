using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class InsuranceStation : Insurance
    {
        public string Name { get; set; } = "Страховая компания для космической станции";
        public void Pay()
        {
        }
    }
}
