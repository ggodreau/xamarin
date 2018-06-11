using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace myApp
{
    static class AppConstants
    {
        public static readonly string ClockType = GetClockType();

        private static string GetClockType()
        {
            string clockType;
            clockType = "clock.png";
            /*
            string clockType;

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    clockType = "clock.png"; 
                    break;
                case Device.Android:
                    clockType = "clock.png"; 
                    break;
                default:
                    clockType = "notclock.png";
                    break;
            }
            */
            return clockType;
        }
    }
}
