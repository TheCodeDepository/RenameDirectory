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
        public List<Document> fileList { get; set; }
        public List<string> fileExtensions { get; set; }

        //Load Record/Image
        private void FileListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FileListView.SelectedIndex > -1)
            {
                imageBox.Image = fileList[FileListView.SelectedIndex].GetImage;

            }
        }




        //Select Folder and load Files into List
        private void directoryRootSelect_ButtonClick(object sender, EventArgs e)
        {
            FolderBrowserDialog open = new FolderBrowserDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                directoryRootSelect.Text = open.SelectedPath;
                ProcessBtn.Enabled = true;
                TickTypeBtn.Enabled = true;
                fileExtensionsCbo.Enabled = true;

                //Load list of file details.
                fileList = GetDocuments(open.SelectedPath);
                FileListView.SetObjects(fileList);

            }
        }

        //Load Files Into List
        private List<Document> GetDocuments(string open)
        {
            fileExtensions = new List<string>();
            var list = new List<Document>();
            string[] all_Files = Directory.GetFiles(open);

            for (int i = 0; i < all_Files.Length; i++)
            {
                list.Add(new Document(all_Files[i]));
                if (!fileExtensions.Contains(list[i].FileExtension))
                {
                    fileExtensions.Add(list[i].FileExtension);
                }
            }
            fileExtensionsCbo.DataSource = fileExtensions;
            return list;
        }

        //Go Button
        private void ProcessBtn_Click(object sender, EventArgs e)
        {
            if (fileList != null)
            {
                if (TemplateStringTxt.Text.Contains("[Index]"))
                {
                    OrderFileList();
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

        //Template String Changed
        private void RenameNameText_TextChanged(object sender, EventArgs e)
        {
            NewNameSample.Text = FileController.UpdateSampleString(TemplateStringTxt.Text);
        }

        //Mass de/selection via file type
        private void TickType_Click(object sender, EventArgs e)
        {
            //var items = FileListView.Items;
            //for (int i = 0; i < FileListView.GetItemCount(); i++)
            //{

            //}
            //foreach (var item in fileList)
            //{
            //    if (item.FileExtension == fileExtensionsCbo.Text)
            //    {
            //        //Process order is important as list view as crude 
            //        //databinding that will overide the option if not set in the object first.
            //        item.Checked = !item.Checked;
            //        FileListView.Items[item.Index].Checked = item.WillRename;
            //    }
            //}
            //FileListView.RefreshOverlays();
            //FileListView.SetObjects(fileList);
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


        private void OrderFileList()
        {
            for (int i = 0; i < FileListView.Items.Count; i++)
            {
                Document file = fileList.FindDoc(FileListView.Items[i].SubItems[1].Text);
                fileList.Remove(file);
                fileList.Insert(i, file);
            }
        }

        //Moving Items up and down the list.
        //private void FileListView_KeyDown(object sender, KeyEventArgs e)
        //{
        //    switch (e.KeyCode)
        //    {
        //        case Keys.Up:
        //            FileController.MoveItemUp(FileListView, fileList);
        //            break;
        //        case Keys.Down:
        //            FileController.MoveItemDown(FileListView, fileList);
        //            break;
        //    }
        //    e.Handled = true;
        //}

        //Will the file be renamed? this passes the value from the view to the property.
        //private void FileListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        //{
        //    fileList[int.Parse(e.Item.Text)].Checked = e.Item.Checked;
        //}

        ////Sorting Overide Methods, Should run used to prevent a recursive loop of sorting.
        //private void FileListView_BeforeSorting(object sender, BrightIdeasSoftware.BeforeSortingEventArgs e)
        //{
        //    e.Handled = true;
        //}
        //bool shouldRun = true;
        //private void FileListView_AfterSorting(object sender, BrightIdeasSoftware.AfterSortingEventArgs e)
        //{
        //    if (shouldRun)
        //    {
        //        FileController.SortList(fileList, e);
        //        shouldRun = false;
        //        FileListView.SetObjects(fileList);
        //        shouldRun = true;
        //    }
        //}


    }
}
