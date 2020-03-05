using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using LearningArch.Models;

namespace LearningArch.DAL
{
    public class LearningArchDbContext : DbContext
    {
        public LearningArchDbContext(DbContextOptions<LearningArchDbContext> options) : base(options) { }
        public virtual DbSet<Product> Product { get;set; }
    }
}
