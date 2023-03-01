using System;
using System.ComponentModel.DataAnnotations;

namespace LillysCatering.Models
{
	public class Menu
	{
        public int Id { get; set; }

        [Required(ErrorMessage = "* Please enter a title")]
        [Display(Name = "Menu name")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "* Please enter a price")]
        public int Price { get; set; }

        [Required(ErrorMessage = "* Please enter a minimum guest amount")]
        [Display(Name = "Minimum guest amount")]
        public int MinGuestAmount { get; set; }
    }
}

