using davaleba_7.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace davaleba_7.Data
{
    public class SchoolDbContext : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Pupil> Pupils { get; set; }
    }
}
