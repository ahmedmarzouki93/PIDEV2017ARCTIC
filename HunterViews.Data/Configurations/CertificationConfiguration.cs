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
            //Configuration here !!
        }
    }
}
