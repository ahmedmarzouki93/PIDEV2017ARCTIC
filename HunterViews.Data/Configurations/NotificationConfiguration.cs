using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using HunterViews.Domain.Entities;


namespace HunterViews.Data.Configurations
{
    public class NotificationConfiguration : EntityTypeConfiguration<Notification>
    {
        public NotificationConfiguration()
        {
            HasMany(p => p.users)
                .WithMany(v => v.notifications)
                .Map(m =>
                {
                    m.ToTable("User_Notification");
                    //Table d'association
                    m.MapLeftKey("user");
                    m.MapRightKey("notification");
                });

        }


    }
}
