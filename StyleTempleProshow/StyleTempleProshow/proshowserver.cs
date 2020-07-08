using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace StyleTempleProshow
{
    public class proshowserver
    {
        public static string getLocalInProshow(string local)
        {
            return local.Replace("\\", "/");
        }

        public string _CreatePSH(int idproshow,string id, string pathintro, string timeintro, string pathouttro, string timeouttro, string localFoder, string musicbg, DataTable tableimage, string videobg)
        {
            string _psh = "";
            if (tableimage.Rows.Count > 0)
            {

                string head = daWS_FakeAuto._Head((tableimage.Rows.Count + 2).ToString(), localFoder, musicbg);
                // string head = daWS_FakeAuto._Head((tableimage.Rows.Count).ToString(), localFoder, musicbg);
                string slide;
                string tran;
                string groupslide = "";

                string intro;
                string tranintro;
                string groupintro = "";

                string outtro;
                string tranouttro;
                string groupouttro = "";

                int i = 0;
                if (pathintro != "")
                {
                    intro = daWS_FakeAuto._InTro(i.ToString(), getLocalInProshow(pathintro), timeintro);
                    tranintro = daWS_FakeAuto._TranSlide(i.ToString());
                    groupintro = intro + "\n" + tranintro;
                    i = i + 1;
                }
                foreach (DataRow r in tableimage.Rows)
                {
                    if (videobg != "")
                    {
                        slide = daWS_FakeAuto._SlideVideoBG_ID(idproshow,i.ToString(), getLocalInProshow(r["PathSub"].ToString()), r["PathImage"].ToString(), r["TimeSlide"].ToString(), r["PathVoice"].ToString(), r["TimeVoice"].ToString(), videobg);
                    }
                    else
                    {
                        slide = daWS_FakeAuto._Slide(i.ToString(), getLocalInProshow(r["PathSub"].ToString()), r["PathImage"].ToString(), r["TimeSlide"].ToString(), r["PathVoice"].ToString(), r["TimeVoice"].ToString());
                    }
                    tran = daWS_FakeAuto._TranSlide(i.ToString());
                    groupslide = groupslide + "\n" + slide + "\n" + tran;
                    i = i + 1;
                }
                if (pathouttro != "")
                {
                    outtro = daWS_FakeAuto._OutTro((i).ToString(), getLocalInProshow(pathouttro), timeouttro);
                    tranouttro = daWS_FakeAuto._TranSlide(i.ToString());
                    groupouttro = outtro; //+ "\n" + tranouttro;
                }
                string footer = daWS_FakeAuto._Footer();
                _psh = head + "\n" + groupintro + "\n" + groupslide + "\n" + groupouttro + "\n" + footer;
                //_psh = head + "\n" + groupslide + "\n" + footer;
            }
            StringBuilder content = new StringBuilder();
            content.Append(_psh.Trim());
            content.Replace("\r\n", "\n").Replace("\r", "\n").Replace("\n", "\r\n");
            string inputFile = localFoder + "\\" + id + ".psh";

            //File.Create(inputFile);
            try
            {
                using (StreamWriter outputFile = new StreamWriter(File.Open(inputFile, FileMode.Create), Encoding.Default))
                {
                    outputFile.Write(content.ToString());
                    return inputFile;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return "";
            }
        }
    }
}
