namespace InstitutionskennzeichenBerechnung
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
            this.lblHeadline = new System.Windows.Forms.Label();
            this.txtBoxNumber = new System.Windows.Forms.TextBox();
            this.lblChecksumDesignation = new System.Windows.Forms.Label();
            this.lblChecksum = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCalculateChecksum = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblIKNumber = new System.Windows.Forms.Label();
            this.lblIKNumberComplete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeadline
            // 
            this.lblHeadline.AutoSize = true;
            this.lblHeadline.Location = new System.Drawing.Point(284, 30);
            this.lblHeadline.Name = "lblHeadline";
            this.lblHeadline.Size = new System.Drawing.Size(257, 20);
            this.lblHeadline.TabIndex = 0;
            this.lblHeadline.Text = "Institutionskennzeichen berechnen\r\n";
            // 
            // txtBoxNumber
            // 
            this.txtBoxNumber.Location = new System.Drawing.Point(314, 80);
            this.txtBoxNumber.Name = "txtBoxNumber";
            this.txtBoxNumber.Size = new System.Drawing.Size(100, 26);
            this.txtBoxNumber.TabIndex = 1;
            // 
            // lblChecksumDesignation
            // 
            this.lblChecksumDesignation.AutoSize = true;
            this.lblChecksumDesignation.Location = new System.Drawing.Point(168, 125);
            this.lblChecksumDesignation.Name = "lblChecksumDesignation";
            this.lblChecksumDesignation.Size = new System.Drawing.Size(94, 20);
            this.lblChecksumDesignation.TabIndex = 2;
            this.lblChecksumDesignation.Text = "Prüfsumme:";
            // 
            // lblChecksum
            // 
            this.lblChecksum.AutoSize = true;
            this.lblChecksum.Location = new System.Drawing.Point(310, 125);
            this.lblChecksum.Name = "lblChecksum";
            this.lblChecksum.Size = new System.Drawing.Size(90, 20);
            this.lblChecksum.TabIndex = 3;
            this.lblChecksum.Text = "Prüfsumme";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(676, 340);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(20, 20);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "A";
            // 
            // btnCalculateChecksum
            // 
            this.btnCalculateChecksum.Location = new System.Drawing.Point(429, 80);
            this.btnCalculateChecksum.Name = "btnCalculateChecksum";
            this.btnCalculateChecksum.Size = new System.Drawing.Size(98, 29);
            this.btnCalculateChecksum.TabIndex = 5;
            this.btnCalculateChecksum.Text = "Berechnen";
            this.btnCalculateChecksum.UseVisualStyleBackColor = true;
            this.btnCalculateChecksum.Click += new System.EventHandler(this.btnCalculateChecksum_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(549, 78);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 31);
            this.btnRestart.TabIndex = 6;
            this.btnRestart.Text = "Neu";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(695, 388);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 36);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Beenden";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblIKNumber
            // 
            this.lblIKNumber.AutoSize = true;
            this.lblIKNumber.Location = new System.Drawing.Point(85, 170);
            this.lblIKNumber.Name = "lblIKNumber";
            this.lblIKNumber.Size = new System.Drawing.Size(181, 20);
            this.lblIKNumber.TabIndex = 8;
            this.lblIKNumber.Text = "Institutionskennzeichen:";
            // 
            // lblIKNumberComplete
            // 
            this.lblIKNumberComplete.AutoSize = true;
            this.lblIKNumberComplete.Location = new System.Drawing.Point(310, 170);
            this.lblIKNumberComplete.Name = "lblIKNumberComplete";
            this.lblIKNumberComplete.Size = new System.Drawing.Size(177, 20);
            this.lblIKNumberComplete.TabIndex = 9;
            this.lblIKNumberComplete.Text = "Institutionskennzeichen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIKNumberComplete);
            this.Controls.Add(this.lblIKNumber);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnCalculateChecksum);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblChecksum);
            this.Controls.Add(this.lblChecksumDesignation);
            this.Controls.Add(this.txtBoxNumber);
            this.Controls.Add(this.lblHeadline);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeadline;
        private System.Windows.Forms.TextBox txtBoxNumber;
        private System.Windows.Forms.Label lblChecksumDesignation;
        private System.Windows.Forms.Label lblChecksum;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCalculateChecksum;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblIKNumber;
        private System.Windows.Forms.Label lblIKNumberComplete;
    }
}

