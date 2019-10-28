using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RestSharp;
using System.Threading;

namespace HAHA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread start = new Thread(() => {
                for (int i = int.Parse(textBox1.Text); i <= int.Parse(textBox2.Text); i++)
                {
                    haha.Test check = new haha.Test();

                    if (check._HamLayID(i.ToString()) == 0)
                    {
                        DataTable dt = new DataTable();
                        var client = new RestClient("https://dieutin.vnpost.vn/");
                        //var request = new RestRequest("serviceApi/v1/getAcceptance", Method.GET);
                        var request = new RestRequest("serviceApi/v1/huyDonHang", Method.GET);
                        request.AddParameter("donhang", i.ToString());
                        request.AddParameter("maBuuGui", "");
                        request.AddParameter("ghichu", "");
                        var result = client.Execute(request);
                        if (result != null && result.Content != null && result.Content.Length > 0)
                        {
                            if (result.Content.IndexOf("0") != -1)
                            {
                                label1.Text = "Toạch id=" + i.ToString();
                            }
                            else
                            {

                            }
                        }
                    }
                }
            });
            start.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }
    }
}
