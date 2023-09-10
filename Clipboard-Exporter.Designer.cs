namespace Clipboard_Exporter
{
    partial class Clipboard_Exporter
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
            components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Text = "Clipboard Exporter";

            this.clipboardHistoryTextBox = new System.Windows.Forms.TextBox();
            this.clipboardHistoryTextBox.Location = new System.Drawing.Point(12, 12);
            this.clipboardHistoryTextBox.Multiline = true;
            this.clipboardHistoryTextBox.ReadOnly = true;
            this.clipboardHistoryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.clipboardHistoryTextBox.Size = new System.Drawing.Size(450, 300);

            this.clearButton = new System.Windows.Forms.Button();
            this.clearButton.Location = new System.Drawing.Point(12, 330);
            this.clearButton.Size = new System.Drawing.Size(150, 30);
            this.clearButton.Text = "清空";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);

            this.copyButton = new System.Windows.Forms.Button();
            this.copyButton.Location = new System.Drawing.Point(175, 330);
            this.copyButton.Size = new System.Drawing.Size(150, 30);
            this.copyButton.Text = "复制";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);

            this.saveToFileButton = new System.Windows.Forms.Button();
            this.saveToFileButton.Location = new System.Drawing.Point(338, 330);
            this.saveToFileButton.Size = new System.Drawing.Size(150, 30);
            this.saveToFileButton.Text = "保存到文件";
            this.saveToFileButton.UseVisualStyleBackColor = true;
            this.saveToFileButton.Click += new System.EventHandler(this.saveToFileButton_Click);

            this.startStopButton = new System.Windows.Forms.Button();
            this.startStopButton.Location = new System.Drawing.Point(501, 330);
            this.startStopButton.Size = new System.Drawing.Size(90, 30);
            this.startStopButton.Text = "开始监听";
            this.startStopButton.UseVisualStyleBackColor = true;
            this.startStopButton.Click += new System.EventHandler(this.startStopButton_Click);

            this.clipboardMonitorTimer = new System.Windows.Forms.Timer(this.components);
            this.clipboardMonitorTimer.Interval = 1000; // 设置定时器间隔为1秒
            this.clipboardMonitorTimer.Tick += new System.EventHandler(this.clipboardMonitorTimer_Tick);

            this.Controls.Add(this.clipboardHistoryTextBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.saveToFileButton);
            this.Controls.Add(this.startStopButton);
        }

        #endregion

        private System.Windows.Forms.Timer clipboardMonitorTimer;
        private Button copyButton;
        private Button clearButton;
        private Button saveToFileButton;
        private Button startStopButton;
        private TextBox clipboardHistoryTextBox;
    }
}