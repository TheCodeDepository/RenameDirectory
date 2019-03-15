using Microsoft.WindowsAPICodePack.Shell;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using static RenameCollection.Files;

namespace RenameCollection
{
    public class Document
    {
        public Document(string filePath)
        {            
            FullPath = filePath;
            FileName = Path.GetFileNameWithoutExtension(filePath);
            FileExtension = Path.GetExtension(filePath).ToUpper();
            DateCreated = GetDateTimeProperty(filePath,PropertiesEnum.Datecreated);
            DateModified = GetDateTimeProperty(filePath, PropertiesEnum.Datemodified);
            EarliestDate = FindEarliestDate();
        }


        public bool Checked { get; set; }
        public string FileName { get; private set; }
        public string FullPath { get; private set; }
        public string FileExtension { get; private set; }

        public DateTime DateCreated { get; private set; }
        public DateTime DateModified { get; private set; }
        public DateTime EarliestDate { get; private set; }


        private static List<string> FileTypes = new List<string> { ".BMP", ".GIF", ".JPEG", ".JPG", ".PNG", ".TIFF", ".TIF" };
        public Image GetImage
        {
            get
            {
                if (FileTypes.Contains(FileExtension))
                {
                    return Image.FromFile(FullPath);                    
                }
                else
                {
                    ShellFile shellFile = ShellFile.FromFilePath(FullPath);
                    Bitmap image = shellFile.Thumbnail.LargeBitmap;
                    image.MakeTransparent();
                    return image;
                }
            }
        }
        private DateTime FindEarliestDate()
        {
            PropertiesEnum[] options =    {
                PropertiesEnum.Datetaken,
                PropertiesEnum.Mediacreated,
                PropertiesEnum.Contentcreated,
                PropertiesEnum.Datereleased,
                PropertiesEnum.Broadcastdate,
                PropertiesEnum.Datecreated,
                PropertiesEnum.Datemodified
            };

            DateTime date =  DateTime.Now;
            foreach (PropertiesEnum prop in options)
            {
                var tmp = GetDateTimeProperty(FullPath, prop);
                if (tmp == ErrorTime)
                    continue;
                else if (tmp < date)
                {
                    date = tmp;
                }
            }
            return date;
        }

        public void UpdateFileName(string new_name)
        {
            string Target = Path.GetDirectoryName(FullPath) + "\\" + new_name + FileExtension;
            File.Move(FullPath, Target);

            FileName = new_name;
            FullPath = Target;
        }
    }

}
