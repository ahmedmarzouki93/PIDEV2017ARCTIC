using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace HunterViews.Domain.Entities
{
    public class Skill
    {

       // [Key]
        public int? id { get; set; } //Nullable
        
        [Required]
        [Display(Name ="Category :")]
        public Category category { get; set; }
        [Required]
        [Display(Name ="Name :")]
        public string name { get; set; }

        virtual public ICollection<User> users { get; set; }


    }
}
