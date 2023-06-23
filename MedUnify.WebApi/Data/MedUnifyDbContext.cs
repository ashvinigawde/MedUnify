using MedUnify.WebApi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace MedUnify.WebApi.Data
{
    public class MedUnifyDbContext : DbContext
    {
        public MedUnifyDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<PatientVisit> PatientVisits { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<ProgressNote> ProgressNotes { get; set; }
        public DbSet<User> User { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        
        }
    }
}
