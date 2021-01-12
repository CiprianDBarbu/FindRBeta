using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FindRBeta.Models
{
    public enum Gender
    {
        Male,
        Female,
        Others
    }
    public class Profile
    {
        [Key, Column("ProfileId")]
        public int ProfileId { get; set; }

        
        [MaxLength(20, ErrorMessage="Numele nu poate avea mai mult de 20 de caractere!")]
        public string LastName { get; set; }


        [MaxLength(50, ErrorMessage = "Prenumele nu poate avea mai mult de 50 de caractere!")]
        public string FirstName { get; set; }
        

        public int Age { get; set; }
        

        public Gender GenderType { get; set; }
        

        //one to many
        public int LocationId { get; set; }

        [ForeignKey("LocationId")]
        public virtual Location Address { get; set; }

        [MaxLength(1000, ErrorMessage = "Nu poti scrie mai mult de 1000 de caractere!")]
        public string Details { get; set; }
        
        [NotMapped]
        public IEnumerable<SelectListItem> LocationsList { get; set; }


        //one-to-one
        //[ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }
        public string AplicationUserName { get; set; }


        //many to one
        public virtual ICollection<Ad> Ads { get; set; }
    }
}