namespace DigidoktersNieuwBorghysForms
{
    partial class Klanten
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
            this.lstKlanten = new System.Windows.Forms.ListBox();
            this.btnKlantAdd = new System.Windows.Forms.Button();
            this.btnKlantUpdate = new System.Windows.Forms.Button();
            this.btnKlantDelete = new System.Windows.Forms.Button();
            this.grpButtons = new System.Windows.Forms.GroupBox();
            this.lblKlantVerwijderen = new System.Windows.Forms.Label();
            this.cboKlantVerwijderen = new System.Windows.Forms.ComboBox();
            this.btnTerug = new System.Windows.Forms.Button();
            this.grpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstKlanten
            // 
            this.lstKlanten.FormattingEnabled = true;
            this.lstKlanten.Location = new System.Drawing.Point(32, 27);
            this.lstKlanten.Name = "lstKlanten";
            this.lstKlanten.Size = new System.Drawing.Size(572, 381);
            this.lstKlanten.TabIndex = 0;
            this.lstKlanten.SelectedIndexChanged += new System.EventHandler(this.lstKlanten_SelectedIndexChanged);
            // 
            // btnKlantAdd
            // 
            this.btnKlantAdd.Location = new System.Drawing.Point(10, 15);
            this.btnKlantAdd.Name = "btnKlantAdd";
            this.btnKlantAdd.Size = new System.Drawing.Size(141, 40);
            this.btnKlantAdd.TabIndex = 1;
            this.btnKlantAdd.Text = "Add";
            this.btnKlantAdd.UseVisualStyleBackColor = true;
            this.btnKlantAdd.Click += new System.EventHandler(this.btnKlantAdd_Click);
            // 
            // btnKlantUpdate
            // 
            this.btnKlantUpdate.Location = new System.Drawing.Point(10, 105);
            this.btnKlantUpdate.Name = "btnKlantUpdate";
            this.btnKlantUpdate.Size = new System.Drawing.Size(141, 40);
            this.btnKlantUpdate.TabIndex = 2;
            this.btnKlantUpdate.Text = "Update";
            this.btnKlantUpdate.UseVisualStyleBackColor = true;
            this.btnKlantUpdate.Click += new System.EventHandler(this.btnKlantUpdate_Click);
            // 
            // btnKlantDelete
            // 
            this.btnKlantDelete.Location = new System.Drawing.Point(10, 235);
            this.btnKlantDelete.Name = "btnKlantDelete";
            this.btnKlantDelete.Size = new System.Drawing.Size(141, 40);
            this.btnKlantDelete.TabIndex = 3;
            this.btnKlantDelete.Text = "Delete";
            this.btnKlantDelete.UseVisualStyleBackColor = true;
            this.btnKlantDelete.Click += new System.EventHandler(this.btnKlantDelete_Click);
            // 
            // grpButtons
            // 
            this.grpButtons.Controls.Add(this.lblKlantVerwijderen);
            this.grpButtons.Controls.Add(this.cboKlantVerwijderen);
            this.grpButtons.Controls.Add(this.btnKlantDelete);
            this.grpButtons.Controls.Add(this.btnKlantUpdate);
            this.grpButtons.Controls.Add(this.btnKlantAdd);
            this.grpButtons.Location = new System.Drawing.Point(630, 22);
            this.grpButtons.Name = "grpButtons";
            this.grpButtons.Size = new System.Drawing.Size(163, 281);
            this.grpButtons.TabIndex = 4;
            this.grpButtons.TabStop = false;
            this.grpButtons.Text = "Acties";
            // 
            // lblKlantVerwijderen
            // 
            this.lblKlantVerwijderen.AutoSize = true;
            this.lblKlantVerwijderen.Location = new System.Drawing.Point(8, 192);
            this.lblKlantVerwijderen.Name = "lblKlantVerwijderen";
            this.lblKlantVerwijderen.Size = new System.Drawing.Size(102, 13);
            this.lblKlantVerwijderen.TabIndex = 5;
            this.lblKlantVerwijderen.Text = "Selecteer een klant:";
            this.lblKlantVerwijderen.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboKlantVerwijderen
            // 
            this.cboKlantVerwijderen.FormattingEnabled = true;
            this.cboKlantVerwijderen.Location = new System.Drawing.Point(11, 208);
            this.cboKlantVerwijderen.Name = "cboKlantVerwijderen";
            this.cboKlantVerwijderen.Size = new System.Drawing.Size(140, 21);
            this.cboKlantVerwijderen.TabIndex = 4;
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(12, 414);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(101, 24);
            this.btnTerug.TabIndex = 5;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // Klanten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.grpButtons);
            this.Controls.Add(this.lstKlanten);
            this.Name = "Klanten";
            this.Text = "Klanten";
            this.Load += new System.EventHandler(this.Klanten_Load);
            this.grpButtons.ResumeLayout(false);
            this.grpButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstKlanten;
        private System.Windows.Forms.Button btnKlantAdd;
        private System.Windows.Forms.Button btnKlantUpdate;
        private System.Windows.Forms.Button btnKlantDelete;
        private System.Windows.Forms.GroupBox grpButtons;
        private System.Windows.Forms.Label lblKlantVerwijderen;
        private System.Windows.Forms.ComboBox cboKlantVerwijderen;
        private System.Windows.Forms.Button btnTerug;
    }
}