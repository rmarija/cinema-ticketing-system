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
    public partial class FrmGlavna : Form
    {
        public FrmGlavna()
        {
            InitializeComponent();

            dodajRacunToolStripMenuItem.Click += MainCoordinator.Instance.ShowDodajRacunPanel;
            pretragaRacunaToolStripMenuItem.Click += MainCoordinator.Instance.ShowPretraziRacunPanel;

            dodajKupcaToolStripMenuItem.Click += MainCoordinator.Instance.ShowDodajKupcaPanel;
            pretragaKupcaToolStripMenuItem.Click += MainCoordinator.Instance.ShowPretraziKupcaPanel;

            dodajStrucnuSpremuToolStripMenuItem.Click += MainCoordinator.Instance.ShowDodajStrucnuSpremuPanel;
        }

        public void ChangePanel(Control control)
        {
            pnlGlavni.Controls.Clear();
            control.Dock = DockStyle.Fill;
            pnlGlavni.Controls.Add(control);
            pnlGlavni.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }
    }
}
