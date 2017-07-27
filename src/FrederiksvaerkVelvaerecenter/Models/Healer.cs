using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FrederiksvaerkVelvaerecenter.Models
{
    public class Healer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string[] Treatments { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }
    }
}