using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exam.Models
{
    public class User
    {
        public int id { get; set; }
        public String user01 { get; set; }
        public String passwork { get; set; }
        public String email { get; set; }
        public String phone { get; set; }
        public Status status { get; set; }

       public enum Status
        {
            ACTIVE = 1,
            DEACTIVE = 0
        }

    }
}