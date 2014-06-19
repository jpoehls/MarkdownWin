using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using MarkdownSharp;

namespace MarkdownWin
{
    public partial class MainForm : Form
    {
        private string _pendingPreviewHtml;
        private readonly Markdown _markdown;
        private readonly FileSystemWatcher _fileWatcher;

        public MainForm()
        {
            InitializeComponent();
            
            browser.DocumentCompleted += BrowserDocumentCompleted;
            browser.PreviewKeyDown += BrowserPreviewKeyDown;
            browser.AllowWebBrowserDrop = false;
            browser.IsWebBrowserContextMenuEnabled = false;
            browser.WebBrowserShortcutsEnabled = false;
            //browser.AllowNavigation = false;
            browser.ScriptErrorsSuppressed = true;

            _markdown = new Markdown();
            _fileWatcher = new FileSystemWatcher();
            _fileWatcher.NotifyFilter = NotifyFilters.LastWrite;
            _fileWatcher.Changed += new FileSystemEventHandler(OnWatchedFileChanged);

            this.Disposed += new EventHandler(Watcher_Disposed);
            browser.AllowWebBrowserDrop = false;
        }

        private void Watcher_Disposed(object sender, EventArgs e)
        {
            _fileWatcher.Dispose();
        }

        private void Watcher_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                e.Effect = DragDropEffects.Link;
            }
        }

        private void Watcher_DragDrop(object sender, DragEventArgs e)
        {
            var files = (string[])e.Data.GetData(DataFormats.FileDrop);
            WatchFile(files[0]);
        }

        private void OnWatchedFileChanged(object sender, FileSystemEventArgs e)
        {
            RefreshPreview(e.FullPath);
        }

        private void mnuOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.Filter = "All files (*.*)|*.*";
            openFileDialog1.FileName = string.Empty;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                WatchFile(openFileDialog1.FileName);
            }
        }

        private void RefreshPreview(string fileName)
        {
            browser.Stop();

            string text;
            using (var stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var reader = new StreamReader(stream))
            {
                text = reader.ReadToEnd();
            }

            _pendingPreviewHtml = _markdown.Transform(text);

            //browser.AllowNavigation = true;
            browser.Navigate("about:blank");
            //browser.AllowNavigation = false;
        }

        private void BrowserDocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (browser.Document != null)
            {
                browser.Document.Write(Stylizer.Run(_pendingPreviewHtml));
                Debug.WriteLine("Document Completed and written to.");
            }
        }

        private void BrowserPreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (mnuFloatWindow.ShortcutKeys == e.KeyData)
                mnuFloatWindow_Click(mnuFloatWindow, EventArgs.Empty);

            else if (mnuOpenFile.ShortcutKeys == e.KeyData)
                mnuOpenFile_Click(mnuOpenFile, EventArgs.Empty);

            else if (mnuCopyHtml.ShortcutKeys == e.KeyData)
                mnuCopyHtml_Click(mnuCopyHtml, EventArgs.Empty);

            else if (mnuPrint.ShortcutKeys == e.KeyData)
                mnuPrint_Click(mnuPrint, EventArgs.Empty);

            else if (mnuExit.ShortcutKeys == e.KeyData)
                mnuExit_Click(mnuExit, EventArgs.Empty);
        }

        private void WatchFile(string fileName)
        {
            RefreshPreview(fileName);

            _fileWatcher.Path = Path.GetDirectoryName(fileName);
            _fileWatcher.Filter = Path.GetFileName(fileName);
            _fileWatcher.EnableRaisingEvents = true;
        }

        private void mnuPrint_Click(object sender, EventArgs e)
        {
            browser.ShowPrintDialog();
        }

        private void mnuPrintPreview_Click(object sender, EventArgs e)
        {
            browser.ShowPrintPreviewDialog();
        }

        private void mnuCopyHtml_Click(object sender, EventArgs e)
        {
            if (_pendingPreviewHtml != null)
                Clipboard.SetText(_pendingPreviewHtml.Trim());
        }

        private void mnuFloatWindow_Click(object sender, EventArgs e)
        {
            mnuFloatWindow.Checked = !mnuFloatWindow.Checked;
            TopMost = mnuFloatWindow.Checked;
        }

        private void mnuMarkdownGuide_Click(object sender, EventArgs e)
        {
            Process.Start("http://daringfireball.net/projects/markdown/syntax");
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.github.com/jpoehls/MarkdownWin");
        }
    }
}
