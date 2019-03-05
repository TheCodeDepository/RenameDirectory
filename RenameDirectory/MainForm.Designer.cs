namespace RenameDirectory
{
    partial class MainForm
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
            this.directoryRootSelect = new MetroFramework.Controls.MetroTextBox();
            this.FileListView = new BrightIdeasSoftware.ObjectListView();
            this.OldIndexCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.FileNameCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.DateCreatedCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.DateModifiedCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.FileExtensionCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.NewIndexCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.RenameNameText = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.ManualUpBtn = new MetroFramework.Controls.MetroButton();
            this.ManualDownBtn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.FileListView)).BeginInit();
            this.SuspendLayout();
            // 
            // directoryRootSelect
            // 
            this.directoryRootSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.directoryRootSelect.CustomButton.Image = null;
            this.directoryRootSelect.CustomButton.Location = new System.Drawing.Point(875, 1);
            this.directoryRootSelect.CustomButton.Name = "";
            this.directoryRootSelect.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.directoryRootSelect.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.directoryRootSelect.CustomButton.TabIndex = 1;
            this.directoryRootSelect.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.directoryRootSelect.CustomButton.UseSelectable = true;
            this.directoryRootSelect.Lines = new string[0];
            this.directoryRootSelect.Location = new System.Drawing.Point(23, 85);
            this.directoryRootSelect.MaxLength = 32767;
            this.directoryRootSelect.Name = "directoryRootSelect";
            this.directoryRootSelect.PasswordChar = '\0';
            this.directoryRootSelect.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.directoryRootSelect.SelectedText = "";
            this.directoryRootSelect.SelectionLength = 0;
            this.directoryRootSelect.SelectionStart = 0;
            this.directoryRootSelect.ShortcutsEnabled = true;
            this.directoryRootSelect.ShowButton = true;
            this.directoryRootSelect.ShowClearButton = true;
            this.directoryRootSelect.Size = new System.Drawing.Size(897, 23);
            this.directoryRootSelect.TabIndex = 0;
            this.directoryRootSelect.UseSelectable = true;
            this.directoryRootSelect.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.directoryRootSelect.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.directoryRootSelect.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.directoryRootSelect_ButtonClick);
            // 
            // FileListView
            // 
            this.FileListView.AllColumns.Add(this.OldIndexCol);
            this.FileListView.AllColumns.Add(this.NewIndexCol);
            this.FileListView.AllColumns.Add(this.FileNameCol);
            this.FileListView.AllColumns.Add(this.DateCreatedCol);
            this.FileListView.AllColumns.Add(this.DateModifiedCol);
            this.FileListView.AllColumns.Add(this.FileExtensionCol);
            this.FileListView.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
            this.FileListView.CellEditUseWholeCell = false;
            this.FileListView.CheckBoxes = true;
            this.FileListView.CheckedAspectName = "WillRename";
            this.FileListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OldIndexCol,
            this.NewIndexCol,
            this.FileNameCol,
            this.DateCreatedCol,
            this.DateModifiedCol,
            this.FileExtensionCol});
            this.FileListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.FileListView.FullRowSelect = true;
            this.FileListView.Location = new System.Drawing.Point(23, 171);
            this.FileListView.Name = "FileListView";
            this.FileListView.ShowGroups = false;
            this.FileListView.Size = new System.Drawing.Size(832, 360);
            this.FileListView.TabIndex = 1;
            this.FileListView.UseCompatibleStateImageBehavior = false;
            this.FileListView.View = System.Windows.Forms.View.Details;
            this.FileListView.AfterSorting += new System.EventHandler<BrightIdeasSoftware.AfterSortingEventArgs>(this.FileListView_AfterSorting);
            this.FileListView.BeforeSorting += new System.EventHandler<BrightIdeasSoftware.BeforeSortingEventArgs>(this.FileListView_BeforeSorting);
            this.FileListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.FileListView_ItemChecked);
            // 
            // OldIndexCol
            // 
            this.OldIndexCol.AspectName = "OriginalIndex";
            this.OldIndexCol.IsEditable = false;
            this.OldIndexCol.Text = "Original Order";
            this.OldIndexCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.OldIndexCol.Width = 85;
            // 
            // FileNameCol
            // 
            this.FileNameCol.AspectName = "Name";
            this.FileNameCol.IsEditable = false;
            this.FileNameCol.Text = "File Name";
            this.FileNameCol.Width = 300;
            // 
            // DateCreatedCol
            // 
            this.DateCreatedCol.AspectName = "DateCreated";
            this.DateCreatedCol.IsEditable = false;
            this.DateCreatedCol.Text = "Date Created";
            this.DateCreatedCol.Width = 120;
            // 
            // DateModifiedCol
            // 
            this.DateModifiedCol.AspectName = "DateModified";
            this.DateModifiedCol.IsEditable = false;
            this.DateModifiedCol.Text = "Date Modified";
            this.DateModifiedCol.Width = 120;
            // 
            // FileExtensionCol
            // 
            this.FileExtensionCol.AspectName = "FileExtension";
            this.FileExtensionCol.IsEditable = false;
            this.FileExtensionCol.Searchable = false;
            this.FileExtensionCol.Sortable = false;
            this.FileExtensionCol.Text = "File Type";
            this.FileExtensionCol.UseFiltering = false;
            this.FileExtensionCol.Width = 100;
            // 
            // NewIndexCol
            // 
            this.NewIndexCol.AspectName = "NewIndex";
            this.NewIndexCol.IsEditable = false;
            this.NewIndexCol.Searchable = false;
            this.NewIndexCol.Sortable = false;
            this.NewIndexCol.Text = "New Index";
            this.NewIndexCol.Width = 85;
            // 
            // RenameNameText
            // 
            // 
            // 
            // 
            this.RenameNameText.CustomButton.Image = null;
            this.RenameNameText.CustomButton.Location = new System.Drawing.Point(875, 1);
            this.RenameNameText.CustomButton.Name = "";
            this.RenameNameText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.RenameNameText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.RenameNameText.CustomButton.TabIndex = 1;
            this.RenameNameText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.RenameNameText.CustomButton.UseSelectable = true;
            this.RenameNameText.CustomButton.Visible = false;
            this.RenameNameText.Lines = new string[] {
        "Image"};
            this.RenameNameText.Location = new System.Drawing.Point(23, 114);
            this.RenameNameText.MaxLength = 32767;
            this.RenameNameText.Name = "RenameNameText";
            this.RenameNameText.PasswordChar = '\0';
            this.RenameNameText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RenameNameText.SelectedText = "";
            this.RenameNameText.SelectionLength = 0;
            this.RenameNameText.SelectionStart = 0;
            this.RenameNameText.ShortcutsEnabled = true;
            this.RenameNameText.Size = new System.Drawing.Size(897, 23);
            this.RenameNameText.TabIndex = 3;
            this.RenameNameText.Text = "Image";
            this.RenameNameText.UseSelectable = true;
            this.RenameNameText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.RenameNameText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(875, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[] {
        "metroTextBox1"};
            this.metroTextBox1.Location = new System.Drawing.Point(23, 142);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(897, 23);
            this.metroTextBox1.TabIndex = 4;
            this.metroTextBox1.Text = "metroTextBox1";
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ManualUpBtn
            // 
            this.ManualUpBtn.Location = new System.Drawing.Point(862, 172);
            this.ManualUpBtn.Name = "ManualUpBtn";
            this.ManualUpBtn.Size = new System.Drawing.Size(58, 51);
            this.ManualUpBtn.TabIndex = 5;
            this.ManualUpBtn.Text = "Up";
            this.ManualUpBtn.UseSelectable = true;
            this.ManualUpBtn.Click += new System.EventHandler(this.ManualUpBtn_Click);
            // 
            // ManualDownBtn
            // 
            this.ManualDownBtn.Location = new System.Drawing.Point(862, 229);
            this.ManualDownBtn.Name = "ManualDownBtn";
            this.ManualDownBtn.Size = new System.Drawing.Size(58, 51);
            this.ManualDownBtn.TabIndex = 6;
            this.ManualDownBtn.Text = "Down";
            this.ManualDownBtn.UseSelectable = true;
            this.ManualDownBtn.Click += new System.EventHandler(this.ManualDownBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 554);
            this.Controls.Add(this.ManualDownBtn);
            this.Controls.Add(this.ManualUpBtn);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.RenameNameText);
            this.Controls.Add(this.FileListView);
            this.Controls.Add(this.directoryRootSelect);
            this.Name = "MainForm";
            this.Text = "You Wanna Order?";
            ((System.ComponentModel.ISupportInitialize)(this.FileListView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox directoryRootSelect;
        private BrightIdeasSoftware.ObjectListView FileListView;
        private BrightIdeasSoftware.OLVColumn FileNameCol;
        private BrightIdeasSoftware.OLVColumn FileExtensionCol;
        private BrightIdeasSoftware.OLVColumn DateCreatedCol;
        private BrightIdeasSoftware.OLVColumn OldIndexCol;
        private MetroFramework.Controls.MetroTextBox RenameNameText;
        private BrightIdeasSoftware.OLVColumn DateModifiedCol;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton ManualUpBtn;
        private MetroFramework.Controls.MetroButton ManualDownBtn;
        private BrightIdeasSoftware.OLVColumn NewIndexCol;
    }
}

