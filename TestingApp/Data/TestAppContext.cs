using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingApp.Models;
using Microsoft.EntityFrameworkCore;


namespace TestingApp.Data
{
    public class TestAppContext : DbContext
    {
        public TestAppContext(DbContextOptions<TestAppContext> options) : base(options)
        { }

        public DbSet<TestAppRecord> TestAppRecords { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TestAppRecord>().ToTable("TestAppRecord");
        }

    }
}
