using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3_HK_TaxCalculator
{
    class MethodClass
    {
        public MethodClass()
        {

        }

        public static int get__result (int a , int b)
        {
            return a + b;
        }

        public static int is_LeapYear (bool rBtn_Checked,int year)
        {
            if (true)
            {
                if (DateTime.IsLeapYear(DateTime.Now.Year))
                    return 366;
                else
                    return 365;
            }
            else if (false)
            {
                if (DateTime.IsLeapYear(year))
                    return 366;
                else
                    return 365;
            }
            return 0;
        }
    }
}
