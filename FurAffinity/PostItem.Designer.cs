namespace FurAffinity
{
    partial class PostItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.postName = new System.Windows.Forms.Label();
            this.itemContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hidePreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postImage = new System.Windows.Forms.PictureBox();
            this.imageProgressBar = new System.Windows.Forms.ProgressBar();
            this.itemContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postImage)).BeginInit();
            this.SuspendLayout();
            // 
            // postName
            // 
            this.postName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.postName.AutoEllipsis = true;
            this.postName.ContextMenuStrip = this.itemContextMenu;
            this.postName.Location = new System.Drawing.Point(2, 170);
            this.postName.Name = "postName";
            this.postName.Size = new System.Drawing.Size(151, 13);
            this.postName.TabIndex = 0;
            this.postName.Text = "Name";
            this.postName.Click += new System.EventHandler(this.PostItem_Click);
            // 
            // itemContextMenu
            // 
            this.itemContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLinkToolStripMenuItem,
            this.openImageToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.hidePreviewToolStripMenuItem});
            this.itemContextMenu.Name = "contextMenuStrip1";
            this.itemContextMenu.Size = new System.Drawing.Size(144, 92);
            // 
            // showLinkToolStripMenuItem
            // 
            this.showLinkToolStripMenuItem.Name = "showLinkToolStripMenuItem";
            this.showLinkToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.showLinkToolStripMenuItem.Text = "Open Link";
            this.showLinkToolStripMenuItem.Click += new System.EventHandler(this.showLinkToolStripMenuItem_Click);
            // 
            // openImageToolStripMenuItem
            // 
            this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            this.openImageToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.openImageToolStripMenuItem.Text = "Open Image";
            this.openImageToolStripMenuItem.Click += new System.EventHandler(this.openImageToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // hidePreviewToolStripMenuItem
            // 
            this.hidePreviewToolStripMenuItem.Name = "hidePreviewToolStripMenuItem";
            this.hidePreviewToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.hidePreviewToolStripMenuItem.Text = "Hide Preview";
            this.hidePreviewToolStripMenuItem.Click += new System.EventHandler(this.hidePreviewToolStripMenuItem_Click);
            // 
            // postImage
            // 
            this.postImage.ContextMenuStrip = this.itemContextMenu;
            this.postImage.Location = new System.Drawing.Point(3, 3);
            this.postImage.Name = "postImage";
            this.postImage.Size = new System.Drawing.Size(149, 162);
            this.postImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.postImage.TabIndex = 1;
            this.postImage.TabStop = false;
            this.postImage.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.PostImage_LoadCompleted);
            this.postImage.LoadProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.PostImage_LoadProgressChanged);
            this.postImage.Click += new System.EventHandler(this.PostItem_Click);
            // 
            // imageProgressBar
            // 
            this.imageProgressBar.Location = new System.Drawing.Point(27, 71);
            this.imageProgressBar.Name = "imageProgressBar";
            this.imageProgressBar.Size = new System.Drawing.Size(100, 23);
            this.imageProgressBar.TabIndex = 2;
            // 
            // PostItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ContextMenuStrip = this.itemContextMenu;
            this.Controls.Add(this.imageProgressBar);
            this.Controls.Add(this.postImage);
            this.Controls.Add(this.postName);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "PostItem";
            this.Size = new System.Drawing.Size(152, 187);
            this.Click += new System.EventHandler(this.PostItem_Click);
            this.itemContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.postImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label postName;
        private System.Windows.Forms.PictureBox postImage;
        private System.Windows.Forms.ProgressBar imageProgressBar;
        private System.Windows.Forms.ContextMenuStrip itemContextMenu;
        private System.Windows.Forms.ToolStripMenuItem showLinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hidePreviewToolStripMenuItem;
    }
}
