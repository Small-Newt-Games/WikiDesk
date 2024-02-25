using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WikiDeskApp
{
    public partial class WikiDeskFinder : Form
    {
        string pageOpen = "none";
        public Form1 form1;


        public WikiDeskFinder()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        public void openPage(string page)
        {
            Debug.Write(page);
            pageOpen = page;
            this.textBox1.Text = "Search " + pageOpen + "...";
        }

        private void WikiDeskFinder_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(pageOpen == "Fandom Wikis'")
            {
                string url;

                url = "https://www.fandom.com/?s=" + this.textBox1.Text;

                this.webBrowser1.Url = new Uri(url);
            }

            if (pageOpen == "Wikipedia")
            {
                string url;

                url = "https://en.wikipedia.org/w/index.php?search=" + this.textBox1.Text;

                this.webBrowser1.Url = new Uri(url);
            }

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(this.webBrowser1.Url.ToString());        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }

}