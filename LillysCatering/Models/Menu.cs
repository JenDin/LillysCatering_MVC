using System;
using System.ComponentModel.DataAnnotations;

namespace LillysCatering.Models
{
	public class Menu
	{
        public int Id { get; set; }

        [Required]
        [Display(Name = "Menu")]
        public string? Title { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        [Display(Name = "Minimum guest amount")]
        public int MinGuestAmount { get; set; }
    }
}

