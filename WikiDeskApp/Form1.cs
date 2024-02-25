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
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deskFinder = new WikiDeskFinder();


            if (this.comboBox1.SelectedItem != null)
            {
                deskFinder.Show();

                string page = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);

                deskFinder.openPage(page);

                this.Hide();
            }
        }
    }
}
