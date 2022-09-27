using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using suivi_des_drones.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suivi_des_drones.Core.Infrastructure.Databases.EntityConfigurations
{
    internal class DroneEntityTypeConfiguration : IEntityTypeConfiguration<Drone>
    {
        #region Public Methods
        public void Configure(EntityTypeBuilder<Drone> builder)
        {
            builder.HasKey(item => item.Matricule);
            builder.ToTable("Drone");
            builder.Property(item => item.Matricule).IsRequired(true);
            builder.Property(item => item.Matricule).HasMaxLength(255);

            //Pas besoin de le faire car on a respecté dans "Drone" la nomenclature Entity
            //Autrement dit, entity fait le lien automatiquement si le dev écris proprement
            //builder.HasOne(item => item.HealthStatus)
            //    .WithMany(item => item.Drones)
            //    .HasForeignKey(item => item.HealthStatusId);
        }
        #endregion
    }
}
