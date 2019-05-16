namespace DigidoktersNieuwBorghysForms
{
    partial class Startpagina
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnKlantenStart = new System.Windows.Forms.Button();
            this.btnLeerlingenStart = new System.Windows.Forms.Button();
            this.btnSessiesStart = new System.Windows.Forms.Button();
            this.btnProblemenStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digidokters Applicatie";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnKlantenStart
            // 
            this.btnKlantenStart.Font = new System.Drawing.Font("Sitka Banner", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKlantenStart.Location = new System.Drawing.Point(103, 94);
            this.btnKlantenStart.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnKlantenStart.Name = "btnKlantenStart";
            this.btnKlantenStart.Size = new System.Drawing.Size(148, 85);
            this.btnKlantenStart.TabIndex = 1;
            this.btnKlantenStart.Text = "Klanten";
            this.btnKlantenStart.UseVisualStyleBackColor = true;
            this.btnKlantenStart.Click += new System.EventHandler(this.btnKlantenStart_Click);
            // 
            // btnLeerlingenStart
            // 
            this.btnLeerlingenStart.Font = new System.Drawing.Font("Sitka Banner", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeerlingenStart.Location = new System.Drawing.Point(103, 198);
            this.btnLeerlingenStart.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnLeerlingenStart.Name = "btnLeerlingenStart";
            this.btnLeerlingenStart.Size = new System.Drawing.Size(148, 85);
            this.btnLeerlingenStart.TabIndex = 2;
            this.btnLeerlingenStart.Text = "Leerlingen";
            this.btnLeerlingenStart.UseVisualStyleBackColor = true;
            this.btnLeerlingenStart.Click += new System.EventHandler(this.btnLeerlingenStart_Click);
            // 
            // btnSessiesStart
            // 
            this.btnSessiesStart.Font = new System.Drawing.Font("Sitka Banner", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSessiesStart.Location = new System.Drawing.Point(103, 304);
            this.btnSessiesStart.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnSessiesStart.Name = "btnSessiesStart";
            this.btnSessiesStart.Size = new System.Drawing.Size(148, 85);
            this.btnSessiesStart.TabIndex = 3;
            this.btnSessiesStart.Text = "Sessies";
            this.btnSessiesStart.UseVisualStyleBackColor = true;
            this.btnSessiesStart.Click += new System.EventHandler(this.btnSessiesStart_Click);
            // 
            // btnProblemenStart
            // 
            this.btnProblemenStart.Font = new System.Drawing.Font("Sitka Banner", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProblemenStart.Location = new System.Drawing.Point(103, 407);
            this.btnProblemenStart.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnProblemenStart.Name = "btnProblemenStart";
            this.btnProblemenStart.Size = new System.Drawing.Size(148, 85);
            this.btnProblemenStart.TabIndex = 4;
            this.btnProblemenStart.Text = "Problemen";
            this.btnProblemenStart.UseVisualStyleBackColor = true;
            this.btnProblemenStart.Click += new System.EventHandler(this.btnProblemenStart_Click);
            // 
            // Startpagina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(769, 514);
            this.Controls.Add(this.btnProblemenStart);
            this.Controls.Add(this.btnSessiesStart);
            this.Controls.Add(this.btnLeerlingenStart);
            this.Controls.Add(this.btnKlantenStart);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Sitka Banner", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Startpagina";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DigidoktersNieuw";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKlantenStart;
        private System.Windows.Forms.Button btnLeerlingenStart;
        private System.Windows.Forms.Button btnSessiesStart;
        private System.Windows.Forms.Button btnProblemenStart;
    }
}

