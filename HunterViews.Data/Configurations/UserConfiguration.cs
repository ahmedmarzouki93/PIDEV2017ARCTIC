using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using HunterViews.Domain.Entities;

namespace HunterViews.Data.Configurations
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            Property(e => e.login).HasMaxLength(50).IsRequired();
            Property(e => e.password).HasMaxLength(50).IsRequired();
            Property(e => e.email).HasMaxLength(50).IsRequired();
            Property(e => e.image).HasMaxLength(50).IsOptional();

         

            //Heritage
            Map<JobSeeker>(c =>
            {
                c.Requires("Role").HasValue("Jobseeker");  
            });
            Map<HeadHunter>(c =>
            {
                c.Requires("Role").HasValue("HeadHunter");
            });
            Map<WebCoordinator>(c =>
            {
                c.Requires("Role").HasValue("WebCoordinator");
            });




        }


    }
}
