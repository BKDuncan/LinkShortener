using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LinkShortener.Models
{
    public class Links
    {
        [Required(ErrorMessage ="Required field")]
        [Url(ErrorMessage ="Please enter a valid Url")]
        public string LongUrl { get; set; }
    }
}