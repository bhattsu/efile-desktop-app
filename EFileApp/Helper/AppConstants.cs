using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFileApp.Models;
namespace EFileApp.Helper
{
    public static class AppConstants
    {
        public static String LoginState { get; set; }
        public static APICall ApiCaller { get; set; }
        public static string LoginEmail { get; set; }
        public static string LoginStateName { get; set; }
        public static string LoginEnviornment { get; set; }

        public const string JSON_PATTERN = ".json";
        public const string PDF_PATTERN = ".pdf";
        public const string XSV_SEPERATOR = "\t";
        public const string COMMENT_OUT = "#";
        public const string AUTH_API = "/user/authenticate";
        public const string EFILE_API = "/efile/template";
        public const string FILING_API = "/filing/";
        public const string ENVELOPE_API = "/envelope/";
        public const string BATCH_API = "/batch";
        public const string BATCH_LISTING_API = "/batches";
        public const string CODE_API = "/code";

        public static Color DarkColor = Color.FromArgb(112, 146, 190);
        public static Color PrimaryColor = Color.FromArgb(0, 128, 192);
        public static Color LightPrimary = Color.FromArgb(0, 0, 0);
        public static Color AccentColor = Color.FromArgb(189, 189, 189);


    }
}
