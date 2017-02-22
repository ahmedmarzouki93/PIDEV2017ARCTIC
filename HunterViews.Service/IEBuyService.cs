using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HunterViews.Domain.Entities;
using HunterViews.Data.Infrastructure;
namespace HunterViews.Service
{
    public interface IEBuyService : IDisposable
    {
        void CreateUser(User u);
        void CreateJobSeeker(JobSeeker j);
        void CreateCertification(Certification c);
        void CreateFormation(Formation f);
        void CreateOffer(Offer o);
        void CreatePost(Post p);
        void CreateNotification(Notification n);
        void CreateReclamation(Reclamation r);
        void CreateSkill(Skill s);



        JobSeeker GetJobSeeker(int id);
        HeadHunter GetHeadHunter(int id);
        IEnumerable<User> GetUsers();
    }
}
