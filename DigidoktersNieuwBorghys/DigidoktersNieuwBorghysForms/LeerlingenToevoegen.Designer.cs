namespace DigidoktersNieuwBorghysForms
{
    partial class LeerlingenToevoegen
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
            this.lblKlantAchternaamToevoegen = new System.Windows.Forms.Label();
            this.txtLeerlingAchternaamToevoegen = new System.Windows.Forms.TextBox();
            this.lblLeerlingVoornaamToevoegen = new System.Windows.Forms.Label();
            this.txtLeerlingVoornaamToevoegen = new System.Windows.Forms.TextBox();
            this.btnLeerlingToevoegenAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKlantAchternaamToevoegen
            // 
            this.lblKlantAchternaamToevoegen.AutoSize = true;
            this.lblKlantAchternaamToevoegen.Location = new System.Drawing.Point(2, 87);
            this.lblKlantAchternaamToevoegen.Name = "lblKlantAchternaamToevoegen";
            this.lblKlantAchternaamToevoegen.Size = new System.Drawing.Size(139, 13);
            this.lblKlantAchternaamToevoegen.TabIndex = 7;
            this.lblKlantAchternaamToevoegen.Text = "Achternaam van de leerling:";
            // 
            // txtLeerlingAchternaamToevoegen
            // 
            this.txtLeerlingAchternaamToevoegen.Location = new System.Drawing.Point(5, 103);
            this.txtLeerlingAchternaamToevoegen.Name = "txtLeerlingAchternaamToevoegen";
            this.txtLeerlingAchternaamToevoegen.Size = new System.Drawing.Size(242, 20);
            this.txtLeerlingAchternaamToevoegen.TabIndex = 6;
            // 
            // lblLeerlingVoornaamToevoegen
            // 
            this.lblLeerlingVoornaamToevoegen.AutoSize = true;
            this.lblLeerlingVoornaamToevoegen.Location = new System.Drawing.Point(2, 30);
            this.lblLeerlingVoornaamToevoegen.Name = "lblLeerlingVoornaamToevoegen";
            this.lblLeerlingVoornaamToevoegen.Size = new System.Drawing.Size(130, 13);
            this.lblLeerlingVoornaamToevoegen.TabIndex = 5;
            this.lblLeerlingVoornaamToevoegen.Text = "Voornaam van de leerling:";
            this.lblLeerlingVoornaamToevoegen.Click += new System.EventHandler(this.lblKlantVoornaamToevoegen_Click);
            // 
            // txtLeerlingVoornaamToevoegen
            // 
            this.txtLeerlingVoornaamToevoegen.Location = new System.Drawing.Point(5, 46);
            this.txtLeerlingVoornaamToevoegen.Name = "txtLeerlingVoornaamToevoegen";
            this.txtLeerlingVoornaamToevoegen.Size = new System.Drawing.Size(242, 20);
            this.txtLeerlingVoornaamToevoegen.TabIndex = 4;
            // 
            // btnLeerlingToevoegenAccept
            // 
            this.btnLeerlingToevoegenAccept.Location = new System.Drawing.Point(48, 170);
            this.btnLeerlingToevoegenAccept.Name = "btnLeerlingToevoegenAccept";
            this.btnLeerlingToevoegenAccept.Size = new System.Drawing.Size(151, 56);
            this.btnLeerlingToevoegenAccept.TabIndex = 9;
            this.btnLeerlingToevoegenAccept.Text = "Voeg leerling toe";
            this.btnLeerlingToevoegenAccept.UseVisualStyleBackColor = true;
            this.btnLeerlingToevoegenAccept.Click += new System.EventHandler(this.btnKlantToevoegenAccept_Click);
            // 
            // LeerlingenToevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 264);
            this.Controls.Add(this.btnLeerlingToevoegenAccept);
            this.Controls.Add(this.lblKlantAchternaamToevoegen);
            this.Controls.Add(this.txtLeerlingAchternaamToevoegen);
            this.Controls.Add(this.lblLeerlingVoornaamToevoegen);
            this.Controls.Add(this.txtLeerlingVoornaamToevoegen);
            this.Name = "LeerlingenToevoegen";
            this.Text = "LeerlingenToevoegen";
            this.Load += new System.EventHandler(this.LeerlingenToevoegen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKlantAchternaamToevoegen;
        private System.Windows.Forms.TextBox txtLeerlingAchternaamToevoegen;
        private System.Windows.Forms.Label lblLeerlingVoornaamToevoegen;
        private System.Windows.Forms.TextBox txtLeerlingVoornaamToevoegen;
        private System.Windows.Forms.Button btnLeerlingToevoegenAccept;
    }
}