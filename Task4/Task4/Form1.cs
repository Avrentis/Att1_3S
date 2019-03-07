using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Cosmonaut_pb.Visible = false;
            Money_pb.Visible = false;
        }

        private void Start_btn_Click(object sender, EventArgs e)
        {
            Rocket rocket = new Rocket();
            //движение ракеты
            Thread moveRocketThread = new Thread(new ParameterizedThreadStart(Utils.MoveObjectRocket));
            ClassForMove objRocket = new ClassForMove(rocket, Rocket_pb, Backhround_pb);
            moveRocketThread.Start(objRocket);
            //выход космонавтов
            Thread moveCosmonautThread = new Thread(new ParameterizedThreadStart(Utils.CheckSuccesfullStart));
            ClassForMove objCosmonaut = new ClassForMove(rocket, Cosmonaut_pb, Backhround_pb);
            moveCosmonautThread.Start(objCosmonaut);
            //выплата страховки
            Insurance insurance = new InsuranceRocket();
            Thread insuranceThread = new Thread(new ParameterizedThreadStart(Utils.CheckCrashStatus));
            ClassForMove objInsurance = new ClassForMove(rocket, Money_pb, Backhround_pb);
            insuranceThread.Start(objInsurance);
        }
    }
}
