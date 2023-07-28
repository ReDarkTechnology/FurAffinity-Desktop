namespace FurAffinity
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.imagesHeader = new System.Windows.Forms.Label();
            this.downloadOnFaveBox = new System.Windows.Forms.CheckBox();
            this.imagesPathBox = new System.Windows.Forms.TextBox();
            this.imageLocationLabel = new System.Windows.Forms.Label();
            this.applicationHeader = new System.Windows.Forms.Label();
            this.profileDataLabel = new System.Windows.Forms.Label();
            this.profileDataBox = new System.Windows.Forms.TextBox();
            this.hideOnTrayBox = new System.Windows.Forms.CheckBox();
            this.notificationHeader = new System.Windows.Forms.Label();
            this.notifBackgroundBox = new System.Windows.Forms.CheckBox();
            this.notifDelayNumeric = new System.Windows.Forms.NumericUpDown();
            this.notifDelaySlider = new System.Windows.Forms.TrackBar();
            this.notifDelayLabel = new System.Windows.Forms.Label();
            this.notifDelayHint = new System.Windows.Forms.Label();
            this.profilesHeader = new System.Windows.Forms.Label();
            this.profilesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.profileAddButton = new System.Windows.Forms.Button();
            this.profileNameBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.notifDelayNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notifDelaySlider)).BeginInit();
            this.SuspendLayout();
            // 
            // imagesHeader
            // 
            this.imagesHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagesHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.imagesHeader.Location = new System.Drawing.Point(7, 10);
            this.imagesHeader.Margin = new System.Windows.Forms.Padding(9);
            this.imagesHeader.Name = "imagesHeader";
            this.imagesHeader.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.imagesHeader.Size = new System.Drawing.Size(377, 23);
            this.imagesHeader.TabIndex = 0;
            this.imagesHeader.Text = "Images";
            this.imagesHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // downloadOnFaveBox
            // 
            this.downloadOnFaveBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.downloadOnFaveBox.Checked = true;
            this.downloadOnFaveBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.downloadOnFaveBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.downloadOnFaveBox.Location = new System.Drawing.Point(11, 63);
            this.downloadOnFaveBox.Name = "downloadOnFaveBox";
            this.downloadOnFaveBox.Size = new System.Drawing.Size(140, 24);
            this.downloadOnFaveBox.TabIndex = 1;
            this.downloadOnFaveBox.Text = "Download on Favorite";
            this.downloadOnFaveBox.UseVisualStyleBackColor = true;
            this.downloadOnFaveBox.CheckedChanged += new System.EventHandler(this.downloadOnFaveBox_CheckedChanged);
            // 
            // imagesPathBox
            // 
            this.imagesPathBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagesPathBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.imagesPathBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagesPathBox.ForeColor = System.Drawing.Color.Magenta;
            this.imagesPathBox.Location = new System.Drawing.Point(138, 42);
            this.imagesPathBox.Name = "imagesPathBox";
            this.imagesPathBox.Size = new System.Drawing.Size(239, 20);
            this.imagesPathBox.TabIndex = 2;
            this.imagesPathBox.Text = "{ApplicationDir}/Images";
            this.imagesPathBox.TextChanged += new System.EventHandler(this.imagesPathBox_TextChanged);
            // 
            // imageLocationLabel
            // 
            this.imageLocationLabel.AutoSize = true;
            this.imageLocationLabel.Location = new System.Drawing.Point(12, 44);
            this.imageLocationLabel.Name = "imageLocationLabel";
            this.imageLocationLabel.Size = new System.Drawing.Size(108, 13);
            this.imageLocationLabel.TabIndex = 3;
            this.imageLocationLabel.Text = "Image Save Location";
            // 
            // applicationHeader
            // 
            this.applicationHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.applicationHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.applicationHeader.Location = new System.Drawing.Point(7, 93);
            this.applicationHeader.Margin = new System.Windows.Forms.Padding(9);
            this.applicationHeader.Name = "applicationHeader";
            this.applicationHeader.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.applicationHeader.Size = new System.Drawing.Size(377, 23);
            this.applicationHeader.TabIndex = 4;
            this.applicationHeader.Text = "Application";
            this.applicationHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // profileDataLabel
            // 
            this.profileDataLabel.AutoSize = true;
            this.profileDataLabel.Location = new System.Drawing.Point(12, 128);
            this.profileDataLabel.Name = "profileDataLabel";
            this.profileDataLabel.Size = new System.Drawing.Size(62, 13);
            this.profileDataLabel.TabIndex = 6;
            this.profileDataLabel.Text = "Profile Data";
            // 
            // profileDataBox
            // 
            this.profileDataBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profileDataBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.profileDataBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileDataBox.ForeColor = System.Drawing.Color.Magenta;
            this.profileDataBox.Location = new System.Drawing.Point(138, 125);
            this.profileDataBox.Name = "profileDataBox";
            this.profileDataBox.Size = new System.Drawing.Size(246, 20);
            this.profileDataBox.TabIndex = 5;
            this.profileDataBox.Text = "{ApplicationDir}/ProfileData";
            this.profileDataBox.TextChanged += new System.EventHandler(this.profileDataBox_TextChanged);
            // 
            // hideOnTrayBox
            // 
            this.hideOnTrayBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hideOnTrayBox.Checked = true;
            this.hideOnTrayBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hideOnTrayBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hideOnTrayBox.Location = new System.Drawing.Point(11, 147);
            this.hideOnTrayBox.Name = "hideOnTrayBox";
            this.hideOnTrayBox.Size = new System.Drawing.Size(140, 24);
            this.hideOnTrayBox.TabIndex = 7;
            this.hideOnTrayBox.Text = "Hide on Tray";
            this.hideOnTrayBox.UseVisualStyleBackColor = true;
            this.hideOnTrayBox.CheckedChanged += new System.EventHandler(this.hideOnTrayBox_CheckedChanged);
            // 
            // notificationHeader
            // 
            this.notificationHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notificationHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.notificationHeader.Location = new System.Drawing.Point(7, 180);
            this.notificationHeader.Margin = new System.Windows.Forms.Padding(9);
            this.notificationHeader.Name = "notificationHeader";
            this.notificationHeader.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.notificationHeader.Size = new System.Drawing.Size(377, 23);
            this.notificationHeader.TabIndex = 8;
            this.notificationHeader.Text = "Notification";
            this.notificationHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // notifBackgroundBox
            // 
            this.notifBackgroundBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.notifBackgroundBox.Checked = true;
            this.notifBackgroundBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.notifBackgroundBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.notifBackgroundBox.Location = new System.Drawing.Point(11, 207);
            this.notifBackgroundBox.Name = "notifBackgroundBox";
            this.notifBackgroundBox.Size = new System.Drawing.Size(140, 24);
            this.notifBackgroundBox.TabIndex = 9;
            this.notifBackgroundBox.Text = "Check in background";
            this.notifBackgroundBox.UseVisualStyleBackColor = true;
            this.notifBackgroundBox.CheckedChanged += new System.EventHandler(this.notifBackgroundBox_CheckedChanged);
            // 
            // notifDelayNumeric
            // 
            this.notifDelayNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.notifDelayNumeric.Location = new System.Drawing.Point(302, 233);
            this.notifDelayNumeric.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.notifDelayNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.notifDelayNumeric.Name = "notifDelayNumeric";
            this.notifDelayNumeric.Size = new System.Drawing.Size(37, 20);
            this.notifDelayNumeric.TabIndex = 10;
            this.notifDelayNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.notifDelayNumeric.ValueChanged += new System.EventHandler(this.notifDelayNumeric_ValueChanged);
            // 
            // notifDelaySlider
            // 
            this.notifDelaySlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notifDelaySlider.Location = new System.Drawing.Point(130, 233);
            this.notifDelaySlider.Maximum = 25;
            this.notifDelaySlider.Minimum = 1;
            this.notifDelaySlider.Name = "notifDelaySlider";
            this.notifDelaySlider.Size = new System.Drawing.Size(166, 45);
            this.notifDelaySlider.TabIndex = 11;
            this.notifDelaySlider.Value = 1;
            this.notifDelaySlider.Scroll += new System.EventHandler(this.notifDelaySlider_Scroll);
            // 
            // notifDelayLabel
            // 
            this.notifDelayLabel.AutoSize = true;
            this.notifDelayLabel.Location = new System.Drawing.Point(12, 235);
            this.notifDelayLabel.Name = "notifDelayLabel";
            this.notifDelayLabel.Size = new System.Drawing.Size(80, 13);
            this.notifDelayLabel.TabIndex = 12;
            this.notifDelayLabel.Text = "Checking delay";
            // 
            // notifDelayHint
            // 
            this.notifDelayHint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.notifDelayHint.AutoSize = true;
            this.notifDelayHint.Location = new System.Drawing.Point(341, 236);
            this.notifDelayHint.Name = "notifDelayHint";
            this.notifDelayHint.Size = new System.Drawing.Size(43, 13);
            this.notifDelayHint.TabIndex = 13;
            this.notifDelayHint.Text = "minutes";
            // 
            // profilesHeader
            // 
            this.profilesHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profilesHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.profilesHeader.Location = new System.Drawing.Point(7, 268);
            this.profilesHeader.Margin = new System.Windows.Forms.Padding(9);
            this.profilesHeader.Name = "profilesHeader";
            this.profilesHeader.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.profilesHeader.Size = new System.Drawing.Size(377, 23);
            this.profilesHeader.TabIndex = 14;
            this.profilesHeader.Text = "Other Profiles";
            this.profilesHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // profilesPanel
            // 
            this.profilesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profilesPanel.AutoScroll = true;
            this.profilesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profilesPanel.Location = new System.Drawing.Point(7, 297);
            this.profilesPanel.Name = "profilesPanel";
            this.profilesPanel.Size = new System.Drawing.Size(377, 84);
            this.profilesPanel.TabIndex = 15;
            // 
            // profileAddButton
            // 
            this.profileAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.profileAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileAddButton.Location = new System.Drawing.Point(344, 387);
            this.profileAddButton.Name = "profileAddButton";
            this.profileAddButton.Size = new System.Drawing.Size(40, 23);
            this.profileAddButton.TabIndex = 16;
            this.profileAddButton.Text = "Add";
            this.profileAddButton.UseVisualStyleBackColor = true;
            this.profileAddButton.Click += new System.EventHandler(this.profileAddButton_Click);
            // 
            // profileNameBox
            // 
            this.profileNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profileNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.profileNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileNameBox.ForeColor = System.Drawing.Color.Magenta;
            this.profileNameBox.Location = new System.Drawing.Point(7, 388);
            this.profileNameBox.Name = "profileNameBox";
            this.profileNameBox.Size = new System.Drawing.Size(332, 20);
            this.profileNameBox.TabIndex = 17;
            this.profileNameBox.Text = "OtherProfile";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(389, 418);
            this.Controls.Add(this.profileNameBox);
            this.Controls.Add(this.profileAddButton);
            this.Controls.Add(this.profilesPanel);
            this.Controls.Add(this.profilesHeader);
            this.Controls.Add(this.notifDelayHint);
            this.Controls.Add(this.notifDelayLabel);
            this.Controls.Add(this.notifDelaySlider);
            this.Controls.Add(this.notifDelayNumeric);
            this.Controls.Add(this.notifBackgroundBox);
            this.Controls.Add(this.notificationHeader);
            this.Controls.Add(this.hideOnTrayBox);
            this.Controls.Add(this.profileDataLabel);
            this.Controls.Add(this.profileDataBox);
            this.Controls.Add(this.applicationHeader);
            this.Controls.Add(this.imageLocationLabel);
            this.Controls.Add(this.imagesPathBox);
            this.Controls.Add(this.downloadOnFaveBox);
            this.Controls.Add(this.imagesHeader);
            this.ForeColor = System.Drawing.Color.Magenta;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.notifDelayNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notifDelaySlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label imagesHeader;
        private System.Windows.Forms.CheckBox downloadOnFaveBox;
        private System.Windows.Forms.TextBox imagesPathBox;
        private System.Windows.Forms.Label imageLocationLabel;
        private System.Windows.Forms.Label applicationHeader;
        private System.Windows.Forms.Label profileDataLabel;
        private System.Windows.Forms.TextBox profileDataBox;
        private System.Windows.Forms.CheckBox hideOnTrayBox;
        private System.Windows.Forms.Label notificationHeader;
        private System.Windows.Forms.CheckBox notifBackgroundBox;
        private System.Windows.Forms.NumericUpDown notifDelayNumeric;
        private System.Windows.Forms.TrackBar notifDelaySlider;
        private System.Windows.Forms.Label notifDelayLabel;
        private System.Windows.Forms.Label notifDelayHint;
        private System.Windows.Forms.Label profilesHeader;
        private System.Windows.Forms.FlowLayoutPanel profilesPanel;
        private System.Windows.Forms.Button profileAddButton;
        private System.Windows.Forms.TextBox profileNameBox;
    }
}