using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public class Utils
    {
        public static AutoResetEvent waitHandler = new AutoResetEvent(true);
        public static AutoResetEvent waitHandler2 = new AutoResetEvent(true);
        public static void MoveObjectRocket(object obj)
        {
            while (true)
            {
                ((ClassForMove)obj).Background.BackgroundImage = Image.FromFile("BbaAckground.jpg");
                ((ClassForMove)obj).Rocket.PrepareRocket();
                ((ClassForMove)obj).Rocket.StartEngine();
                while (((ClassForMove)obj).PictureBox.Location.Y > -50)
                {
                    ((ClassForMove)obj).PictureBox.Invoke(new MethodInvoker(() =>
                    ((ClassForMove)obj).PictureBox.Top = ((ClassForMove)obj).PictureBox.Top - 10));
                    Thread.Sleep(100);
                }
                ((ClassForMove)obj).Rocket.RocketEmergencyCase();
                if (((ClassForMove)obj).Rocket.CrashStatus == true)
                {
                    Thread.Sleep(8000);
                }
                else
                    ((ClassForMove)obj).Background.BackgroundImage = Image.FromFile("space.jpg");
                while (((ClassForMove)obj).PictureBox.Location.Y > -500)
                {
                    ((ClassForMove)obj).PictureBox.Invoke(new MethodInvoker(() =>
                    ((ClassForMove)obj).PictureBox.Top = ((ClassForMove)obj).PictureBox.Top - 10));
                    Thread.Sleep(50);

                }
                ((ClassForMove)obj).PictureBox.Invoke(new MethodInvoker(() =>
                ((ClassForMove)obj).PictureBox.Top = 300));
            }
        }
        public static void MoveObjectCosmonaut(object obj)
        {
            ((ClassForMove)obj).PictureBox.Invoke(new MethodInvoker(() =>
            ((ClassForMove)obj).PictureBox.Visible = true));
            while(((ClassForMove)obj).PictureBox.Location.X > -100)
            {
                ((ClassForMove)obj).PictureBox.Invoke(new MethodInvoker(() =>
                ((ClassForMove)obj).PictureBox.Left = ((ClassForMove)obj).PictureBox.Left - 10));
                Thread.Sleep(100);
            }
            ((ClassForMove)obj).PictureBox.Invoke(new MethodInvoker(() =>
            ((ClassForMove)obj).PictureBox.Visible = false));
            ((ClassForMove)obj).PictureBox.Invoke(new MethodInvoker(() =>
                ((ClassForMove)obj).PictureBox.Left = 165));
        }
        public static void InsurancePayMoney(object obj)
        {
            if(((ClassForMove)obj).Number + ((ClassForMove)obj).NearestNumber == 3)
            {
                waitHandler.WaitOne();
                PayMoney(obj);
                waitHandler.Set();
            }
            if (((ClassForMove)obj).Number + ((ClassForMove)obj).NearestNumber == 7)
            {
                waitHandler2.WaitOne();
                PayMoney(obj);
                waitHandler2.Set();
            }
        }
        public static void PayMoney(object obj)
        {
            ((ClassForMove)obj).PictureBox.Invoke(new MethodInvoker(() =>
           ((ClassForMove)obj).PictureBox.Visible = true));
            Thread.Sleep(9000);
            ((ClassForMove)obj).PictureBox.Invoke(new MethodInvoker(() =>
           ((ClassForMove)obj).PictureBox.Visible = false));
        }
        public static void CheckSuccesfullStart(object obj)
        {
            while (true)
            {
                if (((ClassForMove)obj).Rocket.Pilot.Status == ClassLibrary.CosmonautStatus.InOrbit)
                    MoveObjectCosmonaut(obj);
            }
        }
        public static void CheckCrashStatus(object obj)
        {
            while (true)
            {
                if (((ClassForMove)obj).Rocket.CrashStatus == true)
                    InsurancePayMoney(obj);
            }
        }
    }
}
