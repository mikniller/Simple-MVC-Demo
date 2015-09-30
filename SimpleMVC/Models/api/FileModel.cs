using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Demo.Models.api
{
    public class FileModel
    {
        public string FileName { get; set; }
        public string FullPath { get; set; }
        public string FileContent { get; set; }

        public void Load(string fullName) {
            FileContent = File.ReadAllText(fullName);
            FileName = Path.GetFileName(fullName);
            FullPath = Path.GetDirectoryName(fullName);
        }
    }


    public class FileList
    {
        public IEnumerable<FileInfo> AllFiles { get; set; }

        public void LoadAllFiles(string path)
        {
        
            AllFiles = Directory.EnumerateFiles(path, "*.cs*",SearchOption.AllDirectories).
                Where(fi => Path.GetExtension(fi)==".cs" || Path.GetExtension(fi)==".cshtml").Select(fi => new FileInfo() {
                FileName = Path.GetFileName(fi),
                FilePath = Path.GetDirectoryName(fi)
            });

        

        }
    }

    public class FileInfo
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }

        public string FullName { get { return FilePath + "\\"+FileName; } }
    }
}