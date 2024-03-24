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
    public class OrphanAttachmentConfiguration : IEntityTypeConfiguration<OrphanAttachment>
    {
        public void Configure(EntityTypeBuilder<OrphanAttachment> builder)
        {
            builder.HasOne(o => o.newOrphan).WithMany(a => a.OrphanAttachment)
                .HasForeignKey(f => f.NewOrphanId);
        }
    }
}
