namespace Klijent.UserControlls
{
    partial class UCPrikaziKupca
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
            btnSacuvaj = new Button();
            txtPostanski = new TextBox();
            txtTelefon = new TextBox();
            txtEmail = new TextBox();
            txtIme = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            lblNaziv = new Label();
            btnIzmeni = new Button();
            btnObrisi = new Button();
            cbMesto = new ComboBox();
            label8 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(706, 401);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(87, 25);
            btnSacuvaj.TabIndex = 27;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            // 
            // txtPostanski
            // 
            txtPostanski.Location = new Point(639, 242);
            txtPostanski.Name = "txtPostanski";
            txtPostanski.Size = new Size(139, 23);
            txtPostanski.TabIndex = 26;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(226, 299);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(139, 23);
            txtTelefon.TabIndex = 24;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(226, 242);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(139, 23);
            txtEmail.TabIndex = 23;
            // 
            // txtIme
            // 
            txtIme.Location = new Point(226, 187);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(139, 23);
            txtIme.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(520, 250);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 21;
            label7.Text = "Postanski broj";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(520, 195);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 20;
            label6.Text = "Naziv";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(132, 307);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 18;
            label4.Text = "Telefon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(132, 250);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 17;
            label3.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 166);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 15;
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Location = new Point(132, 195);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(78, 15);
            lblNaziv.TabIndex = 14;
            lblNaziv.Text = "Ime i prezime";
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(706, 370);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(87, 25);
            btnIzmeni.TabIndex = 28;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(706, 401);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(87, 25);
            btnObrisi.TabIndex = 29;
            btnObrisi.Text = "Obrisi";
            btnObrisi.UseVisualStyleBackColor = true;
            // 
            // cbMesto
            // 
            cbMesto.FormattingEnabled = true;
            cbMesto.Location = new Point(639, 187);
            cbMesto.Name = "cbMesto";
            cbMesto.Size = new Size(139, 23);
            cbMesto.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(121, 122);
            label8.Name = "label8";
            label8.Size = new Size(89, 15);
            label8.TabIndex = 31;
            label8.Text = "Podaci o kupcu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(508, 122);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 32;
            label2.Text = "Informacije o mestu";
            // 
            // UCPrikaziKupca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(cbMesto);
            Controls.Add(btnObrisi);
            Controls.Add(btnIzmeni);
            Controls.Add(btnSacuvaj);
            Controls.Add(txtPostanski);
            Controls.Add(txtTelefon);
            Controls.Add(txtEmail);
            Controls.Add(txtIme);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(lblNaziv);
            Name = "UCPrikaziKupca";
            Size = new Size(1000, 650);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button btnSacuvaj;
        public TextBox txtPostanski;
        public TextBox txtTelefon;
        public TextBox txtEmail;
        public TextBox txtIme;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label lblNaziv;
        public Button btnIzmeni;
        public Button btnObrisi;
        public ComboBox cbMesto;
        private Label label8;
        private Label label2;
    }
}
