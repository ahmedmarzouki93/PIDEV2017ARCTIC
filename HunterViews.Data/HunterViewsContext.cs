using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using HunterViews.Domain.Entities;
using HunterViews.Data.CustumConventions;
using HunterViews.Data.Configurations;

namespace HunterViews.Data
{
    public class HunterViewsContext : DbContext
    {
        public HunterViewsContext() : base("Name=HunterViewsDB")
        {
            //
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Add(new DateTime2Convention());

            modelBuilder.Configurations.Add(new AddressConfiguration());
            modelBuilder.Configurations.Add(new CertificationConfiguration());
            modelBuilder.Configurations.Add(new EvaluationConfiguration());
            modelBuilder.Configurations.Add(new FormationConfiguration());
            modelBuilder.Configurations.Add(new NotificationConfiguration());
            modelBuilder.Configurations.Add(new OfferConfiguration());
            modelBuilder.Configurations.Add(new PostConfiguration());
            modelBuilder.Configurations.Add(new ReclamationConfiguration());
            modelBuilder.Configurations.Add(new SkillConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());


        }

        public DbSet<User> users { get; set; }
        public DbSet<JobSeeker> jobseekers { get; set; }
        public DbSet<HeadHunter> headHunters { get; set; }
        public DbSet<Offer> offers { get; set; }
        public DbSet<Post> posts { get; set; }
        public DbSet<Skill> skills { get; set; }
        public DbSet<Reclamation> reclamations { get; set; }
        public DbSet<Evaluation> evaluations { get; set; }
        public DbSet<Formation> formations { get; set; }
        public DbSet<Notification> notifications { get; set; }
        public DbSet<Certification> certifications { get; set; }










    }
}
