﻿namespace ME3Explorer
{
    partial class AssetExplorer
    {

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssetExplorer));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openExternalPccToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToOvervieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.StatusStrip();
            this.pb1 = new System.Windows.Forms.ToolStripProgressBar();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.TV1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelImage = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.rtb1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openInPackageEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soundsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(832, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openExternalPccToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // openExternalPccToolStripMenuItem
            // 
            this.openExternalPccToolStripMenuItem.Name = "openExternalPccToolStripMenuItem";
            this.openExternalPccToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.openExternalPccToolStripMenuItem.Text = "Open external pcc";
            this.openExternalPccToolStripMenuItem.Click += new System.EventHandler(this.openExternalPccToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToOvervieToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.fileToolStripMenuItem.Text = "View";
            // 
            // backToOvervieToolStripMenuItem
            // 
            this.backToOvervieToolStripMenuItem.Name = "backToOvervieToolStripMenuItem";
            this.backToOvervieToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.backToOvervieToolStripMenuItem.Text = "All PCCs";
            this.backToOvervieToolStripMenuItem.Click += new System.EventHandler(this.backToOvervieToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Visible = false;
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pb1,
            this.StatusLabel});
            this.status.Location = new System.Drawing.Point(0, 399);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(832, 22);
            this.status.TabIndex = 2;
            this.status.Text = "statusStrip1";
            // 
            // pb1
            // 
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(100, 16);
            // 
            // StatusLabel
            // 
            this.StatusLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rtb1);
            this.splitContainer1.Size = new System.Drawing.Size(832, 375);
            this.splitContainer1.SplitterDistance = 308;
            this.splitContainer1.TabIndex = 3;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.TV1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panelImage);
            this.splitContainer2.Panel2.Controls.Add(this.listView1);
            this.splitContainer2.Size = new System.Drawing.Size(832, 308);
            this.splitContainer2.SplitterDistance = 275;
            this.splitContainer2.TabIndex = 0;
            // 
            // TV1
            // 
            this.TV1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TV1.ImageIndex = 0;
            this.TV1.ImageList = this.imageList1;
            this.TV1.Location = new System.Drawing.Point(0, 0);
            this.TV1.Name = "TV1";
            this.TV1.SelectedImageIndex = 0;
            this.TV1.Size = new System.Drawing.Size(275, 308);
            this.TV1.TabIndex = 0;
            this.TV1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TV1_AfterSelect);
            this.TV1.DoubleClick += new System.EventHandler(this.TV1_DoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "select.ico");
            this.imageList1.Images.SetKeyName(1, "Folder.ico");
            // 
            // panelImage
            // 
            this.panelImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelImage.AutoScroll = true;
            this.panelImage.AutoScrollMinSize = new System.Drawing.Size(10, 10);
            this.panelImage.Controls.Add(this.pictureBox);
            this.panelImage.Location = new System.Drawing.Point(0, 0);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(553, 308);
            this.panelImage.TabIndex = 2;
            this.panelImage.Visible = false;
            this.panelImage.Click += new System.EventHandler(this.panelImage_Click);
            this.panelImage.Paint += new System.Windows.Forms.PaintEventHandler(this.panelImage_Paint);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(524, 289);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.GridLines = true;
            this.listView1.LargeImageList = this.imageList2;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(553, 308);
            this.listView1.TabIndex = 0;
            this.listView1.TileSize = new System.Drawing.Size(128, 196);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "page.png");
            this.imageList2.Images.SetKeyName(1, "photo.png");
            this.imageList2.Images.SetKeyName(2, "film.png");
            this.imageList2.Images.SetKeyName(3, "home.png");
            this.imageList2.Images.SetKeyName(4, "music_note.png");
            // 
            // rtb1
            // 
            this.rtb1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb1.Location = new System.Drawing.Point(0, 0);
            this.rtb1.Name = "rtb1";
            this.rtb1.Size = new System.Drawing.Size(832, 63);
            this.rtb1.TabIndex = 0;
            this.rtb1.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openInPackageEditorToolStripMenuItem,
            this.textureToolStripMenuItem,
            this.soundsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(198, 70);
            // 
            // openInPackageEditorToolStripMenuItem
            // 
            this.openInPackageEditorToolStripMenuItem.Name = "openInPackageEditorToolStripMenuItem";
            this.openInPackageEditorToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.openInPackageEditorToolStripMenuItem.Text = "Open in Package Editor";
            this.openInPackageEditorToolStripMenuItem.Click += new System.EventHandler(this.openInPackageEditorToolStripMenuItem_Click);
            // 
            // textureToolStripMenuItem
            // 
            this.textureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extractToolStripMenuItem,
            this.previewToolStripMenuItem});
            this.textureToolStripMenuItem.Name = "textureToolStripMenuItem";
            this.textureToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.textureToolStripMenuItem.Text = "Texture";
            this.textureToolStripMenuItem.Visible = false;
            // 
            // extractToolStripMenuItem
            // 
            this.extractToolStripMenuItem.Name = "extractToolStripMenuItem";
            this.extractToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.extractToolStripMenuItem.Text = "Extract";
            this.extractToolStripMenuItem.Click += new System.EventHandler(this.extractToolStripMenuItem_Click);
            // 
            // previewToolStripMenuItem
            // 
            this.previewToolStripMenuItem.Name = "previewToolStripMenuItem";
            this.previewToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.previewToolStripMenuItem.Text = "Preview";
            this.previewToolStripMenuItem.Click += new System.EventHandler(this.previewToolStripMenuItem_Click);
            // 
            // soundsToolStripMenuItem
            // 
            this.soundsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extractToolStripMenuItem1,
            this.playToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.soundsToolStripMenuItem.Name = "soundsToolStripMenuItem";
            this.soundsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.soundsToolStripMenuItem.Text = "Sounds";
            // 
            // extractToolStripMenuItem1
            // 
            this.extractToolStripMenuItem1.Name = "extractToolStripMenuItem1";
            this.extractToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
            this.extractToolStripMenuItem1.Text = "Extract";
            this.extractToolStripMenuItem1.Click += new System.EventHandler(this.extractToolStripMenuItem1_Click);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // AssetExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 421);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AssetExplorer";
            this.Text = "Asset Explorer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panelImage.ResumeLayout(false);
            this.panelImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.StatusStrip status;
        public System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.SplitContainer splitContainer2;
        public System.Windows.Forms.TreeView TV1;
        public System.Windows.Forms.RichTextBox rtb1;
        public System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.ToolStripProgressBar pb1;
        public System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.ImageList imageList2;
        public System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem backToOvervieToolStripMenuItem;
        public System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem textureToolStripMenuItem;
        public System.Windows.Forms.OpenFileDialog openFileDialog;
        public System.Windows.Forms.ToolStripMenuItem soundsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem extractToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem extractToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem openExternalPccToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem previewToolStripMenuItem;
        public System.Windows.Forms.Panel panelImage;
        public System.Windows.Forms.PictureBox pictureBox;
        public System.Windows.Forms.ToolStripMenuItem openInPackageEditorToolStripMenuItem;
        private System.ComponentModel.IContainer components;
    }
}