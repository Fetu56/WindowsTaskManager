using System;
using System.Diagnostics;

namespace WindowsTaskManager
{
    class TaskProcess
    {
        public string processName { get; set; }
        public int processId { get; set; }
        public string processMem { get; set; }
        public TaskProcess(Process process)
        {
            processName = process.ProcessName;
            processId = process.Id;
            processMem = BytesToString(process.PagedMemorySize64);
        }
        static string BytesToString(long byteCount)
        {
            string[] suf = { "B", "KB", "MB", "GB", "TB", "PB", "EB" };
            if (byteCount == 0)
                return "0" + suf[0];
            long bytes = Math.Abs(byteCount);
            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return (Math.Sign(byteCount) * num).ToString() + suf[place];
        }
    }
}
