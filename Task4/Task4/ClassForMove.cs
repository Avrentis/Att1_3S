using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public class ClassForMove
    {
        public Rocket Rocket { get; set; }
        public PictureBox PictureBox { get; set; }
        public PictureBox Background { get; set; }
        public ClassForMove(Rocket rocket, PictureBox pictureBox, PictureBox pictureBox1)
        {
            PictureBox = pictureBox;
            Rocket = rocket;
            Background = pictureBox1;
        }
    }
}
