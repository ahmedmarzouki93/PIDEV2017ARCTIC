using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HunterViews.Domain.Entities
{
    public class Offer
    {
        
        [Key]
        public int? id { get; set; } //Nullable

        [Required]
        [Display(Name ="Type Contrat :")]
        public TypeOffer typeOffer { get; set; }
        
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date Starts :")]
        public DateTime dateStart { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date End :")]
        public DateTime dateEnd { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Description :")]
        public string description { get; set; }

        [Display(AutoGenerateField =false)]
        public int seen { get; set; }

        [Display(AutoGenerateField = false)]
        public int state { get; set; }

        [Required]
        [Range(0,double.MaxValue)]
        [Display(Name = "Salary :")]
        public double salary { get; set; }
        
        virtual public User user { get; set; }
        virtual public ICollection<Post> posts { get; set; }
        virtual public ICollection<Evaluation> evaluations { get; set; }


    }
}
