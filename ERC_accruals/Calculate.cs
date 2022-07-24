using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERC_accruals
{
    public class Calculate 
    {
        public static double CVSSum;
        public static double HVSSum;
        public static double EESum;
        public static int nPeople;
        public static double GetCVSSum(string accrual)
        {
            double Vcurr;
            double Vprev = 0;
            var T = 35.78;
            var N = 4.85;
            

            if (!(accrual == ""))
            {
                Vcurr = double.Parse(accrual);
                CVSSum = (Vcurr - Vprev) * T;
            }
            else
            {
                Vcurr = 0;
                CVSSum = N * nPeople * T; 
            }

            Vprev = Vcurr;
            return CVSSum; 
        }
        public static double GetHVSSum(string accrual)
        {
            double Vcurr;
            double Vprev = 0;
            var T = 158.98;
            var N = 4.01;

            if (!(accrual == ""))
            {
                Vcurr = double.Parse(accrual);
                HVSSum = (Vcurr - Vprev) * T;
            }
            else
            {
                Vcurr = 0;
                HVSSum = N * nPeople * T;
            }

            Vprev = Vcurr;
            return HVSSum;
        }
        public static double GetEEDaySum(string accrual)
        {
            double Vcurr=double.Parse(accrual);
            double Vprev = 0;
            var T = 4.9;
           
            Vprev = Vcurr;
            return (Vcurr - Vprev) * T; 
        }
        public static double GetEENightSum(string accrual)
        {
            double Vcurr = double.Parse(accrual);
            double Vprev = 0;
            var T = 2.31;

            Vprev = Vcurr;
            return (Vcurr - Vprev) * T;
        }
        public static double GetEESum()
        {
            var N = 164;
            var T = 4.28;
            return N * nPeople * T;
        }

        public static double GetERCSum(double EE)
        {
            
            return CVSSum + HVSSum + EE;
        }

    }
}
