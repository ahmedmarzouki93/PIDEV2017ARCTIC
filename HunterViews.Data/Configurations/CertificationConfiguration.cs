using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using HunterViews.Domain.Entities;

namespace HunterViews.Data.Configurations
{
    public class CertificationConfiguration : EntityTypeConfiguration<Certification>
    {
        public CertificationConfiguration()
        {
            ToTable("Certification");
            Property(c => c.title).HasMaxLength(50).IsRequired();


            HasMany(p => p.users)
                  .WithMany(v => v.certifications)
                  .Map(m =>
                  {
                      m.ToTable("User_Certification");
                    //Table d'association
                    m.MapLeftKey("user");
                      m.MapRightKey("certification");
                  });
        }
    }
}
