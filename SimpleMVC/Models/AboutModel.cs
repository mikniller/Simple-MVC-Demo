using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleMVC.Models
{
    public class AboutModel
    {
        public string VersionInformation { get; set; }
        public IEnumerable<string> ReleaseNotes { get; set; }

        public AboutModel()
        {
            VersionInformation = "SuperOffice deluxe Version 17.2";
            ReleaseNotes = new string[] { 
                "1.0 : Added some amazing features", 
                "2.0 : Added some additional awesome stuff", 
                "3.0 : Deleted most of the appælication", 
                "4.0 : Deleted rest of the application" };
        }
    }
}