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
            label3 = new Label();
            cbProdavac = new ComboBox();
            dtpDatumSticanja = new DateTimePicker();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(280, 156);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Naziv";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(280, 218);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 1;
            label2.Text = "Stepen obrazovanja";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(480, 148);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(191, 23);
            txtNaziv.TabIndex = 2;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(359, 380);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(224, 23);
            btnDodaj.TabIndex = 4;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            // 
            // cbStrSprema
            // 
            cbStrSprema.FormattingEnabled = true;
            cbStrSprema.Items.AddRange(new object[] { "I", "II", "III", "IV", "V", "VI", "VII", "VIII" });
            cbStrSprema.Location = new Point(480, 215);
            cbStrSprema.Name = "cbStrSprema";
            cbStrSprema.Size = new Size(191, 23);
            cbStrSprema.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(280, 86);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 5;
            label3.Text = "Prodavac";
            // 
            // cbProdavac
            // 
            cbProdavac.FormattingEnabled = true;
            cbProdavac.Location = new Point(480, 83);
            cbProdavac.Name = "cbProdavac";
            cbProdavac.Size = new Size(191, 23);
            cbProdavac.TabIndex = 6;
            // 
            // dtpDatumSticanja
            // 
            dtpDatumSticanja.Format = DateTimePickerFormat.Short;
            dtpDatumSticanja.Location = new Point(565, 285);
            dtpDatumSticanja.Name = "dtpDatumSticanja";
            dtpDatumSticanja.Size = new Size(106, 23);
            dtpDatumSticanja.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(280, 285);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 8;
            label4.Text = "Datum sticanja";
            // 
            // UCDodajStrucnuSpremu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(dtpDatumSticanja);
            Controls.Add(cbProdavac);
            Controls.Add(label3);
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
        private Label label3;
        public ComboBox cbProdavac;
        private Label label4;
        public DateTimePicker dtpDatumSticanja;
    }
}
