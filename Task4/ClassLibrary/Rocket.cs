using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Rocket
    {
        public Cosmonaut Pilot { get; set; }
        private delegate void MovingSubject();
        private event MovingSubject Explode;
        private event MovingSubject SuccesfullStart;
        private event MovingSubject Move;
        public bool CrashStatus { get; set; }
        private bool MoveStatus { get; set; }
        public Rocket()
        {
            Pilot = new Cosmonaut();
        }
        public void RocketEmergencyCase()
        {
            Random rnd = new Random();
            int s = rnd.Next(0,3);
            if (s == 0)
                EmergencyCase();
            else
                SuccesfullyStart();
        }
        public void PrepareRocket()
        {
            Pilot.Status = CosmonautStatus.OnTheEarth;
            CrashStatus = false;
        }
        public void StartEngine()
        {
            Move = () => MoveStatus = true;
            if (Move != null)
                Move.Invoke();
        }
        private void SuccesfullyStart()
        {
            SuccesfullStart += () => CrashStatus = false;
            SuccesfullStart += () => Pilot.GoInOrbit();
            if (SuccesfullStart != null)
                SuccesfullStart.Invoke();
            SuccesfullStart -= () => CrashStatus = false;
            SuccesfullStart -= () => Pilot.GoInOrbit();
        }
        private void EmergencyCase()
        {
            Explode += () => CrashStatus = true;
            if (Explode != null)
                Explode.Invoke();
            Explode -= () => CrashStatus = true;
        }

    }
}
