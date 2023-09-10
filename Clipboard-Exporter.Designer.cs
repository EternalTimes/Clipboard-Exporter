﻿namespace Clipboard_Exporter
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
            clipboardMonitorTimer = new System.Windows.Forms.Timer(components);
            copyButton = new Button();
            clearButton = new Button();
            saveToFileButton = new Button();
            clipboardHistoryTextBox = new TextBox();
            SuspendLayout();
            // 
            // clipboardMonitorTimer
            // 
            clipboardMonitorTimer.Tick += clipboardMonitorTimer_Tick;
            // 
            // copyButton
            // 
            resources.ApplyResources(copyButton, "copyButton");
            copyButton.AccessibleRole = AccessibleRole.OutlineButton;
            copyButton.Name = "copyButton";
            copyButton.UseVisualStyleBackColor = true;
            copyButton.Click += copyButton_Click;
            // 
            // clearButton
            // 
            resources.ApplyResources(clearButton, "clearButton");
            clearButton.ForeColor = SystemColors.ControlText;
            clearButton.Name = "clearButton";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // saveToFileButton
            // 
            resources.ApplyResources(saveToFileButton, "saveToFileButton");
            saveToFileButton.Name = "saveToFileButton";
            saveToFileButton.UseVisualStyleBackColor = true;
            saveToFileButton.Click += saveToFileButton_Click;
            // 
            // clipboardHistoryTextBox
            // 
            resources.ApplyResources(clipboardHistoryTextBox, "clipboardHistoryTextBox");
            clipboardHistoryTextBox.Name = "clipboardHistoryTextBox";
            clipboardHistoryTextBox.ReadOnly = true;
            
            // 
            // Clipboard_Exporter
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(clipboardHistoryTextBox);
            Controls.Add(saveToFileButton);
            Controls.Add(clearButton);
            Controls.Add(copyButton);
            Name = "Clipboard_Exporter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer clipboardMonitorTimer;
        private Button copyButton;
        private Button clearButton;
        private Button saveToFileButton;
        private TextBox clipboardHistoryTextBox;
    }
}