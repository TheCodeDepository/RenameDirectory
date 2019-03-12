using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace RenameCollection
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        //Form Loading
        public MainForm()
        {
            InitializeComponent();

        }

        //Properties
        public List<FileDetails> fileList { get; set; }
        public List<string> fileExtensions { get; set; }

        //Select Folder and load Files into List
        private void directoryRootSelect_ButtonClick(object sender, EventArgs e)
        {
            FolderBrowserDialog open = new FolderBrowserDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                //Load list of file details.
                fileList = new List<FileDetails>();
                fileExtensions = new List<string>();

                var all_Files = Directory.GetFiles(open.SelectedPath);
                for (int i = 0; i < all_Files.Length; i++)
                {
                    fileList.Add(new FileDetails(all_Files[i], i));

                    if (!fileExtensions.Contains(fileList[i].FileExtension))
                    {
                        fileExtensions.Add(fileList[i].FileExtension);
                    }
                }

                directoryRootSelect.Text = open.SelectedPath;
                fileExtensionsCbo.DataSource = fileExtensions;
                FileListView.SetObjects(fileList);
                ProcessBtn.Enabled = true;
                TickTypeBtn.Enabled = true;
                fileExtensionsCbo.Enabled = true;
            }
        }

        private void RenameNameText_TextChanged(object sender, EventArgs e)
        {
            NewNameSample.Text = FileController.UpdateSampleString(TemplateStringTxt.Text);
        }

        //Mass de/selection via file type
        private void TickType_Click(object sender, EventArgs e)
        {
            foreach (var item in fileList)
            {
                if (item.FileExtension == fileExtensionsCbo.Text)
                {
                    //Process order is important as list view as crude 
                    //databinding that will overide the option if not set in the object first.
                    item.WillRename = !item.WillRename;
                    FileListView.Items[item.Index].Checked = item.WillRename;
                }
            }
            FileListView.RefreshOverlays();
            //FileListView.SetObjects(fileList);
        }

        //Moving Items up and down the list.
        private void FileListView_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    FileController.MoveItemUp(FileListView, fileList);
                    break;
                case Keys.Down:
                    FileController.MoveItemDown(FileListView, fileList);
                    break;
            }
            e.Handled = true;
        }

        //Will the file be renamed? this passes the value from the view to the property.
        private void FileListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            fileList[int.Parse(e.Item.Text)].WillRename = e.Item.Checked;
        }

        //Sorting Overide Methods, Should run used to prevent a recursive loop of sorting.
        private void FileListView_BeforeSorting(object sender, BrightIdeasSoftware.BeforeSortingEventArgs e)
        {
            e.Handled = true;
        }
        bool shouldRun = true;
        private void FileListView_AfterSorting(object sender, BrightIdeasSoftware.AfterSortingEventArgs e)
        {
            if (shouldRun)
            {
                FileController.SortList(fileList, e);
                shouldRun = false;
                FileListView.SetObjects(fileList);
                shouldRun = true;
            }
        }

        //Help Button
        private void helpBtn_Click(object sender, EventArgs e)
        {
            string message = "The following Tags can be used for the string template.\n" +
                                "[Index], [DateCreated], [TimeCreated], [DateModified], [TimeModified], [DateNow], [TimeNow]\n" +
                                "The Order in which the items are displayed is the order that they will be renamed.\n" +
                                "Use the up/down arrow keys to move single files up and down the list.\n" +
                                "This will be reset when ordering by a column.\n" +
                                "Author: Martin White";

            string title = "Help";
            MetroFramework.MetroMessageBox.Show(this, message, title);
        }

        //Go Button
        private void ProcessBtn_Click(object sender, EventArgs e)
        {
            if (fileList != null)
            {
                if (TemplateStringTxt.Text.Contains("[Index]"))
                {
                    ProgressWindow win = new ProgressWindow(TemplateStringTxt.Text, fileList);
                    win.ShowDialog();
                    FileListView.SetObjects(fileList);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please Include the '[Index]' Tag in the Name Template.", "Incorrect String Template");
                }
            }
        }


    }
}
