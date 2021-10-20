using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace L
{
    public class File
    {
        public string LoadText()
        {
            return string.Empty;
        }
        public void SaveText()
        {
        }
    }

    class ReadOnlyFile : File
    {
        public string FilePath { get; set; }
        public string FileText { get; set; }
        public string LoadText() => "Read only file";
        public void SaveText() => throw new IOException("Can't Save");
    }

    public class ReadWriteFile : File
    {
        public string FilePath { get; set; }
        public string FileText { get; set; }
        public string LoadText() => "Read only file";

        public void SaveText()
        {

        }
    }

    public class SqlFileManager
    {
        public List<File> AllFiles { get; set; }

        public string GetTextFromFiles()
        {
            StringBuilder objStrBuilder = new StringBuilder();
            foreach (var objFile in AllFiles)
            {
                objStrBuilder.Append(objFile.LoadText());
            }
            return objStrBuilder.ToString();
        }
        public void SaveTextIntoFiles()
        {
            foreach (var objFile in AllFiles.Where(objFile => !(objFile is ReadOnlyFile)))
            {
                objFile.SaveText();
            }
        }
    }
}
