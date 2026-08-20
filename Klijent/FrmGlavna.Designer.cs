namespace Klijent
{
    partial class FrmGlavna
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            racuniToolStripMenuItem = new ToolStripMenuItem();
            dodajRacunToolStripMenuItem = new ToolStripMenuItem();
            pretragaRacunaToolStripMenuItem = new ToolStripMenuItem();
            kupciToolStripMenuItem = new ToolStripMenuItem();
            dodajKupcaToolStripMenuItem = new ToolStripMenuItem();
            pretragaKupcaToolStripMenuItem = new ToolStripMenuItem();
            strucnaSpremaToolStripMenuItem = new ToolStripMenuItem();
            dodajStrucnuSpremuToolStripMenuItem = new ToolStripMenuItem();
            pnlGlavni = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { racuniToolStripMenuItem, kupciToolStripMenuItem, strucnaSpremaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1113, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // racuniToolStripMenuItem
            // 
            racuniToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dodajRacunToolStripMenuItem, pretragaRacunaToolStripMenuItem });
            racuniToolStripMenuItem.Name = "racuniToolStripMenuItem";
            racuniToolStripMenuItem.Size = new Size(55, 20);
            racuniToolStripMenuItem.Text = "Racuni";
            // 
            // dodajRacunToolStripMenuItem
            // 
            dodajRacunToolStripMenuItem.Name = "dodajRacunToolStripMenuItem";
            dodajRacunToolStripMenuItem.Size = new Size(157, 22);
            dodajRacunToolStripMenuItem.Text = "Dodaj racun";
            // 
            // pretragaRacunaToolStripMenuItem
            // 
            pretragaRacunaToolStripMenuItem.Name = "pretragaRacunaToolStripMenuItem";
            pretragaRacunaToolStripMenuItem.Size = new Size(157, 22);
            pretragaRacunaToolStripMenuItem.Text = "Pretraga racuna";
            // 
            // kupciToolStripMenuItem
            // 
            kupciToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dodajKupcaToolStripMenuItem, pretragaKupcaToolStripMenuItem });
            kupciToolStripMenuItem.Name = "kupciToolStripMenuItem";
            kupciToolStripMenuItem.Size = new Size(49, 20);
            kupciToolStripMenuItem.Text = "Kupci";
            // 
            // dodajKupcaToolStripMenuItem
            // 
            dodajKupcaToolStripMenuItem.Name = "dodajKupcaToolStripMenuItem";
            dodajKupcaToolStripMenuItem.Size = new Size(153, 22);
            dodajKupcaToolStripMenuItem.Text = "Dodaj kupca";
            // 
            // pretragaKupcaToolStripMenuItem
            // 
            pretragaKupcaToolStripMenuItem.Name = "pretragaKupcaToolStripMenuItem";
            pretragaKupcaToolStripMenuItem.Size = new Size(153, 22);
            pretragaKupcaToolStripMenuItem.Text = "Pretraga kupca";
            // 
            // strucnaSpremaToolStripMenuItem
            // 
            strucnaSpremaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dodajStrucnuSpremuToolStripMenuItem });
            strucnaSpremaToolStripMenuItem.Name = "strucnaSpremaToolStripMenuItem";
            strucnaSpremaToolStripMenuItem.Size = new Size(101, 20);
            strucnaSpremaToolStripMenuItem.Text = "Strucna sprema";
            // 
            // dodajStrucnuSpremuToolStripMenuItem
            // 
            dodajStrucnuSpremuToolStripMenuItem.Name = "dodajStrucnuSpremuToolStripMenuItem";
            dodajStrucnuSpremuToolStripMenuItem.Size = new Size(191, 22);
            dodajStrucnuSpremuToolStripMenuItem.Text = "Dodaj strucnu spremu";
            // 
            // pnlGlavni
            // 
            pnlGlavni.Dock = DockStyle.Fill;
            pnlGlavni.Location = new Point(0, 24);
            pnlGlavni.Name = "pnlGlavni";
            pnlGlavni.Size = new Size(1113, 522);
            pnlGlavni.TabIndex = 1;
            // 
            // FrmGlavna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000,550);
            MinimumSize = new Size(1000, 350);
            Controls.Add(pnlGlavni);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmGlavna";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Glavni meni";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private Panel pnlGlavni;
        private ToolStripMenuItem racuniToolStripMenuItem;
        private ToolStripMenuItem dodajRacunToolStripMenuItem;
        private ToolStripMenuItem pretragaRacunaToolStripMenuItem;
        private ToolStripMenuItem kupciToolStripMenuItem;
        private ToolStripMenuItem dodajKupcaToolStripMenuItem;
        private ToolStripMenuItem pretragaKupcaToolStripMenuItem;
        private ToolStripMenuItem strucnaSpremaToolStripMenuItem;
        private ToolStripMenuItem dodajStrucnuSpremuToolStripMenuItem;
    }
}