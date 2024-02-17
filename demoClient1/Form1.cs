using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoClient1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.ServiceClient sc = new ServiceReference1.ServiceClient();
            string username = textBox1.Text;
            string password = textBox2.Text;

            ServiceReference1.ResponseContract rc = sc.Login(username, password);
            label1.Text = rc.message;
        }
    }
}
