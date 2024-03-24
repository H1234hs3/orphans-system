using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using orphan.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orphan.Data.Configurations
{
    public class MonthlyMovementConfiguration : IEntityTypeConfiguration<MonthlyMovement>
    {
        public void Configure(EntityTypeBuilder<MonthlyMovement> builder)
        {
            builder.HasOne(m => m.NewOrphan).WithMany(n => n.MonthlyMovement)
                 .HasForeignKey(m => m.NewOrphanId);
        }
    }
}
