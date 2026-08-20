namespace Klijent.UserControlls
{
    partial class UCPretraziRacun
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
            lblPretrazi = new Label();
            txtPretrazi = new TextBox();
            dgvPretrazi = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPretrazi).BeginInit();
            SuspendLayout();
            // 
            // lblPretrazi
            // 
            lblPretrazi.AutoSize = true;
            lblPretrazi.Location = new Point(79, 49);
            lblPretrazi.Name = "lblPretrazi";
            lblPretrazi.Size = new Size(261, 15);
            lblPretrazi.TabIndex = 0;
            lblPretrazi.Text = "Pretrazi racun  (po imenu i prezimenu prodavca)";
            // 
            // txtPretrazi
            // 
            txtPretrazi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right; 
            txtPretrazi.Location = new Point(399, 46);
            txtPretrazi.Name = "txtPretrazi";
            txtPretrazi.Size = new Size(312, 23);
            txtPretrazi.TabIndex = 1;
            // 
            // dgvPretrazi
            // 
            dgvPretrazi.AllowUserToAddRows = false;
            dgvPretrazi.AllowUserToDeleteRows = false;
            dgvPretrazi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left |AnchorStyles.Right;
            dgvPretrazi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPretrazi.Location = new Point(32, 114);
            dgvPretrazi.Name = "dgvPretrazi";
            dgvPretrazi.ReadOnly = true;
            dgvPretrazi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPretrazi.Size = new Size(736, 285);
            dgvPretrazi.TabIndex = 2;
            // 
            // UCPretraziRacun
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvPretrazi);
            Controls.Add(txtPretrazi);
            Controls.Add(lblPretrazi);
            Name = "UCPretraziRacun";
            Size = new Size(800, 426);
            ((System.ComponentModel.ISupportInitialize)dgvPretrazi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPretrazi;
        public TextBox txtPretrazi;
        public DataGridView dgvPretrazi;
    }
}
