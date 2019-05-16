namespace DigidoktersNieuwBorghysForms
{
    partial class SessiesUpdaten
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
            this.lblLeerlingVoornaamSelecteer = new System.Windows.Forms.Label();
            this.lblLeerlingSelecteer = new System.Windows.Forms.Label();
            this.txtLeerlingAchternaam = new System.Windows.Forms.TextBox();
            this.txtLeerlingVoornaam = new System.Windows.Forms.TextBox();
            this.cboUpdate = new System.Windows.Forms.ComboBox();
            this.btnLeerlingUpdateAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLeerlingAchternaamSelecteer
            // 
            this.lblLeerlingAchternaamSelecteer.AutoSize = true;
            this.lblLeerlingAchternaamSelecteer.Location = new System.Drawing.Point(46, 140);
            this.lblLeerlingAchternaamSelecteer.Name = "lblLeerlingAchternaamSelecteer";
            this.lblLeerlingAchternaamSelecteer.Size = new System.Drawing.Size(77, 13);
            this.lblLeerlingAchternaamSelecteer.TabIndex = 26;
            this.lblLeerlingAchternaamSelecteer.Text = "Tijdstip Sessie:";
            // 
            // lblLeerlingVoornaamSelecteer
            // 
            this.lblLeerlingVoornaamSelecteer.AutoSize = true;
            this.lblLeerlingVoornaamSelecteer.Location = new System.Drawing.Point(46, 78);
            this.lblLeerlingVoornaamSelecteer.Name = "lblLeerlingVoornaamSelecteer";
            this.lblLeerlingVoornaamSelecteer.Size = new System.Drawing.Size(75, 13);
            this.lblLeerlingVoornaamSelecteer.TabIndex = 25;
            this.lblLeerlingVoornaamSelecteer.Text = "Datum Sessie:";
            // 
            // lblLeerlingSelecteer
            // 
            this.lblLeerlingSelecteer.AutoSize = true;
            this.lblLeerlingSelecteer.Location = new System.Drawing.Point(46, 1);
            this.lblLeerlingSelecteer.Name = "lblLeerlingSelecteer";
            this.lblLeerlingSelecteer.Size = new System.Drawing.Size(110, 13);
            this.lblLeerlingSelecteer.TabIndex = 24;
            this.lblLeerlingSelecteer.Text = "Selecteer een Sessie:";
            // 
            // txtLeerlingAchternaam
            // 
            this.txtLeerlingAchternaam.Location = new System.Drawing.Point(49, 155);
            this.txtLeerlingAchternaam.Name = "txtLeerlingAchternaam";
            this.txtLeerlingAchternaam.Size = new System.Drawing.Size(140, 20);
            this.txtLeerlingAchternaam.TabIndex = 23;
            // 
            // txtLeerlingVoornaam
            // 
            this.txtLeerlingVoornaam.Location = new System.Drawing.Point(49, 94);
            this.txtLeerlingVoornaam.Name = "txtLeerlingVoornaam";
            this.txtLeerlingVoornaam.Size = new System.Drawing.Size(140, 20);
            this.txtLeerlingVoornaam.TabIndex = 22;
            // 
            // cboUpdate
            // 
            this.cboUpdate.FormattingEnabled = true;
            this.cboUpdate.Location = new System.Drawing.Point(49, 17);
            this.cboUpdate.Name = "cboUpdate";
            this.cboUpdate.Size = new System.Drawing.Size(140, 21);
            this.cboUpdate.TabIndex = 21;
            // 
            // btnLeerlingUpdateAccept
            // 
            this.btnLeerlingUpdateAccept.Location = new System.Drawing.Point(49, 245);
            this.btnLeerlingUpdateAccept.Name = "btnLeerlingUpdateAccept";
            this.btnLeerlingUpdateAccept.Size = new System.Drawing.Size(140, 47);
            this.btnLeerlingUpdateAccept.TabIndex = 20;
            this.btnLeerlingUpdateAccept.Text = "Update";
            this.btnLeerlingUpdateAccept.UseVisualStyleBackColor = true;
            this.btnLeerlingUpdateAccept.Click += new System.EventHandler(this.btnLeerlingUpdateAccept_Click);
            // 
            // SessiesUpdaten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 323);
            this.Controls.Add(this.lblLeerlingAchternaamSelecteer);
            this.Controls.Add(this.lblLeerlingVoornaamSelecteer);
            this.Controls.Add(this.lblLeerlingSelecteer);
            this.Controls.Add(this.txtLeerlingAchternaam);
            this.Controls.Add(this.txtLeerlingVoornaam);
            this.Controls.Add(this.cboUpdate);
            this.Controls.Add(this.btnLeerlingUpdateAccept);
            this.Name = "SessiesUpdaten";
            this.Text = "SessiesUpdaten";
            this.Load += new System.EventHandler(this.SessiesUpdaten_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLeerlingAchternaamSelecteer;
        private System.Windows.Forms.Label lblLeerlingVoornaamSelecteer;
        private System.Windows.Forms.Label lblLeerlingSelecteer;
        private System.Windows.Forms.TextBox txtLeerlingAchternaam;
        private System.Windows.Forms.TextBox txtLeerlingVoornaam;
        private System.Windows.Forms.ComboBox cboUpdate;
        private System.Windows.Forms.Button btnLeerlingUpdateAccept;
    }
}