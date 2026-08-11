namespace Klijent.UserControlls
{
    partial class UCPretraziKupca
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
            txtPretrazi = new TextBox();
            dgvPretrazi = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPretrazi).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 45);
            label1.Name = "label1";
            label1.Size = new Size(181, 15);
            label1.TabIndex = 0;
            label1.Text = "Pretrazi kupca (po nazivu mesta) ";
            // 
            // txtPretrazi
            // 
            txtPretrazi.Location = new Point(276, 42);
            txtPretrazi.Name = "txtPretrazi";
            txtPretrazi.Size = new Size(402, 23);
            txtPretrazi.TabIndex = 1;
            // 
            // dgvPretrazi
            // 
            dgvPretrazi.AllowUserToAddRows = false;
            dgvPretrazi.AllowUserToDeleteRows = false;
            dgvPretrazi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPretrazi.Location = new Point(14, 103);
            dgvPretrazi.Name = "dgvPretrazi";
            dgvPretrazi.ReadOnly = true;
            dgvPretrazi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPretrazi.Size = new Size(747, 259);
            dgvPretrazi.TabIndex = 2;
            // 
            // UCPretraziKupca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvPretrazi);
            Controls.Add(txtPretrazi);
            Controls.Add(label1);
            Name = "UCPretraziKupca";
            Size = new Size(800, 426);
            ((System.ComponentModel.ISupportInitialize)dgvPretrazi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public TextBox txtPretrazi;
        public DataGridView dgvPretrazi;
    }
}
