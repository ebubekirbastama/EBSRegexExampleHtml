using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBSREGEX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string htmlveri = "<div class=\"rebateBadge\">%55</div>";
        string regexparent = @"<[^>]*?>";
        private void button1_Click(object sender, EventArgs e)
        {
           textBox1.Text = Regex.Replace(htmlveri, regexparent, "");
        }
    }
}
