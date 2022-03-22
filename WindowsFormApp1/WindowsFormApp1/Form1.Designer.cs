namespace WindowsFormApp1
{
    partial class ApplicationAryanOfficial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationAryanOfficial));
            this.Company_name = new System.Windows.Forms.Label();
            this.loading = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Company_name
            // 
            this.Company_name.BackColor = System.Drawing.Color.Transparent;
            this.Company_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Company_name.Font = new System.Drawing.Font("Microsoft Uighur", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Company_name.Location = new System.Drawing.Point(273, 77);
            this.Company_name.Name = "Company_name";
            this.Company_name.Size = new System.Drawing.Size(300, 167);
            this.Company_name.TabIndex = 1;
            this.Company_name.Text = "Application Aryan Official";
            // 
            // loading
            // 
            this.loading.AutoSize = true;
            this.loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loading.Location = new System.Drawing.Point(461, 298);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(98, 24);
            this.loading.TabIndex = 2;
            this.loading.Text = "Loading....";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 258);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ApplicationAryanOfficial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(571, 331);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.Company_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ApplicationAryanOfficial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application Aryan Official";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Company_name;
        private System.Windows.Forms.Label loading;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

