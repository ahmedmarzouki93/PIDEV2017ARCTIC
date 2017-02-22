using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using HunterViews.Domain.Entities;


namespace HunterViews.Data.Configurations
{
    public class EvaluationConfiguration : EntityTypeConfiguration<Evaluation>
    {
        public EvaluationConfiguration()
        {
            //One To Many
            HasOptional(p => p.offer)   // 0,1..*   
                .WithMany(c => c.evaluations)
                .WillCascadeOnDelete(false);
        }
    }
}

