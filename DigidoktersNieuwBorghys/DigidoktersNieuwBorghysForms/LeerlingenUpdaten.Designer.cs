namespace DigidoktersNieuwBorghysForms
{
    partial class LeerlingenUpdaten
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
            this.lblLeerlingAchternaamSelecteer.Location = new System.Drawing.Point(67, 166);
            this.lblLeerlingAchternaamSelecteer.Name = "lblLeerlingAchternaamSelecteer";
            this.lblLeerlingAchternaamSelecteer.Size = new System.Drawing.Size(103, 13);
            this.lblLeerlingAchternaamSelecteer.TabIndex = 19;
            this.lblLeerlingAchternaamSelecteer.Text = "Achternaam leerling:";
            // 
            // lblLeerlingVoornaamSelecteer
            // 
            this.lblLeerlingVoornaamSelecteer.AutoSize = true;
            this.lblLeerlingVoornaamSelecteer.Location = new System.Drawing.Point(67, 104);
            this.lblLeerlingVoornaamSelecteer.Name = "lblLeerlingVoornaamSelecteer";
            this.lblLeerlingVoornaamSelecteer.Size = new System.Drawing.Size(94, 13);
            this.lblLeerlingVoornaamSelecteer.TabIndex = 18;
            this.lblLeerlingVoornaamSelecteer.Text = "Voornaam leerling:";
            // 
            // lblLeerlingSelecteer
            // 
            this.lblLeerlingSelecteer.AutoSize = true;
            this.lblLeerlingSelecteer.Location = new System.Drawing.Point(67, 27);
            this.lblLeerlingSelecteer.Name = "lblLeerlingSelecteer";
            this.lblLeerlingSelecteer.Size = new System.Drawing.Size(116, 13);
            this.lblLeerlingSelecteer.TabIndex = 17;
            this.lblLeerlingSelecteer.Text = "Selecteer een Leerling:";
            // 
            // txtLeerlingAchternaam
            // 
            this.txtLeerlingAchternaam.Location = new System.Drawing.Point(70, 181);
            this.txtLeerlingAchternaam.Name = "txtLeerlingAchternaam";
            this.txtLeerlingAchternaam.Size = new System.Drawing.Size(140, 20);
            this.txtLeerlingAchternaam.TabIndex = 14;
            // 
            // txtLeerlingVoornaam
            // 
            this.txtLeerlingVoornaam.Location = new System.Drawing.Point(70, 120);
            this.txtLeerlingVoornaam.Name = "txtLeerlingVoornaam";
            this.txtLeerlingVoornaam.Size = new System.Drawing.Size(140, 20);
            this.txtLeerlingVoornaam.TabIndex = 13;
            // 
            // cboUpdate
            // 
            this.cboUpdate.FormattingEnabled = true;
            this.cboUpdate.Location = new System.Drawing.Point(70, 43);
            this.cboUpdate.Name = "cboUpdate";
            this.cboUpdate.Size = new System.Drawing.Size(140, 21);
            this.cboUpdate.TabIndex = 12;
            this.cboUpdate.SelectedIndexChanged += new System.EventHandler(this.cboUpdate_SelectedIndexChanged);
            // 
            // btnLeerlingUpdateAccept
            // 
            this.btnLeerlingUpdateAccept.Location = new System.Drawing.Point(70, 271);
            this.btnLeerlingUpdateAccept.Name = "btnLeerlingUpdateAccept";
            this.btnLeerlingUpdateAccept.Size = new System.Drawing.Size(140, 47);
            this.btnLeerlingUpdateAccept.TabIndex = 11;
            this.btnLeerlingUpdateAccept.Text = "Update";
            this.btnLeerlingUpdateAccept.UseVisualStyleBackColor = true;
            this.btnLeerlingUpdateAccept.Click += new System.EventHandler(this.btnLeerlingUpdateAccept_Click);
            // 
            // LeerlingenUpdaten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 344);
            this.Controls.Add(this.lblLeerlingAchternaamSelecteer);
            this.Controls.Add(this.lblLeerlingVoornaamSelecteer);
            this.Controls.Add(this.lblLeerlingSelecteer);
            this.Controls.Add(this.txtLeerlingAchternaam);
            this.Controls.Add(this.txtLeerlingVoornaam);
            this.Controls.Add(this.cboUpdate);
            this.Controls.Add(this.btnLeerlingUpdateAccept);
            this.Name = "LeerlingenUpdaten";
            this.Text = "LeerlingenUpdaten";
            this.Load += new System.EventHandler(this.LeerlingenUpdaten_Load);
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