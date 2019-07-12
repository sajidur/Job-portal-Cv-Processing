using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobPortal.Models
{
    public class JobSettings
    {
        public int Id { get; set; }
        public String JobId { get; set; }
        public string JobTitle { get; set; }
        public string Company { get; set; }
        public int vacancy { get; set; }
        public string TopSkills { get; set; }
        public string MinorSkills { get; set; }

    }
}
