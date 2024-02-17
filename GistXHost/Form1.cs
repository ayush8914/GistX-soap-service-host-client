using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GistXservices;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace GistXHost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ServiceHost sh = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            Uri tcpa = new Uri("net.tcp://localhost:8000/TcpBinding");
            sh = new ServiceHost(typeof(AuthService),tcpa);

            NetTcpBinding tcpb = new NetTcpBinding();

            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            
            sh.Description.Behaviors.Add(smb);
            sh.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexTcpBinding(), "mex");
            sh.AddServiceEndpoint(typeof(IService), tcpb, tcpa);
            sh.Open();

            label2.Text = "Service is running";
        }
    }
}
