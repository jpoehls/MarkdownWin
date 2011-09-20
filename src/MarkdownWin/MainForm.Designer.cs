using System;

namespace MarkdownWin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCopyHtml = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.stylesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFloatWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMarkdownGuide = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.browser = new System.Windows.Forms.WebBrowser();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.stylesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(465, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenFile,
            this.toolStripSeparator3,
            this.mnuCopyHtml,
            this.toolStripSeparator4,
            this.mnuPrint,
            this.mnuPrintPreview,
            this.toolStripSeparator1,
            this.mnuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // mnuOpenFile
            // 
            this.mnuOpenFile.Name = "mnuOpenFile";
            this.mnuOpenFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuOpenFile.Size = new System.Drawing.Size(180, 22);
            this.mnuOpenFile.Text = "&Open...";
            this.mnuOpenFile.Click += new System.EventHandler(this.mnuOpenFile_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuCopyHtml
            // 
            this.mnuCopyHtml.Name = "mnuCopyHtml";
            this.mnuCopyHtml.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnuCopyHtml.Size = new System.Drawing.Size(180, 22);
            this.mnuCopyHtml.Text = "&Copy HTML";
            this.mnuCopyHtml.Click += new System.EventHandler(this.mnuCopyHtml_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuPrint
            // 
            this.mnuPrint.Name = "mnuPrint";
            this.mnuPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.mnuPrint.Size = new System.Drawing.Size(180, 22);
            this.mnuPrint.Text = "&Print...";
            this.mnuPrint.Click += new System.EventHandler(this.mnuPrint_Click);
            // 
            // mnuPrintPreview
            // 
            this.mnuPrintPreview.Name = "mnuPrintPreview";
            this.mnuPrintPreview.Size = new System.Drawing.Size(180, 22);
            this.mnuPrintPreview.Text = "Print Pre&view...";
            this.mnuPrintPreview.Click += new System.EventHandler(this.mnuPrintPreview_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuExit.Size = new System.Drawing.Size(180, 22);
            this.mnuExit.Text = "E&xit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // stylesToolStripMenuItem
            // 
            this.stylesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFloatWindow});
            this.stylesToolStripMenuItem.Name = "stylesToolStripMenuItem";
            this.stylesToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.stylesToolStripMenuItem.Text = "&View";
            // 
            // mnuFloatWindow
            // 
            this.mnuFloatWindow.Name = "mnuFloatWindow";
            this.mnuFloatWindow.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mnuFloatWindow.Size = new System.Drawing.Size(187, 22);
            this.mnuFloatWindow.Text = "&Float Window";
            this.mnuFloatWindow.Click += new System.EventHandler(this.mnuFloatWindow_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMarkdownGuide,
            this.toolStripSeparator2,
            this.mnuAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // mnuMarkdownGuide
            // 
            this.mnuMarkdownGuide.Name = "mnuMarkdownGuide";
            this.mnuMarkdownGuide.Size = new System.Drawing.Size(188, 22);
            this.mnuMarkdownGuide.Text = "&Markdown Guide";
            this.mnuMarkdownGuide.Click += new System.EventHandler(this.mnuMarkdownGuide_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // browser
            // 
            this.browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browser.Location = new System.Drawing.Point(0, 24);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(465, 339);
            this.browser.TabIndex = 3;
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(188, 22);
            this.mnuAbout.Text = "&About MarkdownWin";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(185, 6);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 363);
            this.Controls.Add(this.browser);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "MarkdownWin";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Watcher_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Watcher_DragEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenFile;
        private System.Windows.Forms.ToolStripMenuItem mnuPrint;
        private System.Windows.Forms.ToolStripMenuItem stylesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFloatWindow;
        private System.Windows.Forms.ToolStripMenuItem mnuCopyHtml;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem mnuPrintPreview;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mnuMarkdownGuide;
        private System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
    }
}