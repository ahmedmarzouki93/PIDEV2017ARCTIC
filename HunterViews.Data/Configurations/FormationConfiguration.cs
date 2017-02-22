using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using HunterViews.Domain.Entities;

namespace HunterViews.Data.Configurations
{
    public class FormationConfiguration : EntityTypeConfiguration<Formation>
    {
        public FormationConfiguration()
        {
            HasMany(p => p.users)
                .WithMany(v => v.formations)
                .Map(m =>
                {
                    m.ToTable("User_Formation");
                    //Table d'association
                    m.MapLeftKey("user");
                    m.MapRightKey("formation");
                });

        }


    }
}
