using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public class PictureBoxexClass
    {
        public PictureBox Rocket_pb { get; set; }
        public PictureBox Cosmonaut_pb { get; set; }
        public PictureBox Bg_pb { get; set; }
        public PictureBox Insurance_pb { get; set; }
        public Panel PanelNumber { get; set;}
        public PictureBoxexClass(PictureBox rocket_box, PictureBox cosmonaut_box, Panel panel, PictureBox bg_pb, PictureBox insurance_pb)
        {
            Rocket_pb = rocket_box;
            Cosmonaut_pb = cosmonaut_box;
            PanelNumber = panel;
            Bg_pb = bg_pb;
            Insurance_pb = insurance_pb;
        }
    }
}
