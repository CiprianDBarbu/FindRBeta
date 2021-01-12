using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FindRBeta.Models
{
    public class Ad
    {
        [Key, Column("AdId")]
        public int AdId { get; set; }

        //one to many
        public int ProfileId { get; set; }
        [ForeignKey("ProfileId")]
        public virtual Profile Profile { get; set; }    //the profile who posted


        //one to one
        public virtual Housing Housing { get; set; }

        [Required, RegularExpression(@"^[1-9](\d{3})$", ErrorMessage = "Acesta nu este un an valid!")]
        public int HousingYear { get; set; }


        [Required, RegularExpression(@"^(0[1-9])|(1[012])$", ErrorMessage = "Aceasta nu e o luna valida!")]
        public string HousingMonth { get; set; }

        [Required, RegularExpression(@"^((0[1-9])|([12]\d)|(3[01]))$", ErrorMessage = "Aceasta nu este o zi valida!")]
        public string HousingDay { get; set; }
    }
}