namespace Evidence
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboKamera = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            this.btnAufnahme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // cboKamera
            // 
            this.cboKamera.FormattingEnabled = true;
            this.cboKamera.Location = new System.Drawing.Point(71, 30);
            this.cboKamera.Name = "cboKamera";
            this.cboKamera.Size = new System.Drawing.Size(216, 21);
            this.cboKamera.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kamera:";
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(12, 116);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(587, 430);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            // 
            // btnAufnahme
            // 
            this.btnAufnahme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAufnahme.Location = new System.Drawing.Point(238, 72);
            this.btnAufnahme.Name = "btnAufnahme";
            this.btnAufnahme.Size = new System.Drawing.Size(145, 38);
            this.btnAufnahme.TabIndex = 3;
            this.btnAufnahme.Text = "&Aufnahme";
            this.btnAufnahme.UseVisualStyleBackColor = true;
            this.btnAufnahme.Click += new System.EventHandler(this.btnAufnahme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 574);
            this.Controls.Add(this.btnAufnahme);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboKamera);
            this.Name = "Form1";
            this.Text = "Evidence";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboKamera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btnAufnahme;
    }
}

