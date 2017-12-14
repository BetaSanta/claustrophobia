namespace claustrophobia
{
    partial class loadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loadForm));
            this.headLabel = new System.Windows.Forms.Label();
            this.SettingsLabel = new System.Windows.Forms.Label();
            this.referLabel = new System.Windows.Forms.Label();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.newGameLabel = new System.Windows.Forms.Label();
            this.switchImage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.doorImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.switchImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorImage)).BeginInit();
            this.SuspendLayout();
            // 
            // headLabel
            // 
            this.headLabel.AutoSize = true;
            this.headLabel.Font = new System.Drawing.Font("Lovelo Black", 80.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headLabel.ForeColor = System.Drawing.Color.White;
            this.headLabel.Location = new System.Drawing.Point(200, 9);
            this.headLabel.Name = "headLabel";
            this.headLabel.Size = new System.Drawing.Size(907, 137);
            this.headLabel.TabIndex = 0;
            this.headLabel.Text = "клаустрофобия";
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.Font = new System.Drawing.Font("London", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsLabel.ForeColor = System.Drawing.Color.White;
            this.SettingsLabel.Location = new System.Drawing.Point(650, 248);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(280, 60);
            this.SettingsLabel.TabIndex = 2;
            this.SettingsLabel.Text = "Настройки";
            this.SettingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SettingsLabel.Click += new System.EventHandler(this.SettingsLabel_Click);
            this.SettingsLabel.MouseEnter += new System.EventHandler(this.newGameLabel_MouseEnter);
            this.SettingsLabel.MouseLeave += new System.EventHandler(this.newGameLabel_MouseLeave);
            // 
            // referLabel
            // 
            this.referLabel.Font = new System.Drawing.Font("London", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.referLabel.ForeColor = System.Drawing.Color.White;
            this.referLabel.Location = new System.Drawing.Point(650, 311);
            this.referLabel.Name = "referLabel";
            this.referLabel.Size = new System.Drawing.Size(280, 60);
            this.referLabel.TabIndex = 3;
            this.referLabel.Text = "Справка";
            this.referLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.referLabel.Click += new System.EventHandler(this.referLabel_Click);
            this.referLabel.MouseEnter += new System.EventHandler(this.newGameLabel_MouseEnter);
            this.referLabel.MouseLeave += new System.EventHandler(this.newGameLabel_MouseLeave);
            // 
            // ExitLabel
            // 
            this.ExitLabel.Font = new System.Drawing.Font("London", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitLabel.ForeColor = System.Drawing.Color.White;
            this.ExitLabel.Location = new System.Drawing.Point(650, 374);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(280, 60);
            this.ExitLabel.TabIndex = 4;
            this.ExitLabel.Text = "Выход";
            this.ExitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            this.ExitLabel.MouseEnter += new System.EventHandler(this.newGameLabel_MouseEnter);
            this.ExitLabel.MouseLeave += new System.EventHandler(this.newGameLabel_MouseLeave);
            // 
            // newGameLabel
            // 
            this.newGameLabel.Font = new System.Drawing.Font("London", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newGameLabel.ForeColor = System.Drawing.Color.White;
            this.newGameLabel.Location = new System.Drawing.Point(644, 163);
            this.newGameLabel.Name = "newGameLabel";
            this.newGameLabel.Size = new System.Drawing.Size(280, 60);
            this.newGameLabel.TabIndex = 8;
            this.newGameLabel.Text = "Новая игра";
            this.newGameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.newGameLabel.Click += new System.EventHandler(this.newGameLabel_Click);
            this.newGameLabel.MouseEnter += new System.EventHandler(this.newGameLabel_MouseEnter);
            this.newGameLabel.MouseLeave += new System.EventHandler(this.newGameLabel_MouseLeave);
            // 
            // switchImage
            // 
            this.switchImage.Image = global::claustrophobia.Properties.Resources.button;
            this.switchImage.Location = new System.Drawing.Point(342, 298);
            this.switchImage.Name = "switchImage";
            this.switchImage.Size = new System.Drawing.Size(37, 31);
            this.switchImage.TabIndex = 6;
            this.switchImage.TabStop = false;
            this.switchImage.Click += new System.EventHandler(this.switchImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::claustrophobia.Properties.Resources.bottom;
            this.pictureBox1.Location = new System.Drawing.Point(500, 437);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(563, 80);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // doorImage
            // 
            this.doorImage.Image = global::claustrophobia.Properties.Resources.doors;
            this.doorImage.Location = new System.Drawing.Point(2, 169);
            this.doorImage.Name = "doorImage";
            this.doorImage.Size = new System.Drawing.Size(520, 370);
            this.doorImage.TabIndex = 5;
            this.doorImage.TabStop = false;
            // 
            // loadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1056, 536);
            this.Controls.Add(this.switchImage);
            this.Controls.Add(this.newGameLabel);
            this.Controls.Add(this.ExitLabel);
            this.Controls.Add(this.referLabel);
            this.Controls.Add(this.SettingsLabel);
            this.Controls.Add(this.headLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.doorImage);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "loadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Claustrophobia";
            this.Load += new System.EventHandler(this.loadForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.switchImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headLabel;
        private System.Windows.Forms.Label SettingsLabel;
        private System.Windows.Forms.Label referLabel;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.PictureBox doorImage;
        private System.Windows.Forms.PictureBox switchImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label newGameLabel;
    }
}

