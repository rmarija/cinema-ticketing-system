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
            btnDodaj = new Button();
            cbStrSprema = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(280, 196);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Naziv";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(280, 279);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 1;
            label2.Text = "Stepen obrazovanja";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(480, 193);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(191, 23);
            txtNaziv.TabIndex = 2;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(364, 383);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(224, 23);
            btnDodaj.TabIndex = 4;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            // 
            // cbStrSprema
            // 
            cbStrSprema.FormattingEnabled = true;
            cbStrSprema.Items.AddRange(new object[] { "I", "II", "III", "IV" });
            cbStrSprema.Location = new Point(480, 276);
            cbStrSprema.Name = "cbStrSprema";
            cbStrSprema.Size = new Size(191, 23);
            cbStrSprema.TabIndex = 3;
            // 
            // UCDodajStrucnuSpremu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cbStrSprema);
            Controls.Add(btnDodaj);
            Controls.Add(txtNaziv);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UCDodajStrucnuSpremu";
            Size = new Size(1000, 650);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        public TextBox txtNaziv;
        public Button btnDodaj;
        public ComboBox cbStrSprema;
    }
}
