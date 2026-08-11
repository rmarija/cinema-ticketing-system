namespace Klijent.UserControlls
{
    partial class UCDodajStrucnuSpremu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtNaziv = new TextBox();
            txtStrSprema = new TextBox();
            btnDodaj = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(198, 110);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Naziv";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 193);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 1;
            label2.Text = "Stepen obrazovanja";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(398, 107);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(191, 23);
            txtNaziv.TabIndex = 2;
            // 
            // txtStrSprema
            // 
            txtStrSprema.Location = new Point(398, 190);
            txtStrSprema.Name = "txtStrSprema";
            txtStrSprema.Size = new Size(191, 23);
            txtStrSprema.TabIndex = 3;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(282, 297);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(224, 23);
            btnDodaj.TabIndex = 4;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            // 
            // UCDodajStrucnuSpremu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDodaj);
            Controls.Add(txtStrSprema);
            Controls.Add(txtNaziv);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UCDodajStrucnuSpremu";
            Size = new Size(800, 426);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        public TextBox txtNaziv;
        public TextBox txtStrSprema;
        public Button btnDodaj;
    }
}
