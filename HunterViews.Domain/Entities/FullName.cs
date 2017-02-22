using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace HunterViews.Domain.Entities
{
    [ComplexType]
    public class FullName 
    {
       
        [Required]
        [Display(Name ="First Name")]
     //   [Range(2,50,ErrorMessage ="This field must contain beetwen 2 and 50 characters")]
        public string firstName { get; set; }

        [Required]
        [Display(Name = "Second Name")]
       // [Range(2, 50, ErrorMessage = "This field must contain beetwen 2 and 50 characters")]
        public string secondName { get; set; }
    }

}
