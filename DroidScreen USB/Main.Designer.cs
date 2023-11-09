namespace DroidScreen_USB
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.tip = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ViewDevices = new System.Windows.Forms.ListView();
            this.LargImages = new System.Windows.Forms.ImageList(this.components);
            this.LearnLink = new System.Windows.Forms.Label();
            this.TelegramLink = new System.Windows.Forms.PictureBox();
            this.GitHub = new System.Windows.Forms.PictureBox();
            this.info = new System.Windows.Forms.PictureBox();
            this.CopyRight = new System.Windows.Forms.Label();
            this.MenuPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TelegramLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GitHub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.info)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.AutoSize = true;
            this.MenuPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MenuPanel.Controls.Add(this.CopyRight);
            this.MenuPanel.Controls.Add(this.TelegramLink);
            this.MenuPanel.Controls.Add(this.GitHub);
            this.MenuPanel.Controls.Add(this.LearnLink);
            this.MenuPanel.Controls.Add(this.info);
            this.MenuPanel.Controls.Add(this.tip);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MenuPanel.Location = new System.Drawing.Point(0, 484);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(1094, 45);
            this.MenuPanel.TabIndex = 0;
            // 
            // tip
            // 
            this.tip.AutoSize = true;
            this.tip.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tip.ForeColor = System.Drawing.SystemColors.Window;
            this.tip.Location = new System.Drawing.Point(45, 12);
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(349, 18);
            this.tip.TabIndex = 0;
            this.tip.Text = "You must activate \"Developer Options\" on your device,";
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.ViewDevices);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1094, 484);
            this.MainPanel.TabIndex = 1;
            // 
            // ViewDevices
            // 
            this.ViewDevices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ViewDevices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ViewDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewDevices.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewDevices.ForeColor = System.Drawing.SystemColors.Window;
            this.ViewDevices.HideSelection = false;
            this.ViewDevices.LargeImageList = this.LargImages;
            this.ViewDevices.Location = new System.Drawing.Point(0, 0);
            this.ViewDevices.MultiSelect = false;
            this.ViewDevices.Name = "ViewDevices";
            this.ViewDevices.Size = new System.Drawing.Size(1094, 484);
            this.ViewDevices.TabIndex = 0;
            this.ViewDevices.UseCompatibleStateImageBehavior = false;
            this.ViewDevices.DoubleClick += new System.EventHandler(this.ViewDevices_DoubleClick);
            // 
            // LargImages
            // 
            this.LargImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("LargImages.ImageStream")));
            this.LargImages.TransparentColor = System.Drawing.Color.Transparent;
            this.LargImages.Images.SetKeyName(0, "device.png");
            // 
            // LearnLink
            // 
            this.LearnLink.AutoSize = true;
            this.LearnLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LearnLink.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LearnLink.ForeColor = System.Drawing.SystemColors.Info;
            this.LearnLink.Location = new System.Drawing.Point(389, 12);
            this.LearnLink.Name = "LearnLink";
            this.LearnLink.Size = new System.Drawing.Size(156, 18);
            this.LearnLink.TabIndex = 2;
            this.LearnLink.Text = "Click here to learn more";
            this.LearnLink.Click += new System.EventHandler(this.LearnLink_Click);
            // 
            // TelegramLink
            // 
            this.TelegramLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TelegramLink.Image = global::DroidScreen_USB.Properties.Resources.pngwing_com;
            this.TelegramLink.Location = new System.Drawing.Point(1054, 3);
            this.TelegramLink.Name = "TelegramLink";
            this.TelegramLink.Size = new System.Drawing.Size(37, 39);
            this.TelegramLink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TelegramLink.TabIndex = 4;
            this.TelegramLink.TabStop = false;
            this.TelegramLink.Click += new System.EventHandler(this.TelegramLink_Click);
            // 
            // GitHub
            // 
            this.GitHub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GitHub.Image = global::DroidScreen_USB.Properties.Resources.pngegg;
            this.GitHub.Location = new System.Drawing.Point(1017, 5);
            this.GitHub.Name = "GitHub";
            this.GitHub.Size = new System.Drawing.Size(31, 33);
            this.GitHub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GitHub.TabIndex = 3;
            this.GitHub.TabStop = false;
            this.GitHub.Click += new System.EventHandler(this.GitHub_Click);
            // 
            // info
            // 
            this.info.Image = global::DroidScreen_USB.Properties.Resources.info;
            this.info.Location = new System.Drawing.Point(12, 8);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(31, 27);
            this.info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.info.TabIndex = 1;
            this.info.TabStop = false;
            // 
            // CopyRight
            // 
            this.CopyRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyRight.AutoSize = true;
            this.CopyRight.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyRight.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.CopyRight.Location = new System.Drawing.Point(958, 11);
            this.CopyRight.Name = "CopyRight";
            this.CopyRight.Size = new System.Drawing.Size(57, 23);
            this.CopyRight.TabIndex = 5;
            this.CopyRight.Text = "SU13R\r\n";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1094, 529);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.MenuPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DroidScreen USB - SU13R";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TelegramLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GitHub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.ListView ViewDevices;
        private System.Windows.Forms.ImageList LargImages;
        private System.Windows.Forms.PictureBox info;
        private System.Windows.Forms.Label tip;
        private System.Windows.Forms.Label LearnLink;
        private System.Windows.Forms.PictureBox GitHub;
        private System.Windows.Forms.PictureBox TelegramLink;
        private System.Windows.Forms.Label CopyRight;
    }
}

