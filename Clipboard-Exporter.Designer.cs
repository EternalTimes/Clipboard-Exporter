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
            this.ClientSize = new Size(1020, 500);
            this.Size = new Size(1020, 500);
            this.Font = new System.Drawing.Font("霞鹜YO", 14, System.Drawing.FontStyle.Regular, ((byte)(0)));
            this.Icon = new Icon("favicon.ico");
            /// this.AutoScaleMode = AutoScaleMode.None;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clipboard_Exporter));
            clipboardHistoryTextBox = new TextBox();
            clearButton = new Button();
            copyButton = new Button();
            saveToFileButton = new Button();
            startStopButton = new Button();
            clipboardMonitorTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // clipboardHistoryTextBox
            // 
            resources.ApplyResources(clipboardHistoryTextBox, "clipboardHistoryTextBox");
            clipboardHistoryTextBox.Name = "clipboardHistoryTextBox";
            clipboardHistoryTextBox.ReadOnly = true;
            clipboardHistoryTextBox.Size = new System.Drawing.Size(860, 350);
            clipboardHistoryTextBox.Location = new System.Drawing.Point(0, 0);
            clipboardHistoryTextBox.Multiline = true;
            clipboardHistoryTextBox.ScrollBars = ScrollBars.Both;
            // 
            // clearButton
            // 
            resources.ApplyResources(clearButton, "clearButton");
            clearButton.Name = "clearButton";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            clearButton.Size = new System.Drawing.Size(140, 30);
            clearButton.Location = new System.Drawing.Point(50, 385);
            clearButton.Text = "清空";
            // 
            // copyButton
            // 
            resources.ApplyResources(copyButton, "copyButton");
            copyButton.Name = "copyButton";
            copyButton.UseVisualStyleBackColor = true;
            copyButton.Click += copyButton_Click;
            copyButton.Size = new System.Drawing.Size(140, 30);
            copyButton.Location = new System.Drawing.Point(240, 385);
            copyButton.Text = "复制";
            // 
            // saveToFileButton
            // 
            resources.ApplyResources(saveToFileButton, "saveToFileButton");
            saveToFileButton.Name = "saveToFileButton";
            saveToFileButton.UseVisualStyleBackColor = true;
            saveToFileButton.Click += saveToFileButton_Click;
            saveToFileButton.Size = new System.Drawing.Size(140, 30);
            saveToFileButton.Location = new System.Drawing.Point(430, 385);
            saveToFileButton.Text = "保存";
            // 
            // startStopButton
            // 
            resources.ApplyResources(startStopButton, "startStopButton");
            startStopButton.Name = "startStopButton";
            startStopButton.UseVisualStyleBackColor = true;
            startStopButton.Click += startStopButton_Click;
            startStopButton.Size = new System.Drawing.Size(140, 30);
            startStopButton.Location = new System.Drawing.Point(620, 385);
            startStopButton.Text = "开启监听";
            // 
            // clipboardMonitorTimer
            // 
            clipboardMonitorTimer.Interval = 1000;
            clipboardMonitorTimer.Tick += clipboardMonitorTimer_Tick;
            // 
            // Clipboard_Exporter
            // 
            resources.ApplyResources(this, "$this");
            ///AutoScaleMode = AutoScaleMode.None;
            Controls.Add(clipboardHistoryTextBox);
            Controls.Add(clearButton);
            Controls.Add(copyButton);
            Controls.Add(saveToFileButton);
            Controls.Add(startStopButton);
            Name = "Clipboard_Exporter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer clipboardMonitorTimer;
        private TextBox clipboardHistoryTextBox;
        public Button startStopButton;
        public Button copyButton;
        public Button saveToFileButton;
        public Button clearButton;
    }
}