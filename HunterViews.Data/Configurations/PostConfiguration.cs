using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using HunterViews.Domain.Entities;


namespace HunterViews.Data.Configurations
{
    class PostConfiguration : EntityTypeConfiguration<Post>
    {
        public PostConfiguration()
        {
            //One To Many
            HasOptional(p => p.offer)  
                .WithMany(c => c.posts)
                .WillCascadeOnDelete(false);


        }


    }
}
