using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RightO.Models
{
    public class BaseModel
    {
        public string PinCode { get; set; }

        public string Timings { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public List<QuestionMaster> Questions { get; set; }


    }
}