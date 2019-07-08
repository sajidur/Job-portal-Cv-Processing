using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobPortal
{
    public class JobPortalDbContext:DbContext
    {
        public JobPortalDbContext(DbContextOptions<JobPortalDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DBSettings.DbConnection);
        }
    }
}
