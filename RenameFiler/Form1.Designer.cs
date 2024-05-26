namespace RenameFiler
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PathToString = new TextBox();
            RenameToString = new TextBox();
            DoButton = new Button();
            SuspendLayout();
            // 
            // PathToString
            // 
            PathToString.Location = new Point(12, 12);
            PathToString.Name = "PathToString";
            PathToString.Size = new Size(358, 23);
            PathToString.TabIndex = 0;
            PathToString.TextChanged += PathToString_TextChanged;
            // 
            // RenameToString
            // 
            RenameToString.Location = new Point(12, 41);
            RenameToString.Multiline = true;
            RenameToString.Name = "RenameToString";
            RenameToString.Size = new Size(146, 76);
            RenameToString.TabIndex = 1;
            RenameToString.TextChanged += RenameToString_TextChanged;
            // 
            // DoButton
            // 
            DoButton.Location = new Point(295, 74);
            DoButton.Name = "DoButton";
            DoButton.Size = new Size(75, 43);
            DoButton.TabIndex = 2;
            DoButton.Text = "Rename";
            DoButton.UseVisualStyleBackColor = true;
            DoButton.Click += DoButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 140);
            Controls.Add(DoButton);
            Controls.Add(RenameToString);
            Controls.Add(PathToString);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox PathToString;
        private TextBox RenameToString;
        private Button DoButton;
    }
}
