using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace RenameDirectory
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public List<FileDetails> listOfFiles { get; set; }

        private void directoryRootSelect_ButtonClick(object sender, EventArgs e)
        {
            FolderBrowserDialog open = new FolderBrowserDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                listOfFiles = new List<FileDetails>();
                var all_Files = Directory.GetFiles(open.SelectedPath);
                for (int i = 0; i < all_Files.Length; i++)
                {
                    listOfFiles.Add(new FileDetails(all_Files[i], i));
                }

                LoadRecords();
            }
        }

        private void LoadRecords()
        {
            for (int i = 0; i < listOfFiles.Count; i++)
            {
                listOfFiles[i].NewIndex = i;
            }
            FileListView.SetObjects(listOfFiles);
        }

        bool shouldRun = true;

        private void FileListView_AfterSorting(object sender, BrightIdeasSoftware.AfterSortingEventArgs e)
        {
            if (shouldRun)
            {
                if (listOfFiles != null && e.ColumnToSort != null)
                {
                    SortMethod method;
                    switch (e.ColumnToSort.Name)
                    {
                        case "OldIndexCol":
                            method = SortMethod.Index;
                            break;
                        case "FileNameCol":
                            method = SortMethod.Name;
                            break;
                        case "DateCreatedCol":
                            method = SortMethod.DateCreated;
                            break;
                        case "DateModifiedCol":
                            method = SortMethod.DateModified;
                            break;
                        default:
                            method = SortMethod.Index;
                            break;
                    }

                    bool asc = true;
                    if (e.SortOrder == SortOrder.Ascending)
                    {
                        asc = false;
                    }
                    listOfFiles.Sort(method, asc);

                    //Prevents recursive loop
                    shouldRun = false;
                    FileListView.SetObjects(listOfFiles);
                    shouldRun = true;

                }
            }
        }

        private void FileListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            listOfFiles[int.Parse(e.Item.SubItems[0].Text)].WillRename = e.Item.Checked;
        }

        private void ManualUpBtn_Click(object sender, EventArgs e)
        {
            var row = FileListView.Items[FileListView.SelectedIndex];
            int rowI = row.Index;
            if (rowI != 0)
            {
                FileListView.Items.RemoveAt(rowI);
                FileListView.Items.Insert(rowI - 1, row);
                FileListView.Focus();

                FileListView.SelectedIndex = rowI - 1;
            }
        }

        private void ManualDownBtn_Click(object sender, EventArgs e)
        {
            var row = FileListView.Items[FileListView.SelectedIndex];
            int rowI = row.Index;
            if (rowI != FileListView.Items.Count - 1)
            {
                FileListView.Items.RemoveAt(rowI);
                FileListView.Items.Insert(rowI + 1, row);
                FileListView.Focus();
                FileListView.SelectedIndex = rowI + 1;
            }
        }

        private void FileListView_BeforeSorting(object sender, BrightIdeasSoftware.BeforeSortingEventArgs e)
        {
            e.Handled = true;
        }
    }

    class RenameFiles
    {
        public void RenameAllFiles(string path)
        {
            string[] files = Directory.GetFiles(path);

            foreach (string orginalName in files)
            {
                File.GetCreationTime(Path.Combine(path, orginalName));
            }
            File.Move("oldfilename", "newfilename");
        }
    }
}
