
namespace TestVars
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.UserAskTextBox = new System.Windows.Forms.TextBox();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.AskButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.HeadderLabel = new System.Windows.Forms.Label();
            this.AnswerPromptLabel = new System.Windows.Forms.Label();
            this.DebugLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserAskTextBox
            // 
            this.UserAskTextBox.Location = new System.Drawing.Point(44, 89);
            this.UserAskTextBox.Name = "UserAskTextBox";
            this.UserAskTextBox.Size = new System.Drawing.Size(187, 20);
            this.UserAskTextBox.TabIndex = 0;
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnswerLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.AnswerLabel.Location = new System.Drawing.Point(124, 63);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(138, 14);
            this.AnswerLabel.TabIndex = 1;
            this.AnswerLabel.Text = "Thinking...";
            this.AnswerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AskButton
            // 
            this.AskButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AskButton.Location = new System.Drawing.Point(100, 115);
            this.AskButton.Name = "AskButton";
            this.AskButton.Size = new System.Drawing.Size(75, 23);
            this.AskButton.TabIndex = 2;
            this.AskButton.Text = "Ask";
            this.AskButton.UseVisualStyleBackColor = true;
            this.AskButton.Click += new System.EventHandler(this.AskButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearButton.Location = new System.Drawing.Point(140, 144);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuitButton.Location = new System.Drawing.Point(59, 144);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 23);
            this.QuitButton.TabIndex = 4;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // HeadderLabel
            // 
            this.HeadderLabel.AutoSize = true;
            this.HeadderLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.HeadderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadderLabel.Location = new System.Drawing.Point(49, 30);
            this.HeadderLabel.Name = "HeadderLabel";
            this.HeadderLabel.Size = new System.Drawing.Size(176, 20);
            this.HeadderLabel.TabIndex = 5;
            this.HeadderLabel.Text = "MAGIC EIGHT BALL";
            this.HeadderLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AnswerPromptLabel
            // 
            this.AnswerPromptLabel.AutoSize = true;
            this.AnswerPromptLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.AnswerPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerPromptLabel.Location = new System.Drawing.Point(12, 64);
            this.AnswerPromptLabel.Name = "AnswerPromptLabel";
            this.AnswerPromptLabel.Size = new System.Drawing.Size(106, 13);
            this.AnswerPromptLabel.TabIndex = 6;
            this.AnswerPromptLabel.Text = "THE BALL SAYS:";
            this.AnswerPromptLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DebugLabel
            // 
            this.DebugLabel.Location = new System.Drawing.Point(1, 7);
            this.DebugLabel.Name = "DebugLabel";
            this.DebugLabel.Size = new System.Drawing.Size(269, 23);
            this.DebugLabel.TabIndex = 7;
            this.DebugLabel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 186);
            this.Controls.Add(this.DebugLabel);
            this.Controls.Add(this.AnswerPromptLabel);
            this.Controls.Add(this.HeadderLabel);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.AskButton);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.UserAskTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Magic Eight Ball";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserAskTextBox;
        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.Button AskButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Label HeadderLabel;
        private System.Windows.Forms.Label AnswerPromptLabel;
        private System.Windows.Forms.Label DebugLabel;
    }
}

