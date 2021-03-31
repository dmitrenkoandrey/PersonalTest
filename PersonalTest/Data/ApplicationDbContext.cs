using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PersonalTest.Models;

namespace PersonalTest.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Appoint> Appoints { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Structure> Structures { get; set; }
        public DbSet<Vacation> Vacations { get; set; }
        public DbSet<Dismiss> Dismisses { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<FamilyStatus> FamilyStatuses { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<WorkCondition> WorkConditions { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<StaffingTable> Staffs { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Tabel> Tabels { get; set; }
        public DbSet<TabelWork> TabelWorks { get; set; }
        public DbSet<TabWork> TabWorks { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
         //Database.EnsureDeleted();
         Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=personaldb;Trusted_Connection=True;");
        }
    }
}
