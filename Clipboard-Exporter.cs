using System.Windows.Forms;

namespace Clipboard_Exporter
{

    public partial class Clipboard_Exporter : Form
    {
        private string lastClipboardText = ""; // 上一次的剪贴板内容
        private int consecutiveCopies = 0; // 连续复制相同内容的次数
        private List<string> clipboardHistory = new List<string>();
        private bool isListening = false;
        private SaveFileDialog saveFileDialog;

        public Clipboard_Exporter()
        {
            InitializeComponent();
            ///this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None; // 设置DPI缩放适配
            ///this.AutoScroll = true; // 启用自动滚动以适应小屏幕
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files|*.txt|All Files|*.*";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        private void Clipboard_Exporter_Load(object sender, EventArgs e)
        {
            UpdateClipboardHistoryTextBox();
            ///EnableClipboardMonitoring(isListening); // 开始或停止剪贴板监听
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
            ///lastClipboardText = ""; // 重置上一次的剪贴板内容
            consecutiveCopies = 0; // 重置连续复制次数
        }

        private void saveToFileButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss-fff") + ".txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(saveFileDialog.FileName, clipboardHistory);
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
                clipboardHistory.Clear(); // 清空剪贴板历史记录
                UpdateClipboardHistoryTextBox();
                clipboardMonitorTimer.Start();
                startStopButton.Text = "停止监听";
            }
            else
            {
                clipboardMonitorTimer.Stop();
                startStopButton.Text = "开始监听";
            }
        }

        ///private string lastClipboardText = ""; // 上一次的剪贴板内容

        private void clipboardMonitorTimer_Tick(object sender, EventArgs e)
        {
            string clipboardText = Clipboard.GetText();

            if (!string.IsNullOrWhiteSpace(clipboardText))
            {
                if (lastClipboardText != clipboardText)
                {
                    clipboardHistory.Insert(0, clipboardText);
                    UpdateClipboardHistoryTextBox();
                }
                else
                {
                    // 多次复制相同内容，都记录下来
                    clipboardHistory.Insert(0, clipboardText);
                    UpdateClipboardHistoryTextBox();
                }

                lastClipboardText = clipboardText;
            }
        }
    }
}
