namespace DigidoktersNieuwBorghysForms
{
    partial class Leerlingen
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
            this.lstLeerlingen = new System.Windows.Forms.ListBox();
            this.btnKlantAdd = new System.Windows.Forms.Button();
            this.lblLeerlingVerwijderen = new System.Windows.Forms.Label();
            this.cboLeerlingVerwijderen = new System.Windows.Forms.ComboBox();
            this.btnLeerlingDelete = new System.Windows.Forms.Button();
            this.btnLeerlingUpdate = new System.Windows.Forms.Button();
            this.btnTerug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstLeerlingen
            // 
            this.lstLeerlingen.FormattingEnabled = true;
            this.lstLeerlingen.Location = new System.Drawing.Point(44, 27);
            this.lstLeerlingen.Name = "lstLeerlingen";
            this.lstLeerlingen.Size = new System.Drawing.Size(558, 381);
            this.lstLeerlingen.TabIndex = 0;
            // 
            // btnKlantAdd
            // 
            this.btnKlantAdd.Location = new System.Drawing.Point(635, 39);
            this.btnKlantAdd.Name = "btnKlantAdd";
            this.btnKlantAdd.Size = new System.Drawing.Size(141, 40);
            this.btnKlantAdd.TabIndex = 2;
            this.btnKlantAdd.Text = "Add";
            this.btnKlantAdd.UseVisualStyleBackColor = true;
            this.btnKlantAdd.Click += new System.EventHandler(this.btnKlantAdd_Click);
            // 
            // lblLeerlingVerwijderen
            // 
            this.lblLeerlingVerwijderen.AutoSize = true;
            this.lblLeerlingVerwijderen.Location = new System.Drawing.Point(633, 197);
            this.lblLeerlingVerwijderen.Name = "lblLeerlingVerwijderen";
            this.lblLeerlingVerwijderen.Size = new System.Drawing.Size(102, 13);
            this.lblLeerlingVerwijderen.TabIndex = 9;
            this.lblLeerlingVerwijderen.Text = "Selecteer een klant:";
            this.lblLeerlingVerwijderen.Click += new System.EventHandler(this.lblLeerlingVerwijderen_Click);
            // 
            // cboLeerlingVerwijderen
            // 
            this.cboLeerlingVerwijderen.FormattingEnabled = true;
            this.cboLeerlingVerwijderen.Location = new System.Drawing.Point(636, 213);
            this.cboLeerlingVerwijderen.Name = "cboLeerlingVerwijderen";
            this.cboLeerlingVerwijderen.Size = new System.Drawing.Size(140, 21);
            this.cboLeerlingVerwijderen.TabIndex = 8;
            this.cboLeerlingVerwijderen.SelectedIndexChanged += new System.EventHandler(this.cboLeerlingVerwijderen_SelectedIndexChanged);
            // 
            // btnLeerlingDelete
            // 
            this.btnLeerlingDelete.Location = new System.Drawing.Point(635, 240);
            this.btnLeerlingDelete.Name = "btnLeerlingDelete";
            this.btnLeerlingDelete.Size = new System.Drawing.Size(141, 40);
            this.btnLeerlingDelete.TabIndex = 7;
            this.btnLeerlingDelete.Text = "Delete";
            this.btnLeerlingDelete.UseVisualStyleBackColor = true;
            this.btnLeerlingDelete.Click += new System.EventHandler(this.btnLeerlingDelete_Click);
            // 
            // btnLeerlingUpdate
            // 
            this.btnLeerlingUpdate.Location = new System.Drawing.Point(635, 110);
            this.btnLeerlingUpdate.Name = "btnLeerlingUpdate";
            this.btnLeerlingUpdate.Size = new System.Drawing.Size(141, 40);
            this.btnLeerlingUpdate.TabIndex = 6;
            this.btnLeerlingUpdate.Text = "Update";
            this.btnLeerlingUpdate.UseVisualStyleBackColor = true;
            this.btnLeerlingUpdate.Click += new System.EventHandler(this.btnLeerlingUpdate_Click);
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(12, 414);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(101, 24);
            this.btnTerug.TabIndex = 10;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // Leerlingen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.lblLeerlingVerwijderen);
            this.Controls.Add(this.cboLeerlingVerwijderen);
            this.Controls.Add(this.btnLeerlingDelete);
            this.Controls.Add(this.btnLeerlingUpdate);
            this.Controls.Add(this.btnKlantAdd);
            this.Controls.Add(this.lstLeerlingen);
            this.Name = "Leerlingen";
            this.Text = "Leerlingen";
            this.Load += new System.EventHandler(this.Leerlingen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstLeerlingen;
        private System.Windows.Forms.Button btnKlantAdd;
        private System.Windows.Forms.Label lblLeerlingVerwijderen;
        private System.Windows.Forms.ComboBox cboLeerlingVerwijderen;
        private System.Windows.Forms.Button btnLeerlingDelete;
        private System.Windows.Forms.Button btnLeerlingUpdate;
        private System.Windows.Forms.Button btnTerug;
    }
}