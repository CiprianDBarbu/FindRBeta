using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FindRBeta.Models
{
    public enum Zone
    {
        Central,
        Periferial
    }
    public class Location
    {
        [Key]
        public int LocationId { get; set; }

        [MinLength(2, ErrorMessage = "Numele tarii trebuie sa aiba mai mult de 2 caractere!"),
            MaxLength(20, ErrorMessage = "Numele tarii nu poate avea mai mult de 20 de caractere!")]
        public string Country { get; set; }

        [MinLength(2, ErrorMessage = "Numele orasului trebuie sa aiba mai mult de 2 caractere!"),
            MaxLength(25, ErrorMessage = "Numele orasului nu poate avea mai mult de 25 de caractere!")]
        public string City { get; set; }

        public Zone Placement { get; set; }

        //many to one
        public virtual ICollection<Profile> Profile { get; set; }


        //many to one
        public virtual ICollection<Housing> Housings { get; set; }
    }
}