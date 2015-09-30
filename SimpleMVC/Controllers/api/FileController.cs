using Demo.Models.api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Demo.Controllers.api
{
    public class FileController : ApiController
    {
        [System.Web.Http.AcceptVerbs("GET", "POST")]
        [System.Web.Http.HttpGet]
        public IEnumerable<FileInfo> AllSourceFiles()
        {
            FileList fl = new FileList();
            fl.LoadAllFiles(System.Web.Hosting.HostingEnvironment.MapPath("~/"));
            return fl.AllFiles;
        }

        [System.Web.Http.AcceptVerbs("GET", "POST")]
        [System.Web.Http.HttpGet]
        public FileModel Info(string file)
        {
            FileList fl = new FileList();
            fl.LoadAllFiles(System.Web.Hosting.HostingEnvironment.MapPath("~/"));
            var foundFile = fl.AllFiles.FirstOrDefault(f => f.FileName.ToLower().Equals(file.ToLower()));

            if (foundFile == null)
                throw new Exception("Kunne ikke finde filen " + file);
               
            FileModel model = new FileModel();
            model.Load(foundFile.FullName);
            model.FileContent = HttpUtility.HtmlEncode(model.FileContent);
            

            return model;
        }
    }
}
