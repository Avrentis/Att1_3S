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
            Cosmonaut_pb2.Visible = false;
            Money_pb2.Visible = false;
            Cosmonaut_pb3.Visible = false;
            Money_pb3.Visible = false;
            Cosmonaut_pb4.Visible = false;
            Money_pb4.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        static int count = 1;
        static int NearestCount1 = 0;
        static int NearestCount2 = 0;
        private void Start_btn_Click(object sender, EventArgs e)
        {
            switch (count)
            {
                case 1:
                    NearestCount2 = 2;
                    NearestCount1 = 1;
                    PictureBoxexClass pictureBoxexClass1 = new PictureBoxexClass(Rocket_pb, Cosmonaut_pb, panel1, Backhround_pb, Money_pb);
                    Thread StartMoveThread1 = new Thread(new ParameterizedThreadStart(StartMovingForThread));
                    StartMoveThread1.Start(pictureBoxexClass1);
                    count++;
                    break;
                case 2:
                    NearestCount2 = 1;
                    NearestCount1 = 2;
                    PictureBoxexClass pictureBoxexClass2 = new PictureBoxexClass(Rocket_pb2, Cosmonaut_pb2, panel2, Backhround_pb2, Money_pb2);
                    Thread StartMoveThread2 = new Thread(new ParameterizedThreadStart(StartMovingForThread));
                    StartMoveThread2.Start(pictureBoxexClass2);
                    count++;
                    break;
                case 3:
                    NearestCount2 = 4;
                    NearestCount1 = 3;
                    PictureBoxexClass pictureBoxexClass3 = new PictureBoxexClass(Rocket_pb3, Cosmonaut_pb3, panel3, Backhround_pb3, Money_pb3);
                    Thread StartMoveThread3 = new Thread(new ParameterizedThreadStart(StartMovingForThread));
                    StartMoveThread3.Start(pictureBoxexClass3);
                    count++;
                    break;
                case 4:
                    NearestCount2 = 4;
                    NearestCount1 = 3;
                    PictureBoxexClass pictureBoxexClass4 = new PictureBoxexClass(Rocket_pb4, Cosmonaut_pb4, panel4, Backhround_pb4, Money_pb4);
                    Thread StartMoveThread4 = new Thread(new ParameterizedThreadStart(StartMovingForThread));
                    StartMoveThread4.Start(pictureBoxexClass4);
                    count++;
                    break;
                case 5:
                    MessageBox.Show("К сожалению места больше нет");
                    break;
            }
        }
        private static void StartMoving(PictureBox rocket_pb, PictureBox cosmonaut_pb, PictureBox insurance_pb, PictureBox bg_pb, Panel panel)
        {
            panel.Invoke(new MethodInvoker(() =>
                panel.Visible = true));
            Rocket rocket = new Rocket();
            //движение ракеты
            Thread moveRocketThread = new Thread(new ParameterizedThreadStart(Utils.MoveObjectRocket));
            ClassForMove objRocket = new ClassForMove(rocket, rocket_pb, bg_pb, NearestCount1, NearestCount2);
            moveRocketThread.Start(objRocket);
            //выход космонавтов
            Thread moveCosmonautThread = new Thread(new ParameterizedThreadStart(Utils.CheckSuccesfullStart));
            ClassForMove objCosmonaut = new ClassForMove(rocket, cosmonaut_pb, bg_pb, NearestCount1, NearestCount2);
            moveCosmonautThread.Start(objCosmonaut);
            //выплата страховки
            Insurance insurance = new InsuranceRocket();
            Thread insuranceThread = new Thread(new ParameterizedThreadStart(Utils.CheckCrashStatus));
            ClassForMove objInsurance = new ClassForMove(rocket, insurance_pb, bg_pb, NearestCount1, NearestCount2);
            insuranceThread.Start(objInsurance);
        }
        private static void StartMovingForThread(object boxClass)
        {
            StartMoving(((PictureBoxexClass)boxClass).Rocket_pb, ((PictureBoxexClass)boxClass).Cosmonaut_pb, ((PictureBoxexClass)boxClass).Insurance_pb, ((PictureBoxexClass)boxClass).Bg_pb, ((PictureBoxexClass)boxClass).PanelNumber);
        }
    }
}
