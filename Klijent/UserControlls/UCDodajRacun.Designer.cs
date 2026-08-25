namespace Klijent.UserControlls
{
    partial class UCDodajRacun
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
            dtpDatumProdaje = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            dtpDatumCekiranja = new DateTimePicker();
            cbKupac = new ComboBox();
            lbl = new Label();
            label3 = new Label();
            cbProdavac = new ComboBox();
            Projekcija = new Label();
            label4 = new Label();
            cbProjekcija = new ComboBox();
            label5 = new Label();
            numKolicina = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            lblUkupanIznos = new Label();
            btnDodaj = new Button();
            dgvStavke = new DataGridView();
            btnObrisi = new Button();
            btnSacuvaj = new Button();
            cbNacinPlacanja = new ComboBox();
            label8 = new Label();
            lblCena = new Label();
            ((System.ComponentModel.ISupportInitialize)numKolicina).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStavke).BeginInit();
            SuspendLayout();
            // 
            // dtpDatumProdaje
            // 
            dtpDatumProdaje.Location = new Point(169, 24);
            dtpDatumProdaje.Name = "dtpDatumProdaje";
            dtpDatumProdaje.Size = new Size(201, 23);
            dtpDatumProdaje.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 27);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 1;
            label1.Text = "Datum prodaje";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 67);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 2;
            label2.Text = "Datum cekiranja";
            // 
            // dtpDatumCekiranja
            // 
            dtpDatumCekiranja.Location = new Point(169, 64);
            dtpDatumCekiranja.Name = "dtpDatumCekiranja";
            dtpDatumCekiranja.Size = new Size(200, 23);
            dtpDatumCekiranja.TabIndex = 3;
            // 
            // cbKupac
            // 
            cbKupac.FormattingEnabled = true;
            cbKupac.Location = new Point(547, 21);
            cbKupac.Name = "cbKupac";
            cbKupac.Size = new Size(152, 23);
            cbKupac.TabIndex = 4;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(437, 24);
            lbl.Name = "lbl";
            lbl.Size = new Size(40, 15);
            lbl.TabIndex = 5;
            lbl.Text = "Kupac";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(437, 72);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 6;
            label3.Text = "Prodavac";
            // 
            // cbProdavac
            // 
            cbProdavac.FormattingEnabled = true;
            cbProdavac.Location = new Point(547, 64);
            cbProdavac.Name = "cbProdavac";
            cbProdavac.Size = new Size(152, 23);
            cbProdavac.TabIndex = 7;
            // 
            // Projekcija
            // 
            Projekcija.AutoSize = true;
            Projekcija.Location = new Point(35, 166);
            Projekcija.Name = "Projekcija";
            Projekcija.Size = new Size(80, 15);
            Projekcija.TabIndex = 8;
            Projekcija.Text = "Stavke racuna";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 207);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 9;
            label4.Text = "Projekcija";
            // 
            // cbProjekcija
            // 
            cbProjekcija.FormattingEnabled = true;
            cbProjekcija.Location = new Point(180, 199);
            cbProjekcija.Name = "cbProjekcija";
            cbProjekcija.Size = new Size(152, 23);
            cbProjekcija.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 290);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 11;
            label5.Text = "Cena po karti";
            // 
            // numKolicina
            // 
            numKolicina.Location = new Point(180, 244);
            numKolicina.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numKolicina.Name = "numKolicina";
            numKolicina.Size = new Size(152, 23);
            numKolicina.TabIndex = 13;
            numKolicina.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 252);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 14;
            label6.Text = "Kolicina";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 366);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 15;
            label7.Text = "Ukupan iznos";
            // 
            // lblUkupanIznos
            // 
            lblUkupanIznos.AutoSize = true;
            lblUkupanIznos.Location = new Point(297, 366);
            lblUkupanIznos.Name = "lblUkupanIznos";
            lblUkupanIznos.Size = new Size(52, 15);
            lblUkupanIznos.TabIndex = 16;
            lblUkupanIznos.Text = "0.00 RSD";
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(46, 443);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(237, 23);
            btnDodaj.TabIndex = 17;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            // 
            // dgvStavke
            // 
            dgvStavke.AllowUserToAddRows = false;
            dgvStavke.AllowUserToDeleteRows = false;
            dgvStavke.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStavke.Location = new Point(385, 155);
            dgvStavke.Name = "dgvStavke";
            dgvStavke.ReadOnly = true;
            dgvStavke.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStavke.Size = new Size(594, 193);
            dgvStavke.TabIndex = 18;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(904, 383);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(75, 23);
            btnObrisi.TabIndex = 20;
            btnObrisi.Text = "Obrisi";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(904, 422);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(75, 23);
            btnSacuvaj.TabIndex = 21;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            // 
            // cbNacinPlacanja
            // 
            cbNacinPlacanja.FormattingEnabled = true;
            cbNacinPlacanja.Items.AddRange(new object[] { "Gotovina", "Kartica" });
            cbNacinPlacanja.Location = new Point(169, 104);
            cbNacinPlacanja.Name = "cbNacinPlacanja";
            cbNacinPlacanja.Size = new Size(200, 23);
            cbNacinPlacanja.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(46, 104);
            label8.Name = "label8";
            label8.Size = new Size(85, 15);
            label8.TabIndex = 23;
            label8.Text = "Nacin placanja";
            // 
            // lblCena
            // 
            lblCena.AutoSize = true;
            lblCena.Location = new Point(294, 290);
            lblCena.Name = "lblCena";
            lblCena.Size = new Size(52, 15);
            lblCena.TabIndex = 24;
            lblCena.Text = "0.00 RSD";
            // 
            // UCDodajRacun
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblCena);
            Controls.Add(label8);
            Controls.Add(cbNacinPlacanja);
            Controls.Add(btnSacuvaj);
            Controls.Add(btnObrisi);
            Controls.Add(dgvStavke);
            Controls.Add(btnDodaj);
            Controls.Add(lblUkupanIznos);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(numKolicina);
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
            Name = "UCDodajRacun";
            Size = new Size(1029, 485);
            ((System.ComponentModel.ISupportInitialize)numKolicina).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStavke).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label lbl;
        private Label label3;
        private Label Projekcija;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        public ComboBox cbKupac;
        public Button btnDodaj;
        public Button btnObrisi;
        public ComboBox cbProjekcija;
        public ComboBox cbProdavac;
        public NumericUpDown numKolicina;
        public DataGridView dgvStavke;
        public Label lblUkupanIznos;
        public DateTimePicker dtpDatumProdaje;
        public DateTimePicker dtpDatumCekiranja;
        public Button btnSacuvaj;
        private Label label8;
        public ComboBox cbNacinPlacanja;
        public Label lblCena;
    }
}
