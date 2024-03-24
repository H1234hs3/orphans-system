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
    public class AnnualReportConfiguration : IEntityTypeConfiguration<AnnualReport>
    {
        public void Configure(EntityTypeBuilder<AnnualReport> builder)
        {
            builder.HasOne(or => or.NewOrphan).WithMany(m=>m.AnnualReport).HasForeignKey(or => or.NewOrphanId);
        }
    }
}
