using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace VirtMVC.Models
{
    public class mvcUserModel
    {
        public int id { get; set; }
        [DisplayName("FirstName")]
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}