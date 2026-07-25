namespace Server
{
    partial class FrmServer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnStart = new Button();
            btnStop = new Button();
            lblText = new Label();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(32, 90);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(123, 44);
            btnStart.TabIndex = 0;
            btnStart.Text = "Pokreni server";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click_1;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(250, 90);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(123, 44);
            btnStop.TabIndex = 1;
            btnStop.Text = "Zaustavi server";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click_1;
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Location = new Point(186, 167);
            lblText.Name = "lblText";
            lblText.Size = new Size(31, 15);
            lblText.TabIndex = 2;
            lblText.Text = "        ";
            // 
            // FrmServer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 262);
            Controls.Add(lblText);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Name = "FrmServer";
            Text = "Server ";
            FormClosed += FrmServer_FormClosed_1;
            Load += FrmServer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Button btnStop;
        private Label lblText;
    }
}