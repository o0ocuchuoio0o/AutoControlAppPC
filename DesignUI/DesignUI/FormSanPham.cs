using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesignUI
{
    public partial class FormSanPham : Form
    {
        public FormSanPham()
        {
            InitializeComponent();
        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID",typeof(string));
            dt.Columns.Add("Name", typeof(string));

            for (int i = 1; i <= 9;i++ )
            {
                dt.Rows.Add(i.ToString(), "Sản phẩm số " + i.ToString());
            }
            dataGridView1.DataSource = dt;
        }
    }
}
