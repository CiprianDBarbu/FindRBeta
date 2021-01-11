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

        public string Country { get; set; }


        public string City { get; set; }

        public Zone Placement { get; set; }

        //many to one
        public virtual ICollection<Profile> Profile { get; set; }


        //many to one
        public virtual ICollection<Housing> Housings { get; set; }
    }
}