namespace DigidoktersNieuwBorghysForms
{
    partial class SessiesToevoegen
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
            this.lblSessie2Toevoegen = new System.Windows.Forms.Label();
            this.txtSessie2Toevoegen = new System.Windows.Forms.TextBox();
            this.lblSessieToevoegen = new System.Windows.Forms.Label();
            this.txtSessieToevoegen = new System.Windows.Forms.TextBox();
            this.btnSessieToevoegenAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSessie2Toevoegen
            // 
            this.lblSessie2Toevoegen.AutoSize = true;
            this.lblSessie2Toevoegen.Location = new System.Drawing.Point(9, 70);
            this.lblSessie2Toevoegen.Name = "lblSessie2Toevoegen";
            this.lblSessie2Toevoegen.Size = new System.Drawing.Size(111, 13);
            this.lblSessie2Toevoegen.TabIndex = 7;
            this.lblSessie2Toevoegen.Text = "Tijdstip van de sessie:";
            // 
            // txtSessie2Toevoegen
            // 
            this.txtSessie2Toevoegen.Location = new System.Drawing.Point(12, 86);
            this.txtSessie2Toevoegen.Name = "txtSessie2Toevoegen";
            this.txtSessie2Toevoegen.Size = new System.Drawing.Size(242, 20);
            this.txtSessie2Toevoegen.TabIndex = 6;
            // 
            // lblSessieToevoegen
            // 
            this.lblSessieToevoegen.AutoSize = true;
            this.lblSessieToevoegen.Location = new System.Drawing.Point(9, 13);
            this.lblSessieToevoegen.Name = "lblSessieToevoegen";
            this.lblSessieToevoegen.Size = new System.Drawing.Size(109, 13);
            this.lblSessieToevoegen.TabIndex = 5;
            this.lblSessieToevoegen.Text = "Datum van de sessie:";
            // 
            // txtSessieToevoegen
            // 
            this.txtSessieToevoegen.Location = new System.Drawing.Point(12, 29);
            this.txtSessieToevoegen.Name = "txtSessieToevoegen";
            this.txtSessieToevoegen.Size = new System.Drawing.Size(242, 20);
            this.txtSessieToevoegen.TabIndex = 4;
            // 
            // btnSessieToevoegenAccept
            // 
            this.btnSessieToevoegenAccept.Location = new System.Drawing.Point(56, 170);
            this.btnSessieToevoegenAccept.Name = "btnSessieToevoegenAccept";
            this.btnSessieToevoegenAccept.Size = new System.Drawing.Size(151, 56);
            this.btnSessieToevoegenAccept.TabIndex = 9;
            this.btnSessieToevoegenAccept.Text = "Voeg sessie toe";
            this.btnSessieToevoegenAccept.UseVisualStyleBackColor = true;
            this.btnSessieToevoegenAccept.Click += new System.EventHandler(this.btnSessieToevoegenAccept_Click);
            // 
            // SessiesToevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 276);
            this.Controls.Add(this.btnSessieToevoegenAccept);
            this.Controls.Add(this.lblSessie2Toevoegen);
            this.Controls.Add(this.txtSessie2Toevoegen);
            this.Controls.Add(this.lblSessieToevoegen);
            this.Controls.Add(this.txtSessieToevoegen);
            this.Name = "SessiesToevoegen";
            this.Text = "SessiesToevoegen";
            this.Load += new System.EventHandler(this.SessiesToevoegen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSessie2Toevoegen;
        private System.Windows.Forms.TextBox txtSessie2Toevoegen;
        private System.Windows.Forms.Label lblSessieToevoegen;
        private System.Windows.Forms.TextBox txtSessieToevoegen;
        private System.Windows.Forms.Button btnSessieToevoegenAccept;
    }
}