using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace HunterViews.Domain.Entities
{
    public class Experience : ComplexTypeAttribute
    {
        [Required]
        [Display(Name ="Years :")]
        public int years { get; set; }
        //public Entreprise entreprise { get; set; }

    }
}
