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

        public static string[] car_CBXArray = new string[] { "機車", "貨車", "大客車", "自用小客車", "營業用小客車" };
        public static string[] scooterArray = new string[] { "150cc 以下", "151cc~ 250cc", "251cc~ 500cc", "501cc~ 600cc", "601cc~1200cc", "1201cc~1800cc", "1801cc 以上", };
        public static string[] truckArray = new string[] { "500cc 以下", "501cc - 600cc", "601cc - 1200cc", "1201cc - 1800cc", "1801cc - 2400cc", "2401cc - 3000cc", "3001cc~3600cc", "3601cc~4200cc", "4201cc~4800cc", "4801cc~5400cc", "5401cc~6000cc", "6001cc~6600cc", "6601cc~7200cc", "7201cc~7800cc", "7801cc~8400cc", "8401cc~9000cc", "9001cc~9600cc", "9601cc~10200cc", "10201cc 以上" };
        public static string[] busArray = new string[] { "501cc - 600cc", "601cc - 1200cc", "1201cc - 1800cc", "1801cc - 2400cc", "2401cc - 3000cc", "3001cc~3600cc", "3601cc~4200cc", "4201cc~4800cc", "4801cc~5400cc", "5401cc~6000cc", "6001cc~6600cc", "6601cc~7200cc", "7201cc~7800cc", "7801cc~8400cc", "8401cc~9000cc", "9001cc~9600cc", "9601cc~10200cc", "10201cc 以上" };
        public static string[] carArray = new string[] { "500cc 以下", "501cc - 600cc", "601cc - 1200cc", "1201cc - 1800cc", "1801cc - 2400cc", "2401cc - 3000cc", "3001cc - 4200cc", "4201cc - 5400cc", "5401cc - 6600cc", "6601cc - 7800cc", "7801cc 以上" };
        public static string[] carForBusinessArray = new string[] { "500cc 以下", "501cc - 600cc", "601cc - 1200cc", "1201cc - 1800cc", "1801cc - 2400cc", "2401cc - 3000cc", "3001cc - 4200cc", "4201cc - 5400cc", "5401cc - 6600cc", "6601cc - 7800cc", "7801cc 以上" };

        public static int get__result (int a , int b)
        {
            return a + b;
        }
    }
}
