using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Server
{
    public partial class FrmServer : Form
    {
        private Server server;
        public FrmServer()
        {
            InitializeComponent();
            btnStop.Enabled = false;
        }

     

        private void FrmServer_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            try
            {
                server = new Server();
                server.Start();

                lblText.Text = "Server je pokrenut!";
                btnStart.Enabled = false;
                btnStop.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStop_Click_1(object sender, EventArgs e)
        {
            try
            {
                server.Stop();

                lblText.Text = "Server nije pokrenut!";
                btnStart.Enabled = true;
                btnStop.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmServer_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);

        }
    }
}
