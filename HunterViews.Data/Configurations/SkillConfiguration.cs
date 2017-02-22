using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using HunterViews.Domain.Entities;


namespace HunterViews.Data.Configurations
{
    public class SkillConfiguration : EntityTypeConfiguration<Skill>
    {
        public SkillConfiguration()
        {
            
                 HasMany(p => p.users)
                .WithMany(v => v.skills)
                .Map(m =>
                {
                m.ToTable("User_Skill");
                //Table d'association
                m.MapLeftKey("user");
                m.MapRightKey("skill");
            });



            }


    }
}
