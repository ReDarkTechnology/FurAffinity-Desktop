namespace FurAffinity
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.topPanel = new System.Windows.Forms.Panel();
            this.settingsButton = new System.Windows.Forms.Button();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.reloadButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.checkManualButton = new System.Windows.Forms.Button();
            this.checkBackgroundBox = new System.Windows.Forms.CheckBox();
            this.notifMessagesButton = new System.Windows.Forms.Button();
            this.notifSubsButton = new System.Windows.Forms.Button();
            this.notifCommentsButton = new System.Windows.Forms.Button();
            this.notifJournalsButton = new System.Windows.Forms.Button();
            this.notifWatchersButton = new System.Windows.Forms.Button();
            this.notifFavesButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.favoritePostsLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.favoritePostButton = new System.Windows.Forms.Button();
            this.notifIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.oPenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowser = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.topPanel.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.notifContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.settingsButton);
            this.topPanel.Controls.Add(this.urlBox);
            this.topPanel.Controls.Add(this.reloadButton);
            this.topPanel.Controls.Add(this.nextButton);
            this.topPanel.Controls.Add(this.backButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(800, 30);
            this.topPanel.TabIndex = 1;
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Location = new System.Drawing.Point(739, 4);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(58, 23);
            this.settingsButton.TabIndex = 4;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            this.settingsButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // urlBox
            // 
            this.urlBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.urlBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.urlBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.urlBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.urlBox.ForeColor = System.Drawing.Color.White;
            this.urlBox.Location = new System.Drawing.Point(81, 5);
            this.urlBox.Margin = new System.Windows.Forms.Padding(5);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(650, 20);
            this.urlBox.TabIndex = 3;
            this.urlBox.Text = "https://www.furaffinity.net/";
            this.urlBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.urlBox_KeyDown);
            // 
            // reloadButton
            // 
            this.reloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reloadButton.Location = new System.Drawing.Point(51, 3);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(24, 23);
            this.reloadButton.TabIndex = 2;
            this.reloadButton.Text = "@";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            this.reloadButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // nextButton
            // 
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Location = new System.Drawing.Point(27, 3);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(24, 23);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            this.nextButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // backButton
            // 
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(3, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(24, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "<";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            this.backButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // sidePanel
            // 
            this.sidePanel.Controls.Add(this.checkManualButton);
            this.sidePanel.Controls.Add(this.checkBackgroundBox);
            this.sidePanel.Controls.Add(this.notifMessagesButton);
            this.sidePanel.Controls.Add(this.notifSubsButton);
            this.sidePanel.Controls.Add(this.notifCommentsButton);
            this.sidePanel.Controls.Add(this.notifJournalsButton);
            this.sidePanel.Controls.Add(this.notifWatchersButton);
            this.sidePanel.Controls.Add(this.notifFavesButton);
            this.sidePanel.Controls.Add(this.label2);
            this.sidePanel.Controls.Add(this.favoritePostsLayout);
            this.sidePanel.Controls.Add(this.label1);
            this.sidePanel.Controls.Add(this.favoritePostButton);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 30);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(172, 532);
            this.sidePanel.TabIndex = 2;
            // 
            // checkManualButton
            // 
            this.checkManualButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkManualButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkManualButton.Location = new System.Drawing.Point(3, 312);
            this.checkManualButton.Name = "checkManualButton";
            this.checkManualButton.Size = new System.Drawing.Size(166, 23);
            this.checkManualButton.TabIndex = 11;
            this.checkManualButton.Text = "Check Manually";
            this.checkManualButton.UseVisualStyleBackColor = true;
            this.checkManualButton.Click += new System.EventHandler(this.checkManualButton_Click);
            this.checkManualButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // checkBackgroundBox
            // 
            this.checkBackgroundBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBackgroundBox.AutoSize = true;
            this.checkBackgroundBox.Location = new System.Drawing.Point(6, 342);
            this.checkBackgroundBox.Name = "checkBackgroundBox";
            this.checkBackgroundBox.Size = new System.Drawing.Size(129, 17);
            this.checkBackgroundBox.TabIndex = 10;
            this.checkBackgroundBox.Text = "Check in Background";
            this.checkBackgroundBox.UseVisualStyleBackColor = true;
            this.checkBackgroundBox.CheckedChanged += new System.EventHandler(this.cibBox_CheckedChanged);
            this.checkBackgroundBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // notifMessagesButton
            // 
            this.notifMessagesButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notifMessagesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notifMessagesButton.Location = new System.Drawing.Point(3, 506);
            this.notifMessagesButton.Name = "notifMessagesButton";
            this.notifMessagesButton.Size = new System.Drawing.Size(166, 23);
            this.notifMessagesButton.TabIndex = 9;
            this.notifMessagesButton.Text = "Messages: 0";
            this.notifMessagesButton.UseVisualStyleBackColor = true;
            this.notifMessagesButton.Click += new System.EventHandler(this.notifMessagesButton_Click);
            this.notifMessagesButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // notifSubsButton
            // 
            this.notifSubsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notifSubsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notifSubsButton.Location = new System.Drawing.Point(3, 380);
            this.notifSubsButton.Name = "notifSubsButton";
            this.notifSubsButton.Size = new System.Drawing.Size(166, 23);
            this.notifSubsButton.TabIndex = 8;
            this.notifSubsButton.Text = "Submissions: 0";
            this.notifSubsButton.UseVisualStyleBackColor = true;
            this.notifSubsButton.Click += new System.EventHandler(this.notifSubsButton_Click);
            this.notifSubsButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // notifCommentsButton
            // 
            this.notifCommentsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notifCommentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notifCommentsButton.Location = new System.Drawing.Point(3, 481);
            this.notifCommentsButton.Name = "notifCommentsButton";
            this.notifCommentsButton.Size = new System.Drawing.Size(166, 23);
            this.notifCommentsButton.TabIndex = 7;
            this.notifCommentsButton.Text = "Comments: 0";
            this.notifCommentsButton.UseVisualStyleBackColor = true;
            this.notifCommentsButton.Click += new System.EventHandler(this.notifCommentsButton_Click);
            this.notifCommentsButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // notifJournalsButton
            // 
            this.notifJournalsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notifJournalsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notifJournalsButton.Location = new System.Drawing.Point(3, 456);
            this.notifJournalsButton.Name = "notifJournalsButton";
            this.notifJournalsButton.Size = new System.Drawing.Size(166, 23);
            this.notifJournalsButton.TabIndex = 6;
            this.notifJournalsButton.Text = "Journals: 0";
            this.notifJournalsButton.UseVisualStyleBackColor = true;
            this.notifJournalsButton.Click += new System.EventHandler(this.notifJournalsButton_Click);
            this.notifJournalsButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // notifWatchersButton
            // 
            this.notifWatchersButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notifWatchersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notifWatchersButton.Location = new System.Drawing.Point(3, 431);
            this.notifWatchersButton.Name = "notifWatchersButton";
            this.notifWatchersButton.Size = new System.Drawing.Size(166, 23);
            this.notifWatchersButton.TabIndex = 5;
            this.notifWatchersButton.Text = "Watches: 0";
            this.notifWatchersButton.UseVisualStyleBackColor = true;
            this.notifWatchersButton.Click += new System.EventHandler(this.notifWatchersButton_Click);
            this.notifWatchersButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // notifFavesButton
            // 
            this.notifFavesButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notifFavesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notifFavesButton.Location = new System.Drawing.Point(3, 405);
            this.notifFavesButton.Name = "notifFavesButton";
            this.notifFavesButton.Size = new System.Drawing.Size(166, 23);
            this.notifFavesButton.TabIndex = 4;
            this.notifFavesButton.Text = "Faves: 0";
            this.notifFavesButton.UseVisualStyleBackColor = true;
            this.notifFavesButton.Click += new System.EventHandler(this.notifFavesButton_Click);
            this.notifFavesButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Notifications";
            // 
            // favoritePostsLayout
            // 
            this.favoritePostsLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.favoritePostsLayout.AutoScroll = true;
            this.favoritePostsLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.favoritePostsLayout.Location = new System.Drawing.Point(3, 52);
            this.favoritePostsLayout.Name = "favoritePostsLayout";
            this.favoritePostsLayout.Size = new System.Drawing.Size(166, 254);
            this.favoritePostsLayout.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Favorite";
            // 
            // favoritePostButton
            // 
            this.favoritePostButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.favoritePostButton.Enabled = false;
            this.favoritePostButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.favoritePostButton.Location = new System.Drawing.Point(3, 25);
            this.favoritePostButton.Name = "favoritePostButton";
            this.favoritePostButton.Size = new System.Drawing.Size(166, 23);
            this.favoritePostButton.TabIndex = 0;
            this.favoritePostButton.Text = "Local Favorite";
            this.favoritePostButton.UseVisualStyleBackColor = true;
            this.favoritePostButton.Click += new System.EventHandler(this.favoritePostButton_Click);
            this.favoritePostButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // notifIcon
            // 
            this.notifIcon.ContextMenuStrip = this.notifContextMenu;
            this.notifIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifIcon.Icon")));
            this.notifIcon.Text = "FurAffinity";
            this.notifIcon.Visible = true;
            this.notifIcon.BalloonTipClicked += new System.EventHandler(this.notifIcon_BalloonTipClicked);
            this.notifIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifIcon_MouseClick);
            // 
            // notifContextMenu
            // 
            this.notifContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPenToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.notifContextMenu.Name = "notifContextMenu";
            this.notifContextMenu.Size = new System.Drawing.Size(104, 48);
            // 
            // oPenToolStripMenuItem
            // 
            this.oPenToolStripMenuItem.Name = "oPenToolStripMenuItem";
            this.oPenToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.oPenToolStripMenuItem.Text = "Open";
            this.oPenToolStripMenuItem.Click += new System.EventHandler(this.oPenToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.AllowExternalDrop = true;
            this.webBrowser.CreationProperties = null;
            this.webBrowser.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(172, 30);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(628, 532);
            this.webBrowser.TabIndex = 3;
            this.webBrowser.ZoomFactor = 1D;
            this.webBrowser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.topPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FurAffinity";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            this.notifContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webBrowser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button favoritePostButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel favoritePostsLayout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button notifWatchersButton;
        private System.Windows.Forms.Button notifFavesButton;
        private System.Windows.Forms.Button notifJournalsButton;
        private System.Windows.Forms.Button notifSubsButton;
        private System.Windows.Forms.Button notifCommentsButton;
        private System.Windows.Forms.NotifyIcon notifIcon;
        private System.Windows.Forms.ContextMenuStrip notifContextMenu;
        private System.Windows.Forms.ToolStripMenuItem oPenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button notifMessagesButton;
        private System.Windows.Forms.Button settingsButton;
        private Microsoft.Web.WebView2.WinForms.WebView2 webBrowser;
        private System.Windows.Forms.CheckBox checkBackgroundBox;
        private System.Windows.Forms.Button checkManualButton;
    }
}

