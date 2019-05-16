namespace DigidoktersNieuwBorghysForms
{
    partial class Sessies
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
            this.lstSessies = new System.Windows.Forms.ListBox();
            this.btnKlantAdd = new System.Windows.Forms.Button();
            this.lblSessieVerwijderen = new System.Windows.Forms.Label();
            this.cboSessieVerwijderen = new System.Windows.Forms.ComboBox();
            this.btnSessieDelete = new System.Windows.Forms.Button();
            this.btnSessiesUpdate = new System.Windows.Forms.Button();
            this.btnTerug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstSessies
            // 
            this.lstSessies.FormattingEnabled = true;
            this.lstSessies.Location = new System.Drawing.Point(24, 30);
            this.lstSessies.Name = "lstSessies";
            this.lstSessies.Size = new System.Drawing.Size(553, 381);
            this.lstSessies.TabIndex = 0;
            this.lstSessies.SelectedIndexChanged += new System.EventHandler(this.lstSessies_SelectedIndexChanged);
            // 
            // btnKlantAdd
            // 
            this.btnKlantAdd.Location = new System.Drawing.Point(619, 39);
            this.btnKlantAdd.Name = "btnKlantAdd";
            this.btnKlantAdd.Size = new System.Drawing.Size(141, 40);
            this.btnKlantAdd.TabIndex = 3;
            this.btnKlantAdd.Text = "Add";
            this.btnKlantAdd.UseVisualStyleBackColor = true;
            this.btnKlantAdd.Click += new System.EventHandler(this.btnKlantAdd_Click);
            // 
            // lblSessieVerwijderen
            // 
            this.lblSessieVerwijderen.AutoSize = true;
            this.lblSessieVerwijderen.Location = new System.Drawing.Point(617, 195);
            this.lblSessieVerwijderen.Name = "lblSessieVerwijderen";
            this.lblSessieVerwijderen.Size = new System.Drawing.Size(108, 13);
            this.lblSessieVerwijderen.TabIndex = 13;
            this.lblSessieVerwijderen.Text = "Selecteer een sessie:";
            // 
            // cboSessieVerwijderen
            // 
            this.cboSessieVerwijderen.FormattingEnabled = true;
            this.cboSessieVerwijderen.Location = new System.Drawing.Point(620, 211);
            this.cboSessieVerwijderen.Name = "cboSessieVerwijderen";
            this.cboSessieVerwijderen.Size = new System.Drawing.Size(140, 21);
            this.cboSessieVerwijderen.TabIndex = 12;
            // 
            // btnSessieDelete
            // 
            this.btnSessieDelete.Location = new System.Drawing.Point(619, 238);
            this.btnSessieDelete.Name = "btnSessieDelete";
            this.btnSessieDelete.Size = new System.Drawing.Size(141, 40);
            this.btnSessieDelete.TabIndex = 11;
            this.btnSessieDelete.Text = "Delete";
            this.btnSessieDelete.UseVisualStyleBackColor = true;
            this.btnSessieDelete.Click += new System.EventHandler(this.btnSessieDelete_Click);
            // 
            // btnSessiesUpdate
            // 
            this.btnSessiesUpdate.Location = new System.Drawing.Point(619, 108);
            this.btnSessiesUpdate.Name = "btnSessiesUpdate";
            this.btnSessiesUpdate.Size = new System.Drawing.Size(141, 40);
            this.btnSessiesUpdate.TabIndex = 10;
            this.btnSessiesUpdate.Text = "Update";
            this.btnSessiesUpdate.UseVisualStyleBackColor = true;
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(12, 417);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(101, 24);
            this.btnTerug.TabIndex = 14;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // Sessies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.lblSessieVerwijderen);
            this.Controls.Add(this.cboSessieVerwijderen);
            this.Controls.Add(this.btnSessieDelete);
            this.Controls.Add(this.btnSessiesUpdate);
            this.Controls.Add(this.btnKlantAdd);
            this.Controls.Add(this.lstSessies);
            this.Name = "Sessies";
            this.Text = "Sessies";
            this.Load += new System.EventHandler(this.Sessies_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSessies;
        private System.Windows.Forms.Button btnKlantAdd;
        private System.Windows.Forms.Label lblSessieVerwijderen;
        private System.Windows.Forms.ComboBox cboSessieVerwijderen;
        private System.Windows.Forms.Button btnSessieDelete;
        private System.Windows.Forms.Button btnSessiesUpdate;
        private System.Windows.Forms.Button btnTerug;
    }
}