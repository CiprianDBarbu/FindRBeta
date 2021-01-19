using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FindRBeta.Models
{
    public class Housing
    {
        [Key, Column("Housing_id")]
        public int HousingId { get; set; }

        [Required]
        public string Link { get; set; }


        [Required]
        [RegularExpression(@"^[1-9]\d*$", ErrorMessage = "Este necesar un numar pozitiv!")]
        public int Price { get; set; }


        [Required]
        [RegularExpression(@"^[1-9]\d*$", ErrorMessage = "Este necesar un numar pozitiv!")]
        public int NoOfRooms { get; set; }


        //one-to-many
        public int  LocationId { get; set; }
        [ForeignKey("LocationId")]
        public virtual Location HousingLocation { get; set; }

        [NotMapped]
        public IEnumerable<SelectListItem> LocationsList { get; set; }

    }
}