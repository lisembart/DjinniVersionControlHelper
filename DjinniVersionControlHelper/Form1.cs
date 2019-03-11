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

        private string saveFilePath =
            System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        private string gitPathFirstText = "Path to Git folder: ";

        private ProcessKiller processKiller;

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
                using (FileStream stream = new FileStream(saveFilePath, FileMode.Open))
                {
                    filePaths = (Paths)bf.Deserialize(stream);
                }
            }

            Application.ApplicationExit += OnApplicationQuit;
            UpdateGitPathLabel();
            processKiller = new ProcessKiller();
        }

        private void setGitPathBtn_Click(object sender, EventArgs e)
        {
            if (gitFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                filePaths.GitModPath = gitFolderBrowserDialog.SelectedPath;
            }

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

        private void OnApplicationQuit(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("Application quiting");
            SavePathSettings();
        }

        private void SavePathSettings()
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream stream = new FileStream(saveFilePath, FileMode.Create))
            {
                bf.Serialize(stream, filePaths);
            }
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
                    processKiller.KillEditorProcess();
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("There is no Djinni! process running now", "No editor running error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
