using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QubeVuWebService;  
namespace TestCanDienTu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string qubeVuHost = txtip.Text ;
            QubeVuService qubeVuService=new QubeVuService();
            string webServiceUrl = "http://" + qubeVuHost + "/WebServices/QubeVuService";
            Console.WriteLine("Connecting to {0} ...", webServiceUrl);

            //
            // create an instance of the QubeVu service
            //
            qubeVuService = new QubeVuService();

            //
            // set web service parameters: url, timeout
            //
            qubeVuService.Url = webServiceUrl;
            qubeVuService.Timeout = 5000;

            //
            // request status from QubeVu
            //
            QVStatus qvStatus =  qubeVuService.Status();
            Console.WriteLine("Connection successful");
            Console.WriteLine("Status: {0} Capture Id: {1} Ex status: {2}", qvStatus.Status, qvStatus.CaptureId, qvStatus.ExtendedStatus);

            // show dims and tracker image url if available
            if (qvStatus.Status == "IMAGING" || qvStatus.Status == "REMOVE")
            {
                Console.WriteLine("Dimensions: {0} x {1} x {2} ({3})", qvStatus.CapturedData.Dimensions.Length,
                                                                       qvStatus.CapturedData.Dimensions.Width,
                                                                       qvStatus.CapturedData.Dimensions.Height,
                                                                       qvStatus.CapturedData.Dimensions.DimUnit);
                lblketqua.Text = "D:" + qvStatus.CapturedData.Dimensions.Length.ToString()
                   +" R:" + qvStatus.CapturedData.Dimensions.Width.ToString()
                   +" C:" + qvStatus.CapturedData.Dimensions.Height.ToString()
                   +" TRL:" + qvStatus.CapturedData.Weight.ToString()
                   ;
                Console.WriteLine("Tracker image: {0}", qvStatus.CapturedData.TrackerImage.Url);
            }

            // show image url from high resolution camera if available
            if (qvStatus.Status == "REMOVE")
            {
                if (qvStatus.CapturedData.HighResImages != null && qvStatus.CapturedData.HighResImages.Length > 0)
                {
                    Console.WriteLine("High res image: {0}", qvStatus.CapturedData.HighResImages[0].Url);
                }
            }

        }

        
    }
}
