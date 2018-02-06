namespace Team4Accounts
{
    partial class FormRevenueFinances
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
            this.btnBack = new System.Windows.Forms.Button();
            this.ptbGraph = new System.Windows.Forms.PictureBox();
            this.btnCollectData = new System.Windows.Forms.Button();
            this.btnDigitalDocs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 277);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 41);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back to Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ptbGraph
            // 
            this.ptbGraph.BackColor = System.Drawing.SystemColors.Control;
            this.ptbGraph.Location = new System.Drawing.Point(105, 12);
            this.ptbGraph.Name = "ptbGraph";
            this.ptbGraph.Size = new System.Drawing.Size(572, 306);
            this.ptbGraph.TabIndex = 4;
            this.ptbGraph.TabStop = false;
            // 
            // btnCollectData
            // 
            this.btnCollectData.Location = new System.Drawing.Point(12, 12);
            this.btnCollectData.Name = "btnCollectData";
            this.btnCollectData.Size = new System.Drawing.Size(87, 41);
            this.btnCollectData.TabIndex = 5;
            this.btnCollectData.Text = "Collect Data";
            this.btnCollectData.UseVisualStyleBackColor = true;
            // 
            // btnDigitalDocs
            // 
            this.btnDigitalDocs.Location = new System.Drawing.Point(12, 59);
            this.btnDigitalDocs.Name = "btnDigitalDocs";
            this.btnDigitalDocs.Size = new System.Drawing.Size(87, 41);
            this.btnDigitalDocs.TabIndex = 6;
            this.btnDigitalDocs.Text = "Output to Digital Docs.";
            this.btnDigitalDocs.UseVisualStyleBackColor = true;
            // 
            // FormRevenueFinances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(689, 448);
            this.Controls.Add(this.btnDigitalDocs);
            this.Controls.Add(this.btnCollectData);
            this.Controls.Add(this.ptbGraph);
            this.Controls.Add(this.btnBack);
            this.Name = "FormRevenueFinances";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ptbGraph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox ptbGraph;
        private System.Windows.Forms.Button btnCollectData;
        private System.Windows.Forms.Button btnDigitalDocs;
    }
}