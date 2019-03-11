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
            this.label1 = new System.Windows.Forms.Label();
            this.gitFolderPathLabel = new System.Windows.Forms.Label();
            this.setGitPathBtn = new System.Windows.Forms.Button();
            this.copyToGitDirectoryBtn = new System.Windows.Forms.Button();
            this.copyToEditorModDirectoryBtn = new System.Windows.Forms.Button();
            this.gitFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path to Djinni mod files: C:\\Users\\lisem\\AppData\\Local\\The Witcher\\temp\\__Resourc" +
    "esUnpackTmp";
            // 
            // gitFolderPathLabel
            // 
            this.gitFolderPathLabel.AutoSize = true;
            this.gitFolderPathLabel.Location = new System.Drawing.Point(12, 44);
            this.gitFolderPathLabel.Name = "gitFolderPathLabel";
            this.gitFolderPathLabel.Size = new System.Drawing.Size(217, 13);
            this.gitFolderPathLabel.TabIndex = 1;
            this.gitFolderPathLabel.Text = "Path to Git mod files: C:\\Projects\\Mods\\Test\r\n";
            // 
            // setGitPathBtn
            // 
            this.setGitPathBtn.Location = new System.Drawing.Point(384, 34);
            this.setGitPathBtn.Name = "setGitPathBtn";
            this.setGitPathBtn.Size = new System.Drawing.Size(114, 23);
            this.setGitPathBtn.TabIndex = 2;
            this.setGitPathBtn.Text = "Change Git Path";
            this.setGitPathBtn.UseVisualStyleBackColor = true;
            this.setGitPathBtn.Click += new System.EventHandler(this.setGitPathBtn_Click);
            // 
            // copyToGitDirectoryBtn
            // 
            this.copyToGitDirectoryBtn.Location = new System.Drawing.Point(15, 78);
            this.copyToGitDirectoryBtn.Name = "copyToGitDirectoryBtn";
            this.copyToGitDirectoryBtn.Size = new System.Drawing.Size(214, 23);
            this.copyToGitDirectoryBtn.TabIndex = 3;
            this.copyToGitDirectoryBtn.Text = "Copy mod files to Git folder";
            this.copyToGitDirectoryBtn.UseVisualStyleBackColor = true;
            this.copyToGitDirectoryBtn.Click += new System.EventHandler(this.copyToGitDirectoryBtn_Click);
            // 
            // copyToEditorModDirectoryBtn
            // 
            this.copyToEditorModDirectoryBtn.Location = new System.Drawing.Point(285, 78);
            this.copyToEditorModDirectoryBtn.Name = "copyToEditorModDirectoryBtn";
            this.copyToEditorModDirectoryBtn.Size = new System.Drawing.Size(214, 23);
            this.copyToEditorModDirectoryBtn.TabIndex = 4;
            this.copyToEditorModDirectoryBtn.Text = "Copy mod files from Git folder";
            this.copyToEditorModDirectoryBtn.UseVisualStyleBackColor = true;
            this.copyToEditorModDirectoryBtn.Click += new System.EventHandler(this.copyToEditorModDirectoryBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 116);
            this.Controls.Add(this.copyToEditorModDirectoryBtn);
            this.Controls.Add(this.copyToGitDirectoryBtn);
            this.Controls.Add(this.setGitPathBtn);
            this.Controls.Add(this.gitFolderPathLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Djinni Version Control Helper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label gitFolderPathLabel;
        private System.Windows.Forms.Button setGitPathBtn;
        private System.Windows.Forms.Button copyToGitDirectoryBtn;
        private System.Windows.Forms.Button copyToEditorModDirectoryBtn;
        private System.Windows.Forms.FolderBrowserDialog gitFolderBrowserDialog;
    }
}

