using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HunterViews.Data;

namespace HunterViews.Data.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        
        private HunterViewsContext dataContext;
        public HunterViewsContext DataContext { get { return dataContext; } }

        public DatabaseFactory()
        {
            dataContext = new HunterViewsContext();
        }
        protected override void DisposeCore()
        {
            if (DataContext != null)
                DataContext.Dispose();
        }
    }

}
