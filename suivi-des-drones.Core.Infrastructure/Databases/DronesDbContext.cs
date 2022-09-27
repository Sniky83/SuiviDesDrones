using Microsoft.EntityFrameworkCore;
using suivi_des_drones.Core.Infrastructure.Databases.EntityConfigurations;
using suivi_des_drones.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suivi_des_drones.Core.Infrastructure.Databases
{
    public class DronesDbContext : DbContext
    {
        public DronesDbContext(DbContextOptions<DronesDbContext> options) : base(options)
        {
        }

        public DronesDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EntityConfigurations.DroneEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new EntityConfigurations.HealthStatusEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new EntityConfigurations.UserEntityTypeConfiguration());
            //modelBuilder.Entity<Drone>().HasKey(item => item.Matricule);
        }

        public DbSet<Drone> Drones { get; set; }
        public DbSet<HealthStatus> HealthStatuses { get; set; }
        public DbSet<CompleteUser> Users { get; set; }
    }
}
