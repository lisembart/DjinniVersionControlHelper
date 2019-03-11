using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DjinniVersionControlHelper
{
    class ProcessManager
    {
        private Process[] processes;
        private string editorProcessName = "Notepad";

        public bool EditorProcessExist()
        {
            processes = Process.GetProcesses();

            foreach (Process proc in processes)
            {
                if (proc.ProcessName == "djinni!")
                {
                    return true;
                }
            }

            return false;
        }

        public void KillEditorProcess()
        {
            processes = Process.GetProcesses();
            bool killedEditorProcess = false;
            foreach (Process proc in processes)
            {
                Console.WriteLine(proc.ProcessName);
                if (proc.ProcessName == "djinni!")
                {
                    proc.Kill();
                    killedEditorProcess = true;
                }              
            }

            if (!killedEditorProcess)
            {
                throw new NullReferenceException();
            }
        }
    }
}
