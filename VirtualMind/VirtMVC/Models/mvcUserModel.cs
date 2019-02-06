using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VirtMVC.Models
{
    public class mvcUserModel
    {
        public int id { get; set; }
        [DisplayName("FirstName")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Required!!")]
        [MaxLength(50, ErrorMessage = "Até 50 caracteres")]
        public string firstname { get; set; }
        public string lastname { get; set; }
        [EmailAddress]
        public string email { get; set; }
        public string password { get; set; }
    }
}