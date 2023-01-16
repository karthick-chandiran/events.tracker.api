using System;
using EventTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace EventTracker.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<EventModel> Events { get; set; }
    }
}

