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
    public class GuardianAttachmentConfiguration : IEntityTypeConfiguration<GuardianAttachment>
    {
        public void Configure(EntityTypeBuilder<GuardianAttachment> builder)
        {
            builder.HasOne(n => n.NewOrphan).WithMany(m=>m.GuardianAttachment).HasForeignKey(f => f.NewOrphanId);
        }
    }
}
