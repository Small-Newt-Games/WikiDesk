using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WikiDeskApp
{
    public partial class Form1 : Form
    {
        public WikiDeskFinder deskFinder;

        public Form1()
        {
            //Initializes the program
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Create a new WikiDeskFinder object
            deskFinder = new WikiDeskFinder();


            if (this.comboBox1.SelectedItem != null)
            {
                //Show the WikiDeskFinder window
                deskFinder.Show();

                //Create a new string variable and set it to the value of the combo box (dropdown)
                string page = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);

                //Runs the openPage function from WikiDeskFinder.cs
                deskFinder.openPage(page);

                //Hides the current window
                this.Hide();
            }
        }
    }
}
