using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HunterViews.Domain.Entities
{
   public class Post
    {
        [Key]
        public int? id { get; set; } //Nullable

        [Display(AutoGenerateField =false)]
        public DateTime date { get; set; }
        
        [Required]
        [DataType(DataType.MultilineText)]
        [Display(Name ="Description :")]
        public string description { get; set; }

        virtual public User user { get; set; }
        virtual public Offer offer { get; set; }
    }
}
