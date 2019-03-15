using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using MetroFramework;

namespace RenameCollection
{
    public partial class ProgressWindow : MetroFramework.Forms.MetroForm
    {
        public ProgressWindow(string template, List<Document> fileDetails)
        {
            InitializeComponent();
            Template = template;
            FileList = fileDetails;
            RunProcessWorker.RunWorkerAsync();
        }

        public string Template { get; set; }
        public List<Document> FileList { get; set; }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RunProcessWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            FileController.UpdateFileNames(Template, FileList, RunProcessWorker.ReportProgress);
        }

        private void RunProcessWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;            
        }

        private void RunProcessWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MetroMessageBox.Show(this, e.Error.Message, "Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            okBtn.Enabled = true;
            labelProgress.Text = "Process Complete";
            progressBar.Value = 100;
        }
    }
}
