using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkDaily.Models
{
    public class MobileHelper
    {
        /*
         * 手機會出現的userAgent關鍵字
         */
        private static string[] mobileDevices = new string[]
       {
            "iphone","ppc",
            "windows ce","blackberry",
            "opera mini","mobile","palm",
            "portable","opera mobi"
       };

        /* 判斷使用者所用的裝置是手機/電腦         
         --------------------------------*/
        public static bool IsMobileDevice(string userAgent)
        {
            userAgent = userAgent.ToLower();
            return mobileDevices.Any(x => userAgent.Contains(x));
        }
    }
}