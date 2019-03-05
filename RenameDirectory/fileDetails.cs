using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenameDirectory
{
    public class FileDetails
    {
        public FileDetails(string FilePath, int Index)
        {
            FullPath = FilePath;
            WillRename = true;
            OrginalIndex = Index;
            NewIndex = Index;

            Name = Path.GetFileNameWithoutExtension(FilePath);
            FileExtension = Path.GetExtension(FilePath);
            DateCreated = File.GetCreationTime(FilePath);
            DateModified = File.GetLastWriteTime(FilePath);
        }

        public bool WillRename { get; set; }
        public int OrginalIndex { get; private set; }
        public int NewIndex { get; set; }
        public string Name { get; private set; }
        public string FullPath { get; private set; }
        public string FileExtension { get; private set; }
        public DateTime DateCreated { get; private set; }
        public DateTime DateModified { get; private set; }

        public void UpdateFileName(string new_name)
        {
            if (new_name.Trim(' ').Length > 1)
            {
                Name = new_name;
                File.Move(FullPath, Path.GetPathRoot(FullPath) + Name);
            }
        }
        
    }


}
