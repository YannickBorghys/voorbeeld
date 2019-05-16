namespace DigidoktersNieuwBorghysForms
{
    partial class Problemen
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
            this.lstProblemen = new System.Windows.Forms.ListBox();
            this.btnKlantAdd = new System.Windows.Forms.Button();
            this.lblProbleemVerwijderen = new System.Windows.Forms.Label();
            this.cboProbleemVerwijderen = new System.Windows.Forms.ComboBox();
            this.btnProbleemDelete = new System.Windows.Forms.Button();
            this.btnProbleemUpdate = new System.Windows.Forms.Button();
            this.btnTerug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstProblemen
            // 
            this.lstProblemen.FormattingEnabled = true;
            this.lstProblemen.Location = new System.Drawing.Point(41, 26);
            this.lstProblemen.Name = "lstProblemen";
            this.lstProblemen.Size = new System.Drawing.Size(557, 381);
            this.lstProblemen.TabIndex = 0;
            // 
            // btnKlantAdd
            // 
            this.btnKlantAdd.Location = new System.Drawing.Point(626, 38);
            this.btnKlantAdd.Name = "btnKlantAdd";
            this.btnKlantAdd.Size = new System.Drawing.Size(141, 40);
            this.btnKlantAdd.TabIndex = 3;
            this.btnKlantAdd.Text = "Add";
            this.btnKlantAdd.UseVisualStyleBackColor = true;
            this.btnKlantAdd.Click += new System.EventHandler(this.btnKlantAdd_Click);
            // 
            // lblProbleemVerwijderen
            // 
            this.lblProbleemVerwijderen.AutoSize = true;
            this.lblProbleemVerwijderen.Location = new System.Drawing.Point(624, 195);
            this.lblProbleemVerwijderen.Name = "lblProbleemVerwijderen";
            this.lblProbleemVerwijderen.Size = new System.Drawing.Size(122, 13);
            this.lblProbleemVerwijderen.TabIndex = 13;
            this.lblProbleemVerwijderen.Text = "Selecteer een probleem:";
            // 
            // cboProbleemVerwijderen
            // 
            this.cboProbleemVerwijderen.FormattingEnabled = true;
            this.cboProbleemVerwijderen.Location = new System.Drawing.Point(627, 211);
            this.cboProbleemVerwijderen.Name = "cboProbleemVerwijderen";
            this.cboProbleemVerwijderen.Size = new System.Drawing.Size(140, 21);
            this.cboProbleemVerwijderen.TabIndex = 12;
            // 
            // btnProbleemDelete
            // 
            this.btnProbleemDelete.Location = new System.Drawing.Point(626, 238);
            this.btnProbleemDelete.Name = "btnProbleemDelete";
            this.btnProbleemDelete.Size = new System.Drawing.Size(141, 40);
            this.btnProbleemDelete.TabIndex = 11;
            this.btnProbleemDelete.Text = "Delete";
            this.btnProbleemDelete.UseVisualStyleBackColor = true;
            this.btnProbleemDelete.Click += new System.EventHandler(this.btnProbleemDelete_Click);
            // 
            // btnProbleemUpdate
            // 
            this.btnProbleemUpdate.Location = new System.Drawing.Point(626, 108);
            this.btnProbleemUpdate.Name = "btnProbleemUpdate";
            this.btnProbleemUpdate.Size = new System.Drawing.Size(141, 40);
            this.btnProbleemUpdate.TabIndex = 10;
            this.btnProbleemUpdate.Text = "Update";
            this.btnProbleemUpdate.UseVisualStyleBackColor = true;
            this.btnProbleemUpdate.Click += new System.EventHandler(this.btnProbleemUpdate_Click);
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(12, 414);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(101, 24);
            this.btnTerug.TabIndex = 14;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // Problemen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.lblProbleemVerwijderen);
            this.Controls.Add(this.cboProbleemVerwijderen);
            this.Controls.Add(this.btnProbleemDelete);
            this.Controls.Add(this.btnProbleemUpdate);
            this.Controls.Add(this.btnKlantAdd);
            this.Controls.Add(this.lstProblemen);
            this.Name = "Problemen";
            this.Text = "Problemen";
            this.Load += new System.EventHandler(this.Problemen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstProblemen;
        private System.Windows.Forms.Button btnKlantAdd;
        private System.Windows.Forms.Label lblProbleemVerwijderen;
        private System.Windows.Forms.ComboBox cboProbleemVerwijderen;
        private System.Windows.Forms.Button btnProbleemDelete;
        private System.Windows.Forms.Button btnProbleemUpdate;
        private System.Windows.Forms.Button btnTerug;
    }
}