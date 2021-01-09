using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

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

        
        [MaxLength(50, ErrorMessage="Last name cannot be more than 50!")]
        public string LastName { get; set; }


        [MaxLength(20, ErrorMessage = "Last name cannot be more than 20!")]
        public string FirstName { get; set; }
        

        public int Age { get; set; }
        

        public Gender GenderType { get; set; }
        

        //one to many
        public int LocationId { get; set; }

        [ForeignKey("LocationId")]
        public virtual Location Address { get; set; }
        

        public string Details { get; set; }
        



    }
}