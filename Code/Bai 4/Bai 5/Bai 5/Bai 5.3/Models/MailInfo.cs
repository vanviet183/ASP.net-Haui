using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai_5._3.Models
{
    public class MailInfo
    {
        public String From { get; set; }
        public String To { get; set; }
        public DateTime BirthOfDate { get; set; }
        public decimal Salary { get; set; }
        public string StaffImage { get; set; }
    }
}