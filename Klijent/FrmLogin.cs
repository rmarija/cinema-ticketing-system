using Klijent.GuiControllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            LoginGuiController.Instance.SrediFormu(this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginGuiController.Instance.PrijaviSe(txtUsername.Text.Trim(), txtPassword.Text.Trim());
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
