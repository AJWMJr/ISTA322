using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+",
            ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone number")]
        [RegularExpression("\\d\\d\\d[-. ]\\d{3}[-. ]\\d{4}", ErrorMessage = "Please enter a valid phone number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please specify wheter you'll attend")]
        public bool? WillAttend { get; set; }
    }
}
