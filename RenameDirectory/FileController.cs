﻿using BrightIdeasSoftware;
using System;
using System.Collections.Generic;

namespace RenameCollection
{
    public static class FileController
    {
        internal static void UpdateFileNames(string TemplateString, List<FileDetails> FileList)
        {
            int padding = FileList.Count.ToString().Length + 1;

            bool index = TemplateString.Contains("[Index]");

            bool dateCreated = TemplateString.Contains("[DateCreated]");
            bool timeCreated = TemplateString.Contains("[TimeCreated]");

            bool dateModified = TemplateString.Contains("[DateModified]");
            bool timeModified = TemplateString.Contains("[TimeModified]");

            bool dateNow = TemplateString.Contains("[DateNow]");
            bool timeNow = TemplateString.Contains("[TimeNow]");

            int loopIndex = 0;
            foreach (FileDetails item in FileList)
            {
                if (item.WillRename)
                {
                    string itemName = TemplateString;
                    if (index)
                    {
                        itemName = itemName.Replace("[Index]", loopIndex.ToString().PadLeft(padding, '0'));
                        loopIndex++;
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
        }

        internal static string UpdateSampleString(string TemplateString)
        {
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
            return TemplateString;
        }



        internal static void SortList(List<FileDetails> Files, BrightIdeasSoftware.AfterSortingEventArgs e)
        {
            if (Files != null && e.ColumnToSort != null)
            {
                SortMethod method;
                switch (e.ColumnToSort.Text)
                {
                    case "Index":
                        method = SortMethod.Index;
                        break;
                    case "File Name":
                        method = SortMethod.Name;
                        break;
                    case "Date Created":
                        method = SortMethod.DateCreated;
                        break;
                    case "Date Modified":
                        method = SortMethod.DateModified;
                        break;
                    default:
                        method = SortMethod.Index;
                        break;
                }

                bool asc = true;
                if (e.SortOrder == System.Windows.Forms.SortOrder.Ascending)
                {
                    asc = false;
                }
                Files.Sort(method, asc);
            }
        }

        internal static void MoveItemUp(ObjectListView ListView, List<FileDetails> Files)
        {
            if (ListView.SelectedIndex != -1)
            {
                var row = ListView.Items[ListView.SelectedIndex];
                FileDetails file = Files[ListView.SelectedIndex];
                int rowI = file.Index;
                if (rowI != 0)
                {
                    Files.RemoveAt(rowI);
                    Files.Insert(rowI - 1, file);
                    Files[rowI].Index = rowI;
                    file.Index = rowI - 1;

                    ListView.Items.RemoveAt(rowI);
                    ListView.Items.Insert(file.Index, row);

                    ListView.Focus();
                    ListView.SelectedIndex = rowI - 1;
                }
            }
        }

        internal static void MoveItemDown(ObjectListView ListView, List<FileDetails> Files)
        {
            if (ListView.SelectedIndex != -1)
            {
                var row = ListView.Items[ListView.SelectedIndex];
                FileDetails file = Files[ListView.SelectedIndex];
                int rowI = file.Index;

                if (rowI != Files.Count - 1)
                {
                    Files.RemoveAt(rowI);
                    Files.Insert(rowI + 1, file);
                    Files[rowI].Index = rowI;

                    file.Index = rowI + 1;

                    ListView.Items.RemoveAt(rowI);
                    ListView.Items.Insert(file.Index, row);

                    ListView.Focus();
                    ListView.SelectedIndex = rowI + 1;
                }
            }
        }
    }
}
