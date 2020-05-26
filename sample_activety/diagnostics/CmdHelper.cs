using System;
using System.Diagnostics;
using System.IO;

namespace sample_activity
{
    public class CmdHelper
    {
        public static string RunCmd(string inString)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("cmd.exe",inString)
            {
                RedirectStandardInput = true,
                UseShellExecute = false,
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };

            Process process = Process.Start(startInfo);
            StreamReader reader = process.StandardOutput;
            string result = reader.ReadToEnd();
            process.WaitForExit();
            return result;
        }
    }
}