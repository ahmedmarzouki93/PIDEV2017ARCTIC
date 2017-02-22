using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HunterViews.Data;
using System.Data.Entity.Validation;
using System.Data.Entity.Infrastructure;

namespace HunterViews.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {

        private  HunterViewsContext dataContext;

        IDatabaseFactory dbFactory;
        public UnitOfWork(IDatabaseFactory dbFactory)
        {
            this.dbFactory = dbFactory;
            dataContext = dbFactory.DataContext;
        }

        public void Commit()
        {

            try
            {

                dataContext.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
            catch (DbUpdateException e)
            {
                var sb = new StringBuilder();
                Console.WriteLine($"DbUpdateException error details - {e?.InnerException?.InnerException?.Message}");

                foreach (var eve in e.Entries)
                {
                    Console.WriteLine($"Entity of type {eve.Entity.GetType().Name} in state {eve.State} could not be updated");
                }

               

                throw;
            }

        }
        public void CommitAsync()
        {
            dataContext.SaveChangesAsync();
        }
        public void Dispose()
        {
            dataContext.Dispose();
        }
        public IRepositoryBase<T> getRepository<T>() where T : class
        {
            IRepositoryBase<T> repo = new RepositoryBase<T>(dbFactory);
            return repo;
        }

    }
}
