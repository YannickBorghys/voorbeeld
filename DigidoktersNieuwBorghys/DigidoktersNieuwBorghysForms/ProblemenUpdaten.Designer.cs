namespace DigidoktersNieuwBorghysForms
{
    partial class ProblemenUpdaten
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
            this.lblLeerlingAchternaamSelecteer = new System.Windows.Forms.Label();
            this.lblProbleemVoornaamSelecteer = new System.Windows.Forms.Label();
            this.lblProbleemSelecteer = new System.Windows.Forms.Label();
            this.txtProbleemProgressie = new System.Windows.Forms.TextBox();
            this.txtProbleemBeschrijving = new System.Windows.Forms.TextBox();
            this.cboUpdate = new System.Windows.Forms.ComboBox();
            this.btnLeerlingUpdateAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLeerlingAchternaamSelecteer
            // 
            this.lblLeerlingAchternaamSelecteer.AutoSize = true;
            this.lblLeerlingAchternaamSelecteer.Location = new System.Drawing.Point(55, 154);
            this.lblLeerlingAchternaamSelecteer.Name = "lblLeerlingAchternaamSelecteer";
            this.lblLeerlingAchternaamSelecteer.Size = new System.Drawing.Size(59, 13);
            this.lblLeerlingAchternaamSelecteer.TabIndex = 26;
            this.lblLeerlingAchternaamSelecteer.Text = "Progressie:";
            // 
            // lblProbleemVoornaamSelecteer
            // 
            this.lblProbleemVoornaamSelecteer.AutoSize = true;
            this.lblProbleemVoornaamSelecteer.Location = new System.Drawing.Point(55, 92);
            this.lblProbleemVoornaamSelecteer.Name = "lblProbleemVoornaamSelecteer";
            this.lblProbleemVoornaamSelecteer.Size = new System.Drawing.Size(113, 13);
            this.lblProbleemVoornaamSelecteer.TabIndex = 25;
            this.lblProbleemVoornaamSelecteer.Text = "Probleem beschrijving:";
            // 
            // lblProbleemSelecteer
            // 
            this.lblProbleemSelecteer.AutoSize = true;
            this.lblProbleemSelecteer.Location = new System.Drawing.Point(55, 15);
            this.lblProbleemSelecteer.Name = "lblProbleemSelecteer";
            this.lblProbleemSelecteer.Size = new System.Drawing.Size(123, 13);
            this.lblProbleemSelecteer.TabIndex = 24;
            this.lblProbleemSelecteer.Text = "Selecteer een Probleem:";
            // 
            // txtProbleemProgressie
            // 
            this.txtProbleemProgressie.Location = new System.Drawing.Point(58, 169);
            this.txtProbleemProgressie.Name = "txtProbleemProgressie";
            this.txtProbleemProgressie.Size = new System.Drawing.Size(140, 20);
            this.txtProbleemProgressie.TabIndex = 23;
            // 
            // txtProbleemBeschrijving
            // 
            this.txtProbleemBeschrijving.Location = new System.Drawing.Point(58, 108);
            this.txtProbleemBeschrijving.Name = "txtProbleemBeschrijving";
            this.txtProbleemBeschrijving.Size = new System.Drawing.Size(140, 20);
            this.txtProbleemBeschrijving.TabIndex = 22;
            // 
            // cboUpdate
            // 
            this.cboUpdate.FormattingEnabled = true;
            this.cboUpdate.Location = new System.Drawing.Point(58, 31);
            this.cboUpdate.Name = "cboUpdate";
            this.cboUpdate.Size = new System.Drawing.Size(140, 21);
            this.cboUpdate.TabIndex = 21;
            // 
            // btnLeerlingUpdateAccept
            // 
            this.btnLeerlingUpdateAccept.Location = new System.Drawing.Point(58, 259);
            this.btnLeerlingUpdateAccept.Name = "btnLeerlingUpdateAccept";
            this.btnLeerlingUpdateAccept.Size = new System.Drawing.Size(140, 47);
            this.btnLeerlingUpdateAccept.TabIndex = 20;
            this.btnLeerlingUpdateAccept.Text = "Update";
            this.btnLeerlingUpdateAccept.UseVisualStyleBackColor = true;
            this.btnLeerlingUpdateAccept.Click += new System.EventHandler(this.btnLeerlingUpdateAccept_Click);
            // 
            // ProblemenUpdaten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 321);
            this.Controls.Add(this.lblLeerlingAchternaamSelecteer);
            this.Controls.Add(this.lblProbleemVoornaamSelecteer);
            this.Controls.Add(this.lblProbleemSelecteer);
            this.Controls.Add(this.txtProbleemProgressie);
            this.Controls.Add(this.txtProbleemBeschrijving);
            this.Controls.Add(this.cboUpdate);
            this.Controls.Add(this.btnLeerlingUpdateAccept);
            this.Name = "ProblemenUpdaten";
            this.Text = "ProblemenUpdaten";
            this.Load += new System.EventHandler(this.ProblemenUpdaten_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLeerlingAchternaamSelecteer;
        private System.Windows.Forms.Label lblProbleemVoornaamSelecteer;
        private System.Windows.Forms.Label lblProbleemSelecteer;
        private System.Windows.Forms.TextBox txtProbleemProgressie;
        private System.Windows.Forms.TextBox txtProbleemBeschrijving;
        private System.Windows.Forms.ComboBox cboUpdate;
        private System.Windows.Forms.Button btnLeerlingUpdateAccept;
    }
}