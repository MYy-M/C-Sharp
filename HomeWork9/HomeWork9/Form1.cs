using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork9
{
    public partial class Form1 : Form
    {
        private SimpleCrawler myCrawler;
        private  URL url;
        public Form1()
        {
            InitializeComponent();

        }

        private void Crawler_Click(object sender, EventArgs e)
        {
            myCrawler.Crawl();         
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            crawler.DataBindings.Add("Text", url, "Urls");
      
        }
    }
}
