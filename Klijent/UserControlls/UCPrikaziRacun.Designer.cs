namespace Klijent.UserControlls
{
    partial class UCPrikaziRacun
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
            dgvStavke = new DataGridView();
            btnDodaj = new Button();
            lblUkupanIznos = new Label();
            label7 = new Label();
            label6 = new Label();
            numKolicina = new NumericUpDown();
            txtCena = new TextBox();
            label5 = new Label();
            cbProjekcija = new ComboBox();
            label4 = new Label();
            Projekcija = new Label();
            cbProdavac = new ComboBox();
            label3 = new Label();
            lbl = new Label();
            cbKupac = new ComboBox();
            dtpDatumCekiranja = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            dtpDatumProdaje = new DateTimePicker();
            btnIzmeni = new Button();
            label8 = new Label();
            cbNacinPlacanja = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvStavke).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numKolicina).BeginInit();
            SuspendLayout();
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(712, 361);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(75, 23);
            btnSacuvaj.TabIndex = 42;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            // 
            // dgvStavke
            // 
            dgvStavke.AllowUserToAddRows = false;
            dgvStavke.AllowUserToDeleteRows = false;
            dgvStavke.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStavke.Location = new Point(393, 173);
            dgvStavke.Name = "dgvStavke";
            dgvStavke.ReadOnly = true;
            dgvStavke.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStavke.Size = new Size(647, 182);
            dgvStavke.TabIndex = 40;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(56, 361);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(237, 23);
            btnDodaj.TabIndex = 39;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            // 
            // lblUkupanIznos
            // 
            lblUkupanIznos.AutoSize = true;
            lblUkupanIznos.Location = new Point(241, 317);
            lblUkupanIznos.Name = "lblUkupanIznos";
            lblUkupanIznos.Size = new Size(52, 15);
            lblUkupanIznos.TabIndex = 38;
            lblUkupanIznos.Text = "0.00 RSD";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(56, 317);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 37;
            label7.Text = "Ukupan iznos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 211);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 36;
            label6.Text = "Kolicina";
            label6.Click += label6_Click;
            // 
            // numKolicina
            // 
            numKolicina.Location = new Point(141, 203);
            numKolicina.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numKolicina.Name = "numKolicina";
            numKolicina.Size = new Size(152, 23);
            numKolicina.TabIndex = 35;
            numKolicina.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtCena
            // 
            txtCena.Location = new Point(141, 241);
            txtCena.Name = "txtCena";
            txtCena.Size = new Size(152, 23);
            txtCena.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 241);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 33;
            label5.Text = "Cena";
            // 
            // cbProjekcija
            // 
            cbProjekcija.FormattingEnabled = true;
            cbProjekcija.Location = new Point(141, 173);
            cbProjekcija.Name = "cbProjekcija";
            cbProjekcija.Size = new Size(152, 23);
            cbProjekcija.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 176);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 31;
            label4.Text = "Projekcija";
            // 
            // Projekcija
            // 
            Projekcija.AutoSize = true;
            Projekcija.Location = new Point(14, 140);
            Projekcija.Name = "Projekcija";
            Projekcija.Size = new Size(80, 15);
            Projekcija.TabIndex = 30;
            Projekcija.Text = "Stavke racuna";
            // 
            // cbProdavac
            // 
            cbProdavac.FormattingEnabled = true;
            cbProdavac.Location = new Point(584, 83);
            cbProdavac.Name = "cbProdavac";
            cbProdavac.Size = new Size(152, 23);
            cbProdavac.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(485, 91);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 28;
            label3.Text = "Prodavac";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(485, 46);
            lbl.Name = "lbl";
            lbl.Size = new Size(40, 15);
            lbl.TabIndex = 27;
            lbl.Text = "Kupac";
            // 
            // cbKupac
            // 
            cbKupac.FormattingEnabled = true;
            cbKupac.Location = new Point(584, 43);
            cbKupac.Name = "cbKupac";
            cbKupac.Size = new Size(152, 23);
            cbKupac.TabIndex = 26;
            // 
            // dtpDatumCekiranja
            // 
            dtpDatumCekiranja.Location = new Point(180, 83);
            dtpDatumCekiranja.Name = "dtpDatumCekiranja";
            dtpDatumCekiranja.Size = new Size(200, 23);
            dtpDatumCekiranja.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 86);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 24;
            label2.Text = "Datum cekiranja";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 46);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 23;
            label1.Text = "Datum prodaje";
            // 
            // dtpDatumProdaje
            // 
            dtpDatumProdaje.Location = new Point(180, 43);
            dtpDatumProdaje.Name = "dtpDatumProdaje";
            dtpDatumProdaje.Size = new Size(201, 23);
            dtpDatumProdaje.TabIndex = 22;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(611, 361);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(75, 23);
            btnIzmeni.TabIndex = 43;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(42, 270);
            label8.Name = "label8";
            label8.Size = new Size(85, 15);
            label8.TabIndex = 45;
            label8.Text = "Nacin placanja";
            // 
            // cbNacinPlacanja
            // 
            cbNacinPlacanja.FormattingEnabled = true;
            cbNacinPlacanja.Items.AddRange(new object[] { "Gotovina", "Kartica" });
            cbNacinPlacanja.Location = new Point(141, 267);
            cbNacinPlacanja.Name = "cbNacinPlacanja";
            cbNacinPlacanja.Size = new Size(152, 23);
            cbNacinPlacanja.TabIndex = 44;
            // 
            // UCPrikaziRacun
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label8);
            Controls.Add(cbNacinPlacanja);
            Controls.Add(btnIzmeni);
            Controls.Add(btnSacuvaj);
            Controls.Add(dgvStavke);
            Controls.Add(btnDodaj);
            Controls.Add(lblUkupanIznos);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(numKolicina);
            Controls.Add(txtCena);
            Controls.Add(label5);
            Controls.Add(cbProjekcija);
            Controls.Add(label4);
            Controls.Add(Projekcija);
            Controls.Add(cbProdavac);
            Controls.Add(label3);
            Controls.Add(lbl);
            Controls.Add(cbKupac);
            Controls.Add(dtpDatumCekiranja);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpDatumProdaje);
            Name = "UCPrikaziRacun";
            Size = new Size(1085, 505);
            ((System.ComponentModel.ISupportInitialize)dgvStavke).EndInit();
            ((System.ComponentModel.ISupportInitialize)numKolicina).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button btnSacuvaj;
        public DataGridView dgvStavke;
        public Button btnDodaj;
        public Label lblUkupanIznos;
        private Label label7;
        private Label label6;
        public NumericUpDown numKolicina;
        public TextBox txtCena;
        private Label label5;
        public ComboBox cbProjekcija;
        private Label label4;
        private Label Projekcija;
        public ComboBox cbProdavac;
        private Label label3;
        private Label lbl;
        public ComboBox cbKupac;
        public DateTimePicker dtpDatumCekiranja;
        private Label label2;
        private Label label1;
        public DateTimePicker dtpDatumProdaje;
        public Button btnIzmeni;
        private Label label8;
        public ComboBox cbNacinPlacanja;
    }
}
