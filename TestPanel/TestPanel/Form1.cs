using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace TestPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll")]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll", EntryPoint = "SetWindowLongA", SetLastError = true)]
        private static extern long SetWindowLong(IntPtr hwnd, int nIndex, long dwNewLong);


        static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        const UInt32 SWP_NOSIZE = 0x0001;
        const UInt32 SWP_NOMOVE = 0x0002;
        const UInt32 SWP_SHOWWINDOW = 0x0040;

        private void button1_Click(object sender, EventArgs e)
        {
            //Process p = Process.Start("notepad.exe");
            ////Thread.Sleep(500); // Allow the process to open it's window
            //p.WaitForInputIdle();
            //SetParent(p.MainWindowHandle, panel1.Handle);

            ProcessStartInfo psi = new ProcessStartInfo("notepad.exe");           
            psi.UseShellExecute = true;
            psi.CreateNoWindow = true;
            psi.WindowStyle = ProcessWindowStyle.Maximized;
            psi.RedirectStandardInput = false;
            psi.RedirectStandardOutput = false;
            psi.RedirectStandardError = false;
            
            Process p = Process.Start(psi);
            p.WaitForInputIdle();
            SetWindowPos(p.MainWindowHandle, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_SHOWWINDOW);
            SetParent(p.MainWindowHandle, panel1.Handle);

            Process p2 = Process.Start(psi);
            p2.WaitForInputIdle();
            SetWindowPos(p2.MainWindowHandle, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_SHOWWINDOW);
            SetParent(p2.MainWindowHandle, panel2.Handle);

           
        }
    }
}
