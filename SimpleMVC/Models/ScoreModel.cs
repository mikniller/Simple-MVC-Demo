using SimpleMVC.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleMVC.Models
{
    public class ScoreModel
    {
        [Required(ErrorMessage="Hold1 er påkrævet")]
        [ScoreValid]
        public string Hold1 { get; set;  }

        [Required]
        public string Hold2 { get; set; }

        [CustomEmailAddress]
        public string Email { get; set; }

        [Range(0, 10, ErrorMessage = "Score skal være mellem 0 og 10")]
        public int Hold1Score { get; set; }

        [Range(0, 10, ErrorMessage = "Score skal være mellem 0 og 10")]
        public int Hold2Score { get; set; }
    }
}