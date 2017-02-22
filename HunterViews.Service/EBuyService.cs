using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HunterViews.Service;
using HunterViews.Data.Infrastructure;
using HunterViews.Data.Repositories;
using HunterViews.Domain.Entities;
namespace HunterViews.Service
{
    public class EBuyService : IEBuyService
    {
        DatabaseFactory dbFactory = null;
        IUnitOfWork utOfWork = null;
        public EBuyService()
        {
            dbFactory = new DatabaseFactory();
            utOfWork = new UnitOfWork(dbFactory);
        }

        public void CreateUser(User u)
        {
            utOfWork.getRepository<User>().Add(u);
            utOfWork.Commit();
        }

        public void CreateJobSeeker(JobSeeker j)
        {
            utOfWork.getRepository<JobSeeker>().Add(j);
            utOfWork.Commit();
        }

        public void CreateCertification(Certification c)
        {
            utOfWork.getRepository<Certification>().Add(c);
            utOfWork.Commit();
        }

        public void CreateFormation(Formation f)
        {
            utOfWork.getRepository<Formation>().Add(f);
            utOfWork.Commit();
        }

        public void CreateOffer(Offer o)
        {
            utOfWork.getRepository<Offer>().Add(o);
            utOfWork.Commit();
        }

        public void CreatePost(Post p)
        {
            utOfWork.getRepository<Post>().Add(p);
            utOfWork.Commit();
        }

        public void CreateNotification(Notification n)
        {
            utOfWork.getRepository<Notification>().Add(n);
            utOfWork.Commit();
        }


        public void CreateReclamation(Reclamation r)
        {
            utOfWork.getRepository<Reclamation>().Add(r);
            utOfWork.Commit();
        }

        public void CreateSkill(Skill s)
        {
            utOfWork.getRepository<Skill>().Add(s);
            utOfWork.Commit();
        }










        public JobSeeker GetJobSeeker(int id)
        {
            return utOfWork.getRepository<JobSeeker>().GetById(id);
        }
        public HeadHunter GetHeadHunter(int id)
        {
            return utOfWork.getRepository<HeadHunter>().GetById(id);
        }
        
        public IEnumerable<User> GetUsers()
        {
            return utOfWork.getRepository<User>().GetMany();
        }

        public void Dispose()
        {
            utOfWork.Dispose();
        }
    }
}
