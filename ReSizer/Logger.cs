using System;
using System.IO;
namespace ReSizer
{
    public static class Logger
    {
        private static bool blLogToFile;
        private static bool blVerbose;
        private static string strLogFilePath;
        private static bool blQuiet;

        public static void Init(string logDir, bool logToFile, bool verbose, bool quiet)
        {
            blLogToFile = logToFile;
            blVerbose = verbose;
            blQuiet = quiet;

            if (!logToFile) return;

            var timeStamp = DateTime.Now.ToString("yyMMdd");
            if (!Directory.Exists(logDir))
            {
                Directory.CreateDirectory(logDir);
            }
            strLogFilePath = string.Format("{0}\\Log-{1}.log", logDir, timeStamp);
        }

        public static void WriteLine(string message = "")
        {
            if (!blQuiet)
            {
                Console.WriteLine(message);
            }
            WriteLog(string.Format("NORMAL: \t{0}", message));
        }

        public static void WriteError(string message = "")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            if (!blQuiet)
            {
                Console.WriteLine(message);
            }
            Console.ResetColor();
            WriteLog(string.Format("ERROR: \t{0}", message));
        }

        public static void WriteVerbose(string message = "")
        {
            if (!blVerbose) return;
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (!blQuiet)
            {
                Console.WriteLine(message);
            }
            Console.ResetColor();
            WriteLog(string.Format("VERBOSE: \t{0}", message));
        }

        public static void WriteLine(string messageFormat, params object[] arg)
        {
            var message = string.Format(messageFormat, arg);
            WriteLine(message);
        }

        public static void WriteError(string messageFormat, params object[] arg)
        {
            var message = string.Format(messageFormat, arg);
            WriteError(message);
        }


        public static void WriteVerbose(string messageFormat, params object[] arg)
        {
            var message = string.Format(messageFormat, arg);
            WriteVerbose(message);
        }

        private static void WriteLog(string message)
        {
            if (!blLogToFile || string.IsNullOrWhiteSpace(message) || message.Trim().ToLower() == "normal:") return;

            using (var file = File.Open(strLogFilePath, FileMode.Append))
            using (var writer = new StreamWriter(file))
            {
                writer.WriteLine("{0}\t{1}", DateTime.Now, message);
            }
        }

    }
}
