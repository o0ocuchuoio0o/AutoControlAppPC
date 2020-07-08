using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;

namespace AutoADB
{
    public class ADBHelper
    {
        private static string ADB_FOLDER_PATH = "";
        private static string ADB_PATH = "";
        private static string CAPTURE_SCREEN_TO_DEVICES = "adb -s {0} shell screencap -p \"{1}\"";
        private const int DEFAULT_SWIPE_DURATION = 100;
        private static string GET_SCREEN_RESOLUTION = "adb -s {0} shell dumpsys display | Find \"mCurrentDisplayRect\"";
        private static string INPUT_TEXT_DEVICES = "adb -s {0} shell input text \"{1}\"";
        private static string KEY_DEVICES = "adb -s {0} shell input keyevent {1}";
        private static string LIST_DEVICES = "adb devices";
        private static string PULL_SCREEN_FROM_DEVICES = "adb -s {0} pull \"{1}\"";
        private static string REMOVE_SCREEN_FROM_DEVICES = "adb -s {0} shell rm -f \"{1}\"";
        private static string SWIPE_DEVICES = "adb -s {0} shell input swipe {1} {2} {3} {4} {5}";
        private static string TAP_DEVICES = "adb -s {0} shell input tap {1} {2}";
       
        

        public static void ConnectNox(int count = 1)
        {
            string cmdCommand = "";
            int num = 0xf230;
            if (count <= 1)
            {
                cmdCommand = cmdCommand + "adb connect 127.0.0.1:" + (num + 1);
            }
            else
            {
                cmdCommand = cmdCommand + "adb connect 127.0.0.1:" + (num + 1);
                for (int i = 0x19; i < (count + 0x18); i++)
                {
                    object[] objArray1 = new object[] { cmdCommand, Environment.NewLine, "adb connect 127.0.0.1:", num + i };
                    cmdCommand = string.Concat(objArray1);
                }
            }
            ExecuteCMD(cmdCommand);
        }

        public static void Delay(double delayTime)
        {
            for (double i = 0.0; i < delayTime; i += 100.0)
            {
                Thread.Sleep(TimeSpan.FromMilliseconds(100.0));
            }
        }

        public static string ExecuteCMD(string cmdCommand)
        {
            try
            {
                Process process = new Process();
                ProcessStartInfo info = new ProcessStartInfo
                {
                    WorkingDirectory = ADB_FOLDER_PATH,
                    FileName = "cmd.exe",
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true
                };
                process.StartInfo = info;
                process.Start();
                process.StandardInput.WriteLine(cmdCommand);
                process.StandardInput.Flush();
                process.StandardInput.Close();
                process.WaitForExit();
                return process.StandardOutput.ReadToEnd();
            }
            catch
            {
                return null;
            }
        }

        public static Point? FindImage(string deviceID, string ImagePath, int delayPerCheck = 0x7d0, int count = 5)
        {
            FileInfo[] files = new DirectoryInfo(ImagePath).GetFiles();
            do
            {
                Bitmap mainBitmap = null;
                int num = 3;
                do
                {
                    try
                    {
                        mainBitmap = ScreenShoot(deviceID, true, "screenShoot.png");
                        break;
                    }
                    catch (Exception)
                    {
                        num--;
                        Delay(1000.0);
                    }
                }
                while (num > 0);
                if (mainBitmap == null)
                {
                    return null;
                }
                Point? nullable = null;
                foreach (FileInfo info2 in files)
                {
                    Bitmap subBitmap = (Bitmap)Image.FromFile(info2.FullName);
                    nullable = ImageScanOpenCV.FindOutPoint(mainBitmap, subBitmap, 0.9);
                    if (nullable.HasValue)
                    {
                        break;
                    }
                }
                if (nullable.HasValue)
                {
                    return nullable;
                }
                Delay(2000.0);
                count--;
            }
            while (count > 0);
            return null;
        }

        public static bool FindImageAndClick(string deviceID, string ImagePath, int delayPerCheck = 0x7d0, int count = 5)
        {
            FileInfo[] files = new DirectoryInfo(ImagePath).GetFiles();
            do
            {
                Bitmap mainBitmap = null;
                int num = 3;
                do
                {
                    try
                    {
                        mainBitmap = ScreenShoot(deviceID, true, "screenShoot.png");
                        break;
                    }
                    catch (Exception)
                    {
                        num--;
                        Delay(1000.0);
                    }
                }
                while (num > 0);
                if (mainBitmap == null)
                {
                    return false;
                }
                Point? nullable = null;
                foreach (FileInfo info2 in files)
                {
                    Bitmap subBitmap = (Bitmap)Image.FromFile(info2.FullName);
                    nullable = ImageScanOpenCV.FindOutPoint(mainBitmap, subBitmap, 0.9);
                    if (nullable.HasValue)
                    {
                        break;
                    }
                }
                if (nullable.HasValue)
                {
                    Tap(deviceID, nullable.Value.X, nullable.Value.Y, 1);
                    return true;
                }
                Delay((double)delayPerCheck);
                count--;
            }
            while (count > 0);
            return false;
        }

        public static string GetDeviceName(string deviceID)
        {
            string cmdCommand = "";
            string str3 = ExecuteCMD(cmdCommand);
            return "";
        }

        public static List<string> GetDevices()
        {
            List<string> list = new List<string>();
            string input = ExecuteCMD(LIST_DEVICES);
            string str2 = Path.GetPathRoot(AppDomain.CurrentDomain.BaseDirectory).Replace(@"\", "");
            string pattern = "(?<=List of devices attached ).*?(?=" + str2 + ")";
            MatchCollection matchs = Regex.Matches(input, pattern, RegexOptions.Singleline);
            if ((matchs != null) && (matchs.Count > 0))
            {
                foreach (object obj2 in matchs)
                {
                    string[] separator = new string[] { "device" };
                    string[] strArray = obj2.ToString().Split(separator, StringSplitOptions.None);
                    for (int i = 0; i < (strArray.Length - 1); i++)
                    {
                        string str5 = strArray[i];
                        string item = str5.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        list.Add(item);
                    }
                }
            }
            return list;
        }

        public static Point GetScreenResolution(string deviceID)
        {
            string str2 = ExecuteCMD(string.Format(GET_SCREEN_RESOLUTION, deviceID));
            str2 = str2.Substring(str2.IndexOf("- "));
            char[] separator = new char[] { ',' };
            string[] strArray = str2.Substring(str2.IndexOf(' '), str2.IndexOf(')') - str2.IndexOf(' ')).Split(separator);
            int x = Convert.ToInt32(strArray[0].Trim());
            return new Point(x, Convert.ToInt32(strArray[1].Trim()));
        }

        public static void InputText(string deviceID, string text)
        {
            string str2 = ExecuteCMD(string.Format(INPUT_TEXT_DEVICES, deviceID, text.Replace(" ", "%s").Replace("&", @"\&").Replace("<", @"\<").Replace(">", @"\>").Replace("?", @"\?").Replace(":", @"\:").Replace("{", @"\{").Replace("}", @"\}").Replace("[", @"\[").Replace("]", @"\]").Replace("|", @"\|")));
        }

        public static void Key(string deviceID, ADBKeyEvent key)
        {
            string str2 = ExecuteCMD(string.Format(KEY_DEVICES, deviceID, key));
        }

        public static void LongPress(string deviceID, int x, int y, int duration = 100)
        {
            string str2 = ExecuteCMD(string.Format(SWIPE_DEVICES, new object[] { deviceID, x, y, x, y, duration }));
        }

        public static void PlanModeOFF(string deviceID, CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested==false)
            {
                string str = "adb -s " + deviceID + " settings put global airplane_mode_on 0";
                ExecuteCMD(str + Environment.NewLine + "adb -s " + deviceID + " am broadcast -a android.intent.action.AIRPLANE_MODE");
            }
        }

        public static void PlanModeON(string deviceID, CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested == false)
            {
                string str = "adb -s " + deviceID + " settings put global airplane_mode_on 1";
                ExecuteCMD(str + Environment.NewLine + "adb -s " + deviceID + " am broadcast -a android.intent.action.AIRPLANE_MODE");
            }
        }

        public static Bitmap ScreenShoot(string deviceID = null, bool isDeleteImageAfterCapture = true, string fileName = "screenShoot.png")
        {
            Bitmap bitmap;
            if (string.IsNullOrEmpty(deviceID))
            {
                List<string> devices = GetDevices();
                if ((devices == null) || (devices.Count <= 0))
                {
                    return null;
                }
                deviceID = devices.First<string>();
            }
            string str = deviceID;
            try
            {
                char[] separator = new char[] { ':' };
                str = deviceID.Split(separator)[1];
            }
            catch
            {
            }
            string path = Path.GetFileNameWithoutExtension(fileName) + str + Path.GetExtension(fileName);
            while (true)
            {
                if (!File.Exists(path))
                {
                    break;
                }
                try
                {
                    File.Delete(path);
                    break;
                }
                catch
                {
                }
            }
            string str4 = ExecuteCMD((string.Format(CAPTURE_SCREEN_TO_DEVICES, deviceID, "/sdcard/" + path) + Environment.NewLine + string.Format(PULL_SCREEN_FROM_DEVICES, deviceID, "/sdcard/" + path)) + Environment.NewLine + string.Format(REMOVE_SCREEN_FROM_DEVICES, deviceID, "/sdcard/" + path) + Environment.NewLine);
            using (Bitmap bitmap3 = new Bitmap(path))
            {
                bitmap = new Bitmap(bitmap3);
            }
            if (isDeleteImageAfterCapture)
            {
                try
                {
                    File.Delete(path);
                }
                catch
                {
                }
            }
            return bitmap;
        }

        public static string SetADBFolderPath(string folderPath)
        {
            ADB_FOLDER_PATH = folderPath;
            ADB_PATH = folderPath + "adb.exe";
            if (File.Exists(ADB_PATH))
            {
                return null;
            }
            return "ADB Path not Exits!!!";
        }

        public static void Swipe(string deviceID, int x1, int y1, int x2, int y2, int duration = 100)
        {
            string str2 = ExecuteCMD(string.Format(SWIPE_DEVICES, new object[] { deviceID, x1, y1, x2, y2, duration }));
        }

        public static void SwipeByPercent(string deviceID, double x1, double y1, double x2, double y2, int duration = 100)
        {
            Point screenResolution = GetScreenResolution(deviceID);
            int num = (int)(x1 * ((screenResolution.X * 1.0) / 100.0));
            int num2 = (int)(y1 * ((screenResolution.Y * 1.0) / 100.0));
            int num3 = (int)(x2 * ((screenResolution.X * 1.0) / 100.0));
            int num4 = (int)(y2 * ((screenResolution.Y * 1.0) / 100.0));
            string str2 = ExecuteCMD(string.Format(SWIPE_DEVICES, new object[] { deviceID, num, num2, num3, num4, duration }));
        }

        public static void Tap(string deviceID, int x, int y, int count = 1)
        {
            string cmdCommand = string.Format(TAP_DEVICES, deviceID, x, y);
            for (int i = 1; i < count; i++)
            {
                cmdCommand = cmdCommand + " && " + string.Format(TAP_DEVICES, deviceID, x, y);
            }
            string str2 = ExecuteCMD(cmdCommand);
        }

        public static void TapByPercent(string deviceID, double x, double y, int count = 1)
        {
            Point screenResolution = GetScreenResolution(deviceID);
            int num = (int)(x * ((screenResolution.X * 1.0) / 100.0));
            int num2 = (int)(y * ((screenResolution.Y * 1.0) / 100.0));
            string cmdCommand = string.Format(TAP_DEVICES, deviceID, num, num2);
            for (int i = 1; i < count; i++)
            {
                cmdCommand = cmdCommand + " && " + string.Format(TAP_DEVICES, deviceID, x, y);
            }
            string str2 = ExecuteCMD(cmdCommand);
        }
    }
}
