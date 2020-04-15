using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EFileApp.Helper
{
    public static class LogManager
    {
        private static log4net.ILog Log { get; set; }
        static LogManager()
        {
            Log = log4net.LogManager.GetLogger(typeof(LogManager));
        }
        /// <summary>
        /// Method will be used to log errors
        /// </summary>
        /// <param name="msg"></param>
        public static void Error(object msg)
        {
            Log.Error(msg);
        }
        /// <summary>
        /// Method will be used to log errors with message
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="ex"></param>
        public static void Error(object msg, Exception ex)
        {
            Log.Error(msg, ex);
        }
        /// <summary>
        /// Method will be used to log exceptions
        /// </summary>
        /// <param name="ex"></param>
        public static void Error(Exception ex)
        {
            Log.Error(ex.Message, ex);
        }
        /// <summary>
        /// Method will be used to log exceptions and show messages
        /// </summary>
        /// <param name="ex"></param>
        public static void LogError(Exception ex)
        {
            
            Log.Error(ex.Message, ex);
            System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);  
        }
        /// <summary>
        /// Method will be used for tracing
        /// </summary>
        /// <param name="msg"></param>
        public static void Trace(object msg)
        {
            Log.Info(msg);
        }
        /// <summary>
        ///  Method will be used for Debug
        /// </summary>
        /// <param name="msg"></param>
        public static void Debug(object msg)
        {
            Log.Debug(msg);
        }
    }
    }
