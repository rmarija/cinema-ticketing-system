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
            txtNaziv = new TextBox();
            txtTelefon = new TextBox();
            txtEmail = new TextBox();
            txtIme = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblNaziv = new Label();
            btnIzmeni = new Button();
            btnObrisi = new Button();
            SuspendLayout();
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(561, 334);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(182, 29);
            btnSacuvaj.TabIndex = 27;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            // 
            // txtPostanski
            // 
            txtPostanski.Location = new Point(595, 177);
            txtPostanski.Name = "txtPostanski";
            txtPostanski.Size = new Size(139, 23);
            txtPostanski.TabIndex = 26;
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(595, 122);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(139, 23);
            txtNaziv.TabIndex = 25;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(182, 234);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(139, 23);
            txtTelefon.TabIndex = 24;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(182, 177);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(139, 23);
            txtEmail.TabIndex = 23;
            // 
            // txtIme
            // 
            txtIme.Location = new Point(182, 122);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(139, 23);
            txtIme.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(476, 185);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 21;
            label7.Text = "Postanski broj";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(476, 130);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 20;
            label6.Text = "Naziv";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(429, 57);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 19;
            label5.Text = "Mesto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 242);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 18;
            label4.Text = "Telefon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 185);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 17;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 57);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 16;
            label2.Text = "Kupac";
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
            lblNaziv.Location = new Point(88, 130);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(78, 15);
            lblNaziv.TabIndex = 14;
            lblNaziv.Text = "Ime i prezime";
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(300, 334);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(182, 29);
            btnIzmeni.TabIndex = 28;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(52, 334);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(182, 29);
            btnObrisi.TabIndex = 29;
            btnObrisi.Text = "Obrisi";
            btnObrisi.UseVisualStyleBackColor = true;
            // 
            // UCPrikaziKupca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnObrisi);
            Controls.Add(btnIzmeni);
            Controls.Add(btnSacuvaj);
            Controls.Add(txtPostanski);
            Controls.Add(txtNaziv);
            Controls.Add(txtTelefon);
            Controls.Add(txtEmail);
            Controls.Add(txtIme);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblNaziv);
            Name = "UCPrikaziKupca";
            Size = new Size(800, 426);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button btnSacuvaj;
        public TextBox txtPostanski;
        public TextBox txtNaziv;
        public TextBox txtTelefon;
        public TextBox txtEmail;
        public TextBox txtIme;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblNaziv;
        public Button btnIzmeni;
        public Button btnObrisi;
    }
}
