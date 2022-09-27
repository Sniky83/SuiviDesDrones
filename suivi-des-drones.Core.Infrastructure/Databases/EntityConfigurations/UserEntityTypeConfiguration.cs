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
    public class UserEntityTypeConfiguration : IEntityTypeConfiguration<CompleteUser>
    {
        #region Public Methods
        public void Configure(EntityTypeBuilder<CompleteUser> builder)
        {
            builder.HasKey(item => item.Login);
            builder.ToTable("User");
        }
        #endregion
    }
}
