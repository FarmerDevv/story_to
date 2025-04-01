namespace SeninBorcun
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer tarafından üretilen kod

        private void InitializeComponent()
        {
            this.scenePictureBox = new System.Windows.Forms.PictureBox();
            this.facePictureBox = new System.Windows.Forms.PictureBox();
            this.dialogPanel = new System.Windows.Forms.Panel();
            this.dialogLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scenePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facePictureBox)).BeginInit();
            this.dialogPanel.SuspendLayout();
            this.SuspendLayout();
            
            // 
            // scenePictureBox (Sinematik sahne)
            // 
            this.scenePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scenePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scenePictureBox.TabIndex = 0;
            this.scenePictureBox.TabStop = false;

            // 
            // facePictureBox (Konuşan kişinin yüzü)
            // 
            this.facePictureBox.Location = new System.Drawing.Point(10, 10);
            this.facePictureBox.Size = new System.Drawing.Size(100, 100);
            this.facePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.facePictureBox.TabIndex = 1;
            this.facePictureBox.TabStop = false;

            // 
            // dialogPanel (Şeffaf diyalog kutusu)
            // 
            this.dialogPanel.BackColor = System.Drawing.Color.FromArgb(150, 0, 0, 0); // %50 şeffaf siyah
            this.dialogPanel.Location = new System.Drawing.Point(120, 10);
            this.dialogPanel.Size = new System.Drawing.Size(650, 80);
            this.dialogPanel.TabIndex = 3;

            // 
            // dialogLabel (Diyalog metni)
            // 
            this.dialogLabel.ForeColor = System.Drawing.Color.White;
            this.dialogLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.dialogLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dialogLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dialogPanel.Controls.Add(this.dialogLabel);

            // 
            // Form1 (Ana form)
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dialogPanel);
            this.Controls.Add(this.facePictureBox);
            this.Controls.Add(this.scenePictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = new System.Drawing.Icon("data/app.ico");
            this.Name = "Form1";
            this.Text = "story_to";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.scenePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facePictureBox)).EndInit();
            this.dialogPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox scenePictureBox;
        private System.Windows.Forms.PictureBox facePictureBox;
        private System.Windows.Forms.Panel dialogPanel;
        private System.Windows.Forms.Label dialogLabel;
    }
}
