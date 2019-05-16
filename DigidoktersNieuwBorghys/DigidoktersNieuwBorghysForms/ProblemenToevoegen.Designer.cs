namespace DigidoktersNieuwBorghysForms
{
    partial class ProblemenToevoegen
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
            this.lblProbleemProgressieToevoegen = new System.Windows.Forms.Label();
            this.txtProbleemProgressieToevoegen = new System.Windows.Forms.TextBox();
            this.lblProbleemBeschrijvingToevoegen = new System.Windows.Forms.Label();
            this.txtProbleemBeschrijvingToevoegen = new System.Windows.Forms.TextBox();
            this.btnProbleemToevoegenAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProbleemProgressieToevoegen
            // 
            this.lblProbleemProgressieToevoegen.AutoSize = true;
            this.lblProbleemProgressieToevoegen.Location = new System.Drawing.Point(9, 66);
            this.lblProbleemProgressieToevoegen.Name = "lblProbleemProgressieToevoegen";
            this.lblProbleemProgressieToevoegen.Size = new System.Drawing.Size(59, 13);
            this.lblProbleemProgressieToevoegen.TabIndex = 7;
            this.lblProbleemProgressieToevoegen.Text = "Progressie:";
            // 
            // txtProbleemProgressieToevoegen
            // 
            this.txtProbleemProgressieToevoegen.Location = new System.Drawing.Point(12, 82);
            this.txtProbleemProgressieToevoegen.Name = "txtProbleemProgressieToevoegen";
            this.txtProbleemProgressieToevoegen.Size = new System.Drawing.Size(242, 20);
            this.txtProbleemProgressieToevoegen.TabIndex = 6;
            // 
            // lblProbleemBeschrijvingToevoegen
            // 
            this.lblProbleemBeschrijvingToevoegen.AutoSize = true;
            this.lblProbleemBeschrijvingToevoegen.Location = new System.Drawing.Point(9, 9);
            this.lblProbleemBeschrijvingToevoegen.Name = "lblProbleemBeschrijvingToevoegen";
            this.lblProbleemBeschrijvingToevoegen.Size = new System.Drawing.Size(67, 13);
            this.lblProbleemBeschrijvingToevoegen.TabIndex = 5;
            this.lblProbleemBeschrijvingToevoegen.Text = "Beschrijving:";
            // 
            // txtProbleemBeschrijvingToevoegen
            // 
            this.txtProbleemBeschrijvingToevoegen.Location = new System.Drawing.Point(12, 25);
            this.txtProbleemBeschrijvingToevoegen.Name = "txtProbleemBeschrijvingToevoegen";
            this.txtProbleemBeschrijvingToevoegen.Size = new System.Drawing.Size(242, 20);
            this.txtProbleemBeschrijvingToevoegen.TabIndex = 4;
            // 
            // btnProbleemToevoegenAccept
            // 
            this.btnProbleemToevoegenAccept.Location = new System.Drawing.Point(54, 161);
            this.btnProbleemToevoegenAccept.Name = "btnProbleemToevoegenAccept";
            this.btnProbleemToevoegenAccept.Size = new System.Drawing.Size(151, 56);
            this.btnProbleemToevoegenAccept.TabIndex = 9;
            this.btnProbleemToevoegenAccept.Text = "Voeg probleem toe";
            this.btnProbleemToevoegenAccept.UseVisualStyleBackColor = true;
            this.btnProbleemToevoegenAccept.Click += new System.EventHandler(this.btnProbleemToevoegenAccept_Click);
            // 
            // ProblemenToevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 270);
            this.Controls.Add(this.btnProbleemToevoegenAccept);
            this.Controls.Add(this.lblProbleemProgressieToevoegen);
            this.Controls.Add(this.txtProbleemProgressieToevoegen);
            this.Controls.Add(this.lblProbleemBeschrijvingToevoegen);
            this.Controls.Add(this.txtProbleemBeschrijvingToevoegen);
            this.Name = "ProblemenToevoegen";
            this.Text = "ProblemenToevoegen";
            this.Load += new System.EventHandler(this.ProblemenToevoegen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProbleemProgressieToevoegen;
        private System.Windows.Forms.TextBox txtProbleemProgressieToevoegen;
        private System.Windows.Forms.Label lblProbleemBeschrijvingToevoegen;
        private System.Windows.Forms.TextBox txtProbleemBeschrijvingToevoegen;
        private System.Windows.Forms.Button btnProbleemToevoegenAccept;
    }
}