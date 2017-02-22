using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HunterViews.Domain.Entities
{
    public class HeadHunter : User  
    {
        public Entreprise entreprise { get; set; }
    }
}
