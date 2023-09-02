using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ClipboardHistoryApp
{
    public partial class MainForm : Form
    {
        private List<string> clipboardHistory = new List<string>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateClipboardHistoryTextBox();
        }

        private void UpdateClipboardHistoryTextBox()
        {
            clipboardHistoryTextBox.Text = string.Join(Environment.NewLine, clipboardHistory);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clipboardHistory.Clear();
            UpdateClipboardHistoryTextBox();
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            if (clipboardHistory.Count > 0)
            {
                Clipboard.SetText(string.Join(Environment.NewLine, clipboardHistory));
            }
        }

        private void saveToFileButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files|*.txt|All Files|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllLines(saveFileDialog.FileName, clipboardHistory);
                }
            }
        }

        private void clipboardMonitorTimer_Tick(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                string clipboardText = Clipboard.GetText();
                if (!string.IsNullOrWhiteSpace(clipboardText) && !clipboardHistory.Contains(clipboardText))
                {
                    clipboardHistory.Insert(0, clipboardText);
                    UpdateClipboardHistoryTextBox();
                }
            }
        }
    }
}
