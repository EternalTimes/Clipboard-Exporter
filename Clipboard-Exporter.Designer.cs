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
            timer1 = new System.Windows.Forms.Timer(components);
            copyButton = new Button();
            clearButton = new Button();
            saveToFileButton = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // copyButton
            // 
            resources.ApplyResources(copyButton, "copyButton");
            copyButton.AccessibleRole = AccessibleRole.OutlineButton;
            copyButton.Name = "copyButton";
            copyButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            resources.ApplyResources(clearButton, "clearButton");
            clearButton.ForeColor = SystemColors.ControlText;
            clearButton.Name = "clearButton";
            clearButton.UseVisualStyleBackColor = true;
            // 
            // saveToFileButton
            // 
            resources.ApplyResources(saveToFileButton, "saveToFileButton");
            saveToFileButton.Name = "saveToFileButton";
            saveToFileButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            resources.ApplyResources(textBox1, "textBox1");
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Clipboard_Exporter
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox1);
            Controls.Add(saveToFileButton);
            Controls.Add(clearButton);
            Controls.Add(copyButton);
            Name = "Clipboard_Exporter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Button copyButton;
        private Button clearButton;
        private Button saveToFileButton;
        private TextBox textBox1;
    }
}