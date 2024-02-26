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
using System.Threading;

namespace WikiDeskApp
{
    public partial class WikiDeskFinder : Form
    {
        //Create variables
        string pageOpen = "none";
        public Form1 form1;


        public WikiDeskFinder()
        {
            //Initializes the program
            InitializeComponent();
        }

        public void openPage(string page)
        {
            //Write the 'page' variable to the debug output
            Debug.Write(page);

            //Set the 'pageOpen' variable to the 'page' String parameter from the openPage() function
            pageOpen = page;

            //Set the Search textbox text to 'Search ' + the current page that is open
            this.textBox1.Text = "Search " + pageOpen + "...";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(pageOpen == "Fandom Wikis'")
            {
                //Create a 'url' variable of type String
                string url;

                //Set the url string
                url = "https://www.fandom.com/?s=" + this.textBox1.Text;

                //Set the Web Browser object to a url and create a Uri object
                this.webBrowser1.Url = new Uri(url);
            }

            if (pageOpen == "Wikipedia")
            {
                //Create a 'url' variable of type String
                string url;

                //Set the url string
                url = "https://en.wikipedia.org/w/index.php?search=" + this.textBox1.Text;

                //Set the Web Browser object to a url and create a Uri object
                this.webBrowser1.Url = new Uri(url);
            }

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(this.webBrowser1.Url.ToString());

            //Disable button and add success text
            this.button2.Text = "Opened In Browser Successfully!";
            this.button2.Enabled = false;

            //Sleep
            Thread.Sleep(4000);

            //Enable button and remove success text
            this.button2.Text = "Opened In Browser Successfully!";
            this.button2.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Create new form1 object
            form1 = new Form1();

            //Show the form1 Window
            form1.Show();
            
            //Hide current window
            this.Hide();
        }
    }

}