using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace JobPortal.Models
{
    public class JobPortalDbContext:DbContext
    {
        public JobPortalDbContext(DbContextOptions<JobPortalDbContext> options) : base(options: options) { }
        public DbSet<JobSettings> JobSettingses { get; set; }
        public DbSet<CandidateInfo> Candidate { get; set; }
    }
}
