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
    internal class HealthStatusEntityTypeConfiguration : IEntityTypeConfiguration<HealthStatus>
    {
        #region Public Methods
        public void Configure(EntityTypeBuilder<HealthStatus> builder)
        {
            builder.HasKey(item => item.Id);
            builder.ToTable("HealthStatus");
        }
        #endregion
    }
}
