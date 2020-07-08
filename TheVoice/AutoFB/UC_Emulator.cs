using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoFB
{
    public partial class UC_Emulator : UserControl
    {
        public UC_Emulator(string idprosess, string name,string idphone)
        {
            InitializeComponent();
            m_idprosess = idprosess;
            m_name = name;
            m_idphone = idphone;
        }
        public string m_idprosess;
        public string m_name;

        public string Idprosess
        {
            get
            {
                return m_idprosess;
            }

            set
            {
                m_idprosess = value;
            }
        }

        public string Name1
        {
            get
            {
                return m_name;
            }

            set
            {
                m_name = value;
            }
        }

        public string m_idphone;
        public string Idphone {
            get
            {
                return m_idphone;
            }

            set
            {
                m_idphone = value;
            }
        }
     
        private void UC_Emulator_Load(object sender, EventArgs e)
        {
            loadname();
        }
        public void loadname()
        {
            lblname.Text = m_name;
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            ChayGiaLap f1 = (ChayGiaLap)Application.OpenForms["ChayGiaLap"];
            f1.Closeemulator(m_idprosess, m_name);
        }

        private void btnsetting_Click(object sender, EventArgs e)
        {
            ChayGiaLap f1 = (ChayGiaLap)Application.OpenForms["ChayGiaLap"];
            f1.Setting(m_idphone);
        }
    }
}
