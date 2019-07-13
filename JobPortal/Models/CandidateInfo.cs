using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobPortal.Models
{
    public class CandidateInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Skills { get; set; }
        public string Summary { get; set; }
        public string Experience { get; set; }
        public string Education { get; set; }
    }
}
