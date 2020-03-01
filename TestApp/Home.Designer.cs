namespace TestApp
{
    partial class Home
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
            this.AddMessageGroupBox = new System.Windows.Forms.GroupBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.TextBoxGroupBox = new System.Windows.Forms.GroupBox();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.LogStatusStrip = new System.Windows.Forms.StatusStrip();
            this.LogToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.UseThreadButton = new System.Windows.Forms.Button();
            this.AddMessageGroupBox.SuspendLayout();
            this.TextBoxGroupBox.SuspendLayout();
            this.LogStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddMessageGroupBox
            // 
            this.AddMessageGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddMessageGroupBox.Controls.Add(this.UseThreadButton);
            this.AddMessageGroupBox.Controls.Add(this.AddButton);
            this.AddMessageGroupBox.Controls.Add(this.MessageTextBox);
            this.AddMessageGroupBox.Location = new System.Drawing.Point(12, 12);
            this.AddMessageGroupBox.Name = "AddMessageGroupBox";
            this.AddMessageGroupBox.Size = new System.Drawing.Size(460, 48);
            this.AddMessageGroupBox.TabIndex = 0;
            this.AddMessageGroupBox.TabStop = false;
            this.AddMessageGroupBox.Text = "Add Message";
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Location = new System.Drawing.Point(298, 17);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageTextBox.Location = new System.Drawing.Point(6, 19);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(286, 20);
            this.MessageTextBox.TabIndex = 0;
            // 
            // TextBoxGroupBox
            // 
            this.TextBoxGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxGroupBox.Controls.Add(this.LogTextBox);
            this.TextBoxGroupBox.Location = new System.Drawing.Point(12, 66);
            this.TextBoxGroupBox.Name = "TextBoxGroupBox";
            this.TextBoxGroupBox.Size = new System.Drawing.Size(460, 120);
            this.TextBoxGroupBox.TabIndex = 1;
            this.TextBoxGroupBox.TabStop = false;
            this.TextBoxGroupBox.Text = "TextBox Control";
            // 
            // LogTextBox
            // 
            this.LogTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogTextBox.Location = new System.Drawing.Point(3, 16);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ReadOnly = true;
            this.LogTextBox.Size = new System.Drawing.Size(454, 101);
            this.LogTextBox.TabIndex = 0;
            // 
            // LogStatusStrip
            // 
            this.LogStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogToolStripStatusLabel});
            this.LogStatusStrip.Location = new System.Drawing.Point(0, 189);
            this.LogStatusStrip.Name = "LogStatusStrip";
            this.LogStatusStrip.Size = new System.Drawing.Size(484, 22);
            this.LogStatusStrip.TabIndex = 2;
            this.LogStatusStrip.Text = "statusStrip1";
            // 
            // LogToolStripStatusLabel
            // 
            this.LogToolStripStatusLabel.Name = "LogToolStripStatusLabel";
            this.LogToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // UseThreadButton
            // 
            this.UseThreadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UseThreadButton.Location = new System.Drawing.Point(379, 17);
            this.UseThreadButton.Name = "UseThreadButton";
            this.UseThreadButton.Size = new System.Drawing.Size(75, 23);
            this.UseThreadButton.TabIndex = 2;
            this.UseThreadButton.Text = "Use Thread";
            this.UseThreadButton.UseVisualStyleBackColor = true;
            this.UseThreadButton.Click += new System.EventHandler(this.UseThreadButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.LogStatusStrip);
            this.Controls.Add(this.TextBoxGroupBox);
            this.Controls.Add(this.AddMessageGroupBox);
            this.MinimumSize = new System.Drawing.Size(500, 250);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lemon\'s Windows Forms NLog Targets";
            this.AddMessageGroupBox.ResumeLayout(false);
            this.AddMessageGroupBox.PerformLayout();
            this.TextBoxGroupBox.ResumeLayout(false);
            this.TextBoxGroupBox.PerformLayout();
            this.LogStatusStrip.ResumeLayout(false);
            this.LogStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox AddMessageGroupBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.GroupBox TextBoxGroupBox;
        internal System.Windows.Forms.StatusStrip LogStatusStrip;
        internal System.Windows.Forms.ToolStripStatusLabel LogToolStripStatusLabel;
        internal System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.Button UseThreadButton;
    }
}

