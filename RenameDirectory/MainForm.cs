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
        public List<string> FileExtensions { get; set; }
        private void directoryRootSelect_ButtonClick(object sender, EventArgs e)
        {
            FolderBrowserDialog open = new FolderBrowserDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                listOfFiles = new List<FileDetails>();
                FileExtensions = new List<string>();

                var all_Files = Directory.GetFiles(open.SelectedPath);
                for (int i = 0; i < all_Files.Length; i++)
                {
                    listOfFiles.Add(new FileDetails(all_Files[i], i));
                    if (!FileExtensions.Contains(listOfFiles[i].FileExtension))
                    {
                        FileExtensions.Add(listOfFiles[i].FileExtension);
                    }
                }

                directoryRootSelect.Text = open.SelectedPath;
                fileExtensionsCbo.DataSource = FileExtensions;
                LoadRecords();

                ProcessBtn.Enabled = true;
                TickTypeBtn.Enabled = true;
                ManualDownBtn.Enabled = true;
                ManualUpBtn.Enabled = true;
                fileExtensionsCbo.Enabled = true;
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
                    shouldRun = false;
                    FileListView.SetObjects(listOfFiles);
                    shouldRun = true;


                }
            }
        }

        private void FileListView_BeforeSorting(object sender, BrightIdeasSoftware.BeforeSortingEventArgs e)
        {
            e.Handled = true;
        }

        private void FileListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            listOfFiles[int.Parse(e.Item.Text)].WillRename = e.Item.Checked;
        }

        private void ManualUpBtn_Click(object sender, EventArgs e)
        {
            if (FileListView.SelectedIndex != -1)
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

        }

        private void ManualDownBtn_Click(object sender, EventArgs e)
        {
            if (FileListView.SelectedIndex != -1)
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
        }

        private void UpdateSampleString()
        {
            string TemplateString = TemplateStringTxt.Text;
            int padding = 5;

            bool index = TemplateString.Contains("[Index]");

            bool dateCreated = TemplateString.Contains("[DateCreated]");
            bool timeCreated = TemplateString.Contains("[TimeCreated]");

            bool dateModified = TemplateString.Contains("[DateModified]");
            bool timeModified = TemplateString.Contains("[TimeModified]");

            bool dateNow = TemplateString.Contains("[DateNow]");
            bool timeNow = TemplateString.Contains("[TimeNow]");

            if (index)
            {
                TemplateString = TemplateString.Replace("[Index]", "17".PadLeft(padding, '0'));
            }
            if (dateCreated)
            {
                TemplateString = TemplateString.Replace("[DateCreated]", DateTime.Now.ToShortDateString().Replace('/', '-'));
            }
            if (timeCreated)
            {
                TemplateString = TemplateString.Replace("[TimeCreated]", DateTime.Now.ToLongTimeString().Replace(':', '-'));
            }

            if (dateModified)
            {
                TemplateString = TemplateString.Replace("[DateModified]", DateTime.Now.ToShortDateString().Replace('/', '-'));
            }
            if (timeModified)
            {
                TemplateString = TemplateString.Replace("[TimeModified]", DateTime.Now.ToLongTimeString().Replace(':', '-'));
            }
            if (dateNow)
            {
                TemplateString = TemplateString.Replace("[DateNow]", DateTime.Now.ToShortDateString().Replace('/', '-'));
            }
            if (timeNow)
            {
                TemplateString = TemplateString.Replace("[TimeNow]", DateTime.Now.ToLongTimeString().Replace(':', '-'));
            }
            NewNameSample.Text = TemplateString;
        }

        private void UpdateFileNames()
        {
            string TemplateString = TemplateStringTxt.Text;
            int padding = listOfFiles.Count.ToString().Length + 1;

            bool index = TemplateString.Contains("[Index]");

            bool dateCreated = TemplateString.Contains("[DateCreated]");
            bool timeCreated = TemplateString.Contains("[TimeCreated]");

            bool dateModified = TemplateString.Contains("[DateModified]");
            bool timeModified = TemplateString.Contains("[TimeModified]");

            bool dateNow = TemplateString.Contains("[DateNow]");
            bool timeNow = TemplateString.Contains("[TimeNow]");

            foreach (FileDetails item in listOfFiles)
            {
                string itemName = TemplateString;
                if (index)
                {
                    itemName = itemName.Replace("[Index]", item.NewIndex.ToString().PadLeft(padding, '0'));
                }

                if (dateCreated)
                {
                    itemName = itemName.Replace("[DateCreated]", item.DateCreated.ToShortDateString().Replace('/', '-'));
                }
                if (timeCreated)
                {
                    itemName = itemName.Replace("[TimeCreated]", item.DateCreated.ToLongTimeString().Replace(':', '-'));
                }

                if (dateModified)
                {
                    itemName = itemName.Replace("[DateModified]", item.DateModified.ToShortDateString().Replace('/', '-'));
                }
                if (timeModified)
                {
                    itemName = itemName.Replace("[TimeModified]", item.DateModified.ToLongTimeString().Replace(':', '-'));
                }

                if (dateNow)
                {
                    itemName = itemName.Replace("[DateNow]", DateTime.Now.ToShortDateString().Replace('/', '-'));
                }
                if (timeNow)
                {
                    itemName = itemName.Replace("[TimeNow]", DateTime.Now.ToLongTimeString().Replace(':', '-'));
                }
                item.UpdateFileName(itemName);
            }
        }

        private void ProcessBtn_Click(object sender, EventArgs e)
        {
            if (listOfFiles != null)
            {
                if (TemplateStringTxt.Text.Contains("[Index]"))
                {
                    UpdateFileNames();
                    FileListView.SetObjects(listOfFiles);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please Include the '[Index]' Tag in the string template.", "Incorrect String Template");
                }

            }
        }

        private void RenameNameText_TextChanged(object sender, EventArgs e)
        {
            UpdateSampleString();
        }

        private void TickType_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in FileListView.Items)
            {
                if (item.SubItems[4].Text == fileExtensionsCbo.Text)
                {
                    listOfFiles[int.Parse(item.Text)].WillRename = !listOfFiles[int.Parse(item.Text)].WillRename;
                    item.Checked = !item.Checked;
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TemplateStringTxt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TemplateStringTxt.AutoCompleteSource = AutoCompleteSource.CustomSource;

            string[] arr = { "[Index]", "[DateCreated]", "[TimeCreated]", "[DateModified]", "[TimeModified]", "[DateNow]", "[TimeNow]" };

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            collection.AddRange(arr);
            TemplateStringTxt.AutoCompleteCustomSource = collection;
        }

        private void FileListView_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    ManualUpBtn_Click(sender, new EventArgs());
                    break;
                case Keys.Down:
                    ManualDownBtn_Click(sender, new EventArgs());
                    break;
            }
            e.Handled = true;
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            string message =    "The following Tags can be used for the string template.\n" +
                                "[Index], [DateCreated], [TimeCreated], [DateModified], [TimeModified], [DateNow], [TimeNow]\n" +
                                "The Order in which the items are displayed is the order that they will be renamed.\n" +
                                "Use the up/down arrow keys to move single files up and down the list.\n" +
                                "This will be reset when ordering by a column.\n" +
                                "Author: Martin White";

            string title =      "Help";

            MetroFramework.MetroMessageBox.Show(this, message, title);
        }
    }


}
