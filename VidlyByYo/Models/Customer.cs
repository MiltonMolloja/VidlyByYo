using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace VidlyByYo.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name ="Nombre")]
        public string Name { get; set; }

        public bool IsSubcribedToNewsletter { set; get; }

        public MembershipType MembershipType { get; set; }

        [Display(Name ="Tipo de Membresia")]
        public byte MembershipTypeId { get; set; }

        [Display(Name ="Fehca de Cumpleanos")]
        public DateTime? BirthDate { get; set; }
    }
}