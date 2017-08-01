using DynamicCv.Entities.CvEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicCv.DataContext.CvDbContext
{
    public class CvContext : DbContext
    {
        public DbSet<Entry> Entrys { get; set; }
        public DbSet<Area> Area { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<CvUser> CvUser { get; set; }

        public CvContext(DbContextOptions<CvContext> options)
            : base(options)
        {
            
        }
    }
}
