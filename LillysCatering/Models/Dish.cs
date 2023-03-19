using System;
using System.ComponentModel.DataAnnotations;

namespace LillysCatering.Models
{
	public class Dish
	{
        public int Id { get; set; }

        [Required(ErrorMessage = "* Please enter a title")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "* Please enter the ingredients")]
        public string? Ingredients { get; set; }

        // FK to the menu table
        public int MenuId { get; set; }

        [Display(Name = "Menu")]
        public Menu? Menu { get; set; }
    }
}

