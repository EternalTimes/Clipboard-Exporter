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
            // 
            // clearButton
            // 
            resources.ApplyResources(clearButton, "clearButton");
            clearButton.Name = "clearButton";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // copyButton
            // 
            resources.ApplyResources(copyButton, "copyButton");
            copyButton.Name = "copyButton";
            copyButton.UseVisualStyleBackColor = true;
            copyButton.Click += copyButton_Click;
            // 
            // saveToFileButton
            // 
            resources.ApplyResources(saveToFileButton, "saveToFileButton");
            saveToFileButton.Name = "saveToFileButton";
            saveToFileButton.UseVisualStyleBackColor = true;
            saveToFileButton.Click += saveToFileButton_Click;
            // 
            // startStopButton
            // 
            resources.ApplyResources(startStopButton, "startStopButton");
            startStopButton.Name = "startStopButton";
            startStopButton.UseVisualStyleBackColor = true;
            startStopButton.Click += startStopButton_Click;
            // 
            // clipboardMonitorTimer
            // 
            clipboardMonitorTimer.Interval = 1000;
            clipboardMonitorTimer.Tick += clipboardMonitorTimer_Tick;
            // 
            // Clipboard_Exporter
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Dpi;
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
        private Button copyButton;
        private Button clearButton;
        private Button saveToFileButton;
        private Button startStopButton;
        private TextBox clipboardHistoryTextBox;
    }
}