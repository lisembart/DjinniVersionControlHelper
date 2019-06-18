namespace DjinniVersionControlHelper
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pathToModFilesLabel = new System.Windows.Forms.Label();
            this.gitFolderPathLabel = new System.Windows.Forms.Label();
            this.setGitPathBtn = new System.Windows.Forms.Button();
            this.copyToGitDirectoryBtn = new System.Windows.Forms.Button();
            this.copyToEditorModDirectoryBtn = new System.Windows.Forms.Button();
            this.gitFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openGitDirectoryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pathToModFilesLabel
            // 
            this.pathToModFilesLabel.AutoSize = true;
            this.pathToModFilesLabel.Location = new System.Drawing.Point(16, 11);
            this.pathToModFilesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pathToModFilesLabel.Name = "pathToModFilesLabel";
            this.pathToModFilesLabel.Size = new System.Drawing.Size(627, 17);
            this.pathToModFilesLabel.TabIndex = 0;
            this.pathToModFilesLabel.Text = "Path to Djinni mod files: C:\\Users\\lisem\\AppData\\Local\\The Witcher\\temp\\__Resourc" +
    "esUnpackTmp";
            // 
            // gitFolderPathLabel
            // 
            this.gitFolderPathLabel.AutoSize = true;
            this.gitFolderPathLabel.Location = new System.Drawing.Point(16, 54);
            this.gitFolderPathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gitFolderPathLabel.Name = "gitFolderPathLabel";
            this.gitFolderPathLabel.Size = new System.Drawing.Size(281, 17);
            this.gitFolderPathLabel.TabIndex = 1;
            this.gitFolderPathLabel.Text = "Path to Git mod files: C:\\Projects\\Mods\\Test\r\n";
            // 
            // setGitPathBtn
            // 
            this.setGitPathBtn.Location = new System.Drawing.Point(610, 43);
            this.setGitPathBtn.Margin = new System.Windows.Forms.Padding(4);
            this.setGitPathBtn.Name = "setGitPathBtn";
            this.setGitPathBtn.Size = new System.Drawing.Size(134, 28);
            this.setGitPathBtn.TabIndex = 2;
            this.setGitPathBtn.Text = "Change Git Path";
            this.setGitPathBtn.UseVisualStyleBackColor = true;
            this.setGitPathBtn.Click += new System.EventHandler(this.setGitPathBtn_Click);
            // 
            // copyToGitDirectoryBtn
            // 
            this.copyToGitDirectoryBtn.Location = new System.Drawing.Point(12, 89);
            this.copyToGitDirectoryBtn.Margin = new System.Windows.Forms.Padding(4);
            this.copyToGitDirectoryBtn.Name = "copyToGitDirectoryBtn";
            this.copyToGitDirectoryBtn.Size = new System.Drawing.Size(285, 28);
            this.copyToGitDirectoryBtn.TabIndex = 3;
            this.copyToGitDirectoryBtn.Text = "Copy mod files to Git folder";
            this.copyToGitDirectoryBtn.UseVisualStyleBackColor = true;
            this.copyToGitDirectoryBtn.Click += new System.EventHandler(this.copyToGitDirectoryBtn_Click);
            // 
            // copyToEditorModDirectoryBtn
            // 
            this.copyToEditorModDirectoryBtn.Location = new System.Drawing.Point(459, 89);
            this.copyToEditorModDirectoryBtn.Margin = new System.Windows.Forms.Padding(4);
            this.copyToEditorModDirectoryBtn.Name = "copyToEditorModDirectoryBtn";
            this.copyToEditorModDirectoryBtn.Size = new System.Drawing.Size(285, 28);
            this.copyToEditorModDirectoryBtn.TabIndex = 4;
            this.copyToEditorModDirectoryBtn.Text = "Copy mod files from Git folder";
            this.copyToEditorModDirectoryBtn.UseVisualStyleBackColor = true;
            this.copyToEditorModDirectoryBtn.Click += new System.EventHandler(this.copyToEditorModDirectoryBtn_Click);
            // 
            // openGitDirectoryButton
            // 
            this.openGitDirectoryButton.Location = new System.Drawing.Point(461, 42);
            this.openGitDirectoryButton.Name = "openGitDirectoryButton";
            this.openGitDirectoryButton.Size = new System.Drawing.Size(142, 29);
            this.openGitDirectoryButton.TabIndex = 5;
            this.openGitDirectoryButton.Text = "Open Directory";
            this.openGitDirectoryButton.UseVisualStyleBackColor = true;
            this.openGitDirectoryButton.Click += new System.EventHandler(this.OpenGitDirectoryButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 130);
            this.Controls.Add(this.openGitDirectoryButton);
            this.Controls.Add(this.copyToEditorModDirectoryBtn);
            this.Controls.Add(this.copyToGitDirectoryBtn);
            this.Controls.Add(this.setGitPathBtn);
            this.Controls.Add(this.gitFolderPathLabel);
            this.Controls.Add(this.pathToModFilesLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Djinni! Version Control Helper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pathToModFilesLabel;
        private System.Windows.Forms.Label gitFolderPathLabel;
        private System.Windows.Forms.Button setGitPathBtn;
        private System.Windows.Forms.Button copyToGitDirectoryBtn;
        private System.Windows.Forms.Button copyToEditorModDirectoryBtn;
        private System.Windows.Forms.FolderBrowserDialog gitFolderBrowserDialog;
        private System.Windows.Forms.Button openGitDirectoryButton;
    }
}

