using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace AutoADB
{
    public class LDPlayerHelper
    {
        public static string LDP_FOLDER_PATH = "";
        public static string ExecuteCMD(string cmdCommand)
        {
            try
            {
                Process process = new Process();
                ProcessStartInfo info = new ProcessStartInfo
                {
                    WorkingDirectory = LDP_FOLDER_PATH,
                    FileName = "cmd.exe",
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    WindowStyle = ProcessWindowStyle.Normal,
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

        private static string _quit = "dnconsole quit --index {0}";
        private static string _launch = "dnconsole launch --index {0}";
        private static string _add = "dnconsole add --name {0}";
        private static string _copy = "dnconsole copy --name {0} --from {1}";
        private static string _remove = "dnconsole remove --index {0}";
        private static string _rename = "dnconsole rename --index {0} --title {1}";
        private static string _installapp = "dnconsole installapp --index {0} --filename {1} ";
        private static string _uninstallapp = "dnconsole uninstallapp --index {0} --packagename {1} ";
        private static string _runapp = "dnconsole runapp --index {0} --packagename {1} ";
        private static string _killapp = "dnconsole killapp --index {0} --packagename {1} ";
        private static string _locate = "dnconsole locate --index {0} --LLI \"{1}\" ";
        private static string _adb = "dnconsole adb --index {0} --command \"{1}\" ";
        private static string _bachup = "dnconsole bachup --index {0} --file \"{1}\" ";
        private static string _restore = "dnconsole restore --index {0} --file \"{1}\" ";
        private static string _pull = "dnconsole pull --index {0} --remove \"{1}\" --local \"{2}\" ";
        private static string _push = "dnconsole push --index {0} --remove \"{1}\" --local \"{2}\" ";
        private static string _bachupapp = "dnconsole bachupapp --index {0} --packagename {1} --file \"{2}\" ";
        private static string _restorepapp = "dnconsole restorepapp --index {0} --packagename {1} --file \"{2}\" ";
        private static string _launchex = "dnconsole launchex --index {0} --packagename {1} ";

        public static void quit(string index)
        {
            string str2 = ExecuteCMD(string.Format(_quit, index));
        }
        public static void launch(string index)
        {
            string str2 = ExecuteCMD(string.Format(_launch, index));
        }
        public static void add(string name)
        {
            string str2 = ExecuteCMD(string.Format(_add, name));
        }
        public static void copy(string index,string from)
        {
            string str2 = ExecuteCMD(string.Format(_copy, index, from));
        }
        public static void remove(string index)
        {
            string str2 = ExecuteCMD(string.Format(_remove, index));
        }
        public static void rename(string index,string title)
        {
            string str2 = ExecuteCMD(string.Format(_rename, index, title));
        }
        public static void installapp(string index, string filename)
        {
            string str2 = ExecuteCMD(string.Format(_installapp, index, filename));
        }
        public static void uninstallapp(string index, string packagename)
        {
            string str2 = ExecuteCMD(string.Format(_uninstallapp, index, packagename));
        }
        public static void runapp(string index, string packagename)
        {
            string str2 = ExecuteCMD(string.Format(_runapp, index, packagename));
        }
        public static void killapp(string index, string packagename)
        {
            string str2 = ExecuteCMD(string.Format(_killapp, index, packagename));
        }
        public static void locate(string index, string LLI)
        {
            string str2 = ExecuteCMD(string.Format(_locate, index, LLI));
        }
        public static void adb(string index, string command)
        {
            string str2 = ExecuteCMD(string.Format(_adb, index, command));
        }
        public static void bachup(string index, string file)// fromat *ldbk
        {
            string str2 = ExecuteCMD(string.Format(_bachup, index, file));
        }
        public static void restore(string index, string file)// fromat *ldbk
        {
            string str2 = ExecuteCMD(string.Format(_restore, index, file));
        }
        public static void pull(string index, string remove,string local)
        {
            string str2 = ExecuteCMD(string.Format(_pull, index, remove,local));
        }
        public static void push(string index, string remove, string local)
        {
            string str2 = ExecuteCMD(string.Format(_push, index, remove, local));
        }
        public static void bachupapp(string index, string packagename, string file)// * file apk
        {
            string str2 = ExecuteCMD(string.Format(_bachupapp, index, packagename, file));
        }
        public static void restorepapp(string index, string packagename, string file)// * file apk
        {
            string str2 = ExecuteCMD(string.Format(_restorepapp, index, packagename, file));
        }
        public static void launchex(string index, string packagename)// * com.facebook.kanata
        {
            string str2 = ExecuteCMD(string.Format(_launchex, index, packagename));
        }
    }
}
