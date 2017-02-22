using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HunterViews.Data.Infrastructure;
using HunterViews.Domain.Entities;

namespace HunterViews.Data.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(IDatabaseFactory dbFactory) : base(dbFactory)
        {
            //
        }
        
    }

    public interface IUserRepository : IRepositoryBase<User>
    {

    }
}
