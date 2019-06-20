using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobPortal.Models
{
    public class EmailMessage
    {
        public string From { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string CV { get; set; }

    }
}
