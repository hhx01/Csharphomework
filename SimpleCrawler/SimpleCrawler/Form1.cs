using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Crawler
{
    public partial class Form1 : Form
    {
        SimpleCrawler myCrawler = new SimpleCrawler();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            simpleCrawlerBindingSource.DataSource = myCrawler.urls;
            dataGridView1.DataSource = simpleCrawlerBindingSource;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            string startUrl = "";
           
            if (textBox1.Text == null)
            {
              startUrl = "http://www.cnblogs.com/dstang2000/";
            }
            else { startUrl = textBox1.Text; }
            myCrawler.urls.Add(startUrl, false);//加入初始页面
            new Thread(myCrawler.Crawl).Start();
        }
    }
}
