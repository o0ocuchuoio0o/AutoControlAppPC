using KAutoHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoControlAppPC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("notepad");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Process.Start(AppDomain.CurrentDomain.BaseDirectory + "How Kteam - Free Education.html");
            Process.Start("How Kteam - Free Education.html");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strCmdText;
            strCmdText = "/C ping -t howkteam.com";
            Process.Start("CMD.exe", strCmdText);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string strCmdText;
            strCmdText = @"/C ""How Kteam - Free Education.html""";

            Process p = new Process();

            p.StartInfo.FileName = "CMD.exe";
            p.StartInfo.Arguments = strCmdText;

            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            p.Start();

            //p.Kill();

            /*
             
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = @"/C ""How Kteam - Free Education.html""";
            process.StartInfo = startInfo;
            process.Start();
             
             */
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string cmdCommand = "ping howkteam.com";

            Process cmd = new Process();

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe";            
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardInput = true;
            startInfo.RedirectStandardOutput = true;

            cmd.StartInfo = startInfo;
            cmd.Start();

            cmd.StandardInput.WriteLine(cmdCommand);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();

            string result = cmd.StandardOutput.ReadToEnd();

            MessageBox.Show(result);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int x = (int)numericUpDown1.Value;
            int y = (int)numericUpDown2.Value;

            EMouseKey mouseKey = EMouseKey.LEFT;

            if (checkBox1.Checked)
            {
                if (checkBox2.Checked)
                {
                    mouseKey = EMouseKey.DOUBLE_RIGHT;
                }
                else
                {
                    mouseKey = EMouseKey.RIGHT;
                }
            }
            else
            {
                if (checkBox2.Checked)
                {
                    mouseKey = EMouseKey.DOUBLE_LEFT;
                }
            }

            //Cursor.Position = new Point(x,y);
            AutoControl.MouseClick(x,y, mouseKey);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int x = (int)numericUpDown1.Value;
            int y = (int)numericUpDown2.Value;

            //var hWnd = Process.GetProcessById(12012).MainWindowHandle;
            //var hWnd = Process.GetProcessesByName("Remote Desktop Connection")[0].MainWindowHandle;
            IntPtr hWnd = IntPtr.Zero;

            hWnd = AutoControl.FindWindowHandle(null, textBox1.Text);

            // lấy ra tọa độ trên màn hình của tọa độ bên trong cửa sổ
            var pointToClick = AutoControl.GetGlobalPoint(hWnd, x,y);

            EMouseKey mouseKey = EMouseKey.LEFT;

            if (checkBox1.Checked)
            {
                if (checkBox2.Checked)
                {
                    mouseKey = EMouseKey.DOUBLE_RIGHT;
                }
                else
                {
                    mouseKey = EMouseKey.RIGHT;
                }
            }
            else
            {
                if (checkBox2.Checked)
                {
                    mouseKey = EMouseKey.DOUBLE_LEFT;
                }
            }

            AutoControl.BringToFront(hWnd);

            AutoControl.MouseClick(pointToClick, mouseKey);
        }
    }
}
