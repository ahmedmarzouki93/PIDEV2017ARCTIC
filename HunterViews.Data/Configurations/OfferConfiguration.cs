using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using HunterViews.Domain.Entities;

namespace HunterViews.Data.Configurations
{
    public class OfferConfiguration : EntityTypeConfiguration<Offer>
    {
        public OfferConfiguration()
        {

            HasRequired(p => p.user)
               .WithMany(a => a.offers)
               .WillCascadeOnDelete(false);


        }


    }
}
