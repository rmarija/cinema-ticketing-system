namespace Klijent.UserControlls
{
    partial class UCDodajKupca
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
            lblNaziv = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtIme = new TextBox();
            txtEmail = new TextBox();
            txtTelefon = new TextBox();
            txtNaziv = new TextBox();
            txtPostanski = new TextBox();
            btnSacuvaj = new Button();
            SuspendLayout();
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Location = new Point(144, 185);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(78, 15);
            lblNaziv.TabIndex = 0;
            lblNaziv.Text = "Ime i prezime";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 221);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(144, 94);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 2;
            label2.Text = "Podaci o kupcu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(144, 240);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(144, 297);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 4;
            label4.Text = "Telefon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(507, 94);
            label5.Name = "label5";
            label5.Size = new Size(113, 15);
            label5.TabIndex = 5;
            label5.Text = "Informacije o mestu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(507, 207);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 6;
            label6.Text = "Naziv";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(507, 267);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 7;
            label7.Text = "Postanski broj";
            // 
            // txtIme
            // 
            txtIme.Location = new Point(238, 177);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(139, 23);
            txtIme.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(238, 232);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(139, 23);
            txtEmail.TabIndex = 9;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(238, 289);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(139, 23);
            txtTelefon.TabIndex = 10;
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(651, 199);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(139, 23);
            txtNaziv.TabIndex = 11;
            // 
            // txtPostanski
            // 
            txtPostanski.Location = new Point(651, 259);
            txtPostanski.Name = "txtPostanski";
            txtPostanski.Size = new Size(139, 23);
            txtPostanski.TabIndex = 12;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(211, 410);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(553, 31);
            btnSacuvaj.TabIndex = 13;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            // 
            // UCDodajKupca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Name = "UCDodajKupca";
            Size = new Size(1000, 650);
            Load += UCDodajKupca_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNaziv;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        public TextBox txtIme;
        public TextBox txtEmail;
        public TextBox txtTelefon;
        public TextBox txtNaziv;
        public TextBox txtPostanski;
        public Button btnSacuvaj;
    }
}
