using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using orphan.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace orphan.Data.Configurations
{
    public class DataReviewConfiguration : IEntityTypeConfiguration<DataReview>
    {
        public void Configure(EntityTypeBuilder<DataReview> builder)
        {
            builder.HasOne(n => n.NewOrphan).WithMany(no => no.DataReview).
                 HasForeignKey(f => f.NewOrphanId);
        }
    }
}
