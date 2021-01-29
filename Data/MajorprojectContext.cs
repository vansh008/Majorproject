using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Majorproject.Models;

namespace Majorproject.Data
{
    public class MajorprojectContext : DbContext
    {
        public MajorprojectContext (DbContextOptions<MajorprojectContext> options)
            : base(options)
        {
        }

        public DbSet<Majorproject.Models.Booking> Booking { get; set; }

        public DbSet<Majorproject.Models.Customer> Customer { get; set; }

        public DbSet<Majorproject.Models.Branch> Branch { get; set; }

        public DbSet<Majorproject.Models.Room> Room { get; set; }

        public DbSet<Majorproject.Models.Staff> Staff { get; set; }
    }
}
