using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism_Introduction_Numbers
{
    //In this exercise you'll be writing code to analyze the production of an assembly line in a car factory. The assembly line's speed can range from 0 (off) to 10 (maximum).
    //At its lowest speed (1), 221 cars are produced each hour. The production increases linearly with the speed. 
    //So with the speed set to 4, it should produce 4 * 221 = 884 cars per hour.However, higher speeds increase the likelihood that faulty cars are produced, which then 
    //have to be discarded.
    

    static class AssemblyLine
    {
        static double successRate;
        static double ratePerHour;
        static int itemPerMinute;
        public static double SuccessRate(int speed)
        {
            
            if(speed == 0)
            {
                return successRate = 0;
            }
            else if (speed >= 1  && speed <= 4)
            {
                return successRate = 1;
            }
            else if (speed >= 5 && speed <= 8)
            {
                return successRate = 0.9;
            }
            else if (speed == 9)
            {
                return successRate = 0.8;
            }
            else if (speed == 10)
            {
                return successRate = 0.77;
            }
            return successRate;
        }

        public static double ProductionRatePerHour(int speed)
        {
            if (speed == 0)
            {
                return ratePerHour = 0;
            }
            else if (speed >= 1 && speed <= 4)
            {
                return ratePerHour = speed * 221;
            }
            else if (speed >= 5 && speed <= 8)
            {
                return ratePerHour = speed * 221 * 0.9;
            }
            else if (speed == 9)
            {
                return ratePerHour = speed * 221 * 0.8;
            }
            else if (speed == 10)
            {
                return ratePerHour = speed * 221 * 0.77;
            }
            return ratePerHour;
        }
        public static int WorkingItemsPerMinute(int speed)
        {
            if (speed == 0)
            {
                return itemPerMinute = 0;
            }
            else if (speed >= 1 && speed <= 4)
            {
                return itemPerMinute = speed * 221 / 60;
            }
            else if (speed >= 5 && speed <= 8)
            {
                return itemPerMinute = (int)(speed * 221 * 0.9 / 60);
            }
            else if (speed == 9)
            {
                return itemPerMinute = (int)(speed * 221 * 0.8 / 60);
            }
            else if (speed == 10)
            {
                return itemPerMinute = (int)(speed * 221 * 0.77 / 60);
            }
            return itemPerMinute;
            
        }
    }
}
