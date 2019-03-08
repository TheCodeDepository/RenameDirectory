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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.directoryRootSelect = new MetroFramework.Controls.MetroTextBox();
            this.FileListView = new BrightIdeasSoftware.ObjectListView();
            this.IndexCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.FileNameCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.DateCreatedCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.DateModifiedCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.FileExtensionCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.OldIndexCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ProcessBtn = new MetroFramework.Controls.MetroButton();
            this.TemplateStringTxt = new System.Windows.Forms.TextBox();
            this.NewNameSample = new System.Windows.Forms.TextBox();
            this.TickTypeBtn = new MetroFramework.Controls.MetroButton();
            this.fileExtensionsCbo = new System.Windows.Forms.ComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.helpBtn = new MetroFramework.Controls.MetroLabel();
            this.ToolTipController = new MetroFramework.Components.MetroToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.FileListView)).BeginInit();
            this.SuspendLayout();
            // 
            // directoryRootSelect
            // 
            // 
            // 
            // 
            this.directoryRootSelect.CustomButton.Image = null;
            this.directoryRootSelect.CustomButton.Location = new System.Drawing.Point(398, 1);
            this.directoryRootSelect.CustomButton.Name = "";
            this.directoryRootSelect.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.directoryRootSelect.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.directoryRootSelect.CustomButton.TabIndex = 1;
            this.directoryRootSelect.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.directoryRootSelect.CustomButton.UseSelectable = true;
            this.directoryRootSelect.Lines = new string[0];
            this.directoryRootSelect.Location = new System.Drawing.Point(133, 75);
            this.directoryRootSelect.MaxLength = 32767;
            this.directoryRootSelect.Name = "directoryRootSelect";
            this.directoryRootSelect.PasswordChar = '\0';
            this.directoryRootSelect.ReadOnly = true;
            this.directoryRootSelect.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.directoryRootSelect.SelectedText = "";
            this.directoryRootSelect.SelectionLength = 0;
            this.directoryRootSelect.SelectionStart = 0;
            this.directoryRootSelect.ShortcutsEnabled = true;
            this.directoryRootSelect.ShowButton = true;
            this.directoryRootSelect.ShowClearButton = true;
            this.directoryRootSelect.Size = new System.Drawing.Size(420, 23);
            this.directoryRootSelect.TabIndex = 0;
            this.ToolTipController.SetToolTip(this.directoryRootSelect, "Select a folder containing the files you wish to rename.");
            this.directoryRootSelect.UseSelectable = true;
            this.directoryRootSelect.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.directoryRootSelect.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.directoryRootSelect.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.directoryRootSelect_ButtonClick);
            // 
            // FileListView
            // 
            this.FileListView.AllColumns.Add(this.IndexCol);
            this.FileListView.AllColumns.Add(this.FileNameCol);
            this.FileListView.AllColumns.Add(this.DateCreatedCol);
            this.FileListView.AllColumns.Add(this.DateModifiedCol);
            this.FileListView.AllColumns.Add(this.FileExtensionCol);
            this.FileListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileListView.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
            this.FileListView.CellEditUseWholeCell = false;
            this.FileListView.CheckBoxes = true;
            this.FileListView.CheckedAspectName = "WillRename";
            this.FileListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IndexCol,
            this.FileNameCol,
            this.DateCreatedCol,
            this.DateModifiedCol,
            this.FileExtensionCol});
            this.FileListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.FileListView.FullRowSelect = true;
            this.FileListView.Location = new System.Drawing.Point(23, 171);
            this.FileListView.Name = "FileListView";
            this.FileListView.ShowFilterMenuOnRightClick = false;
            this.FileListView.ShowGroups = false;
            this.FileListView.ShowItemCountOnGroups = true;
            this.FileListView.Size = new System.Drawing.Size(854, 406);
            this.FileListView.TabIndex = 1;
            this.FileListView.UseCompatibleStateImageBehavior = false;
            this.FileListView.View = System.Windows.Forms.View.Details;
            this.FileListView.AfterSorting += new System.EventHandler<BrightIdeasSoftware.AfterSortingEventArgs>(this.FileListView_AfterSorting);
            this.FileListView.BeforeSorting += new System.EventHandler<BrightIdeasSoftware.BeforeSortingEventArgs>(this.FileListView_BeforeSorting);
            this.FileListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.FileListView_ItemChecked);
            this.FileListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FileListView_KeyDown);
            // 
            // IndexCol
            // 
            this.IndexCol.AspectName = "OrgIndex";
            this.IndexCol.HeaderCheckBox = true;
            this.IndexCol.HeaderCheckState = System.Windows.Forms.CheckState.Checked;
            this.IndexCol.IsEditable = false;
            this.IndexCol.Searchable = false;
            this.IndexCol.ShowTextInHeader = false;
            this.IndexCol.Text = "Index";
            this.IndexCol.ToolTipText = "";
            this.IndexCol.Width = 100;
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
            this.DateCreatedCol.Width = 150;
            // 
            // DateModifiedCol
            // 
            this.DateModifiedCol.AspectName = "DateModified";
            this.DateModifiedCol.IsEditable = false;
            this.DateModifiedCol.Text = "Date Modified";
            this.DateModifiedCol.Width = 150;
            // 
            // FileExtensionCol
            // 
            this.FileExtensionCol.AspectName = "FileExtension";
            this.FileExtensionCol.IsEditable = false;
            this.FileExtensionCol.Searchable = false;
            this.FileExtensionCol.Sortable = false;
            this.FileExtensionCol.Text = "File Type";
            this.FileExtensionCol.UseFiltering = false;
            this.FileExtensionCol.Width = 130;
            // 
            // OldIndexCol
            // 
            this.OldIndexCol.AspectName = "OriginalIndex";
            this.OldIndexCol.DisplayIndex = 0;
            this.OldIndexCol.IsEditable = false;
            this.OldIndexCol.Text = "Original Order";
            this.OldIndexCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.OldIndexCol.Width = 85;
            // 
            // ProcessBtn
            // 
            this.ProcessBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProcessBtn.Enabled = false;
            this.ProcessBtn.Location = new System.Drawing.Point(784, 75);
            this.ProcessBtn.Name = "ProcessBtn";
            this.ProcessBtn.Size = new System.Drawing.Size(93, 81);
            this.ProcessBtn.TabIndex = 7;
            this.ProcessBtn.Text = "Process";
            this.ToolTipController.SetToolTip(this.ProcessBtn, "Start the process or renaming each file based upon the order that are shown in th" +
        "e list below.");
            this.ProcessBtn.UseSelectable = true;
            this.ProcessBtn.Click += new System.EventHandler(this.ProcessBtn_Click);
            // 
            // TemplateStringTxt
            // 
            this.TemplateStringTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TemplateStringTxt.Location = new System.Drawing.Point(133, 104);
            this.TemplateStringTxt.Name = "TemplateStringTxt";
            this.TemplateStringTxt.Size = new System.Drawing.Size(420, 23);
            this.TemplateStringTxt.TabIndex = 8;
            this.ToolTipController.SetToolTip(this.TemplateStringTxt, "The \'Name Template\' is used to customise what you\r\nwant each file name to look li" +
        "ke.");
            this.TemplateStringTxt.TextChanged += new System.EventHandler(this.RenameNameText_TextChanged);
            // 
            // NewNameSample
            // 
            this.NewNameSample.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NewNameSample.Location = new System.Drawing.Point(133, 133);
            this.NewNameSample.Name = "NewNameSample";
            this.NewNameSample.ReadOnly = true;
            this.NewNameSample.Size = new System.Drawing.Size(420, 23);
            this.NewNameSample.TabIndex = 9;
            this.ToolTipController.SetToolTip(this.NewNameSample, "A sample of the generated file names.");
            // 
            // TickTypeBtn
            // 
            this.TickTypeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TickTypeBtn.Enabled = false;
            this.TickTypeBtn.Location = new System.Drawing.Point(673, 104);
            this.TickTypeBtn.Name = "TickTypeBtn";
            this.TickTypeBtn.Size = new System.Drawing.Size(88, 23);
            this.TickTypeBtn.TabIndex = 10;
            this.TickTypeBtn.Text = "Toggle Type";
            this.ToolTipController.SetToolTip(this.TickTypeBtn, "Select a file type (\".jpg\") that you wish to check or uncheck,\r\n then click the b" +
        "utton.");
            this.TickTypeBtn.UseSelectable = true;
            this.TickTypeBtn.Click += new System.EventHandler(this.TickType_Click);
            // 
            // fileExtensionsCbo
            // 
            this.fileExtensionsCbo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileExtensionsCbo.Enabled = false;
            this.fileExtensionsCbo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.fileExtensionsCbo.FormattingEnabled = true;
            this.fileExtensionsCbo.Location = new System.Drawing.Point(673, 75);
            this.fileExtensionsCbo.Name = "fileExtensionsCbo";
            this.fileExtensionsCbo.Size = new System.Drawing.Size(88, 23);
            this.fileExtensionsCbo.TabIndex = 12;
            this.ToolTipController.SetToolTip(this.fileExtensionsCbo, "Select a file type (\".jpg\") that you wish to check or uncheck,\r\n then click the b" +
        "utton.");
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(24, 75);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(104, 23);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Folder";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTipController.SetToolTip(this.metroLabel1, "Select a folder containing the files you wish to rename.");
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(23, 104);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(104, 23);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Name Template";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTipController.SetToolTip(this.metroLabel2, "The \'Name Template\' is used to customise what you\r\nwant each file name to look li" +
        "ke.");
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(24, 133);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(103, 23);
            this.metroLabel3.TabIndex = 15;
            this.metroLabel3.Text = "Sample";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTipController.SetToolTip(this.metroLabel3, "A sample of the generated file names.");
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel4.Location = new System.Drawing.Point(609, 75);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(58, 23);
            this.metroLabel4.TabIndex = 16;
            this.metroLabel4.Text = "Filtering";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTipController.SetToolTip(this.metroLabel4, "Select a file type (\".jpg\") that you wish to check or uncheck,\r\n then click the b" +
        "utton.");
            // 
            // helpBtn
            // 
            this.helpBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpBtn.AutoSize = true;
            this.helpBtn.Location = new System.Drawing.Point(803, 7);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(15, 19);
            this.helpBtn.TabIndex = 17;
            this.helpBtn.Text = "?";
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // ToolTipController
            // 
            this.ToolTipController.AutomaticDelay = 200;
            this.ToolTipController.AutoPopDelay = 3000;
            this.ToolTipController.InitialDelay = 200;
            this.ToolTipController.ReshowDelay = 40;
            this.ToolTipController.Style = MetroFramework.MetroColorStyle.Blue;
            this.ToolTipController.StyleManager = null;
            this.ToolTipController.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.fileExtensionsCbo);
            this.Controls.Add(this.TickTypeBtn);
            this.Controls.Add(this.NewNameSample);
            this.Controls.Add(this.TemplateStringTxt);
            this.Controls.Add(this.ProcessBtn);
            this.Controls.Add(this.FileListView);
            this.Controls.Add(this.directoryRootSelect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 400);
            this.Name = "MainForm";
            this.Text = "Rename File Collection";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FileListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox directoryRootSelect;
        private BrightIdeasSoftware.ObjectListView FileListView;
        private BrightIdeasSoftware.OLVColumn FileNameCol;
        private BrightIdeasSoftware.OLVColumn FileExtensionCol;
        private BrightIdeasSoftware.OLVColumn DateCreatedCol;
        private BrightIdeasSoftware.OLVColumn DateModifiedCol;
        private BrightIdeasSoftware.OLVColumn IndexCol;
        private BrightIdeasSoftware.OLVColumn OldIndexCol;
        private MetroFramework.Controls.MetroButton ProcessBtn;
        private System.Windows.Forms.TextBox TemplateStringTxt;
        private System.Windows.Forms.TextBox NewNameSample;
        private MetroFramework.Controls.MetroButton TickTypeBtn;
        private System.Windows.Forms.ComboBox fileExtensionsCbo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel helpBtn;
        private MetroFramework.Components.MetroToolTip ToolTipController;
    }
}

