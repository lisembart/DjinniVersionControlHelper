using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DjinniVersionControlHelper
{
    public partial class Form1 : Form
    {
        private Paths filePaths;

        private string saveFilePath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        private string gitPathFirstText = "Path to Git folder: ";

        private ProcessManager processManager;
        private FilesManager filesManager;

        public Form1()
        {
            InitializeComponent();

            if (!File.Exists(saveFilePath))
            {
                Console.WriteLine("No save file, set git path");
                filePaths = new Paths();
            }
            else
            {
                BinaryFormatter bf = new BinaryFormatter();
                using (Stream stream = File.OpenRead(saveFilePath))
                {
                    filePaths = (Paths)bf.Deserialize(stream);
                }
            }

            processManager = new ProcessManager();
            filesManager = new FilesManager(filePaths.GitModPath, filePaths.EditorModPath);

            Application.ApplicationExit += OnApplicationQuit;
            UpdateGitPathLabel();
        }

        private void setGitPathBtn_Click(object sender, EventArgs e)
        {
            if (gitFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                filePaths.GitModPath = gitFolderBrowserDialog.SelectedPath;
            }
            filesManager.UpdatePaths(filePaths.GitModPath, filePaths.EditorModPath);
            UpdateGitPathLabel();
        }

        private void UpdateGitPathLabel()
        {
            if (filePaths.GitModPath != null)
            {
                gitFolderPathLabel.Text = gitPathFirstText + filePaths.GitModPath;
            }
            else
            {
                gitFolderPathLabel.Text = gitPathFirstText + "Path not setted";
            }
        }

        private void SavePathSettings()
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (Stream stream = File.Create(saveFilePath))
            {
                bf.Serialize(stream, filePaths);
            }
        }

        private void OnApplicationQuit(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("Application quiting");
            SavePathSettings();
        }

        private void copyToGitDirectoryBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "This  will close all Djinni! instances, make sure to save all changes.", "Warning",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if(result == DialogResult.OK)
            {
                try
                {
                    processManager.KillEditorProcess();
                    try
                    {
                        filesManager.CopyFilesToGitDirectory();
                        MessageBox.Show("Files copied to git directory succesfully");
                    }
                    catch (FileNotFoundException ex)
                    {
                        MessageBox.Show("Editor mod directory is empty", "No files error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("There is no Djinni! process running now", "No editor running error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void copyToEditorModDirectoryBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Remeber to close all Djinni! instances before continuing", "Warning",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                if (!processManager.EditorProcessExist())
                {
                    try
                    {
                        filesManager.CopyFilesToEditorDirectory();
                        MessageBox.Show("Files copied to editor directory succesfully");
                    }
                    catch (FileNotFoundException ex)
                    {
                        MessageBox.Show("Git mod directory is empty", "No files error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Djinni! process still running, please turn it off before continuing", "Djinni! process running error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }            
            }
        }
    }
}
