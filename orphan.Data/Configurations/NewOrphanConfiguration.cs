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
    public class NewOrphanConfiguration : IEntityTypeConfiguration<NewOrphan>
    {
        public void Configure(EntityTypeBuilder<NewOrphan> builder)
        {
            //builder.ToTable("NewOrphans", "Base");

            builder.HasOne(no => no.City)
                .WithMany(no=>no.NewOrphan)
                .HasForeignKey(no => no.CityId);
            builder.HasOne(c=>c.country).WithMany(n=>n.newOrphan)
                .HasForeignKey(no => no.CountryId);
            builder.HasOne(d=>d.Directorate).WithMany(n=>n.newOrphan)
                .HasForeignKey(f=>f.DirectorateId);
            builder.HasOne(m => m.Nationality).WithMany(o => o.NewOrphan)
                .HasForeignKey(f => f.NationalityId);
            builder.HasOne(m=>m.Status).WithMany(m=>m.NewOrphan)
                .HasForeignKey(f => f.StatusId);
            builder.HasOne(v=>v.Village).WithMany(n=>n.newOrphan)
                .HasForeignKey(f=>f.VillageId);


        }
    }
}
