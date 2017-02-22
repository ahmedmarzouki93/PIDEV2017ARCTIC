using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HunterViews.Data;

namespace HunterViews.Data.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        HunterViewsContext DataContext { get; }
    }

}
