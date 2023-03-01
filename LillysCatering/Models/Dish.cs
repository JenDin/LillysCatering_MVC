using System;
using System.ComponentModel.DataAnnotations;

namespace LillysCatering.Models
{
	public class Dish
	{
        public int Id { get; set; }

        [Required]
        public string? Title { get; set; }

        [Required]
        public string? Ingredients { get; set; }

        public int MenuId { get; set; }

        [Display(Name = "Menu")]
        public Menu? Menu { get; set; }
    }
}

