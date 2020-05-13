using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace AutoTheVoice
{
    public class RunFFMPEG
    {
        #region Properties
        private string _ffExe;
        public string ffExe
        {
            get
            {
                return _ffExe;
            }
            set
            {
                _ffExe = value;
            }
        }
        #endregion

        #region Constructors
        public RunFFMPEG()
        {
            Initialize();
        }
        public RunFFMPEG(string ffmpegExePath)
        {
            _ffExe = ffmpegExePath;
            Initialize();
        }
        #endregion

        #region Initialization
        private void Initialize()
        {
            //first make sure we have a value for the ffexe file setting
            try
            {
                if (string.IsNullOrEmpty(_ffExe))
                {
                    object o = ConfigurationManager.AppSettings["ffmpeg:ExeLocation"];

                    if (o == null)
                    {
                        throw new Exception("Could not find the location of the ffmpeg exe file.  The path for ffmpeg.exe " +
                        "can be passed in via a constructor of the ffmpeg class (this class) or by setting in the app.config or web.config file.  " +
                        "in the appsettings section, the correct property name is: ffmpeg:ExeLocation");
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(o.ToString()))
                            throw new Exception("No value was found in the app setting for ffmpeg:ExeLocation");

                        _ffExe = o.ToString();
                    }
                }

                if (!File.Exists(_ffExe))
                    throw new Exception("Could not find a copy of ffmpeg.exe");
            }
            catch
            {
                _ffExe = Application.StartupPath + "\\Win32bit\\ffmpeg.exe";
            }

        }
        #endregion

        #region Run the process

        public string RunCommand(string Parameters, bool _AtriHide)
        {

            ProcessStartInfo oInfo = new ProcessStartInfo();
            if (this.ffExe == "" || this.ffExe == null)
            {
                _ffExe = Application.StartupPath + "\\Win32bit\\ffmpeg.exe";
            }
            oInfo.FileName = this._ffExe;

            if (_AtriHide == true)
            {
                oInfo.CreateNoWindow = true;
                oInfo.WindowStyle = ProcessWindowStyle.Hidden;
            }
            oInfo.Arguments = Parameters.Trim();
            string output = null; StreamReader srOutput = null;
            try
            {
                //run the process
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo = oInfo;
                proc.Start();
                proc.WaitForExit();
                Console.WriteLine("Result: {0}", proc.ExitCode);
                Thread.Sleep(1000);
                proc.Close();

            }
            catch (Exception)
            {
                output = string.Empty;
            }
            finally
            {
                //now, if we succeded, close out the streamreader
                if (srOutput != null)
                {
                    srOutput.Close();
                    srOutput.Dispose();
                }
            }
            return output;

        }

       
        #endregion
    }
}
