using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HunterViews.Service;
using HunterViews.Domain.Entities;
using HunterViews.Data;
namespace HunterViews.Client
{
    class Program
    {
        static void Main(string[] args)
        {


            //Simulation de la création de deux users, Jobseeker and HeadHunter 

            //Jobseeker
            //Un Jobseeker posséde des certifs, des formations et des skills et quelques notifications et aucun posts


            //tes
            Formation formation = new Formation()
            {
                dateStart = new DateTime(2010, 1, 31),
                dateEnd = new DateTime(2016, 2, 22),
                ecole = "ESPRIT",
              
            };

            Certification certification = new Certification()
            {
                dateStart = new DateTime(2010, 1, 31),
                dateEnd = new DateTime(2011, 2, 22),
                centre = "LPI MAGHREB",
                title = "LPIC 1",
              
            };

            Notification notification = new Notification()
            {
                date = DateTime.Now,
                seen = false,
                type = TypeNotification.User,
                description = "Bienvenu parmis nous !",
               

            };

            Skill skill = new Skill()
            {
                name = "C++",
                category = Category.Desktop,
             
            };

            List<Formation> listFormation = new List<Formation>();
            listFormation.Add(formation);

            List<Certification> listCertification = new List<Certification>();
            listCertification.Add(certification);

            List<Notification> listNotification = new List<Notification>();
            listNotification.Add(notification);

            List<Skill> listSkill = new List<Skill>();
            listSkill.Add(skill);




            JobSeeker firstJobSeeker = new JobSeeker()
            {
                fullName = new FullName()
                {
                    firstName = "Ahmed",
                    secondName = "Marzouki"

                },
                birthDate = new DateTime(1993, 1, 22),
                email = "ahmed.marzouki@esprit.tn",
                address = new Address()
                {
                    city = "Hamem lenf",
                    country = "Ben Arrous",
                    postalCode = 2500,
                    state = "Tunisie",
                    street = "Informatique"
                },
                password = "4815162342951",
                confirmPassword = "4815162342951",
                login = "ahmed.marzouki@esprit.tn",
                image = "/images/ahmed_marzouki",
                experience = new Experience()
                {
                    years = 5
                },
                dateCreationAccount = DateTime.Now,
                formations = listFormation,
                certifications = listCertification,
                notifications = listNotification,
                skills = listSkill,
                offers = null,
                posts = null,
                reclamations = null,
                stateAccount = 0
                
            };

            EBuyService eBuyService = new EBuyService();
          




            //HeadHunter
            //Un headHunter posséde des notification et des offres

            Evaluation evaluation = new Evaluation()
            {
                date = DateTime.Now,
                mark = 5,
            };

            List<Evaluation> listEvaluation = new List<Evaluation>();
            listEvaluation.Add(evaluation);



            Offer offer = new Offer()
            {
                dateStart = new DateTime(2017,2,21),
                dateEnd = new DateTime(2019,2,21),
                description = "Premier Offer posté",
                evaluations = listEvaluation,
                posts = null,
                salary = 5000,
                seen = 0,
                state = 0,
                typeOffer = TypeOffer.CDI    
            };

            List<Offer> listOffer = new List<Offer>();
            listOffer.Add(offer);
            

            HeadHunter firstHeadHunter = new HeadHunter()
            {
                fullName = new FullName()
                {
                    firstName = "Safwene",
                    secondName = "Ben Aich"

                },
                birthDate = new DateTime(1995, 1, 31),
                email = "safwene.benaich@esprit.tn",
                address = new Address()
                {
                    city = "Bizerte Ville",
                    country = "Bizerte",
                    postalCode = 7000,
                    state = "Bizerte",
                    street = "Informatique"
                },
                password = "96183591",
                confirmPassword = "96183591",
                login = "safwene.benaich@esprit.tn",
                image = "/images/safwene_benaich",
                entreprise = new Entreprise()
                {
                    domain = "Informatique",
                    name = "GOOGLE"
                },
                 
                dateCreationAccount = DateTime.Now,
                formations = null,
                certifications = null,
                notifications = null,
                skills = null,
                offers = listOffer,
                posts = null,
                reclamations = null,
                stateAccount = 0

            };

            eBuyService.CreateUser(firstJobSeeker);
            System.Console.WriteLine(firstJobSeeker.email);
            eBuyService.CreateUser(firstHeadHunter);  
            System.Console.WriteLine(firstHeadHunter.email);
            System.Console.ReadKey();


        }
    }
}
