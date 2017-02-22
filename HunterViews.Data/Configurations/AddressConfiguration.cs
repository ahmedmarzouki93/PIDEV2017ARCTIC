using HunterViews.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HunterViews.Data.Configurations
{
    public class AddressConfiguration : ComplexTypeConfiguration<Address>
    {
        public AddressConfiguration()
        {

            Property(p => p.city).HasMaxLength(50).IsRequired();
            Property(p => p.country).HasMaxLength(50).IsRequired();
            Property(p => p.postalCode).IsOptional();
            Property(p => p.state).HasMaxLength(50).IsRequired();
            Property(p => p.street).HasMaxLength(50).IsRequired();

        }


    }
}
