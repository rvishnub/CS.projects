using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockRadio
{
    public class ClockRadio
    {
        public int volumeRadio;
        public int volumeAlarm;
        public string timeCurrent;
        public string timeAlarm;
        public bool timeToWake;

        public ClockRadio(int VolumeAlarm, string TimeCurrent, string TimeAlarm)

        {
            volumeAlarm = VolumeAlarm;
            timeCurrent = TimeCurrent;
            timeAlarm = TimeAlarm;
        }
        public bool Awake()
        {
            bool result;
            Console.WriteLine("Enter the current time: ");
            string timeCurrent = Console.ReadLine();
            if (timeCurrent == timeAlarm)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
        public int Alarm()
        {
            bool timeToWake = Awake();
            if (timeToWake == true)
            {
                volumeAlarm = 10;
            }
            return volumeAlarm;
        }
    }
}