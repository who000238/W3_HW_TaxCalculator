using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3_HK_TaxCalculator
{
    class TaxClass
    {
        public TaxClass() { }
        #region taxLevel
        public static int[][] taxLevel = new int[][]
        {
        new int[] { 0,800,1620,2160,4320,7120,11230},
        new int[] { 900,1080,1800,2700,3600,4500,5400,6300,7200,8100,9000,9900,10800,11700,12600,13500,14400,15300,16200},
        new int[] { 1080,1800, 2700, 3600, 4500, 5400, 6300, 7200, 8100, 9000, 9900, 10800, 11700, 12600, 13500, 14400, 15300, 16200 },
        new int[] { 1620,2160,4320,7120,11230,15210,28220,46170,69690,117000,151200},
        new int[] { 900,1260,2160,3060,6480,9900,16380,24300,33660,44460,56700}
        };
        #endregion

        #region carTaxType

        public static string[] car_CBXArray = new string[] { 
            "機車",
            "貨車",
            "大客車",
            "自用小客車",
            "營業用小客車" };
        public static string[] scooterArray = new string[] {
            "150cc 以下", 
            "151cc~ 250cc", 
            "251cc~ 500cc",
            "501cc~ 600cc", 
            "601cc~1200cc",
            "1201cc~1800cc",
            "1801cc 以上", };
        public static string[] truckArray = new string[] {
            "500cc 以下",
            "501cc - 600cc",
            "601cc - 1200cc",
            "1201cc - 1800cc", 
            "1801cc - 2400cc",
            "2401cc - 3000cc",
            "3001cc~3600cc", 
            "3601cc~4200cc",
            "4201cc~4800cc",
            "4801cc~5400cc",
            "5401cc~6000cc",
            "6001cc~6600cc",
            "6601cc~7200cc",
            "7201cc~7800cc",
            "7801cc~8400cc",
            "8401cc~9000cc",
            "9001cc~9600cc",
            "9601cc~10200cc",
            "10201cc 以上" };
        public static string[] busArray = new string[] {
            "501cc - 600cc",
            "601cc - 1200cc",
            "1201cc - 1800cc",
            "1801cc - 2400cc",
            "2401cc - 3000cc",
            "3001cc~3600cc",
            "3601cc~4200cc",
            "4201cc~4800cc",
            "4801cc~5400cc",
            "5401cc~6000cc",
            "6001cc~6600cc",
            "6601cc~7200cc",
            "7201cc~7800cc",
            "7801cc~8400cc",
            "8401cc~9000cc",
            "9001cc~9600cc",
            "9601cc~10200cc",
            "10201cc 以上" };
        public static string[] carArray = new string[] { "500cc 以下",
            "501cc - 600cc",
            "601cc - 1200cc",
            "1201cc - 1800cc",
            "1801cc - 2400cc",
            "2401cc - 3000cc",
            "3001cc - 4200cc",
            "4201cc - 5400cc",
            "5401cc - 6600cc",
            "6601cc - 7800cc",
            "7801cc 以上" };
        public static string[] carForBusinessArray = new string[] {
            "500cc 以下",
            "501cc - 600cc",
            "601cc - 1200cc",
            "1201cc - 1800cc",
            "1801cc - 2400cc",
            "2401cc - 3000cc",
            "3001cc - 4200cc",
            "4201cc - 5400cc",
            "5401cc - 6600cc",
            "6601cc - 7800cc",
            "7801cc 以上" };
        #endregion


    }
}
