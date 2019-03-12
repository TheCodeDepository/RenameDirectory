using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace RenameCollection
{
    public class FileDetails
    {
        public FileDetails(string FilePath, int Index)
        {
            FullPath = FilePath;
            WillRename = true;
            OrgIndex = Index;
            this.Index = Index;

            Name = Path.GetFileNameWithoutExtension(FilePath);
            FileExtension = Path.GetExtension(FilePath).ToLower();
            DateCreated = File.GetCreationTime(FilePath);

            if (FileExtension == ".jpg")
            {
                DateTaken = GetDateTakenFromImage(FilePath);
            }
            else
            {
                DateTaken = DateCreated;
            }

            DateModified = File.GetLastWriteTime(FilePath);
        }

        public int Index { get; set; }
        public bool WillRename { get; set; }

        public int OrgIndex { get; private set; }
        public string Name { get; private set; }
        public string FullPath { get; private set; }
        public string FileExtension { get; private set; }

        public DateTime DateTaken { get; private set; }
        public DateTime DateCreated { get; private set; }
        public DateTime DateModified { get; private set; }


        public void UpdateFileName(string new_name)
        {
            string Target = Path.GetDirectoryName(FullPath) + "\\" + new_name + FileExtension;
            File.Move(FullPath, Target);

            Name = new_name;
            FullPath = Target;
        }

        //retrieves the datetime WITHOUT loading the whole image
        private Regex r = new Regex(":");
        private DateTime GetDateTakenFromImage(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {                
                using (Image myImage = Image.FromStream(fs, false, false))
                {
                    if (ContainsProperty(myImage))
                    {
                        PropertyItem propItem = myImage.GetPropertyItem(36867);
                        string dateTaken = r.Replace(Encoding.UTF8.GetString(propItem.Value), "-", 2);
                        return DateTime.Parse(dateTaken);
                    }
                    else
                    {
                        return DateCreated;
                    }
                }
            }
        }

        private bool ContainsProperty(Image myImage)
        {
            foreach (int item in myImage.PropertyIdList)
            {
                if (item == 36867)
                {
                    return true;
                }
            }
            return false;
        }


    }


}
