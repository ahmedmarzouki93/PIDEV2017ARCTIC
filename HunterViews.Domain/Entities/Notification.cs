using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HunterViews.Domain.Entities
{
    public class Notification
    {
        [Key]
        public int? id { get; set; } //Nullable

        [Display(AutoGenerateField =false)]
        public DateTime date { get; set; }

        [Display(AutoGenerateField = false)]
        public TypeNotification type { get; set; }

        [Display(AutoGenerateField = false)]
        public bool seen { get; set; }

        public string description { get; set; }
        
        virtual public ICollection<User> users { get; set; }

    }
}
