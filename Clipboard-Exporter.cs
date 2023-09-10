using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Clipboard_Exporter
{

    public partial class Clipboard_Exporter : Form
    {
        private List<string> clipboardHistory = new List<string>();

        private bool isListening = false;


        public Clipboard_Exporter()
        {
            InitializeComponent();
        }

        private void Clipboard_Exporter_Load(object sender, EventArgs e)
        {
            UpdateClipboardHistoryTextBox();
            EnableClipboardMonitoring(isListening); // 开始或停止剪贴板监听
        }

        private void UpdateClipboardHistoryTextBox()
        {
            clipboardHistoryTextBox.Text = string.Join(Environment.NewLine, clipboardHistory);
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            if (clipboardHistory.Count > 0)
            {
                Clipboard.SetText(string.Join(Environment.NewLine, clipboardHistory));
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clipboardHistory.Clear();
            UpdateClipboardHistoryTextBox();
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

        private void startStopButton_Click(object sender, EventArgs e)
        {
            isListening = !isListening; // 切换监听状态
            EnableClipboardMonitoring(isListening);
        }

        private void EnableClipboardMonitoring(bool enable)
        {
            if (enable)
            {
                clipboardMonitorTimer.Start();
                startStopButton.Text = "停止监听";
            }
            else
            {
                clipboardMonitorTimer.Stop();
                startStopButton.Text = "开始监听";
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
