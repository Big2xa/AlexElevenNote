using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ElevenNote.web.Models
{
    public class GuessingGameViewModel
    {
        [Required(ErrorMessage = "What's your name, who shot ya?!")]
        [MinLength(2)]
        [MaxLength(20)]
        [Display(Name = "Your Name")]
        public string Name { get; set; }

        [Required]
        [Range(1,100)]
        [Display(Name ="Your Guess")]
        public int Guess { get; set; }

    }
}