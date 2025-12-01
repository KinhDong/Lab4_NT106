using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_24520303_BuiCongDinh.Bai3
{
    public partial class WebSources : Form
    {
        public WebSources(string webUrl, string source)
        {
            InitializeComponent();

            tb_WebUrl.Text = webUrl;
            rtb_Source.Text = source;
        }
    }
}
